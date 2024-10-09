namespace brahistohrone
{
    partial class Form1
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
            this.labelCoordinateSystem = new System.Windows.Forms.Label();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.labelRadius = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonStartAnimation = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxCoordinateSystem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCoordinateSystem
            // 
            this.labelCoordinateSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCoordinateSystem.AutoSize = true;
            this.labelCoordinateSystem.Location = new System.Drawing.Point(763, 18);
            this.labelCoordinateSystem.Name = "labelCoordinateSystem";
            this.labelCoordinateSystem.Size = new System.Drawing.Size(139, 16);
            this.labelCoordinateSystem.TabIndex = 1;
            this.labelCoordinateSystem.Text = "Система координат:";
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRadius.Location = new System.Drawing.Point(908, 51);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(128, 22);
            this.textBoxRadius.TabIndex = 2;
            // 
            // labelRadius
            // 
            this.labelRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(763, 54);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(133, 16);
            this.labelRadius.TabIndex = 3;
            this.labelRadius.Text = "Значение радиуса:";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDraw.Location = new System.Drawing.Point(766, 363);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(270, 47);
            this.buttonDraw.TabIndex = 4;
            this.buttonDraw.Text = "Построить брахистохрону";
            this.buttonDraw.UseVisualStyleBackColor = true;
            // 
            // buttonStartAnimation
            // 
            this.buttonStartAnimation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartAnimation.Location = new System.Drawing.Point(766, 416);
            this.buttonStartAnimation.Name = "buttonStartAnimation";
            this.buttonStartAnimation.Size = new System.Drawing.Size(270, 47);
            this.buttonStartAnimation.TabIndex = 5;
            this.buttonStartAnimation.Text = "Запустить анимацию";
            this.buttonStartAnimation.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(738, 451);
            this.chart.TabIndex = 6;
            // 
            // comboBoxCoordinateSystem
            // 
            this.comboBoxCoordinateSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCoordinateSystem.FormattingEnabled = true;
            this.comboBoxCoordinateSystem.Items.AddRange(new object[] {
            "Декартовая",
            "Полярная"});
            this.comboBoxCoordinateSystem.Location = new System.Drawing.Point(908, 15);
            this.comboBoxCoordinateSystem.Name = "comboBoxCoordinateSystem";
            this.comboBoxCoordinateSystem.Size = new System.Drawing.Size(128, 24);
            this.comboBoxCoordinateSystem.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1048, 475);
            this.Controls.Add(this.comboBoxCoordinateSystem);
            this.Controls.Add(this.buttonStartAnimation);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.labelRadius);
            this.Controls.Add(this.textBoxRadius);
            this.Controls.Add(this.labelCoordinateSystem);
            this.Controls.Add(this.chart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCoordinateSystem;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonStartAnimation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ComboBox comboBoxCoordinateSystem;
    }
}

