namespace Athenaeum___Integrated_Library_System
{
    partial class BookManagerPage
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
            this.backbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.BooksListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datetextBox = new System.Windows.Forms.TextBox();
            this.publishertextBox = new System.Windows.Forms.TextBox();
            this.isbntextBox = new System.Windows.Forms.TextBox();
            this.authortextBox = new System.Windows.Forms.TextBox();
            this.titletextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.Transparent;
            this.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbutton.FlatAppearance.BorderSize = 0;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(3, 9);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(25, 36);
            this.backbutton.TabIndex = 10;
            this.backbutton.Text = "<";
            this.backbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "VIRTUAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "ATHENAEUM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(561, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 37);
            this.label11.TabIndex = 27;
            this.label11.Text = "BOOK MANAGER";
            // 
            // savebutton
            // 
            this.savebutton.FlatAppearance.BorderSize = 2;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Font = new System.Drawing.Font("Trebuchet MS", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.savebutton.Location = new System.Drawing.Point(630, 298);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(82, 26);
            this.savebutton.TabIndex = 28;
            this.savebutton.Text = "ADD BOOK";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // BooksListBox
            // 
            this.BooksListBox.BackColor = System.Drawing.Color.OldLace;
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.Location = new System.Drawing.Point(56, 74);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(326, 290);
            this.BooksListBox.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(487, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Publication Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(527, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "Publisher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(524, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Print ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(540, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Author";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(553, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 18);
            this.label7.TabIndex = 35;
            this.label7.Text = "Title";
            // 
            // datetextBox
            // 
            this.datetextBox.BackColor = System.Drawing.Color.OldLace;
            this.datetextBox.Location = new System.Drawing.Point(604, 261);
            this.datetextBox.Name = "datetextBox";
            this.datetextBox.Size = new System.Drawing.Size(129, 20);
            this.datetextBox.TabIndex = 45;
            // 
            // publishertextBox
            // 
            this.publishertextBox.BackColor = System.Drawing.Color.OldLace;
            this.publishertextBox.Location = new System.Drawing.Point(604, 218);
            this.publishertextBox.Name = "publishertextBox";
            this.publishertextBox.Size = new System.Drawing.Size(129, 20);
            this.publishertextBox.TabIndex = 44;
            // 
            // isbntextBox
            // 
            this.isbntextBox.BackColor = System.Drawing.Color.OldLace;
            this.isbntextBox.Location = new System.Drawing.Point(604, 175);
            this.isbntextBox.Name = "isbntextBox";
            this.isbntextBox.Size = new System.Drawing.Size(129, 20);
            this.isbntextBox.TabIndex = 43;
            // 
            // authortextBox
            // 
            this.authortextBox.BackColor = System.Drawing.Color.OldLace;
            this.authortextBox.Location = new System.Drawing.Point(604, 132);
            this.authortextBox.Name = "authortextBox";
            this.authortextBox.Size = new System.Drawing.Size(129, 20);
            this.authortextBox.TabIndex = 42;
            // 
            // titletextBox
            // 
            this.titletextBox.BackColor = System.Drawing.Color.OldLace;
            this.titletextBox.Location = new System.Drawing.Point(604, 89);
            this.titletextBox.Name = "titletextBox";
            this.titletextBox.Size = new System.Drawing.Size(129, 20);
            this.titletextBox.TabIndex = 41;
            // 
            // BookManagerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datetextBox);
            this.Controls.Add(this.publishertextBox);
            this.Controls.Add(this.isbntextBox);
            this.Controls.Add(this.authortextBox);
            this.Controls.Add(this.titletextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BooksListBox);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backbutton);
            this.Name = "BookManagerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Athenaeum";
            this.Load += new System.EventHandler(this.BookManagerPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.ListBox BooksListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox datetextBox;
        private System.Windows.Forms.TextBox publishertextBox;
        private System.Windows.Forms.TextBox isbntextBox;
        private System.Windows.Forms.TextBox authortextBox;
        private System.Windows.Forms.TextBox titletextBox;
    }
}