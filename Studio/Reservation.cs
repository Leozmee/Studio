using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace Studio
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private String cheminDB = "data source =.\\SQLEXPRESS;integrated security = true; Initial catalog = Studio";

        private void Reservation_Load(object sender, EventArgs e)
        {


            combo2.Hide();




            listViewResa.View = System.Windows.Forms.View.Details;
            listViewResa.GridLines = true;
            listViewResa.FullRowSelect = true;
            listViewResa.BackColor = Color.MintCream;

            listViewResa.Columns.Add("                              Nom Prénom", 250);
            listViewResa.Columns.Add("                               Date", 220);
            listViewResa.Columns.Add("                            Heure", 180);
            listViewResa.Columns.Add("                             Cabine", 230);
            listViewResa.Columns.Add("                        Durée", 180);
            listViewResa.Columns.Add("                            Prix", 180);
            listViewResa.Columns.Add("                                     Options", 370);
            listViewResa.Columns.Add("                                    ", 370);


            try
            {
                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT * from Reservation ORDER BY ID DESC";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];

                ListViewItem itm;

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

                    itm = new ListViewItem(arr);
                    listViewResa.Items.Add(itm);
                }

                for (int ligne = 0; ligne < listViewResa.Items.Count; ligne++)
                {
                    if (ligne % 2 == 1)
                    {
                        listViewResa.Items[ligne].BackColor = Color.White;
                    }
                    else listViewResa.Items[ligne].BackColor = Color.AliceBlue;
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

                sSQL = @"SELECT * from Clients ORDER BY ID DESC ";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                while (DataRead.Read())
                {
                    guna2ComboBoxNomPrenom.Items.Add(DataRead["Nom"].ToString() + "  " + DataRead["Prenom"].ToString());

                }

                sqlconn.Close();
            }
            catch
            {

            }

            if (guna2ComboBox2.SelectedIndex == 0 || guna2ComboBox2.SelectedIndex == 1)
            {
                guna2CheckBox1.Visible = false;
            }

            if (guna2ComboBox2.SelectedIndex == 2)
            {
                guna2CheckBox1.Visible = true;
            }

            ///////pr le prix
            if (guna2NumericUpDown3.Value == 2)
            {
                guna2NumericUpDown4.Value = 80;
            }
        }


        private void SuppLineReservation()
        {
            SqlConnection thisConnection = new SqlConnection(cheminDB);
            thisConnection.Open();

            SqlCommand myCommand = new SqlCommand("SuppLineReservation", thisConnection);
            myCommand.CommandType = CommandType.StoredProcedure;

            // Add Parameters to Command Parameters collection
            myCommand.Parameters.Add("@ID", SqlDbType.Int);
            // Affectation des valeurs
            myCommand.Parameters["@ID"].Value = textBox1.Text;
            // Affectation des valeurs
            try
            {
                myCommand.ExecuteNonQuery();

            }
            catch
            {
            }
            thisConnection.Close();
            for (int ligne = 0; ligne < listViewResa.Items.Count; ligne++)
            {
                if (ligne % 2 == 1)
                {
                    listViewResa.Items[ligne].BackColor = Color.White;
                }
                else listViewResa.Items[ligne].BackColor = Color.AliceBlue;
            }
            MessageBox.Show("Ligne supprimée...");
        }


        private void InsertMAJreservation()
        {
            try
            {
                using (SqlConnection thisConnection = new SqlConnection(cheminDB))
                {
                    thisConnection.Open();

                    using (SqlCommand myCommand = new SqlCommand("InsertMAJreservation", thisConnection))
                    {
                        myCommand.CommandType = CommandType.StoredProcedure;

                        myCommand.Parameters.Add("@Nom", SqlDbType.VarChar, 50).Value = guna2ComboBoxNomPrenom.Text;
                        myCommand.Parameters.Add("@type_cabine", SqlDbType.VarChar, 50).Value = guna2ComboBox2.Text;
                        myCommand.Parameters.Add("@duree", SqlDbType.VarChar, 50).Value = guna2NumericUpDown3.Text + " h ";
                        myCommand.Parameters.Add("@options", SqlDbType.VarChar, 250).Value = GetOptionsString();
                        myCommand.Parameters.Add("@date", SqlDbType.VarChar, 50).Value = guna2DateTimePicker1.Text;
                        myCommand.Parameters.Add("@heure", SqlDbType.VarChar, 50).Value = guna2NumericUpDown2.Text + " h " + guna2NumericUpDown1.Text;
                        myCommand.Parameters.Add("@prix", SqlDbType.VarChar, 50).Value = guna2NumericUpDown4.Value;
                        myCommand.ExecuteScalar();

                        // Ajout de l'élément en haut de la liste
                        ListViewItem itm = new ListViewItem();
                        itm.Text = guna2ComboBoxNomPrenom.Text;
                        itm.SubItems.Add(guna2DateTimePicker1.Text);
                        itm.SubItems.Add(guna2NumericUpDown2.Text + guna2NumericUpDown1.Text);
                        itm.SubItems.Add(guna2ComboBox2.Text);
                        itm.SubItems.Add(guna2NumericUpDown3.Text);
                        itm.SubItems.Add(guna2NumericUpDown4.Text);
                        itm.SubItems.Add(GetOptionsString());
                        listViewResa.Items.Insert(0, itm);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'insertion : {ex.Message}");
            }
        }



        private void reload()
        {
            listViewResa.Items.Clear();
            try
            {
                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT * from Reservation ORDER BY ID DESC";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];

                ListViewItem itm;

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
                    itm = new ListViewItem(arr);
                    listViewResa.Items.Add(itm);
                }

                for (int ligne = 0; ligne < listViewResa.Items.Count; ligne++)
                {
                    if (ligne % 2 == 1)
                    {
                        listViewResa.Items[ligne].BackColor = Color.White;
                    }
                    else listViewResa.Items[ligne].BackColor = Color.MistyRose;
                }

                sqlconn.Close();
            }
            catch
            {

            }
        }

        private string GetOptionsString()
        {
            StringBuilder checkBuilder = new StringBuilder();

            if (guna2CheckBox6.Checked)
            {
                if (checkBuilder.Length > 0)
                    checkBuilder.Append(" + ");

                checkBuilder.Append(guna2CheckBox6.Text);
            }

            if (guna2CheckBox4.Checked)
            {
                if (checkBuilder.Length > 0)
                    checkBuilder.Append(" + ");

                checkBuilder.Append(guna2CheckBox4.Text);
            }

            if (guna2CheckBox5.Checked)
            {
                if (checkBuilder.Length > 0)
                    checkBuilder.Append(" + ");

                checkBuilder.Append(guna2CheckBox5.Text);
            }

            if (guna2CheckBox1.Checked)
            {
                if (checkBuilder.Length > 0)
                    checkBuilder.Append(" + ");

                checkBuilder.Append(guna2CheckBox1.Text);
            }

            return checkBuilder.ToString();
        }



        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT * from Reservation ORDER BY ID DESC";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                sqlconn.Close();
                InsertMAJreservation();
            }
            catch
            {

            }
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (guna2ComboBox2.SelectedIndex == 0 || guna2ComboBox2.SelectedIndex == 1)
            {
                guna2NumericUpDown3.Value = 0;

                guna2CheckBox5.Checked = false;
                guna2CheckBox6.Checked = false;
                guna2CheckBox4.Checked = false;
                guna2CheckBox1.Visible = false;
                guna2CheckBox1.Checked = false;
                guna2CheckBox6.Text = "Mastering";
                guna2CheckBox4.Text = "Mix Track";
                guna2CheckBox5.Text = "Piste par piste";

            }







            if (guna2ComboBox2.SelectedIndex == 2)
            {
                guna2NumericUpDown3.Value = 0;

                guna2CheckBox1.Checked = false;
                guna2CheckBox5.Checked = false;
                guna2CheckBox6.Checked = false;
                guna2CheckBox4.Checked = false;

                guna2NumericUpDown4.Value = 0;
                guna2CheckBox1.Visible = true;
                guna2CheckBox6.Text = "Mastering track";
                guna2CheckBox5.Text = "Mix multipistes";
                guna2CheckBox4.Text = "Forfait pro single";



            }


        }
        private void guna2NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox2.SelectedIndex == 0 || guna2ComboBox2.SelectedIndex == 1)
            {

                if (guna2NumericUpDown3.Value <= 2)
                {
                    guna2NumericUpDown4.Value = 0;
                }

                if (guna2NumericUpDown3.Value == 2)
                {
                    guna2NumericUpDown4.Value = 80;
                }

                if (guna2NumericUpDown3.Value == 3)
                {
                    guna2NumericUpDown4.Value = 100;
                }
                else if (guna2NumericUpDown3.Value > 3)
                {

                    int valeur = (int)guna2NumericUpDown3.Value; // Convertir en entier si nécessaire
                    int prix = valeur * 30;
                    //guna2TextBox3.Text = prix.ToString() + " €";
                    guna2NumericUpDown4.Value = prix;
                }







            }
            if (guna2ComboBox2.SelectedIndex == 2)
            {
                if (guna2NumericUpDown3.Value == 2)
                {
                    guna2NumericUpDown4.Value = 100;
                }
                if (guna2NumericUpDown3.Value == 3)
                {
                    guna2NumericUpDown4.Value = 120;
                }

                if (guna2NumericUpDown3.Value == 6)
                {
                    guna2NumericUpDown4.Value = 220;
                }

                if (guna2NumericUpDown3.Value == 9)
                {
                    guna2NumericUpDown4.Value = 300;
                }

            }
        }

        private void guna2CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox2.SelectedIndex == 0 || guna2ComboBox2.SelectedIndex == 1)
            {
                if (guna2CheckBox6.Checked)
                {
                    int valeur = (int)guna2NumericUpDown4.Value; // Convertir en entier si nécessaire
                    int prix = valeur + 50;



                    guna2NumericUpDown4.Value = prix;
                }
                if (guna2CheckBox6.Checked == false)
                {
                    int valeur = (int)guna2NumericUpDown4.Value; // Convertir en entier si nécessaire
                    int prix = valeur - 50;



                    guna2NumericUpDown4.Value = prix;
                }


            }
            if (guna2ComboBox2.SelectedIndex == 2)
            {
                
                if (guna2CheckBox6.Checked)
                {
                    int valeur = (int)guna2NumericUpDown4.Value; // Convertir en entier si nécessaire
                    int prix = valeur + 50;



                    guna2NumericUpDown4.Value = prix;
                }
                if (guna2CheckBox6.Checked == false)
                {
                    int valeur = (int)guna2NumericUpDown4.Value; // Convertir en entier si nécessaire
                    int prix = valeur - 50;



                    guna2NumericUpDown4.Value = prix;
                }

            }
        }

        private void guna2CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (guna2ComboBox2.SelectedIndex == 0 || guna2ComboBox2.SelectedIndex == 1)
            {
                if (guna2CheckBox4.Checked)
                {
                    int valeur = (int)guna2NumericUpDown4.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 150;



                    guna2NumericUpDown4.Value = prixe;
                }
                if (guna2CheckBox4.Checked == false)
                {
                    int valeur = (int)guna2NumericUpDown4.Value; // Convertir en entier si nécessaire
                    int prixe = valeur - 150;



                    guna2NumericUpDown4.Value = prixe;
                }
            }
            if (guna2ComboBox2.SelectedIndex == 2)
            {
               
                if (guna2CheckBox4.Checked)
                {
                    int valeur = (int)guna2NumericUpDown4.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 500;



                    guna2NumericUpDown4.Value = prixe;
                }
                if (guna2CheckBox4.Checked == false)
                {
                    int valeur = (int)guna2NumericUpDown4.Value; // Convertir en entier si nécessaire
                    int prixe = valeur - 500;



                    guna2NumericUpDown4.Value = prixe;
                }
            }
        }


        private void guna2CheckBox5_CheckedChanged(object sender, EventArgs e)
        {

            if (guna2ComboBox2.SelectedIndex == 0 || guna2ComboBox2.SelectedIndex == 1)
            {
                if (guna2CheckBox5.Checked)
                {
                    int valeur = (int)guna2NumericUpDown4.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 250;



                    guna2NumericUpDown4.Value = prixe;
                }
                if (guna2CheckBox5.Checked == false)
                {
                    int valeur = (int)guna2NumericUpDown4.Value; // Convertir en entier si nécessaire
                    int prixe = valeur - 250;



                    guna2NumericUpDown4.Value = prixe;
                }
            }
            if (guna2ComboBox2.SelectedIndex == 2)
            {
                
                if (guna2CheckBox5.Checked)
                {
                    int valeur = (int)guna2NumericUpDown4.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 350;



                    guna2NumericUpDown4.Value = prixe;
                }
                if (guna2CheckBox5.Checked == false)
                {
                    int valeur = (int)guna2NumericUpDown4.Value; // Convertir en entier si nécessaire
                    int prixe = valeur - 350;



                    guna2NumericUpDown4.Value = prixe;
                }
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBoxNomPrenom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewResa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItems = listViewResa.SelectedItems;
            if (selectedItems.Count > 0)
            {
                textBox1.Text = selectedItems[0].SubItems[7].Text;
            }
        }

        private int selectedID;
        private void listViewResa_Click(object sender, EventArgs e)
        {

        }



        private void button13_Click(object sender, EventArgs e)
        {

            reload();

            bool trouve = false;
            int ligne = 0;
            for (ligne = 0; ligne <= listViewResa.Items.Count - 1; ligne++)
            {
                if (listViewResa.Items[ligne].SubItems[0].Text.Contains(guna2ComboBoxNomPrenom.Text))
                {

                    trouve = true;



                }


            }

            if (trouve == true)
            {
                string code2 = guna2ComboBoxNomPrenom.Text;
                listViewResa.Items.Clear();
                try
                {

                    SqlConnection sqlconn = new SqlConnection(cheminDB);
                    SqlCommand cmd;
                    string sSQL;

                    sSQL = @"SELECT   * from     dbo.Reservation
                            where Nom ='" + code2 + "'";
                    cmd = new SqlCommand(sSQL, sqlconn);

                    cmd.CommandType = CommandType.Text;

                    SqlDataReader DataRead;
                    sqlconn.Open();
                    DataRead = cmd.ExecuteReader();

                    string[] arr = new string[8];

                    ListViewItem itm;



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




                        itm = new ListViewItem(arr);
                        listViewResa.Items.Add(itm);

                    }
                    sqlconn.Close();
                }
                catch
                {

                }

            }
            for (int ligne2 = 0; ligne2 < listViewResa.Items.Count; ligne2++)
            {
                if (ligne2 % 2 == 1)
                {
                    listViewResa.Items[ligne2].BackColor = Color.White;
                }
                else listViewResa.Items[ligne2].BackColor = Color.MistyRose;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listViewResa.Items.Clear();
            try
            {
                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT * from Reservation ORDER BY ID DESC";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];

                ListViewItem itm;

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
                    itm = new ListViewItem(arr);
                    listViewResa.Items.Add(itm);
                }

                for (int ligne = 0; ligne < listViewResa.Items.Count; ligne++)
                {
                    if (ligne % 2 == 1)
                    {
                        listViewResa.Items[ligne].BackColor = Color.White;
                    }
                    else listViewResa.Items[ligne].BackColor = Color.MistyRose;
                }

                sqlconn.Close();
            }
            catch
            {

            }
        }

        private void guna2ButtonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT * from Reservation ORDER BY ID DESC";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                sqlconn.Close();
                InsertMAJreservation();
            }
            catch
            {

            }


            listViewResa.Items.Clear();

            try
            {
                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT * from Reservation ORDER BY ID DESC";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];

                ListViewItem itm;

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
                    itm = new ListViewItem(arr);
                    listViewResa.Items.Add(itm);
                }

                for (int ligne = 0; ligne < listViewResa.Items.Count; ligne++)
                {



                    if (ligne % 2 == 1)
                    {
                        listViewResa.Items[ligne].BackColor = Color.White;
                    }
                    else listViewResa.Items[ligne].BackColor = Color.MistyRose;
                }

                sqlconn.Close();
            }
            catch
            {

            }


            

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            reload();

            bool trouve = false;
            int ligne = 0;
            for (ligne = 0; ligne <= listViewResa.Items.Count - 1; ligne++)
            {
                if (listViewResa.Items[ligne].SubItems[0].Text.Contains(guna2ComboBoxNomPrenom.Text))
                {

                    trouve = true;



                }



            }

            if (trouve == true)
            {
                string code2 = guna2ComboBox2.Text;
                listViewResa.Items.Clear();
                try
                {

                    SqlConnection sqlconn = new SqlConnection(cheminDB);
                    SqlCommand cmd;
                    string sSQL;

                    sSQL = @"SELECT   * from     dbo.Reservation
                            where Type_cabine ='" + code2 + "'";
                    cmd = new SqlCommand(sSQL, sqlconn);

                    cmd.CommandType = CommandType.Text;

                    SqlDataReader DataRead;
                    sqlconn.Open();
                    DataRead = cmd.ExecuteReader();

                    string[] arr = new string[8];

                    ListViewItem itm;



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




                        itm = new ListViewItem(arr);
                        listViewResa.Items.Add(itm);

                    }
                    sqlconn.Close();
                }
                catch
                {

                }

            }

            for (int ligne2 = 0; ligne2 < listViewResa.Items.Count; ligne2++)
            {
                if (ligne2 % 2 == 1)
                {
                    listViewResa.Items[ligne2].BackColor = Color.White;
                }
                else listViewResa.Items[ligne2].BackColor = Color.MistyRose;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            reload();
            bool trouve = false;
            int ligne = 0;
            for (ligne = 0; ligne <= listViewResa.Items.Count - 1; ligne++)
            {
                if (listViewResa.Items[ligne].SubItems[0].Text.Contains(guna2ComboBoxNomPrenom.Text))
                {

                    trouve = true;



                }


            }

            if (trouve == true)
            {
                string code2 = guna2DateTimePicker1.Text;
                listViewResa.Items.Clear();
                try
                {

                    SqlConnection sqlconn = new SqlConnection(cheminDB);
                    SqlCommand cmd;
                    string sSQL;

                    sSQL = @"SELECT   * from     dbo.Reservation
                            where Date ='" + code2 + "'";
                    cmd = new SqlCommand(sSQL, sqlconn);

                    cmd.CommandType = CommandType.Text;

                    SqlDataReader DataRead;
                    sqlconn.Open();
                    DataRead = cmd.ExecuteReader();

                    string[] arr = new string[8];

                    ListViewItem itm;



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




                        itm = new ListViewItem(arr);
                        listViewResa.Items.Add(itm);

                    }
                    sqlconn.Close();
                }
                catch
                {

                }


            }

            for (int ligne2 = 0; ligne2 < listViewResa.Items.Count; ligne2++)
            {
                if (ligne2 % 2 == 1)
                {
                    listViewResa.Items[ligne2].BackColor = Color.White;
                }
                else listViewResa.Items[ligne2].BackColor = Color.MistyRose;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            reload();
            bool trouve = false;
            int ligne = 0;
            for (ligne = 0; ligne <= listViewResa.Items.Count - 1; ligne++)
            {
                if (listViewResa.Items[ligne].SubItems[0].Text.Contains(guna2ComboBoxNomPrenom.Text))
                {

                    trouve = true;



                }


            }

            if (trouve == true)
            {
                string code2 = guna2NumericUpDown3.Text;
                listViewResa.Items.Clear();
                try
                {

                    SqlConnection sqlconn = new SqlConnection(cheminDB);
                    SqlCommand cmd;
                    string sSQL;

                    sSQL = @"SELECT   * from     dbo.Reservation
                            where Duree ='" + code2 + " h " + "'";
                    cmd = new SqlCommand(sSQL, sqlconn);

                    cmd.CommandType = CommandType.Text;

                    SqlDataReader DataRead;
                    sqlconn.Open();
                    DataRead = cmd.ExecuteReader();

                    string[] arr = new string[8];

                    ListViewItem itm;



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




                        itm = new ListViewItem(arr);
                        listViewResa.Items.Add(itm);

                    }

                    sqlconn.Close();
                }
                catch
                {

                }




            }

            for (int ligne2 = 0; ligne2 < listViewResa.Items.Count; ligne2++)
            {
                if (ligne2 % 2 == 1)
                {
                    listViewResa.Items[ligne2].BackColor = Color.White;
                }
                else listViewResa.Items[ligne2].BackColor = Color.MistyRose;
            }


        }

        private void listViewResa_DoubleClick(object sender, EventArgs e)
        {
            if (listViewResa.SelectedItems.Count > 0)
            {
                var confirmation = MessageBox.Show("Voulez vous vraiment supprimer la ligne séléctionnés?",
                   "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    for (int i = listViewResa.SelectedIndices.Count - 1; i >= 0; i--)

                        // listViewClient.Items.RemoveAt(1);
                        listViewResa.Items.RemoveAt(listViewResa.SelectedIndices[i]);
                    SuppLineReservation();
                }
            }

            else
                MessageBox.Show("aucune ligne n'a été selectionnes", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2NumericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            label4.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            listViewResa.Items.Clear();
            try
            {
                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT * from Reservation ORDER BY ID DESC";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];

                ListViewItem itm;

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
                    itm = new ListViewItem(arr);
                    listViewResa.Items.Add(itm);
                }

                for (int ligne = 0; ligne < listViewResa.Items.Count; ligne++)
                {
                    if (ligne % 2 == 1)
                    {
                        listViewResa.Items[ligne].BackColor = Color.White;
                    }
                    else listViewResa.Items[ligne].BackColor = Color.AliceBlue;
                }

                sqlconn.Close();
            }
            catch
            {

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_MouseMove(object sender, MouseEventArgs e)
        {
            label8.Hide();
        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            label8.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            listViewResa.Items.Clear();
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

                ListViewItem itm;



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



                   

                    itm = new ListViewItem(arr);
                    listViewResa.Items.Add(itm);

                }
                sqlconn.Close();
                for (int ligne2 = 0; ligne2 < listViewResa.Items.Count; ligne2++)
                {
                    if (ligne2 % 2 == 1)
                    {
                        listViewResa.Items[ligne2].BackColor = Color.LightGray;
                    }
                    else listViewResa.Items[ligne2].BackColor = Color.White;
                }
            }
            catch
            {

            }






        }



        private void guna2ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo1.SelectedIndex == 0)
            {

                combo2.Show();


                label13.Hide();
                combo2.Items.Clear();
                combo2.Items.AddRange(new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" });

            }



            if (combo1.SelectedIndex == 1)
            {

                combo2.Show();

                label13.Hide();
                combo2.Items.Clear();
                combo2.Items.AddRange(new string[] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" });
            }

            if (combo1.SelectedIndex == 2)
            {

                combo2.Show();

                label13.Hide();
                combo2.Items.Clear();
                combo2.Items.AddRange(new string[] { "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035" });
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_MouseMove(object sender, MouseEventArgs e)
        {
            label9.Hide();
        }

        private void guna2Button3_MouseLeave(object sender, EventArgs e)
        {
            label9.Show();
        }

        private void guna2Button4_MouseMove(object sender, MouseEventArgs e)
        {
            label10.Hide();
        }

        private void guna2Button4_MouseLeave(object sender, EventArgs e)
        {
            label10.Show();
        }

        private void label11_MouseMove(object sender, MouseEventArgs e)
        {
            label11.Hide();
        }

        private void guna2Button5_MouseLeave(object sender, EventArgs e)
        {
            label11.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            listViewResa.Items.Clear();
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

                ListViewItem itm;



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




                    itm = new ListViewItem(arr);
                    listViewResa.Items.Add(itm);

                }
                sqlconn.Close();
            }
            catch
            {

            }


            for (int ligne2 = 0; ligne2 < listViewResa.Items.Count; ligne2++)
            {
                if (ligne2 % 2 == 1)
                {
                    listViewResa.Items[ligne2].BackColor = Color.LightSalmon;
                }
                else listViewResa.Items[ligne2].BackColor = Color.White;
            }

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            listViewResa.Items.Clear();
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

                ListViewItem itm;



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




                    itm = new ListViewItem(arr);
                    listViewResa.Items.Add(itm);

                }
                sqlconn.Close();
            }
            catch
            {

            }


            for (int ligne2 = 0; ligne2 < listViewResa.Items.Count; ligne2++)
            {
                if (ligne2 % 2 == 1)
                {
                    listViewResa.Items[ligne2].BackColor = Color.LightSteelBlue;
                }
                else listViewResa.Items[ligne2].BackColor = Color.White;
            }

        }

        private void guna2Button5_MouseMove(object sender, MouseEventArgs e)
        {
            label11.Hide();
        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void combo2_SelectedValueChanged(object sender, EventArgs e)
        {


            listViewResa.Items.Clear();
            try
            {
                SqlConnection sqlconn = new SqlConnection(cheminDB);
                SqlCommand cmd;
                string sSQL;

                sSQL = @"SELECT * from Reservation ORDER BY ID DESC";
                cmd = new SqlCommand(sSQL, sqlconn);

                cmd.CommandType = CommandType.Text;

                SqlDataReader DataRead;
                sqlconn.Open();
                DataRead = cmd.ExecuteReader();

                string[] arr = new string[8];

                ListViewItem itm;

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
                    itm = new ListViewItem(arr);
                    listViewResa.Items.Add(itm);
                }

                for (int ligne2 = 0; ligne2 < listViewResa.Items.Count; ligne2++)
                {
                    if (ligne2 % 2 == 1)
                    {
                        listViewResa.Items[ligne2].BackColor = Color.White;
                    }
                    else listViewResa.Items[ligne2].BackColor = Color.MistyRose;
                }

                sqlconn.Close();
            }
            catch
            {

            }




            bool trouve = false;
            int ligne = 0;
            for (ligne = 0; ligne <= listViewResa.Items.Count - 1; ligne++)
            {
                if (listViewResa.Items[ligne].SubItems[0].Text.Contains(guna2ComboBoxNomPrenom.Text))
                {

                    trouve = true;



                }



            }

            if (trouve == true)
            {
                string code2 = combo2.Text;
                listViewResa.Items.Clear();



                try
                {

                    SqlConnection sqlconn = new SqlConnection(cheminDB);
                    SqlCommand cmd;
                    string sSQL;

                    sSQL = @"SELECT   * from     dbo.Reservation
                            where Date like '" + "%" + code2 + "%" + "'";
                    cmd = new SqlCommand(sSQL, sqlconn);

                    cmd.CommandType = CommandType.Text;

                    SqlDataReader DataRead;
                    sqlconn.Open();
                    DataRead = cmd.ExecuteReader();

                    string[] arr = new string[8];

                    ListViewItem itm;



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




                        itm = new ListViewItem(arr);
                        listViewResa.Items.Add(itm);

                    }
                    sqlconn.Close();
                }
                catch
                {

                }
                for (int ligne2 = 0; ligne2 < listViewResa.Items.Count; ligne2++)
                {
                    if (ligne2 % 2 == 1)
                    {
                        listViewResa.Items[ligne2].BackColor = Color.MistyRose;
                    }
                    else listViewResa.Items[ligne2].BackColor = Color.White;
                }

            }
        }

        private void guna2NumericUpDown4_KeyPress(object sender, KeyPressEventArgs e)
        {
            label4.Hide();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox2.SelectedIndex == 0 || guna2ComboBox2.SelectedIndex == 1)
            {
                guna2NumericUpDown4.Value = 0;
                guna2CheckBox1.Checked = false;
            }
            if (guna2ComboBox2.SelectedIndex == 2)
            {
                if (guna2CheckBox1.Checked)
                {
                    int valeur = (int)guna2NumericUpDown4.Value; // Convertir en entier si nécessaire
                    int prixe = valeur + 2500;



                    guna2NumericUpDown4.Value = prixe;
                }
                if (guna2CheckBox1.Checked == false)
                {
                    int valeur = (int)guna2NumericUpDown4.Value; // Convertir en entier si nécessaire
                    int prixe = valeur - 2500;



                    guna2NumericUpDown4.Value = prixe;
                }
            }
            
            }

            private void guna2CheckBox6_Click(object sender, EventArgs e)
            {


            }

        private void guna2NumericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    } 

