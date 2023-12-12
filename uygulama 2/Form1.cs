using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace uygulama_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            int sayi1=Convert.ToInt32(textBox1.Text);
            int sayi2=Convert.ToInt32(textBox2.Text);
            listBox1.Items.Clear();
            int t = 0;
            for (int i=sayi1; i<=sayi2; i++)
            {
                listBox1.Items.Add(i);
                t += i;    
            }
            label1.Text = "Toplam =" + t.ToString();
        }
    }
}
