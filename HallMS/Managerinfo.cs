﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HallMS
{
    public partial class Managerinfo : Form
    {
        public Managerinfo()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        Login c = new Login();
        DataTable dt = new DataTable();
        private void Managerinfo_Load(object sender, EventArgs e)
        {
            dt = da.managerinfo(c);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUname.Text == "")
            {

                MessageBox.Show("Make Sure that you enter Manager Name for search");

            }
            else
            {
                c.name = textBoxUname.Text;

                dt = da.managerinfosearch(c);
                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = da.managerinfo(c);
            dataGridView1.DataSource = dt;
        }
    }
}
