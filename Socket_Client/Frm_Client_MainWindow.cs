using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket_Client
{
    public partial class Frm_Client : Form
    {
        private Socket tcpClientSockrt = null;      // TCP Socket服务
        public static int TCPBufferSize = 1024;        // TCP缓存最大个数
        public byte[] TCPBuffer = new byte[TCPBufferSize];  // TCP缓存数组
        Encoding encoder = Encoding.Default;
        public string getDateTime
        {
            get { return DateTime.Now.ToString("HH:mm:ss") + Environment.NewLine; }
        }
        
        public Frm_Client()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch(button.Name)
            {
                case "btn_SendData":    // 发送数据按钮
                    Socket_SendData();
                    break;
                case "btn_Socket_Opt":  // 连接操作按钮
                    ConnectionSocket();
                    break;
                case "btn_Clear_ReceData_tb":   // 清除接收数据文本框
                    tb_ReceiveData.Clear();
                    break;
                case "btn_Clear_SendData_tb":   // 清除发送文本框数据
                    tb_SendData.Clear();
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 发送数据
        /// </summary>
        private void Socket_SendData()
        {
            string str = tb_SendData.Text.Trim();       // 获取发送文本框里面的数据，不允许开头和结尾有空格
            try
            {
                if(str.Length > 0)
                {
                    byte[] sendDataArr = encoder.GetBytes(str); // 将str转换成byte值
                    tcpClientSockrt.BeginSend(sendDataArr, 0, sendDataArr.Length, 0, null, null);   // 发送数据
                }
            }
            catch (Exception)
            {

                
            }
        }

        /// <summary>
        /// 连接服务器
        /// </summary>
        private void ConnectionSocket()
        {
            if(btn_Socket_Opt.Text == "连接")
            {
                 // ip地址和端口号输入不为空
                 if(!string.IsNullOrEmpty(tb_Con_IP.Text) && !string.IsNullOrEmpty(tb_Con_Port.Text))
                 {
                    try
                    {
                        IPAddress ipAddress = IPAddress.Parse(tb_Con_IP.Text.Trim());   // 获取IP地址
                        int port = int.Parse(tb_Con_Port.Text.Trim());

                        tcpClientSockrt = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        // 使用BeginConnect异步接收
                        tcpClientSockrt.BeginConnect(ipAddress, port, new AsyncCallback(ConnectedCallback), tcpClientSockrt);
                    }
                    catch (Exception)
                    {

                        ShowMessage("IP地址或端口号错误");

                    }

                 }
                 else
                 {
                    ShowMessage("IP地址或端口号错误");
                 }
            }
            else
            {
                try
                {
                    btn_Socket_Opt.Text = "连接";
                    tcpClientSockrt.BeginDisconnect(false, null, null); // 断开连接
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        /// <summary>
        /// 连接完成回调函数
        /// </summary>
        /// <param name="ar"></param>
        private void ConnectedCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            try
            {
                socket.EndConnect(ar);
                // 设置异步读取数据，接收的数据存到TCPBuffer，ReadCallback函数
                socket.BeginReceive(TCPBuffer, 0, TCPBufferSize, 0, new AsyncCallback(ReadCallBack),  socket);
                Invoke(new Action(()=>
                    {
                        ShowMessage("成功连接服务器\r\n");    // 显示连接成功数据
                        btn_Socket_Opt.Text = "断开";
                }));
                
            }
            catch (Exception e)
            {

                ShowMessage("连接失败" + e.Message + "\r\n");        // 显示错误信息
            }
        }

        /// <summary>
        /// 读取数据回调函数
        /// </summary>
        /// <param name="ar"></param>
        private void ReadCallBack(IAsyncResult ar)
        {
            int canReadLen = 0;
            Socket socket = null;
            try
            {
                socket = (Socket)ar.AsyncState;      // 获取连接的Socket
                canReadLen = socket.EndReceive(ar);     // 结束异步读取回调，获取读取的数据个数
            } 
            catch (Exception e)
            {

                ShowMessage(e.Message + "\r\n");
            }
           
            if(canReadLen > 0)
            {
                Invoke(new Action(() =>
                {
                    if (!chk_RecHex.Checked)
                    {
                        string str = encoder.GetString(TCPBuffer, 0, canReadLen);   // 根据默认转码方式转为String
                        ShowMessage(str + "\r\n");
                    }
                    else
                    {
                        byte[] temp = new byte[canReadLen];
                        Array.Copy(TCPBuffer, 0, temp, 0, canReadLen);
                        ShowMessage(BytesArrayHelper.ToHexString(temp));
                    }

                }));
                // 设置异步读取数据，接收的数据缓存到TCPBuffer中，接收完成跳转ReadCallback函数
                socket.BeginReceive(TCPBuffer, 0, TCPBufferSize, 0, new AsyncCallback(ReadCallBack), socket);
            }
            else // 异常状态
            {
                //    Invoke(new Action(() =>
                //    {
                //        btn_Socket_Opt.Text = "连接";
                //        ShowMessage("异常断开\r\n");
                //    }));
                //    try
                //    {
                //        tcpClientSockrt.BeginDisconnect(false, null, null);
                //    }
                //    catch (Exception)
                //    {


            //}
            }
            
        }

        /// <summary>
        /// 显示数据
        /// </summary>
        /// <param name="info"></param>
        private void ShowMessage(string info)
        {
            Invoke(new Action(()=>
            {
                tb_ReceiveData.AppendText(getDateTime + info);
            }));
        }
        /// <summary>
        /// 窗口加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Client_Load(object sender, EventArgs e)
        {
            tb_Con_IP.Text = "127.0.0.1";
            tb_Con_Port.Text = "8080";
        }
    }
}
