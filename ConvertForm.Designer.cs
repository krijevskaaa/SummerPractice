
namespace SummerPractice
{
    partial class ConvertForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_getCurr2 = new System.Windows.Forms.ComboBox();
            this.result = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.cb_getCurr1 = new System.Windows.Forms.ComboBox();
            this.GetResult = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_sum = new System.Windows.Forms.TextBox();
            this.kurs1 = new System.Windows.Forms.Label();
            this.kurs2 = new System.Windows.Forms.Label();
            this.b_switch = new System.Windows.Forms.Button();
            this.l_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть валюту:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Конвертую у:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отримую:";
            // 
            // cb_getCurr2
            // 
            this.cb_getCurr2.FormattingEnabled = true;
            this.cb_getCurr2.Location = new System.Drawing.Point(366, 175);
            this.cb_getCurr2.Name = "cb_getCurr2";
            this.cb_getCurr2.Size = new System.Drawing.Size(178, 28);
            this.cb_getCurr2.TabIndex = 4;
            this.cb_getCurr2.SelectedIndexChanged += new System.EventHandler(this.cb_getCurr2_SelectedIndexChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(362, 400);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 20);
            this.result.TabIndex = 5;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(456, 527);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(111, 32);
            this.close.TabIndex = 6;
            this.close.Text = "Закрити";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click_1);
            // 
            // cb_getCurr1
            // 
            this.cb_getCurr1.FormattingEnabled = true;
            this.cb_getCurr1.Location = new System.Drawing.Point(40, 175);
            this.cb_getCurr1.Name = "cb_getCurr1";
            this.cb_getCurr1.Size = new System.Drawing.Size(178, 28);
            this.cb_getCurr1.TabIndex = 7;
            this.cb_getCurr1.SelectedIndexChanged += new System.EventHandler(this.cb_getCurr1_SelectedIndexChanged);
            // 
            // GetResult
            // 
            this.GetResult.Location = new System.Drawing.Point(40, 455);
            this.GetResult.Name = "GetResult";
            this.GetResult.Size = new System.Drawing.Size(140, 32);
            this.GetResult.TabIndex = 8;
            this.GetResult.Text = "Розрахувати";
            this.GetResult.UseVisualStyleBackColor = true;
            this.GetResult.Click += new System.EventHandler(this.GetResult_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Введіть суму, яку хочете конвертувати";
            // 
            // tb_sum
            // 
            this.tb_sum.Location = new System.Drawing.Point(40, 394);
            this.tb_sum.Name = "tb_sum";
            this.tb_sum.Size = new System.Drawing.Size(140, 26);
            this.tb_sum.TabIndex = 10;
            this.tb_sum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_sum_KeyPress);
            // 
            // kurs1
            // 
            this.kurs1.AutoSize = true;
            this.kurs1.Location = new System.Drawing.Point(36, 223);
            this.kurs1.Name = "kurs1";
            this.kurs1.Size = new System.Drawing.Size(166, 20);
            this.kurs1.TabIndex = 11;
            this.kurs1.Text = "Курс обраної валюти";
            // 
            // kurs2
            // 
            this.kurs2.AutoSize = true;
            this.kurs2.Location = new System.Drawing.Point(362, 223);
            this.kurs2.Name = "kurs2";
            this.kurs2.Size = new System.Drawing.Size(166, 20);
            this.kurs2.TabIndex = 12;
            this.kurs2.Text = "Курс обраної валюти";
            // 
            // b_switch
            // 
            this.b_switch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.b_switch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_switch.Location = new System.Drawing.Point(267, 175);
            this.b_switch.Name = "b_switch";
            this.b_switch.Size = new System.Drawing.Size(35, 32);
            this.b_switch.TabIndex = 13;
            this.b_switch.Text = "↔";
            this.b_switch.UseVisualStyleBackColor = true;
            this.b_switch.Click += new System.EventHandler(this.b_switch_Click);
            // 
            // l_result
            // 
            this.l_result.AutoSize = true;
            this.l_result.Location = new System.Drawing.Point(362, 400);
            this.l_result.Name = "l_result";
            this.l_result.Size = new System.Drawing.Size(89, 20);
            this.l_result.TabIndex = 14;
            this.l_result.Text = "Результат";
            // 
            // ConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 571);
            this.Controls.Add(this.l_result);
            this.Controls.Add(this.b_switch);
            this.Controls.Add(this.kurs2);
            this.Controls.Add(this.kurs1);
            this.Controls.Add(this.tb_sum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GetResult);
            this.Controls.Add(this.cb_getCurr1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.result);
            this.Controls.Add(this.cb_getCurr2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConvertForm";
            this.Text = "Конвертер валют";
            this.Load += new System.EventHandler(this.ConvertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_getCurr2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ComboBox cb_getCurr1;
        private System.Windows.Forms.Button GetResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_sum;
        private System.Windows.Forms.Label kurs1;
        private System.Windows.Forms.Label kurs2;
        private System.Windows.Forms.Button b_switch;
        private System.Windows.Forms.Label l_result;
    }
}