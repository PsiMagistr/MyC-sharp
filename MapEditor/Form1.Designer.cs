namespace MapEditor
{
    partial class MapEditor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Mappic = new System.Windows.Forms.PictureBox();
            this.w = new System.Windows.Forms.NumericUpDown();
            this.h = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btnbild = new System.Windows.Forms.Button();
            this.colorslst = new System.Windows.Forms.ListBox();
            this.SD = new System.Windows.Forms.SaveFileDialog();
            this.btnSavemap = new System.Windows.Forms.Button();
            this.OD = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Mappic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h)).BeginInit();
            this.SuspendLayout();
            // 
            // Mappic
            // 
            this.Mappic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mappic.Location = new System.Drawing.Point(217, 67);
            this.Mappic.Name = "Mappic";
            this.Mappic.Size = new System.Drawing.Size(1232, 520);
            this.Mappic.TabIndex = 0;
            this.Mappic.TabStop = false;
            this.Mappic.Paint += new System.Windows.Forms.PaintEventHandler(this.Mappic_Paint);
            this.Mappic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mappic_MouseDown);
            this.Mappic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mappic_MouseMove);
            this.Mappic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mappic_MouseUp);
            // 
            // w
            // 
            this.w.Location = new System.Drawing.Point(261, 29);
            this.w.Maximum = new decimal(new int[] {
            58,
            0,
            0,
            0});
            this.w.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(120, 20);
            this.w.TabIndex = 1;
            this.w.Value = new decimal(new int[] {
            58,
            0,
            0,
            0});
            // 
            // h
            // 
            this.h.Location = new System.Drawing.Point(12, 29);
            this.h.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.h.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(120, 20);
            this.h.TabIndex = 2;
            this.h.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Высота";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ширина";
            // 
            // Btnbild
            // 
            this.Btnbild.Location = new System.Drawing.Point(468, 31);
            this.Btnbild.Name = "Btnbild";
            this.Btnbild.Size = new System.Drawing.Size(75, 23);
            this.Btnbild.TabIndex = 5;
            this.Btnbild.Text = "Построить";
            this.Btnbild.UseVisualStyleBackColor = true;
            this.Btnbild.Click += new System.EventHandler(this.Btnbild_Click);
            // 
            // colorslst
            // 
            this.colorslst.FormattingEnabled = true;
            this.colorslst.Items.AddRange(new object[] {
            "Оранжевый",
            "Коричневый"});
            this.colorslst.Location = new System.Drawing.Point(12, 67);
            this.colorslst.Name = "colorslst";
            this.colorslst.Size = new System.Drawing.Size(183, 537);
            this.colorslst.TabIndex = 6;
            // 
            // SD
            // 
            this.SD.Filter = "(*.dat)|*.dat";
            // 
            // btnSavemap
            // 
            this.btnSavemap.Location = new System.Drawing.Point(561, 31);
            this.btnSavemap.Name = "btnSavemap";
            this.btnSavemap.Size = new System.Drawing.Size(75, 23);
            this.btnSavemap.TabIndex = 7;
            this.btnSavemap.Text = "Сохранить";
            this.btnSavemap.UseVisualStyleBackColor = true;
            this.btnSavemap.Click += new System.EventHandler(this.btnSavemap_Click);
            // 
            // OD
            // 
            this.OD.FileName = "openFileDialog1";
            this.OD.Filter = "(*.dat)|*.dat";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(655, 31);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Загрузить";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // MapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 615);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSavemap);
            this.Controls.Add(this.colorslst);
            this.Controls.Add(this.Btnbild);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.h);
            this.Controls.Add(this.w);
            this.Controls.Add(this.Mappic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MapEditor";
            this.Text = "Редактор карт";
            this.Load += new System.EventHandler(this.MapEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mappic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Mappic;
        private System.Windows.Forms.NumericUpDown w;
        private System.Windows.Forms.NumericUpDown h;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btnbild;
        private System.Windows.Forms.ListBox colorslst;
        private System.Windows.Forms.SaveFileDialog SD;
        private System.Windows.Forms.Button btnSavemap;
        private System.Windows.Forms.OpenFileDialog OD;
        private System.Windows.Forms.Button btnOpen;
    }
}

