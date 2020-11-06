namespace SmartFarmUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtBaundrate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAutoConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendString = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStringData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkAutoScroll = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnRelayBom = new System.Windows.Forms.Button();
            this.btnRelayQuat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConditionBom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConditionQuat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDoAm = new System.Windows.Forms.Label();
            this.lblNhietDo = new System.Windows.Forms.Label();
            this.lblDoAmDat = new System.Windows.Forms.Label();
            this.lblApSuat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTimeUpdate = new System.Windows.Forms.Label();
            this.lblBomStatus = new System.Windows.Forms.Label();
            this.lblQuatStatus = new System.Windows.Forms.Label();
            this.checkAutoMode = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(645, 30);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(580, 356);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.txtBaundrate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAutoConnect);
            this.panel1.Location = new System.Drawing.Point(41, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 88);
            this.panel1.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(301, 17);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(103, 51);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtBaundrate
            // 
            this.txtBaundrate.Location = new System.Drawing.Point(110, 51);
            this.txtBaundrate.Name = "txtBaundrate";
            this.txtBaundrate.Size = new System.Drawing.Size(118, 22);
            this.txtBaundrate.TabIndex = 4;
            this.txtBaundrate.Text = "57600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Baundrate";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(110, 17);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(118, 22);
            this.txtPort.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // btnAutoConnect
            // 
            this.btnAutoConnect.Location = new System.Drawing.Point(430, 17);
            this.btnAutoConnect.Name = "btnAutoConnect";
            this.btnAutoConnect.Size = new System.Drawing.Size(103, 51);
            this.btnAutoConnect.TabIndex = 0;
            this.btnAutoConnect.Text = "Auto detect";
            this.btnAutoConnect.UseVisualStyleBackColor = true;
            this.btnAutoConnect.Click += new System.EventHandler(this.btnAutoConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kết nối";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkAutoScroll);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLog);
            this.groupBox1.Location = new System.Drawing.Point(635, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 242);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logger";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(0, 55);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(580, 179);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSendString);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtStringData);
            this.groupBox2.Location = new System.Drawing.Point(39, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 69);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send String";
            // 
            // btnSendString
            // 
            this.btnSendString.Location = new System.Drawing.Point(387, 19);
            this.btnSendString.Name = "btnSendString";
            this.btnSendString.Size = new System.Drawing.Size(71, 36);
            this.btnSendString.TabIndex = 2;
            this.btnSendString.Text = "Gửi";
            this.btnSendString.UseVisualStyleBackColor = true;
            this.btnSendString.Click += new System.EventHandler(this.btnSendString_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nội dung";
            // 
            // txtStringData
            // 
            this.txtStringData.Location = new System.Drawing.Point(113, 24);
            this.txtStringData.Name = "txtStringData";
            this.txtStringData.Size = new System.Drawing.Size(248, 22);
            this.txtStringData.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 1;
            // 
            // checkAutoScroll
            // 
            this.checkAutoScroll.AutoSize = true;
            this.checkAutoScroll.Location = new System.Drawing.Point(457, 28);
            this.checkAutoScroll.Name = "checkAutoScroll";
            this.checkAutoScroll.Size = new System.Drawing.Size(96, 21);
            this.checkAutoScroll.TabIndex = 2;
            this.checkAutoScroll.Text = "Auto scroll";
            this.checkAutoScroll.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkAutoMode);
            this.groupBox3.Controls.Add(this.lblQuatStatus);
            this.groupBox3.Controls.Add(this.lblBomStatus);
            this.groupBox3.Controls.Add(this.txtConditionQuat);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtConditionBom);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnRelayQuat);
            this.groupBox3.Controls.Add(this.btnRelayBom);
            this.groupBox3.Location = new System.Drawing.Point(41, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(545, 189);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control Relay";
            // 
            // btnRelayBom
            // 
            this.btnRelayBom.Location = new System.Drawing.Point(349, 26);
            this.btnRelayBom.Name = "btnRelayBom";
            this.btnRelayBom.Size = new System.Drawing.Size(107, 54);
            this.btnRelayBom.TabIndex = 0;
            this.btnRelayBom.Text = "Bật tắt bơm";
            this.btnRelayBom.UseVisualStyleBackColor = true;
            this.btnRelayBom.Click += new System.EventHandler(this.btnRelayBom_Click);
            // 
            // btnRelayQuat
            // 
            this.btnRelayQuat.Location = new System.Drawing.Point(349, 86);
            this.btnRelayQuat.Name = "btnRelayQuat";
            this.btnRelayQuat.Size = new System.Drawing.Size(107, 54);
            this.btnRelayQuat.TabIndex = 1;
            this.btnRelayQuat.Text = "Bật tắt quạt";
            this.btnRelayQuat.UseVisualStyleBackColor = true;
            this.btnRelayQuat.Click += new System.EventHandler(this.btnRelayQuat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Độ ẩm đất hiện tại < ";
            // 
            // txtConditionBom
            // 
            this.txtConditionBom.Location = new System.Drawing.Point(154, 37);
            this.txtConditionBom.Name = "txtConditionBom";
            this.txtConditionBom.Size = new System.Drawing.Size(100, 22);
            this.txtConditionBom.TabIndex = 4;
            this.txtConditionBom.Text = "40";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nhiệt độ hiện tại >";
            // 
            // txtConditionQuat
            // 
            this.txtConditionQuat.Location = new System.Drawing.Point(154, 102);
            this.txtConditionQuat.Name = "txtConditionQuat";
            this.txtConditionQuat.Size = new System.Drawing.Size(100, 22);
            this.txtConditionQuat.TabIndex = 6;
            this.txtConditionQuat.Text = "35";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Độ ẩm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTimeUpdate);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lblApSuat);
            this.groupBox4.Controls.Add(this.lblDoAmDat);
            this.groupBox4.Controls.Add(this.lblNhietDo);
            this.groupBox4.Controls.Add(this.lblDoAm);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(41, 462);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(547, 159);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin thu thập";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Nhiệt độ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(258, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Độ ẩm đất";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(275, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Áp suất";
            // 
            // lblDoAm
            // 
            this.lblDoAm.AutoSize = true;
            this.lblDoAm.Location = new System.Drawing.Point(120, 33);
            this.lblDoAm.Name = "lblDoAm";
            this.lblDoAm.Size = new System.Drawing.Size(28, 17);
            this.lblDoAm.TabIndex = 12;
            this.lblDoAm.Text = "0%";
            // 
            // lblNhietDo
            // 
            this.lblNhietDo.AutoSize = true;
            this.lblNhietDo.Location = new System.Drawing.Point(120, 61);
            this.lblNhietDo.Name = "lblNhietDo";
            this.lblNhietDo.Size = new System.Drawing.Size(43, 17);
            this.lblNhietDo.TabIndex = 12;
            this.lblNhietDo.Text = "30 °C";
            // 
            // lblDoAmDat
            // 
            this.lblDoAmDat.AutoSize = true;
            this.lblDoAmDat.Location = new System.Drawing.Point(364, 33);
            this.lblDoAmDat.Name = "lblDoAmDat";
            this.lblDoAmDat.Size = new System.Drawing.Size(28, 17);
            this.lblDoAmDat.TabIndex = 13;
            this.lblDoAmDat.Text = "0%";
            // 
            // lblApSuat
            // 
            this.lblApSuat.AutoSize = true;
            this.lblApSuat.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblApSuat.Location = new System.Drawing.Point(364, 61);
            this.lblApSuat.Name = "lblApSuat";
            this.lblApSuat.Size = new System.Drawing.Size(70, 17);
            this.lblApSuat.TabIndex = 13;
            this.lblApSuat.Text = "1000 hPA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Chu kỳ: ";
            // 
            // lblTimeUpdate
            // 
            this.lblTimeUpdate.AutoSize = true;
            this.lblTimeUpdate.Location = new System.Drawing.Point(170, 103);
            this.lblTimeUpdate.Name = "lblTimeUpdate";
            this.lblTimeUpdate.Size = new System.Drawing.Size(16, 17);
            this.lblTimeUpdate.TabIndex = 15;
            this.lblTimeUpdate.Text = "0";
            // 
            // lblBomStatus
            // 
            this.lblBomStatus.AutoSize = true;
            this.lblBomStatus.Location = new System.Drawing.Point(275, 40);
            this.lblBomStatus.Name = "lblBomStatus";
            this.lblBomStatus.Size = new System.Drawing.Size(35, 17);
            this.lblBomStatus.TabIndex = 7;
            this.lblBomStatus.Text = "OFF";
            // 
            // lblQuatStatus
            // 
            this.lblQuatStatus.AutoSize = true;
            this.lblQuatStatus.Location = new System.Drawing.Point(275, 105);
            this.lblQuatStatus.Name = "lblQuatStatus";
            this.lblQuatStatus.Size = new System.Drawing.Size(35, 17);
            this.lblQuatStatus.TabIndex = 7;
            this.lblQuatStatus.Text = "OFF";
            // 
            // checkAutoMode
            // 
            this.checkAutoMode.AutoSize = true;
            this.checkAutoMode.Location = new System.Drawing.Point(216, 146);
            this.checkAutoMode.Name = "checkAutoMode";
            this.checkAutoMode.Size = new System.Drawing.Size(189, 21);
            this.checkAutoMode.TabIndex = 3;
            this.checkAutoMode.Text = "Tự động bật bơm và quạt";
            this.checkAutoMode.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(715, 664);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(535, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tác giả: 18127027 Trần Minh Đức  - Đồ án cá nhân Smart Farm @2020 @hcmus fit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 690);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.zedGraphControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EMX Smart Farm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBaundrate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAutoConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStringData;
        private System.Windows.Forms.Button btnSendString;
        private System.Windows.Forms.CheckBox checkAutoScroll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRelayBom;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnRelayQuat;
        private System.Windows.Forms.TextBox txtConditionQuat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConditionBom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblApSuat;
        private System.Windows.Forms.Label lblDoAmDat;
        private System.Windows.Forms.Label lblNhietDo;
        private System.Windows.Forms.Label lblDoAm;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTimeUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblQuatStatus;
        private System.Windows.Forms.Label lblBomStatus;
        private System.Windows.Forms.CheckBox checkAutoMode;
        private System.Windows.Forms.Label label9;
    }
}

