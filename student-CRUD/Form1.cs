using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_CRUD
{
      
    public partial class CRUD : Form
    {
 

        public CRUD()
        {
            InitializeComponent();
           
        }
        /// <summary>
        /// Methode du Button_ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (btn_modifier.Enabled == false)
            {
                this.btn_ajouter.Enabled = false;
                this.btn_modifier.Enabled = false;
                this.btn_supprimer.Enabled = false;
                this.btn_ajouter.Enabled = false;
                this.btn_confirmer.Enabled = true;
                this.btn_annuler.Enabled = true;
                this.text_NOM.Enabled = true;
                this.text_PRENOM.Enabled = true;
                this.text_CNE.Enabled = true;
                this.btn_confirmer.Name = "add";
            }
            else
            {
                this.text_NOM.Enabled = true;
                this.text_PRENOM.Enabled = true;
                this.text_CNE.Enabled = true;
                this.btn_confirmer.Enabled = true;
                this.btn_annuler.Enabled = true;
                this.btn_confirmer.Name = "add1";
                this.btn_ajouter.Enabled = false;
                this.btn_modifier.Enabled = false;
                this.btn_supprimer.Enabled = false;

            }

        }
        
        /// <summary>
        /// methode du boutton Supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            this.text_NOM.Enabled = true;
            this.text_PRENOM.Enabled = true;
            this.text_CNE.Enabled = true;
            this.btn_ajouter.Enabled = false;
            this.btn_modifier.Enabled = false;
            this.btn_supprimer.Enabled = false;
            this.btn_confirmer.Enabled = true;
            this.btn_annuler.Enabled = true;
            this.btn_confirmer.Name = "supp";
           
        }
        /// <summary>
        /// methode du boutton modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            this.text_NOM.Enabled = true;
            this.text_PRENOM.Enabled = true;
            this.text_CNE.Enabled = true;
            this.btn_confirmer.Name = "mod";         
            this.btn_confirmer.Enabled = true;
            this.btn_annuler.Enabled = true;
            this.btn_ajouter.Enabled = false;
            this.btn_modifier.Enabled = false;
            this.btn_supprimer.Enabled = false;

        }
        /// <summary>
        /// methode du boutton Confirmer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private  void btn_confirmer_Click(object sender, EventArgs e)
        {
            
            this.comboBox1.Enabled = true;
            this.btn_modifier.Enabled = true;
            this.btn_supprimer.Enabled = true;
            this.btn_ajouter.Enabled = true;
            this.btn_confirmer.Enabled = false;
            this.btn_annuler.Enabled = false;
            this.text_NOM.Enabled = false;
            this.text_PRENOM.Enabled = false;
            this.text_CNE.Enabled = false;
            switch (this.btn_confirmer.Name)
            {
                case "add1":

                    string message = " voulez vous ajouter cet etudiant ? ";
                    string title = "confirmer l'ajout !";
                    MessageBoxButtons btn = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, btn);
                    if (result == DialogResult.Yes)
                    {
                        String Nom = text_NOM.Text;
                        String Prenom = text_PRENOM.Text;
                        String CNE = text_CNE.Text;
                        Connection.ajouter(Nom, Prenom, CNE);
                        Connection.Combobox(comboBox1);
                    }
                    break;
                case "add":
                   
                    string message2 = " voulez vous ajouter cet etudiant ? ";
                    string title2 = "confirmer l'ajout !";
                    MessageBoxButtons btn1 = MessageBoxButtons.YesNo;
                    DialogResult result2 = MessageBox.Show(message2, title2, btn1);
                    if (result2 == DialogResult.Yes)
                    {
                        String Nom = text_NOM.Text;
                        String Prenom = text_PRENOM.Text;
                        String CNE = text_CNE.Text;
                        Connection.ajouter(Nom, Prenom, CNE);
                        Connection.Combobox(comboBox1);

                    }

                    break;
                case "mod":
                   
                    string message1 = " voulez vous modifier cet etudiant ? ";
                    string title1 = "confirmer la modification !";
                    MessageBoxButtons btns1 = MessageBoxButtons.YesNo;
                    DialogResult result1 = MessageBox.Show(message1, title1, btns1);
                    if (result1 == DialogResult.Yes)
                    {
                                           
                        String Nom = text_NOM.Text;
                        String Prenom = text_PRENOM.Text;
                        String CNE = text_CNE.Text;
                        Connection.modifier(Nom, Prenom, CNE);
                        Connection.Combobox(comboBox1);
                    }
                    break;
                case "supp":
                    
                    string message12 = " voulez vous supprimer cet etudiant ? ";
                    string title12 = "confirmer la suppression !";
                    MessageBoxButtons btns12 = MessageBoxButtons.YesNo;
                    DialogResult result12 = MessageBox.Show(message12, title12, btns12);
                    if (result12 == DialogResult.Yes)
                    {
                       
                        String CNE = text_CNE.Text;
                        Connection.supprimer(CNE);
                       this.comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                        Connection.Combobox(comboBox1);
                    }
                    break;
            }
        }

        /// <summary>
        /// methode du boutton annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            if (this.btn_confirmer.Name == "add1" || this.btn_confirmer.Name == "mod" || this.btn_confirmer.Name == "supp")
            {
                this.comboBox1.Enabled = true;
                this.btn_modifier.Enabled = true;
                this.btn_supprimer.Enabled = true;
                this.btn_ajouter.Enabled = true;
                this.btn_confirmer.Enabled = false;
                this.btn_annuler.Enabled = false;
                text_NOM.Text = String.Empty;
                text_PRENOM.Text = String.Empty;
                text_CNE.Text = String.Empty;
                this.text_NOM.Enabled = false;
                this.text_PRENOM.Enabled = false;
                this.text_CNE.Enabled = false;

            }
            else
            {
                this.btn_ajouter.Enabled = true;
                this.btn_modifier.Enabled = false;
                this.btn_supprimer.Enabled = false;
                this.btn_confirmer.Enabled = false;
                this.btn_annuler.Enabled = false;
                this.comboBox1.Enabled = false;
                this.text_NOM.Enabled = false;
                this.text_PRENOM.Enabled = false;
                this.text_CNE.Enabled = false;
                text_NOM.Text = String.Empty;
                text_PRENOM.Text = String.Empty;
                text_CNE.Text = String.Empty;

            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Student etudiant = new Student();
            etudiant = Connection.select(comboBox1.Text);

            this.text_CNE.Text = etudiant.cne;
            this.text_NOM.Text = etudiant.nom;
            this.text_PRENOM.Text = etudiant.prenom;
        }
      
        private void CRUD_Load(object sender, EventArgs e)
        {
            this.btn_ajouter.Enabled = true;
            this.btn_modifier.Enabled = false;
            this.btn_supprimer.Enabled = false;
            this.btn_confirmer.Enabled = false;
            this.btn_annuler.Enabled = false;
            this.comboBox1.Enabled = false;
            this.text_NOM.Enabled = false;
            this.text_PRENOM.Enabled = false;
            this.text_CNE.Enabled = false;


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
  
}

