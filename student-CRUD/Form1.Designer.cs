
namespace student_CRUD
{
    partial class CRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_NOM = new System.Windows.Forms.TextBox();
            this.text_PRENOM = new System.Windows.Forms.TextBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_confirmer = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.text_CNE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Cursor = System.Windows.Forms.Cursors.No;
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Cursor = System.Windows.Forms.Cursors.No;
            this.label8.Name = "label8";
            // 
            // text_NOM
            // 
            resources.ApplyResources(this.text_NOM, "text_NOM");
            this.text_NOM.Name = "text_NOM";
            
            // 
            // text_PRENOM
            // 
            resources.ApplyResources(this.text_PRENOM, "text_PRENOM");
            this.text_PRENOM.Name = "text_PRENOM";
            // 
            // btn_ajouter
            // 
            resources.ApplyResources(this.btn_ajouter, "btn_ajouter");
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_modifier
            // 
            resources.ApplyResources(this.btn_modifier, "btn_modifier");
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supprimer
            // 
            resources.ApplyResources(this.btn_supprimer, "btn_supprimer");
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_confirmer
            // 
            resources.ApplyResources(this.btn_confirmer, "btn_confirmer");
            this.btn_confirmer.Name = "btn_confirmer";
            this.btn_confirmer.UseVisualStyleBackColor = true;
            this.btn_confirmer.Click += new System.EventHandler(this.btn_confirmer_Click);
            // 
            // btn_annuler
            // 
            resources.ApplyResources(this.btn_annuler, "btn_annuler");
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // text_CNE
            // 
            resources.ApplyResources(this.text_CNE, "text_CNE");
            this.text_CNE.Name = "text_CNE";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Name = "label1";
            // 
            // CRUD
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_confirmer);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.text_PRENOM);
            this.Controls.Add(this.text_CNE);
            this.Controls.Add(this.text_NOM);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CRUD";
            this.Load += new System.EventHandler(this.CRUD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_NOM;
        private System.Windows.Forms.TextBox text_PRENOM;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_confirmer;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.TextBox text_CNE;
        private System.Windows.Forms.Label label1;
    }
}

