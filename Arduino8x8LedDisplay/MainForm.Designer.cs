namespace Arduino8x8LedDisplay
{
    partial class MainForm
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
            this.cbAvailablePorts = new System.Windows.Forms.ComboBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.lbHelp = new System.Windows.Forms.Label();
            this.lbCopyright = new System.Windows.Forms.Label();
            this.pbGrid = new System.Windows.Forms.PictureBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btPrint = new System.Windows.Forms.Button();
            this.lbLink = new System.Windows.Forms.LinkLabel();
            this.lbType = new System.Windows.Forms.Label();
            this.lbCircuit = new System.Windows.Forms.Label();
            this.linkArudinoCircuit = new System.Windows.Forms.LinkLabel();
            this.lbCllick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAvailablePorts
            // 
            this.cbAvailablePorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAvailablePorts.FormattingEnabled = true;
            this.cbAvailablePorts.Location = new System.Drawing.Point(12, 12);
            this.cbAvailablePorts.Name = "cbAvailablePorts";
            this.cbAvailablePorts.Size = new System.Drawing.Size(121, 21);
            this.cbAvailablePorts.TabIndex = 0;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(153, 10);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(119, 23);
            this.btConnect.TabIndex = 1;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(12, 46);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(109, 13);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Status: Disconnected";
            // 
            // btDisconnect
            // 
            this.btDisconnect.Enabled = false;
            this.btDisconnect.Location = new System.Drawing.Point(293, 10);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(119, 23);
            this.btDisconnect.TabIndex = 4;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // lbHelp
            // 
            this.lbHelp.AutoSize = true;
            this.lbHelp.Location = new System.Drawing.Point(12, 302);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(170, 13);
            this.lbHelp.TabIndex = 6;
            this.lbHelp.Text = "Code for Arduino can be found on:";
            // 
            // lbCopyright
            // 
            this.lbCopyright.AutoSize = true;
            this.lbCopyright.Location = new System.Drawing.Point(377, 399);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.Size = new System.Drawing.Size(138, 13);
            this.lbCopyright.TabIndex = 7;
            this.lbCopyright.Text = "(c) Stanislav Ushakov 2015";
            // 
            // pbGrid
            // 
            this.pbGrid.BackColor = System.Drawing.Color.White;
            this.pbGrid.Location = new System.Drawing.Point(15, 88);
            this.pbGrid.Name = "pbGrid";
            this.pbGrid.Size = new System.Drawing.Size(201, 201);
            this.pbGrid.TabIndex = 8;
            this.pbGrid.TabStop = false;
            this.pbGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbGrid_MouseClick);
            // 
            // tbInput
            // 
            this.tbInput.Enabled = false;
            this.tbInput.Location = new System.Drawing.Point(264, 90);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(161, 20);
            this.tbInput.TabIndex = 9;
            // 
            // btPrint
            // 
            this.btPrint.Enabled = false;
            this.btPrint.Location = new System.Drawing.Point(431, 88);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(75, 23);
            this.btPrint.TabIndex = 10;
            this.btPrint.Text = "Print";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // lbLink
            // 
            this.lbLink.AutoSize = true;
            this.lbLink.Location = new System.Drawing.Point(12, 327);
            this.lbLink.Name = "lbLink";
            this.lbLink.Size = new System.Drawing.Size(495, 13);
            this.lbLink.TabIndex = 5;
            this.lbLink.TabStop = true;
            this.lbLink.Text = "https://github.com/StanislavUshakov/Arduino8x8LedDisplay/blob/master/Arduino/_8x8" +
    "LedDisplay.ino";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(261, 70);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(127, 13);
            this.lbType.TabIndex = 11;
            this.lbType.Text = "Type text, then click Print";
            // 
            // lbCircuit
            // 
            this.lbCircuit.AutoSize = true;
            this.lbCircuit.Location = new System.Drawing.Point(12, 355);
            this.lbCircuit.Name = "lbCircuit";
            this.lbCircuit.Size = new System.Drawing.Size(174, 13);
            this.lbCircuit.TabIndex = 13;
            this.lbCircuit.Text = "Circuit for Arduino can be found on:";
            // 
            // linkArudinoCircuit
            // 
            this.linkArudinoCircuit.AutoSize = true;
            this.linkArudinoCircuit.Location = new System.Drawing.Point(12, 380);
            this.linkArudinoCircuit.Name = "linkArudinoCircuit";
            this.linkArudinoCircuit.Size = new System.Drawing.Size(503, 13);
            this.linkArudinoCircuit.TabIndex = 12;
            this.linkArudinoCircuit.TabStop = true;
            this.linkArudinoCircuit.Text = "https://github.com/StanislavUshakov/Arduino8x8LedDisplay/blob/master/Images/Ardui" +
    "no_Scheme.png";
            // 
            // lbCllick
            // 
            this.lbCllick.AutoSize = true;
            this.lbCllick.Location = new System.Drawing.Point(12, 68);
            this.lbCllick.Name = "lbCllick";
            this.lbCllick.Size = new System.Drawing.Size(209, 13);
            this.lbCllick.TabIndex = 14;
            this.lbCllick.Text = "Click on separate pixels to turn them on/off";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 420);
            this.Controls.Add(this.lbCllick);
            this.Controls.Add(this.lbCircuit);
            this.Controls.Add(this.linkArudinoCircuit);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.pbGrid);
            this.Controls.Add(this.lbCopyright);
            this.Controls.Add(this.lbHelp);
            this.Controls.Add(this.lbLink);
            this.Controls.Add(this.btDisconnect);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.cbAvailablePorts);
            this.Name = "MainForm";
            this.Text = "Arduino Dimmer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAvailablePorts;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Label lbHelp;
        private System.Windows.Forms.Label lbCopyright;
        private System.Windows.Forms.PictureBox pbGrid;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.LinkLabel lbLink;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbCircuit;
        private System.Windows.Forms.LinkLabel linkArudinoCircuit;
        private System.Windows.Forms.Label lbCllick;

    }
}

