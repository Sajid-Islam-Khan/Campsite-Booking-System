﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace campsite
{
    public partial class orderhistory : Form
    {
        string usname;
        public orderhistory()
        {
            InitializeComponent();
        }
        public orderhistory(string ussname)
        {
            InitializeComponent();
            usname = ussname;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;

            try
            {



                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"select Items,Prices from Myorder1 where Username='{usname}';";



                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                //string val = dt.Rows[1]["Total"].ToString();
                // MessageBox.Show(val);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
