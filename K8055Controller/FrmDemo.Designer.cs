﻿namespace K8055Controller
{
    partial class FrmDemo
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
            this.butisAvaiable = new System.Windows.Forms.Button();
            this.butGetOutsideTemperature = new System.Windows.Forms.Button();
            this.butGetInsideTemperature = new System.Windows.Forms.Button();
            this.butGetIsOneHeaterOn = new System.Windows.Forms.Button();
            this.butSetBothHeatersOn = new System.Windows.Forms.Button();
            this.butSetOneHeaterOn = new System.Windows.Forms.Button();
            this.butGetAreBothHeatersOn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnHeating = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butisAvaiable
            // 
            this.butisAvaiable.Location = new System.Drawing.Point(12, 12);
            this.butisAvaiable.Name = "butisAvaiable";
            this.butisAvaiable.Size = new System.Drawing.Size(143, 23);
            this.butisAvaiable.TabIndex = 0;
            this.butisAvaiable.Text = "isAvaiable";
            this.butisAvaiable.UseVisualStyleBackColor = true;
            this.butisAvaiable.Click += new System.EventHandler(this.butisAvaiable_Click);
            // 
            // butGetOutsideTemperature
            // 
            this.butGetOutsideTemperature.Location = new System.Drawing.Point(12, 41);
            this.butGetOutsideTemperature.Name = "butGetOutsideTemperature";
            this.butGetOutsideTemperature.Size = new System.Drawing.Size(143, 23);
            this.butGetOutsideTemperature.TabIndex = 1;
            this.butGetOutsideTemperature.Text = "GetOutsideTemperature";
            this.butGetOutsideTemperature.UseVisualStyleBackColor = true;
            this.butGetOutsideTemperature.Click += new System.EventHandler(this.butGetOutsideTemperature_Click);
            // 
            // butGetInsideTemperature
            // 
            this.butGetInsideTemperature.Location = new System.Drawing.Point(12, 70);
            this.butGetInsideTemperature.Name = "butGetInsideTemperature";
            this.butGetInsideTemperature.Size = new System.Drawing.Size(143, 23);
            this.butGetInsideTemperature.TabIndex = 2;
            this.butGetInsideTemperature.Text = "GetInsideTemperature";
            this.butGetInsideTemperature.UseVisualStyleBackColor = true;
            this.butGetInsideTemperature.Click += new System.EventHandler(this.butGetInsideTemperature_Click);
            // 
            // butGetIsOneHeaterOn
            // 
            this.butGetIsOneHeaterOn.Location = new System.Drawing.Point(12, 99);
            this.butGetIsOneHeaterOn.Name = "butGetIsOneHeaterOn";
            this.butGetIsOneHeaterOn.Size = new System.Drawing.Size(143, 23);
            this.butGetIsOneHeaterOn.TabIndex = 3;
            this.butGetIsOneHeaterOn.Text = "GetIsOneHeaterOn";
            this.butGetIsOneHeaterOn.UseVisualStyleBackColor = true;
            this.butGetIsOneHeaterOn.Click += new System.EventHandler(this.butGetIsOneHeaterOn_Click);
            // 
            // butSetBothHeatersOn
            // 
            this.butSetBothHeatersOn.Location = new System.Drawing.Point(12, 186);
            this.butSetBothHeatersOn.Name = "butSetBothHeatersOn";
            this.butSetBothHeatersOn.Size = new System.Drawing.Size(143, 23);
            this.butSetBothHeatersOn.TabIndex = 6;
            this.butSetBothHeatersOn.Text = "SetBothHeatersOn";
            this.butSetBothHeatersOn.UseVisualStyleBackColor = true;
            this.butSetBothHeatersOn.Click += new System.EventHandler(this.butSetBothHeatersOn_Click);
            // 
            // butSetOneHeaterOn
            // 
            this.butSetOneHeaterOn.Location = new System.Drawing.Point(12, 157);
            this.butSetOneHeaterOn.Name = "butSetOneHeaterOn";
            this.butSetOneHeaterOn.Size = new System.Drawing.Size(143, 23);
            this.butSetOneHeaterOn.TabIndex = 5;
            this.butSetOneHeaterOn.Text = "SetOneHeaterOn";
            this.butSetOneHeaterOn.UseVisualStyleBackColor = true;
            this.butSetOneHeaterOn.Click += new System.EventHandler(this.butSetOneHeaterOn_Click);
            // 
            // butGetAreBothHeatersOn
            // 
            this.butGetAreBothHeatersOn.Location = new System.Drawing.Point(12, 128);
            this.butGetAreBothHeatersOn.Name = "butGetAreBothHeatersOn";
            this.butGetAreBothHeatersOn.Size = new System.Drawing.Size(143, 23);
            this.butGetAreBothHeatersOn.TabIndex = 4;
            this.butGetAreBothHeatersOn.Text = "GetAreBothHeatersOn";
            this.butGetAreBothHeatersOn.UseVisualStyleBackColor = true;
            this.butGetAreBothHeatersOn.Click += new System.EventHandler(this.butGetAreBothHeatersOn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "SetNoHeaterOn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHeating
            // 
            this.btnHeating.Location = new System.Drawing.Point(161, 12);
            this.btnHeating.Name = "btnHeating";
            this.btnHeating.Size = new System.Drawing.Size(143, 23);
            this.btnHeating.TabIndex = 8;
            this.btnHeating.Text = "PerformHeating";
            this.btnHeating.UseVisualStyleBackColor = true;
            this.btnHeating.Click += new System.EventHandler(this.btnHeating_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(162, 42);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(142, 23);
            this.btnTimer.TabIndex = 9;
            this.btnTimer.Text = "Toggle Timer On";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 248);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(512, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "Inside Temp: --.-°C";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabel2.Text = "Outside Temp: -°C";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel3.Text = "Fuzzy Result: -%";
            // 
            // FrmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 270);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnHeating);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butSetBothHeatersOn);
            this.Controls.Add(this.butSetOneHeaterOn);
            this.Controls.Add(this.butGetAreBothHeatersOn);
            this.Controls.Add(this.butGetIsOneHeaterOn);
            this.Controls.Add(this.butGetInsideTemperature);
            this.Controls.Add(this.butGetOutsideTemperature);
            this.Controls.Add(this.butisAvaiable);
            this.Name = "FrmDemo";
            this.Text = "FrmDemo";
            this.Load += new System.EventHandler(this.FrmDemo_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butisAvaiable;
        private System.Windows.Forms.Button butGetOutsideTemperature;
        private System.Windows.Forms.Button butGetInsideTemperature;
        private System.Windows.Forms.Button butGetIsOneHeaterOn;
        private System.Windows.Forms.Button butSetBothHeatersOn;
        private System.Windows.Forms.Button butSetOneHeaterOn;
        private System.Windows.Forms.Button butGetAreBothHeatersOn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHeating;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}