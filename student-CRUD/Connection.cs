using System;
using System.Data.SqlClient;
using System.Windows.Forms;
 
namespace student_CRUD
{
    public class Connection
    {

        static string chaine = @"Data Source=HOUSSAM-PC\SQLEXPRESS;Initial Catalog=db;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        /// <summary>
        /// methode ajouter qui insert l'etudiant dans la base de donnees 
        /// </summary>
        /// <param name="Nom">Nom</param>
        /// <param name="Prenom">Prenom</param>
        /// <param name="CNE">CNE</param>
        public static void ajouter(String Nom, String Prenom, String CNE)
        {

            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "insert into etudiant values('" + CNE + "','" + Nom + "','" + Prenom + "');  ";
                int id = cmd.ExecuteNonQuery();

                Console.WriteLine(id);

            }
            catch (Exception e)
            {
               MessageBox.Show(e.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        /// <summary>
        /// methode qui affiche l'id (cne) dans ddl 
        /// </summary>
        /// <param name="comboBox1"> combobox </param>
        public static void Combobox(ComboBox comboBox1)
        {
                   
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "SELECT CNE FROM etudiant";
                SqlDataReader Reader = cmd.ExecuteReader();
                comboBox1.Items.Clear();
          

                while (Reader.Read())
                {
                    comboBox1.Items.Add(Reader[0]);
                }

                Reader.Close();

            }

            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

            finally
            {
                cnx.Close();
            }
        }


        /// <summary>
        /// methode de modification d'un etudiant 
        /// </summary>
        /// <param name="Nom"> nouveau nom </param>
        /// <param name="Prenom"> nouveau prenom </param>
        /// <param name="CNE"> nouveau cne </param>
        public static void modifier(String Nom, String Prenom, String CNE)
        {
            
            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "UPDATE etudiant SET NOM = '" + Nom + "', PRENOM = '" + Prenom + "' WHERE CNE = '" + CNE + "';";
                int id = cmd.ExecuteNonQuery();

                Console.WriteLine(id);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cnx.Close();
            }
        }

        /// <summary>
        /// methode de suppression pour supprimer un etudiant de la base de donnees 
        /// </summary>
        /// <param name="CNE"> cne </param>
        public static void supprimer(String CNE)
        {

            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "DELETE FROM etudiant WHERE CNE = '" + CNE + "'; ";
                int id = cmd.ExecuteNonQuery();

                Console.WriteLine(id);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cnx.Close();
            }

        }

        /// <summary>
        /// methode qui affiche les donnees d'etudiant selectionne dans la base de donnees 
        /// </summary>
        /// <param name="cne"> cne </param>
        /// <returns></returns>
        public static Student select(String cne)
        {
            Student etudiant = new Student();
            cnx.Open();
            cmd.CommandText = "select * from etudiant where CNE = @cne ";
            cmd.Connection = cnx;
            cmd.Parameters.AddWithValue("@cne", cne);

            using (SqlDataReader Reader = cmd.ExecuteReader())
            {
                while (Reader.Read())
                {
                    etudiant.cne = Reader["cne"].ToString();
                    etudiant.nom = Reader["nom"].ToString();
                    etudiant.prenom = Reader["prenom"].ToString();
                }
                cmd.Parameters.Clear();
                cnx.Close();
            }

            return etudiant;
        }



        public Connection()
            {
            }



        }

}
