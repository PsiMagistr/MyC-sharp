namespace StudentSim
{
    partial class GForm
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
            this.Map = new System.Windows.Forms.PictureBox();
            this.actionsTime = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.personalPanel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // Map
            // 
            this.Map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Map.Location = new System.Drawing.Point(12, 153);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(1221, 507);
            this.Map.TabIndex = 0;
            this.Map.TabStop = false;
            this.Map.Paint += new System.Windows.Forms.PaintEventHandler(this.Map_Paint);
            this.Map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Map_MouseDown);
            // 
            // actionsTime
            // 
            this.actionsTime.Enabled = true;
            this.actionsTime.Interval = 200;
            this.actionsTime.Tick += new System.EventHandler(this.actionsTime_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // personalPanel
            // 
            this.personalPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personalPanel.Location = new System.Drawing.Point(12, 41);
            this.personalPanel.Name = "personalPanel";
            this.personalPanel.Size = new System.Drawing.Size(1221, 106);
            this.personalPanel.TabIndex = 2;
            this.personalPanel.TabStop = false;
            this.personalPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.personalPanel_Paint);
            // 
            // GForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 673);
            this.Controls.Add(this.personalPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Map);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GForm";
            this.Text = "Симулятор студента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Map;
        private System.Windows.Forms.Timer actionsTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox personalPanel;
    }
}