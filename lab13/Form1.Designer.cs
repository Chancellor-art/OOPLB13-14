namespace lab13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Priz = new System.Windows.Forms.TextBox();
            this.NameFO = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.Rez = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прізвище:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ім\'я:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "По батькові:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дані співробіника:";
            // 
            // Priz
            // 
            this.Priz.Location = new System.Drawing.Point(185, 6);
            this.Priz.Name = "Priz";
            this.Priz.Size = new System.Drawing.Size(355, 27);
            this.Priz.TabIndex = 4;
            this.Priz.Text = "Лебедюк";
            this.Priz.TextChanged += new System.EventHandler(this.Priz_TextChanged);
            // 
            // NameFO
            // 
            this.NameFO.Location = new System.Drawing.Point(185, 43);
            this.NameFO.Name = "NameFO";
            this.NameFO.Size = new System.Drawing.Size(355, 27);
            this.NameFO.TabIndex = 5;
            this.NameFO.Text = "Вадим";
            this.NameFO.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(185, 85);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(355, 27);
            this.Fname.TabIndex = 6;
            this.Fname.Text = "Федорович";
            this.Fname.TextChanged += new System.EventHandler(this.Fname_TextChanged);
            // 
            // Rez
            // 
            this.Rez.Enabled = false;
            this.Rez.Location = new System.Drawing.Point(185, 176);
            this.Rez.Name = "Rez";
            this.Rez.Size = new System.Drawing.Size(355, 27);
            this.Rez.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 216);
            this.Controls.Add(this.Rez);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.NameFO);
            this.Controls.Add(this.Priz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Дані співробітника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        protected TextBox Rez;
        protected TextBox Priz;
        protected TextBox NameFO;
        protected TextBox Fname;
    }
}