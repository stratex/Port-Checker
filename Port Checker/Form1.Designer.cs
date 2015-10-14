namespace Port_Checker
{
    partial class frmMain
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
            this.cmdStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PortMin = new System.Windows.Forms.NumericUpDown();
            this.PortMax = new System.Windows.Forms.NumericUpDown();
            this.listPort = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.PortMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortMax)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(12, 308);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(190, 28);
            this.cmdStart.TabIndex = 1;
            this.cmdStart.Text = "Check";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(12, 25);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(190, 20);
            this.txtIP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port Range:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "To";
            // 
            // PortMin
            // 
            this.PortMin.Location = new System.Drawing.Point(12, 64);
            this.PortMin.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PortMin.Name = "PortMin";
            this.PortMin.Size = new System.Drawing.Size(80, 20);
            this.PortMin.TabIndex = 7;
            // 
            // PortMax
            // 
            this.PortMax.Location = new System.Drawing.Point(130, 64);
            this.PortMax.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PortMax.Name = "PortMax";
            this.PortMax.Size = new System.Drawing.Size(80, 20);
            this.PortMax.TabIndex = 8;
            // 
            // listPort
            // 
            this.listPort.Location = new System.Drawing.Point(12, 90);
            this.listPort.Name = "listPort";
            this.listPort.Size = new System.Drawing.Size(190, 212);
            this.listPort.TabIndex = 9;
            this.listPort.UseCompatibleStateImageBehavior = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 347);
            this.Controls.Add(this.listPort);
            this.Controls.Add(this.PortMax);
            this.Controls.Add(this.PortMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdStart);
            this.Name = "frmMain";
            this.Text = "Port Checker";
            ((System.ComponentModel.ISupportInitialize)(this.PortMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PortMin;
        private System.Windows.Forms.NumericUpDown PortMax;
        private System.Windows.Forms.ListView listPort;
    }
}

