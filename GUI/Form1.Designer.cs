
namespace GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.pirmais = new System.Windows.Forms.TextBox();
            this.otrais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.poga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "    ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pirmais
            // 
            this.pirmais.Location = new System.Drawing.Point(56, 80);
            this.pirmais.Name = "pirmais";
            this.pirmais.Size = new System.Drawing.Size(100, 20);
            this.pirmais.TabIndex = 1;
            this.pirmais.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // otrais
            // 
            this.otrais.Location = new System.Drawing.Point(201, 80);
            this.otrais.Name = "otrais";
            this.otrais.Size = new System.Drawing.Size(100, 20);
            this.otrais.TabIndex = 2;
            this.otrais.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // poga
            // 
            this.poga.Location = new System.Drawing.Point(143, 140);
            this.poga.Name = "poga";
            this.poga.Size = new System.Drawing.Size(75, 23);
            this.poga.TabIndex = 4;
            this.poga.Text = "saskaitīt";
            this.poga.UseVisualStyleBackColor = true;
            this.poga.Click += new System.EventHandler(this.poga_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 402);
            this.Controls.Add(this.poga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.otrais);
            this.Controls.Add(this.pirmais);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pirmais;
        private System.Windows.Forms.TextBox otrais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button poga;
    }
}

