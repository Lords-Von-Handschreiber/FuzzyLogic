namespace K8055Controller
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
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // FrmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 257);
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
            this.ResumeLayout(false);

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
    }
}