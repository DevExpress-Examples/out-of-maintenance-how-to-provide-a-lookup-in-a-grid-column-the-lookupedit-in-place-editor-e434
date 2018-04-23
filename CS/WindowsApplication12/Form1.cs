using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                dataTable1.Rows.Add(new object[] { i, "Product" + i});
            for (int i = 0; i < 30; i++)
                dataTable2.Rows.Add(new object[] { i, i%5, "details"});
        }
    }
}