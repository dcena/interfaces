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

namespace interfaces
{
    public partial class Dar_Alta : Form
    {
        DateTime? date;
        public Dar_Alta()
        {
            InitializeComponent();
            date = null;
            dtp_Fecha.CustomFormat =" ";
        }

        private void dtp_Fecha_ValueChanged(object sender, EventArgs e)
        {
            dtp_Fecha.CustomFormat = "dd/MM/yyyy";
            date = dtp_Fecha.Value;
            tb_Carpeta.Text = date.Value.Year.ToString().Substring(2);
        }

        private void tb_Carpeta_TextChanged(object sender, EventArgs e)
        {
            //string id = string.Empty;
            //string queryString = "SELECT TOP 1 Orden FROM Personas ORDER BY Orden DESC;";
            //using (SqlConnection con = new SqlConnection(/*connectionString*/))
            //using (SqlCommand cmd = new SqlCommand(queryString, con))
            //{

            //    con.Open();
            //    using (SqlDataReader reader = cmd.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            id = (int.Parse(reader["Orden"].ToString()) + 1).ToString();
            //        }
            //    }
            //}
            //tb_Orden.Text = id;
        }

        private void btn_DarAlta_Click(object sender, EventArgs e)
        {
            if (dtp_Fecha.Text == " ")
            {
                tb_Contenido.Text = "vacio";
            }
        }
    }
}
