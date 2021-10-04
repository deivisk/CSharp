using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI3
{
    
    public partial class Form1 : Form
    {
        List<String> first = new List<String>();
        List<String> second = new List<String>();
        List<String> third = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(first.Count == 3)
            {
                first.Add(text1.Text);
            }
            for(int i = 0; i < first.Count; i++)
            {
                label1.Text = Convert.ToString(first[i]);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                second.Add(text2.Text);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                third.Add(text3.Text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < first.Count; i++)
            {
                if (first[i].Equals(text1.Text))
                {
                    first.RemoveAt(i);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            second.IndexOf(text1.Text);

            second.Remove(text1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            third.IndexOf(text1.Text);

            third.Remove(text1.Text);
        }
    }
}
