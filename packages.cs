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
    public partial class packages : Form
    {
        string usname;
        public packages()
        {
            InitializeComponent();
        }
        public packages(string ussname)
        {
            InitializeComponent();
            usname = ussname;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttongobackpackage_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonaddtocartregular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to cart");


            SqlConnection conn = null;
            try
            {






                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"INSERT INTO Mycart6 (Added_Items,Price,Uname) VALUES ('Bronze Package',6000,'{usname}');";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                //DataTable dt = ds.Tables[0];
                //string val = dt.Rows[0]["Password"].ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("User doesnot exist");
            }
            finally
            {
                //MessageBox.Show("Login Successfull");

                conn.Close();
            }
        }

        private void buttonaddtocartpremium_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to cart");


            SqlConnection conn = null;
            try
            {






                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"INSERT INTO Mycart6 (Added_Items,Price,Uname) VALUES ('Silver Package',12000,'{usname}');";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                //DataTable dt = ds.Tables[0];
                //string val = dt.Rows[0]["Password"].ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("User doesnot exist");
            }
            finally
            {
                //MessageBox.Show("Login Successfull");

                conn.Close();
            }
        }

        private void buttonAddtocartelite_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to cart");


            SqlConnection conn = null;
            try
            {






                conn = new SqlConnection(@"Data Source=LAPTOP-P2SVQ04J\SQLEXPRESS;Initial Catalog=Campsite;Integrated Security=True");
                conn.Open();

                string query = $"INSERT INTO Mycart6 (Added_Items,Price,Uname) VALUES ('Gold Package',22000,'{usname}');";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                //DataTable dt = ds.Tables[0];
                //string val = dt.Rows[0]["Password"].ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("User doesnot exist");
            }
            finally
            {
                //MessageBox.Show("Login Successfull");

                conn.Close();
            }
        }

        private void buttoncartpackage_Click(object sender, EventArgs e)
        {
            mycart aa = new mycart(usname);
            aa.Show();
        }
    }
}
