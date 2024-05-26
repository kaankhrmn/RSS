using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlOku = new XmlTextReader("https://www.haberturk.com/rss");
            while (xmlOku.Read())
            {
                if (xmlOku.Name=="title")
                {
                    listBox1.Items.Add(xmlOku.ReadString());
                }
            }
        }
    }
}
