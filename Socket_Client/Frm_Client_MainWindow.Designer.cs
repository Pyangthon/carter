namespace Socket_Client
{
    partial class Frm_Client
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_ReceiveData = new System.Windows.Forms.TextBox();
            this.tb_SendData = new System.Windows.Forms.TextBox();
            this.tb_Con_IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Con_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Socket_Opt = new System.Windows.Forms.Button();
            this.btn_SendData = new System.Windows.Forms.Button();
            this.btn_Clear_ReceData_tb = new System.Windows.Forms.Button();
            this.btn_Clear_SendData_tb = new System.Windows.Forms.Button();
            this.chk_RecHex = new System.Windows.Forms.CheckBox();
            this.chk_SendHex = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_ReceiveData
            // 
            this.tb_ReceiveData.Location = new System.Drawing.Point(12, 12);
            this.tb_ReceiveData.Multiline = true;
            this.tb_ReceiveData.Name = "tb_ReceiveData";
            this.tb_ReceiveData.Size = new System.Drawing.Size(719, 349);
            this.tb_ReceiveData.TabIndex = 0;
            // 
            // tb_SendData
            // 
            this.tb_SendData.Location = new System.Drawing.Point(12, 398);
            this.tb_SendData.Multiline = true;
            this.tb_SendData.Name = "tb_SendData";
            this.tb_SendData.Size = new System.Drawing.Size(719, 96);
            this.tb_SendData.TabIndex = 1;
            // 
            // tb_Con_IP
            // 
            this.tb_Con_IP.Location = new System.Drawing.Point(879, 29);
            this.tb_Con_IP.Name = "tb_Con_IP";
            this.tb_Con_IP.Size = new System.Drawing.Size(140, 25);
            this.tb_Con_IP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(806, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP地址";
            // 
            // tb_Con_Port
            // 
            this.tb_Con_Port.Location = new System.Drawing.Point(879, 66);
            this.tb_Con_Port.Name = "tb_Con_Port";
            this.tb_Con_Port.Size = new System.Drawing.Size(140, 25);
            this.tb_Con_Port.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(806, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "端口号";
            // 
            // btn_Socket_Opt
            // 
            this.btn_Socket_Opt.Location = new System.Drawing.Point(919, 113);
            this.btn_Socket_Opt.Name = "btn_Socket_Opt";
            this.btn_Socket_Opt.Size = new System.Drawing.Size(100, 29);
            this.btn_Socket_Opt.TabIndex = 4;
            this.btn_Socket_Opt.Text = "连接";
            this.btn_Socket_Opt.UseVisualStyleBackColor = true;
            this.btn_Socket_Opt.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_SendData
            // 
            this.btn_SendData.Location = new System.Drawing.Point(748, 462);
            this.btn_SendData.Name = "btn_SendData";
            this.btn_SendData.Size = new System.Drawing.Size(90, 32);
            this.btn_SendData.TabIndex = 5;
            this.btn_SendData.Text = "发送数据";
            this.btn_SendData.UseVisualStyleBackColor = true;
            this.btn_SendData.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_Clear_ReceData_tb
            // 
            this.btn_Clear_ReceData_tb.Location = new System.Drawing.Point(748, 329);
            this.btn_Clear_ReceData_tb.Name = "btn_Clear_ReceData_tb";
            this.btn_Clear_ReceData_tb.Size = new System.Drawing.Size(90, 32);
            this.btn_Clear_ReceData_tb.TabIndex = 5;
            this.btn_Clear_ReceData_tb.Text = "清除接收";
            this.btn_Clear_ReceData_tb.UseVisualStyleBackColor = true;
            this.btn_Clear_ReceData_tb.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_Clear_SendData_tb
            // 
            this.btn_Clear_SendData_tb.Location = new System.Drawing.Point(748, 424);
            this.btn_Clear_SendData_tb.Name = "btn_Clear_SendData_tb";
            this.btn_Clear_SendData_tb.Size = new System.Drawing.Size(90, 32);
            this.btn_Clear_SendData_tb.TabIndex = 5;
            this.btn_Clear_SendData_tb.Text = "清除发送";
            this.btn_Clear_SendData_tb.UseVisualStyleBackColor = true;
            this.btn_Clear_SendData_tb.Click += new System.EventHandler(this.btn_Click);
            // 
            // chk_RecHex
            // 
            this.chk_RecHex.AutoSize = true;
            this.chk_RecHex.Location = new System.Drawing.Point(748, 304);
            this.chk_RecHex.Name = "chk_RecHex";
            this.chk_RecHex.Size = new System.Drawing.Size(53, 19);
            this.chk_RecHex.TabIndex = 6;
            this.chk_RecHex.Text = "Hex";
            this.chk_RecHex.UseVisualStyleBackColor = true;
            // 
            // chk_SendHex
            // 
            this.chk_SendHex.AutoSize = true;
            this.chk_SendHex.Location = new System.Drawing.Point(748, 400);
            this.chk_SendHex.Name = "chk_SendHex";
            this.chk_SendHex.Size = new System.Drawing.Size(53, 19);
            this.chk_SendHex.TabIndex = 6;
            this.chk_SendHex.Text = "Hex";
            this.chk_SendHex.UseVisualStyleBackColor = true;
            // 
            // Frm_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 540);
            this.Controls.Add(this.chk_SendHex);
            this.Controls.Add(this.chk_RecHex);
            this.Controls.Add(this.btn_Clear_SendData_tb);
            this.Controls.Add(this.btn_Clear_ReceData_tb);
            this.Controls.Add(this.btn_SendData);
            this.Controls.Add(this.btn_Socket_Opt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Con_Port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Con_IP);
            this.Controls.Add(this.tb_SendData);
            this.Controls.Add(this.tb_ReceiveData);
            this.Name = "Frm_Client";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ReceiveData;
        private System.Windows.Forms.TextBox tb_SendData;
        private System.Windows.Forms.TextBox tb_Con_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Con_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Socket_Opt;
        private System.Windows.Forms.Button btn_SendData;
        private System.Windows.Forms.Button btn_Clear_ReceData_tb;
        private System.Windows.Forms.Button btn_Clear_SendData_tb;
        private System.Windows.Forms.CheckBox chk_RecHex;
        private System.Windows.Forms.CheckBox chk_SendHex;
    }
}

