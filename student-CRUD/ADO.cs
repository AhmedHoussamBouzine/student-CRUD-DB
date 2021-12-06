using System;
using System.Data.SqlClient;

namespace student_CRUD {
    public class Connection
    {

        static string chaine = @"Data Source=HOUSSAM-PC;Initial Catalog=db;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);


        public static void ajouter(String Nom, String Prenom, String CNE)
        {

            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "insert into Etudiant values('" + CNE + "','" + Nom"','" + Prenom + "') ";
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnx.Close();
            }


        }

        public Connection()
        {
        }



    }

}
