
namespace GUI3
{
    partial class Form1
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
            this.text1 = new System.Windows.Forms.RichTextBox();
            this.text3 = new System.Windows.Forms.RichTextBox();
            this.text2 = new System.Windows.Forms.RichTextBox();
            this.Pievienot1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Pievienot2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Pievienot3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(133, 74);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(100, 96);
            this.text1.TabIndex = 0;
            this.text1.Text = "";
            this.text1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(567, 74);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(100, 96);
            this.text3.TabIndex = 1;
            this.text3.Text = "";
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(339, 74);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(100, 96);
            this.text2.TabIndex = 2;
            this.text2.Text = "";
            // 
            // Pievienot1
            // 
            this.Pievienot1.Location = new System.Drawing.Point(133, 192);
            this.Pievienot1.Name = "Pievienot1";
            this.Pievienot1.Size = new System.Drawing.Size(75, 23);
            this.Pievienot1.TabIndex = 3;
            this.Pievienot1.Text = "Pievienot";
            this.Pievienot1.UseVisualStyleBackColor = true;
            this.Pievienot1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Dzēst";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pievienot2
            // 
            this.Pievienot2.Location = new System.Drawing.Point(339, 191);
            this.Pievienot2.Name = "Pievienot2";
            this.Pievienot2.Size = new System.Drawing.Size(75, 23);
            this.Pievienot2.TabIndex = 5;
            this.Pievienot2.Text = "Pievienot";
            this.Pievienot2.UseVisualStyleBackColor = true;
            this.Pievienot2.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(339, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Dzēst";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Pievienot3
            // 
            this.Pievienot3.Location = new System.Drawing.Point(567, 191);
            this.Pievienot3.Name = "Pievienot3";
            this.Pievienot3.Size = new System.Drawing.Size(75, 23);
            this.Pievienot3.TabIndex = 7;
            this.Pievienot3.Text = "Pievienot";
            this.Pievienot3.UseVisualStyleBackColor = true;
            this.Pievienot3.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(567, 236);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Dzēst";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(813, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Pievienot3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Pievienot2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Pievienot1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox text1;
        private System.Windows.Forms.RichTextBox text3;
        private System.Windows.Forms.RichTextBox text2;
        private System.Windows.Forms.Button Pievienot1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Pievienot2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Pievienot3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
    }
}

