
namespace SummerPractice
{
    partial class NewsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /*protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_close = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // b_close
            // 
            this.b_close.Location = new System.Drawing.Point(485, 479);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(103, 27);
            this.b_close.TabIndex = 0;
            this.b_close.Text = "Закрити";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(445, 458);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // NewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 518);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.b_close);
            this.Name = "NewsForm";
            this.Text = "Діяльність банків України";
            this.Load += new System.EventHandler(this.NewsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.ListView listView1;
    }
}