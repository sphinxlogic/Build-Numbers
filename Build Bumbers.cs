using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BuildNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataSet dataSet = new DataSet();
            dataSet.ReadXml("data.xml");
            dataGridView1.DataSource = dataSet.Tables[0];           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
