using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace GestionScolaire.BD
{
    public class clsConnection
    {

        public static void Init()
        {
           //Connecter la base de donné 




        }

        /* 
            Ajouter des fonctions pour ajouter modifier supprimer un etudiant

            ** AjouterEtudiant(clsEtudiant);

        */
        public static void modifier()
        {
            Console.WriteLine("Connection to database");
            string strConn = @"Data Source=LILNEX\SQLEXPRESS;Initial Catalog=lilnx;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            //string command = "update stagaire set nom where id";
            command = "update stagiaire set nom ='" + nom + "' where id= " + txtId.Text;

            //SqlCommand cmd = new SqlCommand(command);
            //cmd.Connection = conn;
            //try
            //{
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Ajouté avec succes");
            //    conn.Close();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}