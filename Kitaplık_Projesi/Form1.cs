﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kitaplık_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();


        private void Form1_Load(object sender, EventArgs e)
        {
          void listele()
                {
                DataTable dt = new DataTable();
                SqlDataAdapter da=new SqlDataAdapter("Select * From Tbl_Kitaplar",bgl.baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
           
            

        }
    }
}
