using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;



namespace Studio
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }
        private int childFormNumber = 0;

      

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private String cheminDB = "data source =.\\SQLEXPRESS;integrated security = true; Initial catalog = Studio";

        private void load()
        {

            try
            {

                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT * from Clients ORDER BY ID DESC";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[7];

                ListViewItem itm;



                while (DataRead.Read())
                {

                    arr[0] = DataRead["Code_client"].ToString();
                    arr[1] = DataRead["Nom"].ToString();
                    arr[2] = DataRead["Prenom"].ToString();
                    arr[3] = DataRead["Adresse"].ToString();
                    arr[4] = DataRead["Tel"].ToString();
                    arr[5] = DataRead["Mail"].ToString();
                    arr[6] = DataRead["Contact_reseaux"].ToString();

                    

                    itm = new ListViewItem(arr);
                    listViewClient.Items.Add(itm);

                }
                for (int ligne = 0; ligne < listViewClient.Items.Count; ligne++)
                {
                    if (ligne % 2 == 1)
                    {
                        listViewClient.Items[ligne].BackColor = Color.White;
                    }
                    else listViewClient.Items[ligne].BackColor = Color.MistyRose;
                }
                sqlconn.Close();
            }
            catch
            {

            }
        }


        private void InsertMAJClients(bool trouver)
        {
            SqlConnection thisConnection = new SqlConnection(cheminDB);

            thisConnection.Open();

            SqlCommand myCommand = new SqlCommand("InsertMAJClients", thisConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            // Add Parameters to Command Parameters collection

            myCommand.Parameters.Add("@Code_client", SqlDbType.VarChar, 50);
            myCommand.Parameters.Add("@Nom", SqlDbType.VarChar, 50);
            myCommand.Parameters.Add("@Prenom", SqlDbType.VarChar, 50);
            myCommand.Parameters.Add("@Adresse", SqlDbType.VarChar, 50);
            myCommand.Parameters.Add("@tel", SqlDbType.VarChar, 50);
            myCommand.Parameters.Add("@mail", SqlDbType.VarChar, 50);
            myCommand.Parameters.Add("@Contact_reseaux", SqlDbType.VarChar, 50);


            // Affectation des valeurs

            myCommand.Parameters["@Code_client"].Value = TextBoxCodeClient.Text;
            myCommand.Parameters["@Nom"].Value = TextBoxNomClient.Text;
            myCommand.Parameters["@Prenom"].Value = TextBoxPrenomClient.Text;
            myCommand.Parameters["@Adresse"].Value = TextBoxAdresse.Text;
            myCommand.Parameters["@tel"].Value = TextBoxTel.Text;
            myCommand.Parameters["@mail"].Value = TextBoxMail.Text;
            myCommand.Parameters["@Contact_reseaux"].Value = TextBoxReseaux.Text;






            // Affectation des valeurs


            myCommand.ExecuteScalar();







            ListViewItem itm;
            string[] arr = new string[7];



            if (!trouver)
            {
                        arr[0] = TextBoxCodeClient.Text;
                        arr[1] = TextBoxNomClient.Text;
                        arr[2] = TextBoxPrenomClient.Text;
                        arr[3] = TextBoxAdresse.Text;
                        arr[4] = TextBoxTel.Text;
                        arr[5] = TextBoxMail.Text;
                        arr[6] = TextBoxReseaux.Text;
         


                        itm = new ListViewItem(arr);
                        listViewClient.Items.Add(itm);
                        listViewClient.Items.Clear();
                        load();
                MessageBox.Show("Informations mises à jour...");
                
            }
            else
            {
                MessageBox.Show("Client ajouté...");
               
                for (int ligne = 0; ligne < listViewClient.Items.Count; ligne++)
                { 
                    if (listViewClient.Items[ligne].SubItems[0].Text == TextBoxCodeClient.Text)
                    {
                        listViewClient.Items[ligne].SubItems[1].Text = TextBoxNomClient.Text;
                        listViewClient.Items[ligne].SubItems[2].Text = TextBoxPrenomClient.Text;
                        listViewClient.Items[ligne].SubItems[3].Text = TextBoxAdresse.Text;
                        listViewClient.Items[ligne].SubItems[4].Text = TextBoxTel.Text;
                        listViewClient.Items[ligne].SubItems[5].Text = TextBoxMail.Text;
                        listViewClient.Items[ligne].SubItems[5].Text = TextBoxReseaux.Text;

                    }


                }
            }





        }






        private void guna2ButtonAjouter_Click(object sender, EventArgs e)
        {
            if (TextBoxCodeClient.Text == string.Empty)
            {
                MessageBox.Show("La saisie du code client est obligatoire", "Attention", MessageBoxButtons.OK);
                return;
            }


            try
            {
                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT * from Clients ORDER BY ID DESC";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();
                bool trouve = false;
                while (DataRead.Read())
                {
                    trouve = true;
                }

                sqlconn.Close();
                InsertMAJClients(trouve);

            }
            catch
            {

            }

            string dossier = @"C:\dossierMailClient";
            if (!Directory.Exists(dossier))
            { 
                Directory.CreateDirectory(dossier);
            }

                string fichierUtil = @"C:\dossierMailClient\listeMail.txt";
            if (!File.Exists(fichierUtil))
            {
                
                
                File.WriteAllText(fichierUtil, "");




            }

            using (StreamWriter writetext = File.AppendText(fichierUtil))
            {

                

                writetext.WriteLine(TextBoxMail.Text );


                


                
            }

            //MessageBox.Show("inscription valide  ");


            TextBoxCodeClient.Clear();
            TextBoxNomClient.Clear();
            TextBoxPrenomClient.Clear();
            TextBoxAdresse.Clear();
            TextBoxTel.Clear();
            TextBoxMail.Clear();
            TextBoxReseaux.Clear();

            listViewClient.Items.Clear();
            load();




            

        }





        
        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            //int valeur;
            //int prixe = 0;


            //valeur = (int)guna2ProgressBar2.Maximum; // Convertir en entier si nécessaire
            //prixe = valeur + 50;
            //guna2ProgressBar2.Maximum = prixe;

            //valeur = (int)guna2ProgressBar1.Maximum; // Convertir en entier si nécessaire
            //prixe = valeur + 50;
            //guna2ProgressBar1.Maximum = prixe;

            //valeur = (int)guna2ProgressBar3.Maximum; // Convertir en entier si nécessaire
            //prixe = valeur + 50;
            //guna2ProgressBar3.Maximum = prixe;

            //code inutile effctué mais stylé

            int reduction = 50;

            guna2ProgressBar2.Maximum = Math.Min(500, guna2ProgressBar2.Maximum + reduction);
            guna2ProgressBar1.Maximum = Math.Min(500, guna2ProgressBar1.Maximum + reduction);
            guna2ProgressBar3.Maximum = Math.Min(500, guna2ProgressBar3.Maximum + reduction);


        }

        private void Menu_Load(object sender, EventArgs e)
        {


            //guna2ProgressBar2.Maximum = prixe;


            listViewClient.View = System.Windows.Forms.View.Details;
            listViewClient.GridLines = true;
            listViewClient.FullRowSelect = true;
            listViewClient.BackColor = Color.MintCream;




            listViewClient.Columns.Add("             Code client", 150);
            listViewClient.Columns.Add("                       Nom du client", 230);
            listViewClient.Columns.Add("                      Prenom du client", 230);
            listViewClient.Columns.Add("                               Adresse du client", 300);
            
            listViewClient.Columns.Add("                Numéro de tel du client", 220);
            listViewClient.Columns.Add("                            Mail du client", 260);
            listViewClient.Columns.Add("              Réseaux sociaux du client", 220);


            load();




           
            try
            {

                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT   * from     dbo.Reservation
                            where Type_cabine ='" + "Cabine A" + "'";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];




                while (DataRead.Read())
                {

                    arr[0] = DataRead["Nom"].ToString();
                    arr[1] = DataRead["Date"].ToString();
                    arr[2] = DataRead["Heure"].ToString();
                    arr[3] = DataRead["Type_cabine"].ToString();
                    arr[4] = DataRead["Duree"].ToString();
                    arr[5] = DataRead["Prix"].ToString();
                    arr[6] = DataRead["Options"].ToString();
                    arr[7] = DataRead["ID"].ToString();



                    int valeur = (int)guna2ProgressBar2.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 1;
                    guna2ProgressBar2.Value = prixe;
                    
                    label3.Text = prixe.ToString();


                }
                sqlconn.Close();

            }
            catch
            {

            }

            try
            {

                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT   * from     dbo.Reservation
                            where Type_cabine ='" + "Cabine B" + "'";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];

           



                while (DataRead.Read())
                {

                    arr[0] = DataRead["Nom"].ToString();
                    arr[1] = DataRead["Date"].ToString();
                    arr[2] = DataRead["Heure"].ToString();
                    arr[3] = DataRead["Type_cabine"].ToString();
                    arr[4] = DataRead["Duree"].ToString();
                    arr[5] = DataRead["Prix"].ToString();
                    arr[6] = DataRead["Options"].ToString();
                    arr[7] = DataRead["ID"].ToString();



                    int valeur = (int)guna2ProgressBar1.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 1;
                    guna2ProgressBar1.Value = prixe;
                    label4.Text = prixe.ToString();


                }
                sqlconn.Close();

            }
            catch
            {

            }

            try
            {

                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT   * from     dbo.Reservation
                            where Type_cabine ='" + "Cabine C" + "'";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];

                



                while (DataRead.Read())
                {

                    arr[0] = DataRead["Nom"].ToString();
                    arr[1] = DataRead["Date"].ToString();
                    arr[2] = DataRead["Heure"].ToString();
                    arr[3] = DataRead["Type_cabine"].ToString();
                    arr[4] = DataRead["Duree"].ToString();
                    arr[5] = DataRead["Prix"].ToString();
                    arr[6] = DataRead["Options"].ToString();
                    arr[7] = DataRead["ID"].ToString();



                    int valeur = (int)guna2ProgressBar3.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 1;
                    guna2ProgressBar3.Value = prixe;

                    label5.Text = prixe.ToString();

                }
                sqlconn.Close();

            }
            catch
            {

            }



        }
       
        private void RemoveClient()
        {
            SqlConnection thisConnection = new SqlConnection(cheminDB);
            thisConnection.Open();

            SqlCommand myCommand = new SqlCommand("SuppLineClients", thisConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            // Add Parameters to Command Parameters collection
            myCommand.Parameters.Add("@Code_client", SqlDbType.VarChar, 50);
            // Affectation des valeurs
            myCommand.Parameters["@Code_client"].Value = TextBoxCodeClient.Text;
            // Affectation des valeurs
            try
            {
                myCommand.ExecuteNonQuery();
                
            }
            catch 
            {
            }
            thisConnection.Close();
            for (int ligne = 0; ligne < listViewClient.Items.Count; ligne++)
            {
                if (ligne % 2 == 1)
                {
                    listViewClient.Items[ligne].BackColor = Color.White;
                }
                else listViewClient.Items[ligne].BackColor = Color.MistyRose;
            }
            MessageBox.Show("Ligne supprimée...");
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Reservation Formulaire = new Reservation();
            Formulaire.Close();
            guna2Button4.ForeColor = Color.White;
            guna2Button3.ForeColor = Color.Red;

            guna2ProgressBar2.Value = 0;
            guna2ProgressBar1.Value = 0;
            guna2ProgressBar3.Value = 0;
            try
            {

                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT   * from     dbo.Reservation
                            where Type_cabine ='" + "Cabine A" + "'";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];




                while (DataRead.Read())
                {

                    arr[0] = DataRead["Nom"].ToString();
                    arr[1] = DataRead["Date"].ToString();
                    arr[2] = DataRead["Heure"].ToString();
                    arr[3] = DataRead["Type_cabine"].ToString();
                    arr[4] = DataRead["Duree"].ToString();
                    arr[5] = DataRead["Prix"].ToString();
                    arr[6] = DataRead["Options"].ToString();
                    arr[7] = DataRead["ID"].ToString();



                    int valeur = (int)guna2ProgressBar2.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 1;
                    guna2ProgressBar2.Value = prixe;


                }
                sqlconn.Close();

            }
            catch
            {

            }

            try
            {

                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT   * from     dbo.Reservation
                            where Type_cabine ='" + "Cabine B" + "'";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];





                while (DataRead.Read())
                {

                    arr[0] = DataRead["Nom"].ToString();
                    arr[1] = DataRead["Date"].ToString();
                    arr[2] = DataRead["Heure"].ToString();
                    arr[3] = DataRead["Type_cabine"].ToString();
                    arr[4] = DataRead["Duree"].ToString();
                    arr[5] = DataRead["Prix"].ToString();
                    arr[6] = DataRead["Options"].ToString();
                    arr[7] = DataRead["ID"].ToString();



                    int valeur = (int)guna2ProgressBar1.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 1;
                    guna2ProgressBar1.Value = prixe;



                }
                sqlconn.Close();

            }
            catch
            {

            }

            try
            {

                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT   * from     dbo.Reservation
                            where Type_cabine ='" + "Cabine C" + "'";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];





                while (DataRead.Read())
                {

                    arr[0] = DataRead["Nom"].ToString();
                    arr[1] = DataRead["Date"].ToString();
                    arr[2] = DataRead["Heure"].ToString();
                    arr[3] = DataRead["Type_cabine"].ToString();
                    arr[4] = DataRead["Duree"].ToString();
                    arr[5] = DataRead["Prix"].ToString();
                    arr[6] = DataRead["Options"].ToString();
                    arr[7] = DataRead["ID"].ToString();



                    int valeur = (int)guna2ProgressBar3.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 1;
                    guna2ProgressBar3.Value = prixe;



                }
                sqlconn.Close();

            }
            catch
            {

            }

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Reservation Formulaire = new Reservation();
           
            Formulaire.Location = new Point(317, 23);


            Formulaire.Show();

            guna2Button3.ForeColor = Color.White;
            guna2Button4.ForeColor = Color.Red;



            guna2ProgressBar2.Value = 0;
            guna2ProgressBar1.Value = 0;
            guna2ProgressBar3.Value = 0;
            try
            {

                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT   * from     dbo.Reservation
                            where Type_cabine ='" + "Cabine A" + "'";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];




                while (DataRead.Read())
                {

                    arr[0] = DataRead["Nom"].ToString();
                    arr[1] = DataRead["Date"].ToString();
                    arr[2] = DataRead["Heure"].ToString();
                    arr[3] = DataRead["Type_cabine"].ToString();
                    arr[4] = DataRead["Duree"].ToString();
                    arr[5] = DataRead["Prix"].ToString();
                    arr[6] = DataRead["Options"].ToString();
                    arr[7] = DataRead["ID"].ToString();



                    int valeur = (int)guna2ProgressBar2.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 1;
                    guna2ProgressBar2.Value = prixe;


                }
                sqlconn.Close();

            }
            catch
            {

            }

            try
            {

                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT   * from     dbo.Reservation
                            where Type_cabine ='" + "Cabine B" + "'";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];





                while (DataRead.Read())
                {

                    arr[0] = DataRead["Nom"].ToString();
                    arr[1] = DataRead["Date"].ToString();
                    arr[2] = DataRead["Heure"].ToString();
                    arr[3] = DataRead["Type_cabine"].ToString();
                    arr[4] = DataRead["Duree"].ToString();
                    arr[5] = DataRead["Prix"].ToString();
                    arr[6] = DataRead["Options"].ToString();
                    arr[7] = DataRead["ID"].ToString();



                    int valeur = (int)guna2ProgressBar1.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 1;
                    guna2ProgressBar1.Value = prixe;



                }
                sqlconn.Close();

            }
            catch
            {

            }

            try
            {

                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT   * from     dbo.Reservation
                            where Type_cabine ='" + "Cabine C" + "'";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];





                while (DataRead.Read())
                {

                    arr[0] = DataRead["Nom"].ToString();
                    arr[1] = DataRead["Date"].ToString();
                    arr[2] = DataRead["Heure"].ToString();
                    arr[3] = DataRead["Type_cabine"].ToString();
                    arr[4] = DataRead["Duree"].ToString();
                    arr[5] = DataRead["Prix"].ToString();
                    arr[6] = DataRead["Options"].ToString();
                    arr[7] = DataRead["ID"].ToString();



                    int valeur = (int)guna2ProgressBar3.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 1;
                    guna2ProgressBar3.Value = prixe;



                }
                sqlconn.Close();

            }
            catch
            {

            }

        }

        private void TextBoxTel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBoxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifier si le caractère saisi est un chiffre ou la touche de suppression (Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                // Si ce n'est pas un chiffre, ignorer le caractère en le marquant comme traité
                e.Handled = true;
            }
        }

        private void listViewClient_Click(object sender, EventArgs e)
        {
            for (int ligne = 0; ligne < listViewClient.Items.Count; ligne++)
            {
                if (listViewClient.Items[ligne].SubItems[0].Text == TextBoxCodeClient.Text)
                {
                    listViewClient.Items[ligne].SubItems[1].Text = TextBoxNomClient.Text;
                    listViewClient.Items[ligne].SubItems[2].Text = TextBoxPrenomClient.Text;
                    listViewClient.Items[ligne].SubItems[3].Text = TextBoxAdresse.Text;
                    listViewClient.Items[ligne].SubItems[4].Text = TextBoxTel.Text;
                    listViewClient.Items[ligne].SubItems[5].Text = TextBoxMail.Text;
                    listViewClient.Items[ligne].SubItems[6].Text = TextBoxReseaux.Text;
                }

            }
        }

        private void buttonRechercheCode_Click(object sender, EventArgs e)
        {
            load();
            bool trouve = false;
            int ligne = 0;
            for (ligne = 0; ligne <= listViewClient.Items.Count - 1; ligne++)
            {
                if (listViewClient.Items[ligne].SubItems[0].Text.Contains(TextBoxCodeClient.Text))
                {

                    trouve = true;



                }


            }

            if (trouve == true)
            {
                string code2 = TextBoxCodeClient.Text;
                listViewClient.Items.Clear();
                try
                {

                    SqlConnection sqlconn = new SqlConnection(cheminDB);
                    SqlCommand cmd;
                    string sSQL;

                    sSQL = @"SELECT   * from     dbo.Clients
                            where Code_client ='" + code2 + "'";
                    cmd = new SqlCommand(sSQL, sqlconn);

                    cmd.CommandType = CommandType.Text;

                    SqlDataReader DataRead;
                    sqlconn.Open();
                    DataRead = cmd.ExecuteReader();

                    string[] arr = new string[7];

                    ListViewItem itm;



                    while (DataRead.Read())
                    {

                        arr[0] = DataRead["Code_client"].ToString();
                        arr[1] = DataRead["Nom"].ToString();
                        arr[2] = DataRead["Prenom"].ToString();
                        arr[3] = DataRead["Adresse"].ToString();
                        arr[4] = DataRead["Tel"].ToString();
                        arr[5] = DataRead["Mail"].ToString();
                        arr[6] = DataRead["Contact_reseaux"].ToString();





                        itm = new ListViewItem(arr);
                        listViewClient.Items.Add(itm);

                    }

                    sqlconn.Close();

                }
                catch
                {

                }

            }

            if (trouve == false)
            {
                listViewClient.Items.Clear();
                load();
                
            }
            for (int ligne2 = 0; ligne2 < listViewClient.Items.Count; ligne2++)
            {
                if (ligne2 % 2 == 1)
                {
                    listViewClient.Items[ligne2].BackColor = Color.White;
                }
                else listViewClient.Items[ligne2].BackColor = Color.MistyRose;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            listViewClient.Items.Clear();
            load();
        }

        private void buttonRechercheNom_Click(object sender, EventArgs e)
        {
            load();
            bool trouve = false;
            int ligne = 0;
            for (ligne = 0; ligne <= listViewClient.Items.Count - 1; ligne++)
            {
                if (listViewClient.Items[ligne].SubItems[0].Text.Contains(TextBoxCodeClient.Text))
                {

                    trouve = true;



                }


            }

            if (trouve == true)
            {
                string code2 = TextBoxNomClient.Text;
                listViewClient.Items.Clear();
                try
                {

                    SqlConnection sqlconn = new SqlConnection(cheminDB);
                    SqlCommand cmd;
                    string sSQL;

                    sSQL = @"SELECT   * from     dbo.Clients
                            where Nom ='" + code2 + "'";
                    cmd = new SqlCommand(sSQL, sqlconn);

                    cmd.CommandType = CommandType.Text;

                    SqlDataReader DataRead;
                    sqlconn.Open();
                    DataRead = cmd.ExecuteReader();

                    string[] arr = new string[7];

                    ListViewItem itm;



                    while (DataRead.Read())
                    {

                        arr[0] = DataRead["Code_client"].ToString();
                        arr[1] = DataRead["Nom"].ToString();
                        arr[2] = DataRead["Prenom"].ToString();
                        arr[3] = DataRead["Adresse"].ToString();
                        arr[4] = DataRead["Tel"].ToString();
                        arr[5] = DataRead["Mail"].ToString();
                        arr[6] = DataRead["Contact_reseaux"].ToString();





                        itm = new ListViewItem(arr);
                        listViewClient.Items.Add(itm);

                    }
                    
                    sqlconn.Close();
                }
                catch
                {

                }
            }

            if (trouve == false)
            {
                listViewClient.Items.Clear();
                load();

            }
            for (int ligne2 = 0; ligne2 < listViewClient.Items.Count; ligne2++)
            {
                if (ligne2 % 2 == 1)
                {
                    listViewClient.Items[ligne2].BackColor = Color.White;
                }
                else listViewClient.Items[ligne2].BackColor = Color.MistyRose;
            }
        }

        private void buttonRecherchePrenom_Click(object sender, EventArgs e)
        {
            load();
            bool trouve = false;
            int ligne = 0;
            for (ligne = 0; ligne <= listViewClient.Items.Count - 1; ligne++)
            {
                if (listViewClient.Items[ligne].SubItems[0].Text.Contains(TextBoxCodeClient.Text))
                {

                    trouve = true;



                }


            }

            if (trouve == true)
            {
                string code2 = TextBoxPrenomClient.Text;
                listViewClient.Items.Clear();
                try
                {

                    SqlConnection sqlconn = new SqlConnection(cheminDB);
                    SqlCommand cmd;
                    string sSQL;

                    sSQL = @"SELECT   * from     dbo.Clients
                        where Prenom ='" + code2 + "'";
                    cmd = new SqlCommand(sSQL, sqlconn);

                    cmd.CommandType = CommandType.Text;

                    SqlDataReader DataRead;
                    sqlconn.Open();
                    DataRead = cmd.ExecuteReader();

                    string[] arr = new string[7];

                    ListViewItem itm;



                    while (DataRead.Read())
                    {

                        arr[0] = DataRead["Code_client"].ToString();
                        arr[1] = DataRead["Nom"].ToString();
                        arr[2] = DataRead["Prenom"].ToString();
                        arr[3] = DataRead["Adresse"].ToString();
                        arr[4] = DataRead["Tel"].ToString();
                        arr[5] = DataRead["Mail"].ToString();
                        arr[6] = DataRead["Contact_reseaux"].ToString();





                        itm = new ListViewItem(arr);
                        listViewClient.Items.Add(itm);

                    }
                    
                    sqlconn.Close();
                }
                catch
                {

                }
            }

            if (trouve == false)
            {
                listViewClient.Items.Clear();
                load();

            }
            for (int ligne2 = 0; ligne2 < listViewClient.Items.Count; ligne2++)
            {
                if (ligne2 % 2 == 1)
                {
                    listViewClient.Items[ligne2].BackColor = Color.White;
                }
                else listViewClient.Items[ligne2].BackColor = Color.MistyRose;
            }
        }

        private void buttonRechercheAdresse_Click(object sender, EventArgs e)
        {
            load();
            bool trouve = false;
            int ligne = 0;
            for (ligne = 0; ligne <= listViewClient.Items.Count - 1; ligne++)
            {
                if (listViewClient.Items[ligne].SubItems[0].Text.Contains(TextBoxCodeClient.Text))
                {

                    trouve = true;



                }


            }

            if (trouve == true)
            {
                string code2 = TextBoxAdresse.Text;
                listViewClient.Items.Clear();
                try
                {

                    SqlConnection sqlconn = new SqlConnection(cheminDB);
                    SqlCommand cmd;
                    string sSQL;

                    sSQL = @"SELECT   * from     dbo.Clients
                where Adresse ='" + code2 + "'";
                    cmd = new SqlCommand(sSQL, sqlconn);

                    cmd.CommandType = CommandType.Text;

                    SqlDataReader DataRead;
                    sqlconn.Open();
                    DataRead = cmd.ExecuteReader();

                    string[] arr = new string[7];

                    ListViewItem itm;



                    while (DataRead.Read())
                    {

                        arr[0] = DataRead["Code_client"].ToString();
                        arr[1] = DataRead["Nom"].ToString();
                        arr[2] = DataRead["Prenom"].ToString();
                        arr[3] = DataRead["Adresse"].ToString();
                        arr[4] = DataRead["Tel"].ToString();
                        arr[5] = DataRead["Mail"].ToString();
                        arr[6] = DataRead["Contact_reseaux"].ToString();





                        itm = new ListViewItem(arr);
                        listViewClient.Items.Add(itm);

                    }
                   
                    sqlconn.Close();
                }
                catch
                {

                }
            }

            if (trouve == false)
            {
                listViewClient.Items.Clear();
                load();

            }
            for (int ligne2 = 0; ligne2 < listViewClient.Items.Count; ligne2++)
            {
                if (ligne2 % 2 == 1)
                {
                    listViewClient.Items[ligne2].BackColor = Color.White;
                }
                else listViewClient.Items[ligne2].BackColor = Color.MistyRose;
            }
        }

        private void buttonRechercheTel_Click(object sender, EventArgs e)
        {
            load();
            bool trouve = false;
            int ligne = 0;
            for (ligne = 0; ligne <= listViewClient.Items.Count - 1; ligne++)
            {
                if (listViewClient.Items[ligne].SubItems[0].Text.Contains(TextBoxCodeClient.Text))
                {

                    trouve = true;



                }


            }

            if (trouve == true)
            {
                string code2 = TextBoxTel.Text;
                listViewClient.Items.Clear();
                try
                {

                    SqlConnection sqlconn = new SqlConnection(cheminDB);
                    SqlCommand cmd;
                    string sSQL;

                    sSQL = @"SELECT   * from     dbo.Clients
                where Tel ='" + code2 + "'";
                    cmd = new SqlCommand(sSQL, sqlconn);

                    cmd.CommandType = CommandType.Text;

                    SqlDataReader DataRead;
                    sqlconn.Open();
                    DataRead = cmd.ExecuteReader();

                    string[] arr = new string[7];

                    ListViewItem itm;



                    while (DataRead.Read())
                    {

                        arr[0] = DataRead["Code_client"].ToString();
                        arr[1] = DataRead["Nom"].ToString();
                        arr[2] = DataRead["Prenom"].ToString();
                        arr[3] = DataRead["Adresse"].ToString();
                        arr[4] = DataRead["Tel"].ToString();
                        arr[5] = DataRead["Mail"].ToString();
                        arr[6] = DataRead["Contact_reseaux"].ToString();





                        itm = new ListViewItem(arr);
                        listViewClient.Items.Add(itm);

                    }
                    for (int ligne2 = 0; ligne2 < listViewClient.Items.Count; ligne2++)
                    {
                        if (ligne2 % 2 == 1)
                        {
                            listViewClient.Items[ligne2].BackColor = Color.White;
                        }
                        else listViewClient.Items[ligne2].BackColor = Color.MistyRose;
                    }
                    sqlconn.Close();
                }
                catch
                {

                }
            }

            if (trouve == false)
            {
                listViewClient.Items.Clear();
                load();

            }
            for (int ligne2 = 0; ligne2 < listViewClient.Items.Count; ligne2++)
            {
                if (ligne2 % 2 == 1)
                {
                    listViewClient.Items[ligne2].BackColor = Color.White;
                }
                else listViewClient.Items[ligne2].BackColor = Color.MistyRose;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonRechercheMail_Click(object sender, EventArgs e)
        {
            load();
            bool trouve = false;
            int ligne = 0;
            for (ligne = 0; ligne <= listViewClient.Items.Count - 1; ligne++)
            {
                if (listViewClient.Items[ligne].SubItems[0].Text.Contains(TextBoxCodeClient.Text))
                {

                    trouve = true;



                }


            }

            if (trouve == true)
            {
                string code2 = TextBoxMail.Text;
                listViewClient.Items.Clear();
                try
                {

                    SqlConnection sqlconn = new SqlConnection(cheminDB);
                    SqlCommand cmd;
                    string sSQL;

                    sSQL = @"SELECT   * from     dbo.Clients
                     where Mail ='" + code2 + "'";
                    cmd = new SqlCommand(sSQL, sqlconn);

                    cmd.CommandType = CommandType.Text;

                    SqlDataReader DataRead;
                    sqlconn.Open();
                    DataRead = cmd.ExecuteReader();

                    string[] arr = new string[7];

                    ListViewItem itm;



                    while (DataRead.Read())
                    {

                        arr[0] = DataRead["Code_client"].ToString();
                        arr[1] = DataRead["Nom"].ToString();
                        arr[2] = DataRead["Prenom"].ToString();
                        arr[3] = DataRead["Adresse"].ToString();
                        arr[4] = DataRead["Tel"].ToString();
                        arr[5] = DataRead["Mail"].ToString();
                        arr[6] = DataRead["Contact_reseaux"].ToString();





                        itm = new ListViewItem(arr);
                        listViewClient.Items.Add(itm);

                    }
                    for (int ligne2 = 0; ligne < listViewClient.Items.Count; ligne++)
                    {
                        if (ligne % 2 == 1)
                        {
                            listViewClient.Items[ligne].BackColor = Color.White;
                        }
                        else listViewClient.Items[ligne].BackColor = Color.MistyRose;
                    }
                    sqlconn.Close();
                }
                catch
                {

                }
            }

            if (trouve == false)
            {
                listViewClient.Items.Clear();
                load();

            }
            for (int ligne2 = 0; ligne2 < listViewClient.Items.Count; ligne2++)
            {
                if (ligne2 % 2 == 1)
                {
                    listViewClient.Items[ligne2].BackColor = Color.White;
                }
                else listViewClient.Items[ligne2].BackColor = Color.MistyRose;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            load();
            bool trouve = false;
            int ligne = 0;
            for (ligne = 0; ligne <= listViewClient.Items.Count - 1; ligne++)
            {
                if (listViewClient.Items[ligne].SubItems[0].Text.Contains(TextBoxCodeClient.Text))
                {

                    trouve = true;



                }


            }

            if (trouve == true)
            {
                string code2 = TextBoxReseaux.Text;
                listViewClient.Items.Clear();
                try
                {

                    SqlConnection sqlconn = new SqlConnection(cheminDB);
                    SqlCommand cmd;
                    string sSQL;

                    sSQL = @"SELECT   * from     dbo.Clients
                      where Contact_reseaux ='" + code2 + "'";
                    cmd = new SqlCommand(sSQL, sqlconn);

                    cmd.CommandType = CommandType.Text;

                    SqlDataReader DataRead;
                    sqlconn.Open();
                    DataRead = cmd.ExecuteReader();

                    string[] arr = new string[7];

                    ListViewItem itm;



                    while (DataRead.Read())
                    {

                        arr[0] = DataRead["Code_client"].ToString();
                        arr[1] = DataRead["Nom"].ToString();
                        arr[2] = DataRead["Prenom"].ToString();
                        arr[3] = DataRead["Adresse"].ToString();
                        arr[4] = DataRead["Tel"].ToString();
                        arr[5] = DataRead["Mail"].ToString();
                        arr[6] = DataRead["Contact_reseaux"].ToString();





                        itm = new ListViewItem(arr);
                        listViewClient.Items.Add(itm);

                    }
                   
                    sqlconn.Close();
                }
                catch
                {

                }
            }

            if (trouve == false)
            {
                listViewClient.Items.Clear();
                load();

            }
            for (int ligne2 = 0; ligne2 < listViewClient.Items.Count; ligne2++)
            {
                if (ligne2 % 2 == 1)
                {
                    listViewClient.Items[ligne2].BackColor = Color.White;
                }
                else listViewClient.Items[ligne2].BackColor = Color.MistyRose;
            }
        }

        private void TextBoxNomClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItems = listViewClient.SelectedItems;
            if (selectedItems.Count > 0)
            {
                TextBoxCodeClient.Text = selectedItems[0].SubItems[0].Text;
                TextBoxNomClient.Text = selectedItems[0].SubItems[1].Text;
                TextBoxPrenomClient.Text = selectedItems[0].SubItems[2].Text;
                TextBoxAdresse.Text = selectedItems[0].SubItems[3].Text;
                TextBoxTel.Text = selectedItems[0].SubItems[4].Text;
                TextBoxMail.Text = selectedItems[0].SubItems[5].Text;
                TextBoxReseaux.Text = selectedItems[0].SubItems[6].Text;



            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection("cheminBD"))
            //    {
            //        connection.Open();

            //        // Compter le nombre de clients inscrits dans la catégorie A
            //        SqlCommand commandA = new SqlCommand("SELECT COUNT(Type_cabine) FROM Reservation WHERE Type_cabine = 'cabine A'", connection);
            //        int countA = (int)commandA.ExecuteScalar();
            //        guna2ProgressBar1.Value = countA;

            //        //// Compter le nombre de clients inscrits dans la catégorie B
            //        //SqlCommand commandB = new SqlCommand("SELECT COUNT(Type_cabine) FROM Reservation WHERE Type_cabine = 'cabine B'", connection);
            //        //int countB = (int)commandB.ExecuteScalar();
            //        //guna2ProgressBar2.Value = countB;

            //        //// Compter le nombre de clients inscrits dans la catégorie C
            //        //SqlCommand commandC = new SqlCommand("SELECT COUNT(Type_cabine) FROM Reservation WHERE Type_cabine = 'cabine C'", connection);
            //        //int countC = (int)commandC.ExecuteScalar();
            //        //guna2ProgressBar3.Value = countC;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erreur: " + ex.Message);
            //}
        }

        private void guna2ProgressBar2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listViewClient_DoubleClick(object sender, EventArgs e)
        {
           




            if (listViewClient.SelectedItems.Count > 0)
            {
                var confirmation = MessageBox.Show("Voulez vous vraiment supprimer la ligne séléctionnés?",
                   "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    for (int i = listViewClient.SelectedIndices.Count - 1; i >= 0; i--)
                    {
                        // listViewClient.Items.RemoveAt(1);
                        listViewClient.Items.RemoveAt(listViewClient.SelectedIndices[i]);
                        RemoveClient();
                    }
                }
            }
            else
                MessageBox.Show("aucune ligne n'a été selectionnes", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\dossierMailClient");
        }

        private void TextBoxCodeClient_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TextBoxCodeClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 

                TextBoxNomClient.Focus();
            }
        }

        private void TextBoxNomClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                TextBoxPrenomClient.Focus();
            }
        }

        private void TextBoxPrenomClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                TextBoxAdresse.Focus();
            }
        }

        private void TextBoxAdresse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                TextBoxTel.Focus();
            }
        }

        private void TextBoxTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                TextBoxMail.Focus();
            }
        }

        private void TextBoxMail_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                TextBoxReseaux.Focus();
            }
        }

        private void guna2Button2_MouseLeave(object sender, EventArgs e)
        {
            label9.Show();
        }

        private void guna2Button2_MouseMove(object sender, MouseEventArgs e)
        {
            label9.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            listViewClient.Items.Clear();
            load();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ProgressBar2_Click(object sender, EventArgs e)
        {
            guna2ProgressBar2.Value = 0;
            guna2ProgressBar1.Value = 0;
            guna2ProgressBar3.Value = 0;
            try
            {

                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT   * from     dbo.Reservation
                            where Type_cabine ='" + "Cabine A" + "'";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];




                while (DataRead.Read())
                {

                    arr[0] = DataRead["Nom"].ToString();
                    arr[1] = DataRead["Date"].ToString();
                    arr[2] = DataRead["Heure"].ToString();
                    arr[3] = DataRead["Type_cabine"].ToString();
                    arr[4] = DataRead["Duree"].ToString();
                    arr[5] = DataRead["Prix"].ToString();
                    arr[6] = DataRead["Options"].ToString();
                    arr[7] = DataRead["ID"].ToString();



                    int valeur = (int)guna2ProgressBar2.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 1;
                    guna2ProgressBar2.Value = prixe;


                }
                sqlconn.Close();

            }
            catch
            {

            }

            try
            {

                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT   * from     dbo.Reservation
                            where Type_cabine ='" + "Cabine B" + "'";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];





                while (DataRead.Read())
                {

                    arr[0] = DataRead["Nom"].ToString();
                    arr[1] = DataRead["Date"].ToString();
                    arr[2] = DataRead["Heure"].ToString();
                    arr[3] = DataRead["Type_cabine"].ToString();
                    arr[4] = DataRead["Duree"].ToString();
                    arr[5] = DataRead["Prix"].ToString();
                    arr[6] = DataRead["Options"].ToString();
                    arr[7] = DataRead["ID"].ToString();



                    int valeur = (int)guna2ProgressBar1.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 1;
                    guna2ProgressBar1.Value = prixe;



                }
                sqlconn.Close();

            }
            catch
            {

            }

            try
            {

                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT   * from     dbo.Reservation
                            where Type_cabine ='" + "Cabine C" + "'";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];





                while (DataRead.Read())
                {

                    arr[0] = DataRead["Nom"].ToString();
                    arr[1] = DataRead["Date"].ToString();
                    arr[2] = DataRead["Heure"].ToString();
                    arr[3] = DataRead["Type_cabine"].ToString();
                    arr[4] = DataRead["Duree"].ToString();
                    arr[5] = DataRead["Prix"].ToString();
                    arr[6] = DataRead["Options"].ToString();
                    arr[7] = DataRead["ID"].ToString();



                    int valeur = (int)guna2ProgressBar3.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 1;
                    guna2ProgressBar3.Value = prixe;



                }
                sqlconn.Close();

            }
            catch
            {

            }
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar1_Click(object sender, EventArgs e)
        {
            guna2ProgressBar2.Value = 0;
            guna2ProgressBar1.Value = 0;
            guna2ProgressBar3.Value = 0;
            try
            {

                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT   * from     dbo.Reservation
                            where Type_cabine ='" + "Cabine A" + "'";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];




                while (DataRead.Read())
                {

                    arr[0] = DataRead["Nom"].ToString();
                    arr[1] = DataRead["Date"].ToString();
                    arr[2] = DataRead["Heure"].ToString();
                    arr[3] = DataRead["Type_cabine"].ToString();
                    arr[4] = DataRead["Duree"].ToString();
                    arr[5] = DataRead["Prix"].ToString();
                    arr[6] = DataRead["Options"].ToString();
                    arr[7] = DataRead["ID"].ToString();



                    int valeur = (int)guna2ProgressBar2.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 1;
                    guna2ProgressBar2.Value = prixe;


                }
                sqlconn.Close();

            }
            catch
            {

            }

            try
            {

                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT   * from     dbo.Reservation
                            where Type_cabine ='" + "Cabine B" + "'";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];





                while (DataRead.Read())
                {

                    arr[0] = DataRead["Nom"].ToString();
                    arr[1] = DataRead["Date"].ToString();
                    arr[2] = DataRead["Heure"].ToString();
                    arr[3] = DataRead["Type_cabine"].ToString();
                    arr[4] = DataRead["Duree"].ToString();
                    arr[5] = DataRead["Prix"].ToString();
                    arr[6] = DataRead["Options"].ToString();
                    arr[7] = DataRead["ID"].ToString();



                    int valeur = (int)guna2ProgressBar1.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 1;
                    guna2ProgressBar1.Value = prixe;



                }
                sqlconn.Close();

            }
            catch
            {

            }

            try
            {

                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT   * from     dbo.Reservation
                            where Type_cabine ='" + "Cabine C" + "'";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];





                while (DataRead.Read())
                {

                    arr[0] = DataRead["Nom"].ToString();
                    arr[1] = DataRead["Date"].ToString();
                    arr[2] = DataRead["Heure"].ToString();
                    arr[3] = DataRead["Type_cabine"].ToString();
                    arr[4] = DataRead["Duree"].ToString();
                    arr[5] = DataRead["Prix"].ToString();
                    arr[6] = DataRead["Options"].ToString();
                    arr[7] = DataRead["ID"].ToString();



                    int valeur = (int)guna2ProgressBar3.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 1;
                    guna2ProgressBar3.Value = prixe;



                }
                sqlconn.Close();

            }
            catch
            {

            }
        }

        private void guna2ProgressBar3_Click(object sender, EventArgs e)
        {
            guna2ProgressBar2.Value = 0;
            guna2ProgressBar1.Value = 0;
            guna2ProgressBar3.Value = 0;
            try
            {

                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT   * from     dbo.Reservation
                            where Type_cabine ='" + "Cabine A" + "'";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];




                while (DataRead.Read())
                {

                    arr[0] = DataRead["Nom"].ToString();
                    arr[1] = DataRead["Date"].ToString();
                    arr[2] = DataRead["Heure"].ToString();
                    arr[3] = DataRead["Type_cabine"].ToString();
                    arr[4] = DataRead["Duree"].ToString();
                    arr[5] = DataRead["Prix"].ToString();
                    arr[6] = DataRead["Options"].ToString();
                    arr[7] = DataRead["ID"].ToString();



                    int valeur = (int)guna2ProgressBar2.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 1;
                    guna2ProgressBar2.Value = prixe;


                }
                sqlconn.Close();

            }
            catch
            {

            }

            try
            {

                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT   * from     dbo.Reservation
                            where Type_cabine ='" + "Cabine B" + "'";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];





                while (DataRead.Read())
                {

                    arr[0] = DataRead["Nom"].ToString();
                    arr[1] = DataRead["Date"].ToString();
                    arr[2] = DataRead["Heure"].ToString();
                    arr[3] = DataRead["Type_cabine"].ToString();
                    arr[4] = DataRead["Duree"].ToString();
                    arr[5] = DataRead["Prix"].ToString();
                    arr[6] = DataRead["Options"].ToString();
                    arr[7] = DataRead["ID"].ToString();



                    int valeur = (int)guna2ProgressBar1.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 1;
                    guna2ProgressBar1.Value = prixe;



                }
                sqlconn.Close();

            }
            catch
            {

            }

            try
            {

                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT   * from     dbo.Reservation
                            where Type_cabine ='" + "Cabine C" + "'";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];





                while (DataRead.Read())
                {

                    arr[0] = DataRead["Nom"].ToString();
                    arr[1] = DataRead["Date"].ToString();
                    arr[2] = DataRead["Heure"].ToString();
                    arr[3] = DataRead["Type_cabine"].ToString();
                    arr[4] = DataRead["Duree"].ToString();
                    arr[5] = DataRead["Prix"].ToString();
                    arr[6] = DataRead["Options"].ToString();
                    arr[7] = DataRead["ID"].ToString();



                    int valeur = (int)guna2ProgressBar3.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 1;
                    guna2ProgressBar3.Value = prixe;



                }
                sqlconn.Close();

            }
            catch
            {

            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            

            int reduction = 50;

            guna2ProgressBar2.Maximum = Math.Max(50, guna2ProgressBar2.Maximum - reduction);
            guna2ProgressBar1.Maximum = Math.Max(50, guna2ProgressBar1.Maximum - reduction);
            guna2ProgressBar3.Maximum = Math.Max(50, guna2ProgressBar3.Maximum - reduction);
        }


    }


}
