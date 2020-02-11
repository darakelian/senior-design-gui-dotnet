namespace AutomatedCasualtyControlResponse
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zone5GroupBox = new System.Windows.Forms.GroupBox();
            this.zone1GroupBox = new System.Windows.Forms.GroupBox();
            this.zone2GroupBox = new System.Windows.Forms.GroupBox();
            this.zone3GroupBox = new System.Windows.Forms.GroupBox();
            this.zone4GroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.engineLoadTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.zone5SumpTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.zone5FlowTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.zone1PumpTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.zone1FlowTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.zone1PressureTextBox = new System.Windows.Forms.TextBox();
            this.zone2PressureTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.zone2FlowTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.zone3PressureTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.zone3FlowTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.zone3TemperatureTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txTextBox = new System.Windows.Forms.TextBox();
            this.rxTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.zone5GroupBox.SuspendLayout();
            this.zone1GroupBox.SuspendLayout();
            this.zone2GroupBox.SuspendLayout();
            this.zone3GroupBox.SuspendLayout();
            this.zone4GroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // zone5GroupBox
            // 
            this.zone5GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.zone5GroupBox.BackColor = System.Drawing.Color.Purple;
            this.zone5GroupBox.Controls.Add(this.zone5FlowTextBox);
            this.zone5GroupBox.Controls.Add(this.label3);
            this.zone5GroupBox.Controls.Add(this.zone5SumpTextBox);
            this.zone5GroupBox.Controls.Add(this.label2);
            this.zone5GroupBox.ForeColor = System.Drawing.Color.White;
            this.zone5GroupBox.Location = new System.Drawing.Point(13, 28);
            this.zone5GroupBox.Name = "zone5GroupBox";
            this.zone5GroupBox.Size = new System.Drawing.Size(200, 477);
            this.zone5GroupBox.TabIndex = 1;
            this.zone5GroupBox.TabStop = false;
            this.zone5GroupBox.Text = "Zone 5";
            // 
            // zone1GroupBox
            // 
            this.zone1GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zone1GroupBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.zone1GroupBox.Controls.Add(this.zone1PressureTextBox);
            this.zone1GroupBox.Controls.Add(this.label6);
            this.zone1GroupBox.Controls.Add(this.zone1FlowTextBox);
            this.zone1GroupBox.Controls.Add(this.label5);
            this.zone1GroupBox.Controls.Add(this.zone1PumpTextBox);
            this.zone1GroupBox.Controls.Add(this.label4);
            this.zone1GroupBox.Location = new System.Drawing.Point(220, 28);
            this.zone1GroupBox.Name = "zone1GroupBox";
            this.zone1GroupBox.Size = new System.Drawing.Size(568, 155);
            this.zone1GroupBox.TabIndex = 2;
            this.zone1GroupBox.TabStop = false;
            this.zone1GroupBox.Text = "Zone 1";
            // 
            // zone2GroupBox
            // 
            this.zone2GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zone2GroupBox.BackColor = System.Drawing.Color.Gold;
            this.zone2GroupBox.Controls.Add(this.zone2PressureTextBox);
            this.zone2GroupBox.Controls.Add(this.label7);
            this.zone2GroupBox.Controls.Add(this.zone2FlowTextBox);
            this.zone2GroupBox.Controls.Add(this.label8);
            this.zone2GroupBox.Location = new System.Drawing.Point(220, 189);
            this.zone2GroupBox.Name = "zone2GroupBox";
            this.zone2GroupBox.Size = new System.Drawing.Size(568, 155);
            this.zone2GroupBox.TabIndex = 3;
            this.zone2GroupBox.TabStop = false;
            this.zone2GroupBox.Text = "Zone 2";
            // 
            // zone3GroupBox
            // 
            this.zone3GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zone3GroupBox.BackColor = System.Drawing.Color.YellowGreen;
            this.zone3GroupBox.Controls.Add(this.zone3TemperatureTextBox);
            this.zone3GroupBox.Controls.Add(this.label11);
            this.zone3GroupBox.Controls.Add(this.zone3PressureTextBox);
            this.zone3GroupBox.Controls.Add(this.label9);
            this.zone3GroupBox.Controls.Add(this.zone3FlowTextBox);
            this.zone3GroupBox.Controls.Add(this.label10);
            this.zone3GroupBox.Location = new System.Drawing.Point(220, 350);
            this.zone3GroupBox.Name = "zone3GroupBox";
            this.zone3GroupBox.Size = new System.Drawing.Size(568, 155);
            this.zone3GroupBox.TabIndex = 4;
            this.zone3GroupBox.TabStop = false;
            this.zone3GroupBox.Text = "Zone 3";
            // 
            // zone4GroupBox
            // 
            this.zone4GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zone4GroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.zone4GroupBox.Controls.Add(this.engineLoadTextBox);
            this.zone4GroupBox.Controls.Add(this.label1);
            this.zone4GroupBox.Location = new System.Drawing.Point(605, 511);
            this.zone4GroupBox.Name = "zone4GroupBox";
            this.zone4GroupBox.Size = new System.Drawing.Size(183, 183);
            this.zone4GroupBox.TabIndex = 5;
            this.zone4GroupBox.TabStop = false;
            this.zone4GroupBox.Text = "Zone 4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Engine Load";
            // 
            // engineLoadTextBox
            // 
            this.engineLoadTextBox.Enabled = false;
            this.engineLoadTextBox.Location = new System.Drawing.Point(6, 33);
            this.engineLoadTextBox.Name = "engineLoadTextBox";
            this.engineLoadTextBox.Size = new System.Drawing.Size(100, 20);
            this.engineLoadTextBox.TabIndex = 1;
            this.engineLoadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sump";
            // 
            // zone5SumpTextBox
            // 
            this.zone5SumpTextBox.Enabled = false;
            this.zone5SumpTextBox.Location = new System.Drawing.Point(10, 37);
            this.zone5SumpTextBox.Name = "zone5SumpTextBox";
            this.zone5SumpTextBox.Size = new System.Drawing.Size(100, 20);
            this.zone5SumpTextBox.TabIndex = 1;
            this.zone5SumpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Flow";
            // 
            // zone5FlowTextBox
            // 
            this.zone5FlowTextBox.Enabled = false;
            this.zone5FlowTextBox.Location = new System.Drawing.Point(10, 81);
            this.zone5FlowTextBox.Name = "zone5FlowTextBox";
            this.zone5FlowTextBox.Size = new System.Drawing.Size(100, 20);
            this.zone5FlowTextBox.TabIndex = 3;
            this.zone5FlowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pump";
            // 
            // zone1PumpTextBox
            // 
            this.zone1PumpTextBox.Enabled = false;
            this.zone1PumpTextBox.Location = new System.Drawing.Point(61, 20);
            this.zone1PumpTextBox.Name = "zone1PumpTextBox";
            this.zone1PumpTextBox.Size = new System.Drawing.Size(100, 20);
            this.zone1PumpTextBox.TabIndex = 1;
            this.zone1PumpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Flow";
            // 
            // zone1FlowTextBox
            // 
            this.zone1FlowTextBox.Enabled = false;
            this.zone1FlowTextBox.Location = new System.Drawing.Point(61, 50);
            this.zone1FlowTextBox.Name = "zone1FlowTextBox";
            this.zone1FlowTextBox.Size = new System.Drawing.Size(100, 20);
            this.zone1FlowTextBox.TabIndex = 3;
            this.zone1FlowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pressure";
            // 
            // zone1PressureTextBox
            // 
            this.zone1PressureTextBox.Enabled = false;
            this.zone1PressureTextBox.Location = new System.Drawing.Point(61, 78);
            this.zone1PressureTextBox.Name = "zone1PressureTextBox";
            this.zone1PressureTextBox.Size = new System.Drawing.Size(100, 20);
            this.zone1PressureTextBox.TabIndex = 5;
            this.zone1PressureTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zone2PressureTextBox
            // 
            this.zone2PressureTextBox.Enabled = false;
            this.zone2PressureTextBox.Location = new System.Drawing.Point(61, 47);
            this.zone2PressureTextBox.Name = "zone2PressureTextBox";
            this.zone2PressureTextBox.Size = new System.Drawing.Size(100, 20);
            this.zone2PressureTextBox.TabIndex = 9;
            this.zone2PressureTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pressure";
            // 
            // zone2FlowTextBox
            // 
            this.zone2FlowTextBox.Enabled = false;
            this.zone2FlowTextBox.Location = new System.Drawing.Point(61, 19);
            this.zone2FlowTextBox.Name = "zone2FlowTextBox";
            this.zone2FlowTextBox.Size = new System.Drawing.Size(100, 20);
            this.zone2FlowTextBox.TabIndex = 7;
            this.zone2FlowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Flow";
            // 
            // zone3PressureTextBox
            // 
            this.zone3PressureTextBox.Enabled = false;
            this.zone3PressureTextBox.Location = new System.Drawing.Point(61, 47);
            this.zone3PressureTextBox.Name = "zone3PressureTextBox";
            this.zone3PressureTextBox.Size = new System.Drawing.Size(100, 20);
            this.zone3PressureTextBox.TabIndex = 9;
            this.zone3PressureTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Pressure";
            // 
            // zone3FlowTextBox
            // 
            this.zone3FlowTextBox.Enabled = false;
            this.zone3FlowTextBox.Location = new System.Drawing.Point(61, 19);
            this.zone3FlowTextBox.Name = "zone3FlowTextBox";
            this.zone3FlowTextBox.Size = new System.Drawing.Size(100, 20);
            this.zone3FlowTextBox.TabIndex = 7;
            this.zone3FlowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Flow";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Temp";
            // 
            // zone3TemperatureTextBox
            // 
            this.zone3TemperatureTextBox.Enabled = false;
            this.zone3TemperatureTextBox.Location = new System.Drawing.Point(61, 76);
            this.zone3TemperatureTextBox.Name = "zone3TemperatureTextBox";
            this.zone3TemperatureTextBox.Size = new System.Drawing.Size(100, 20);
            this.zone3TemperatureTextBox.TabIndex = 11;
            this.zone3TemperatureTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rxTextBox);
            this.groupBox1.Controls.Add(this.txTextBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(12, 624);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network Diagnostics";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "TX:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "RX:";
            // 
            // txTextBox
            // 
            this.txTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txTextBox.Location = new System.Drawing.Point(37, 20);
            this.txTextBox.Name = "txTextBox";
            this.txTextBox.Size = new System.Drawing.Size(46, 13);
            this.txTextBox.TabIndex = 2;
            // 
            // rxTextBox
            // 
            this.rxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rxTextBox.Location = new System.Drawing.Point(37, 43);
            this.rxTextBox.Name = "rxTextBox";
            this.rxTextBox.Size = new System.Drawing.Size(46, 13);
            this.rxTextBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 706);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zone4GroupBox);
            this.Controls.Add(this.zone3GroupBox);
            this.Controls.Add(this.zone2GroupBox);
            this.Controls.Add(this.zone1GroupBox);
            this.Controls.Add(this.zone5GroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Casualty Response Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.zone5GroupBox.ResumeLayout(false);
            this.zone5GroupBox.PerformLayout();
            this.zone1GroupBox.ResumeLayout(false);
            this.zone1GroupBox.PerformLayout();
            this.zone2GroupBox.ResumeLayout(false);
            this.zone2GroupBox.PerformLayout();
            this.zone3GroupBox.ResumeLayout(false);
            this.zone3GroupBox.PerformLayout();
            this.zone4GroupBox.ResumeLayout(false);
            this.zone4GroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox zone5GroupBox;
        private System.Windows.Forms.GroupBox zone1GroupBox;
        private System.Windows.Forms.GroupBox zone2GroupBox;
        private System.Windows.Forms.GroupBox zone3GroupBox;
        private System.Windows.Forms.GroupBox zone4GroupBox;
        private System.Windows.Forms.TextBox engineLoadTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox zone5SumpTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox zone5FlowTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox zone1PumpTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox zone1FlowTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox zone1PressureTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox zone2PressureTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox zone2FlowTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox zone3TemperatureTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox zone3PressureTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox zone3FlowTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox rxTextBox;
        private System.Windows.Forms.TextBox txTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

