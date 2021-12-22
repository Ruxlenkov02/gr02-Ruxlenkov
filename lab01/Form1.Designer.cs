
namespace lab01
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
            this.comboBox_Figure = new System.Windows.Forms.ComboBox();
            this.label_figure = new System.Windows.Forms.Label();
            this.button_craft = new System.Windows.Forms.Button();
            this.button_DELETE = new System.Windows.Forms.Button();
            this.picture_craft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_craft)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Figure
            // 
            this.comboBox_Figure.FormattingEnabled = true;
            this.comboBox_Figure.Items.AddRange(new object[] {
            "square",
            "circle"});
            this.comboBox_Figure.Location = new System.Drawing.Point(87, 16);
            this.comboBox_Figure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Figure.Name = "comboBox_Figure";
            this.comboBox_Figure.Size = new System.Drawing.Size(82, 21);
            this.comboBox_Figure.TabIndex = 0;
            // 
            // label_figure
            // 
            this.label_figure.AutoSize = true;
            this.label_figure.Location = new System.Drawing.Point(11, 18);
            this.label_figure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_figure.Name = "label_figure";
            this.label_figure.Size = new System.Drawing.Size(36, 13);
            this.label_figure.TabIndex = 1;
            this.label_figure.Text = "Figure";
            // 
            // button_craft
            // 
            this.button_craft.Location = new System.Drawing.Point(193, 18);
            this.button_craft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_craft.Name = "button_craft";
            this.button_craft.Size = new System.Drawing.Size(61, 22);
            this.button_craft.TabIndex = 2;
            this.button_craft.Text = "ADD";
            this.button_craft.UseVisualStyleBackColor = true;
            this.button_craft.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_DELETE
            // 
            this.button_DELETE.Location = new System.Drawing.Point(276, 18);
            this.button_DELETE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_DELETE.Name = "button_DELETE";
            this.button_DELETE.Size = new System.Drawing.Size(70, 19);
            this.button_DELETE.TabIndex = 3;
            this.button_DELETE.Text = "DELETE";
            this.button_DELETE.UseVisualStyleBackColor = true;
            this.button_DELETE.Click += new System.EventHandler(this.button2_Click);
            // 
            // picture_craft
            // 
            this.picture_craft.Location = new System.Drawing.Point(9, 44);
            this.picture_craft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picture_craft.Name = "picture_craft";
            this.picture_craft.Size = new System.Drawing.Size(506, 244);
            this.picture_craft.TabIndex = 4;
            this.picture_craft.TabStop = false;
            this.picture_craft.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.picture_craft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.picture_craft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.picture_craft);
            this.Controls.Add(this.button_DELETE);
            this.Controls.Add(this.button_craft);
            this.Controls.Add(this.label_figure);
            this.Controls.Add(this.comboBox_Figure);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Lab01_Ruhlenkov";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_craft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Figure;
        private System.Windows.Forms.Label label_figure;
        private System.Windows.Forms.Button button_craft;
        private System.Windows.Forms.Button button_DELETE;
        private System.Windows.Forms.PictureBox picture_craft;
    }
}

