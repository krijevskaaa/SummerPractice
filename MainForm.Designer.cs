
namespace SummerPractice
{
    partial class MainForm
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
            this.b_to_news = new System.Windows.Forms.Button();
            this.b_to_convert = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.l_data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_to_news
            // 
            this.b_to_news.ForeColor = System.Drawing.SystemColors.InfoText;
            this.b_to_news.Location = new System.Drawing.Point(344, 398);
            this.b_to_news.Name = "b_to_news";
            this.b_to_news.Size = new System.Drawing.Size(198, 49);
            this.b_to_news.TabIndex = 0;
            this.b_to_news.Text = "Показники діяльності банків України";
            this.b_to_news.UseVisualStyleBackColor = true;
            this.b_to_news.Click += new System.EventHandler(this.b_to_news_Click_1);
            // 
            // b_to_convert
            // 
            this.b_to_convert.ForeColor = System.Drawing.SystemColors.InfoText;
            this.b_to_convert.Location = new System.Drawing.Point(46, 398);
            this.b_to_convert.Name = "b_to_convert";
            this.b_to_convert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.b_to_convert.Size = new System.Drawing.Size(198, 49);
            this.b_to_convert.TabIndex = 1;
            this.b_to_convert.Text = "Конвертування валюти";
            this.b_to_convert.UseVisualStyleBackColor = true;
            this.b_to_convert.UseWaitCursor = true;
            this.b_to_convert.Click += new System.EventHandler(this.b_to_convert_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button3.Location = new System.Drawing.Point(667, 627);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Завершити";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(16, 57);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateChanged);
            // 
            // l_data
            // 
            this.l_data.Location = new System.Drawing.Point(274, 57);
            this.l_data.Name = "l_data";
            this.l_data.Size = new System.Drawing.Size(313, 253);
            this.l_data.TabIndex = 4;
            this.l_data.Text = "Оберіть дату на календарі для визначення курсу";
            this.l_data.Click += new System.EventHandler(this.l_data_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(599, 579);
            this.Controls.Add(this.l_data);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.b_to_convert);
            this.Controls.Add(this.b_to_news);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "MainForm";
            this.Text = "Конвертер валют";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_to_news;
        private System.Windows.Forms.Button b_to_convert;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label l_data;
    }
}

