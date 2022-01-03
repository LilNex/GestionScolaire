using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace GestionScolaire.Classes
{
    public class ClsAdo
    {
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();

        public void connecter()
        {
            if (cn.State == ConnectionState.Closed || cn.State == ConnectionState.Broken)
            {
                cn.ConnectionString = "";
                cn.Open();
            }

        }
        public void Deconnecter()
        {
            if (cn.State == ConnectionState.Open)
            {

                cn.Close();
            }

        }
    }
}