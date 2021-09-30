using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            List<int> Numbers = new List<int>();

            Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(textBox1.Text);

            int randomnumber = 0;

            for(int i = 0; i < a; i++)
            {
                randomnumber = random.Next(1, 10);

                Numbers.Add(randomnumber);

                a = Numbers[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
