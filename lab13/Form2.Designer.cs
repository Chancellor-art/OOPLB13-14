namespace lab13
{
    partial class Form2
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
            this.label5 = new System.Windows.Forms.Label();
            this.DateB = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Дата нарождення:";
            // 
            // DateB
            // 
            this.DateB.Location = new System.Drawing.Point(185, 127);
            this.DateB.Name = "DateB";
            this.DateB.Size = new System.Drawing.Size(355, 27);
            this.DateB.TabIndex = 17;
            this.DateB.Value = new System.DateTime(2003, 5, 2, 21, 4, 0, 0);
            this.DateB.ValueChanged += new System.EventHandler(this.DateB_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 55);
            this.button1.TabIndex = 18;
            this.button1.Text = "Записати дані у файл по замовчуванню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 55);
            this.button2.TabIndex = 19;
            this.button2.Text = "Зчитати дані з файлу по замовчуванню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 55);
            this.button3.TabIndex = 20;
            this.button3.Text = "Записати дані в обраний файл";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(290, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 55);
            this.button4.TabIndex = 21;
            this.button4.Text = "Зчитати дані з обраного файлу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 357);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DateB);
            this.Controls.Add(this.label5);
            this.Name = "Form2";
            this.Controls.SetChildIndex(this.Priz, 0);
            this.Controls.SetChildIndex(this.NameFO, 0);
            this.Controls.SetChildIndex(this.Fname, 0);
            this.Controls.SetChildIndex(this.Rez, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.DateB, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label5;
        private DateTimePicker DateB;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}