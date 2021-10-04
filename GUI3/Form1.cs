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


                first.Add(text1.Text);
            for(int i = 0; i < first.Count; i++)
            {
                label1.Text = first[i];
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (second.Count == 3)
            {
                second.Add(text2.Text);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (third.Count == 3)
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
            for (int i = 0; i < second.Count; i++)
            {
                if (second[i].Equals(text2.Text))
                {
                    second.RemoveAt(i);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < third.Count; i++)
            {
                if (third[i].Equals(text1.Text))
                {
                    third.RemoveAt(i);
                }
            }
        }
    }
}
