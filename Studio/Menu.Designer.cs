namespace Studio
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listViewClient = new System.Windows.Forms.ListView();
            this.guna2ButtonAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.progressBarB = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ProgressBar3 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2ProgressBar2 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRechercheNom = new System.Windows.Forms.Button();
            this.buttonRechercheCode = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.buttonRechercheMail = new System.Windows.Forms.Button();
            this.buttonRechercheTel = new System.Windows.Forms.Button();
            this.buttonRechercheAdresse = new System.Windows.Forms.Button();
            this.buttonRecherchePrenom = new System.Windows.Forms.Button();
            this.TextBoxReseaux = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxTel = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxCodeClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxAdresse = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxNomClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxPrenomClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listViewClient
            // 
            this.listViewClient.ForeColor = System.Drawing.Color.Black;
            this.listViewClient.HideSelection = false;
            this.listViewClient.Location = new System.Drawing.Point(417, 668);
            this.listViewClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewClient.Name = "listViewClient";
            this.listViewClient.Size = new System.Drawing.Size(2148, 1101);
            this.listViewClient.TabIndex = 56;
            this.listViewClient.UseCompatibleStateImageBehavior = false;
            this.listViewClient.SelectedIndexChanged += new System.EventHandler(this.listViewClient_SelectedIndexChanged);
            this.listViewClient.Click += new System.EventHandler(this.listViewClient_Click);
            this.listViewClient.DoubleClick += new System.EventHandler(this.listViewClient_DoubleClick);
            // 
            // guna2ButtonAjouter
            // 
            this.guna2ButtonAjouter.BorderColor = System.Drawing.Color.White;
            this.guna2ButtonAjouter.BorderRadius = 16;
            this.guna2ButtonAjouter.BorderThickness = 2;
            this.guna2ButtonAjouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAjouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAjouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonAjouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonAjouter.FillColor = System.Drawing.Color.LightGray;
            this.guna2ButtonAjouter.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.guna2ButtonAjouter.ForeColor = System.Drawing.Color.ForestGreen;
            this.guna2ButtonAjouter.Location = new System.Drawing.Point(1461, 455);
            this.guna2ButtonAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ButtonAjouter.Name = "guna2ButtonAjouter";
            this.guna2ButtonAjouter.Size = new System.Drawing.Size(319, 46);
            this.guna2ButtonAjouter.TabIndex = 130;
            this.guna2ButtonAjouter.Text = "Ajouter";
            this.guna2ButtonAjouter.Click += new System.EventHandler(this.guna2ButtonAjouter_Click);
            // 
            // progressBarB
            // 
            this.progressBarB.Location = new System.Drawing.Point(605, 1136);
            this.progressBarB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarB.Name = "progressBarB";
            this.progressBarB.Size = new System.Drawing.Size(269, 23);
            this.progressBarB.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.guna2Button6);
            this.panel1.Controls.Add(this.guna2Button5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.guna2Button4);
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Controls.Add(this.guna2ProgressBar3);
            this.panel1.Controls.Add(this.guna2ProgressBar2);
            this.panel1.Controls.Add(this.guna2ProgressBar1);
            this.panel1.Controls.Add(this.progressBarB);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 1434);
            this.panel1.TabIndex = 54;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(171, 1204);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 137;
            this.label6.Text = "LIMITE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(187, 1067);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 25);
            this.label5.TabIndex = 136;
            this.label5.Text = "00";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(187, 986);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 25);
            this.label4.TabIndex = 135;
            this.label4.Text = "00";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(187, 898);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 134;
            this.label3.Text = "00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button6
            // 
            this.guna2Button6.Animated = true;
            this.guna2Button6.AutoRoundedCorners = true;
            this.guna2Button6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button6.BorderColor = System.Drawing.Color.White;
            this.guna2Button6.BorderRadius = 18;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.Black;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Location = new System.Drawing.Point(55, 1195);
            this.guna2Button6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(88, 39);
            this.guna2Button6.TabIndex = 133;
            this.guna2Button6.Text = "- 50";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.Animated = true;
            this.guna2Button5.AutoRoundedCorners = true;
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderColor = System.Drawing.Color.White;
            this.guna2Button5.BorderRadius = 18;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Black;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(264, 1195);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(88, 39);
            this.guna2Button5.TabIndex = 132;
            this.guna2Button5.Text = "+ 50";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Studio.Properties.Resources.WhatsApp_Image_2024_02_07_a_16_241;
            this.pictureBox1.Location = new System.Drawing.Point(-47, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(519, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 131;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 26;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(41, 668);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(340, 54);
            this.guna2Button1.TabIndex = 130;
            this.guna2Button1.Text = "Liste mail";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.AutoRoundedCorners = true;
            this.guna2Button4.BorderColor = System.Drawing.Color.White;
            this.guna2Button4.BorderRadius = 40;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Black;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(55, 453);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(309, 82);
            this.guna2Button4.TabIndex = 126;
            this.guna2Button4.Text = "Réservation";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button3.BorderRadius = 40;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Black;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2Button3.ForeColor = System.Drawing.Color.Red;
            this.guna2Button3.Location = new System.Drawing.Point(55, 327);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(309, 82);
            this.guna2Button3.TabIndex = 125;
            this.guna2Button3.Text = "Inscription Client";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2ProgressBar3
            // 
            this.guna2ProgressBar3.BorderRadius = 15;
            this.guna2ProgressBar3.Location = new System.Drawing.Point(53, 1055);
            this.guna2ProgressBar3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ProgressBar3.Name = "guna2ProgressBar3";
            this.guna2ProgressBar3.ProgressColor = System.Drawing.Color.CornflowerBlue;
            this.guna2ProgressBar3.ProgressColor2 = System.Drawing.Color.CornflowerBlue;
            this.guna2ProgressBar3.Size = new System.Drawing.Size(299, 52);
            this.guna2ProgressBar3.TabIndex = 123;
            this.guna2ProgressBar3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ProgressBar3.Click += new System.EventHandler(this.guna2ProgressBar3_Click);
            // 
            // guna2ProgressBar2
            // 
            this.guna2ProgressBar2.BorderRadius = 15;
            this.guna2ProgressBar2.Location = new System.Drawing.Point(53, 885);
            this.guna2ProgressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ProgressBar2.Name = "guna2ProgressBar2";
            this.guna2ProgressBar2.ProgressColor = System.Drawing.Color.DarkGray;
            this.guna2ProgressBar2.ProgressColor2 = System.Drawing.Color.DarkGray;
            this.guna2ProgressBar2.Size = new System.Drawing.Size(299, 52);
            this.guna2ProgressBar2.TabIndex = 122;
            this.guna2ProgressBar2.Text = "guna2ProgressBar2";
            this.guna2ProgressBar2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ProgressBar2.Value = 1;
            this.guna2ProgressBar2.ValueChanged += new System.EventHandler(this.guna2ProgressBar2_ValueChanged);
            this.guna2ProgressBar2.Click += new System.EventHandler(this.guna2ProgressBar2_Click);
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.BorderRadius = 15;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(53, 970);
            this.guna2ProgressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.Gold;
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.Gold;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(299, 52);
            this.guna2ProgressBar1.TabIndex = 121;
            this.guna2ProgressBar1.Text = "guna2ProgressBar1";
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ProgressBar1.ValueChanged += new System.EventHandler(this.guna2ProgressBar1_ValueChanged);
            this.guna2ProgressBar1.Click += new System.EventHandler(this.guna2ProgressBar1_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1339, 646);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 14);
            this.label9.TabIndex = 165;
            this.label9.Text = "Reload la liste";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Black;
            this.guna2Button2.BorderRadius = 11;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button2.Location = new System.Drawing.Point(1293, 640);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(236, 48);
            this.guna2Button2.TabIndex = 164;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            this.guna2Button2.MouseLeave += new System.EventHandler(this.guna2Button2_MouseLeave);
            this.guna2Button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2Button2_MouseMove);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(417, -30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2152, 219);
            this.label1.TabIndex = 167;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1008, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(856, 166);
            this.label2.TabIndex = 168;
            this.label2.Text = "label2";
            // 
            // buttonRechercheNom
            // 
            this.buttonRechercheNom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRechercheNom.BackgroundImage")));
            this.buttonRechercheNom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRechercheNom.Location = new System.Drawing.Point(1363, 287);
            this.buttonRechercheNom.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRechercheNom.Name = "buttonRechercheNom";
            this.buttonRechercheNom.Size = new System.Drawing.Size(40, 36);
            this.buttonRechercheNom.TabIndex = 122;
            this.buttonRechercheNom.UseVisualStyleBackColor = true;
            this.buttonRechercheNom.Click += new System.EventHandler(this.buttonRechercheNom_Click);
            // 
            // buttonRechercheCode
            // 
            this.buttonRechercheCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRechercheCode.BackgroundImage")));
            this.buttonRechercheCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRechercheCode.Location = new System.Drawing.Point(1363, 192);
            this.buttonRechercheCode.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRechercheCode.Name = "buttonRechercheCode";
            this.buttonRechercheCode.Size = new System.Drawing.Size(40, 36);
            this.buttonRechercheCode.TabIndex = 114;
            this.buttonRechercheCode.UseVisualStyleBackColor = true;
            this.buttonRechercheCode.Click += new System.EventHandler(this.buttonRechercheCode_Click);
            // 
            // button14
            // 
            this.button14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button14.BackgroundImage")));
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.Location = new System.Drawing.Point(1795, 374);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(40, 36);
            this.button14.TabIndex = 127;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // buttonRechercheMail
            // 
            this.buttonRechercheMail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRechercheMail.BackgroundImage")));
            this.buttonRechercheMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRechercheMail.Location = new System.Drawing.Point(1795, 287);
            this.buttonRechercheMail.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRechercheMail.Name = "buttonRechercheMail";
            this.buttonRechercheMail.Size = new System.Drawing.Size(40, 36);
            this.buttonRechercheMail.TabIndex = 126;
            this.buttonRechercheMail.UseVisualStyleBackColor = true;
            this.buttonRechercheMail.Click += new System.EventHandler(this.buttonRechercheMail_Click);
            // 
            // buttonRechercheTel
            // 
            this.buttonRechercheTel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRechercheTel.BackgroundImage")));
            this.buttonRechercheTel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRechercheTel.Location = new System.Drawing.Point(1795, 193);
            this.buttonRechercheTel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRechercheTel.Name = "buttonRechercheTel";
            this.buttonRechercheTel.Size = new System.Drawing.Size(40, 36);
            this.buttonRechercheTel.TabIndex = 125;
            this.buttonRechercheTel.UseVisualStyleBackColor = true;
            this.buttonRechercheTel.Click += new System.EventHandler(this.buttonRechercheTel_Click);
            // 
            // buttonRechercheAdresse
            // 
            this.buttonRechercheAdresse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRechercheAdresse.BackgroundImage")));
            this.buttonRechercheAdresse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRechercheAdresse.Location = new System.Drawing.Point(1363, 462);
            this.buttonRechercheAdresse.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRechercheAdresse.Name = "buttonRechercheAdresse";
            this.buttonRechercheAdresse.Size = new System.Drawing.Size(40, 36);
            this.buttonRechercheAdresse.TabIndex = 124;
            this.buttonRechercheAdresse.UseVisualStyleBackColor = true;
            this.buttonRechercheAdresse.Click += new System.EventHandler(this.buttonRechercheAdresse_Click);
            // 
            // buttonRecherchePrenom
            // 
            this.buttonRecherchePrenom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRecherchePrenom.BackgroundImage")));
            this.buttonRecherchePrenom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRecherchePrenom.Location = new System.Drawing.Point(1363, 374);
            this.buttonRecherchePrenom.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRecherchePrenom.Name = "buttonRecherchePrenom";
            this.buttonRecherchePrenom.Size = new System.Drawing.Size(40, 36);
            this.buttonRecherchePrenom.TabIndex = 123;
            this.buttonRecherchePrenom.UseVisualStyleBackColor = true;
            this.buttonRecherchePrenom.Click += new System.EventHandler(this.buttonRecherchePrenom_Click);
            // 
            // TextBoxReseaux
            // 
            this.TextBoxReseaux.Animated = true;
            this.TextBoxReseaux.AutoRoundedCorners = true;
            this.TextBoxReseaux.BackgroundImage = global::Studio.Properties.Resources.eraser;
            this.TextBoxReseaux.BorderColor = System.Drawing.Color.Black;
            this.TextBoxReseaux.BorderRadius = 21;
            this.TextBoxReseaux.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxReseaux.DefaultText = "";
            this.TextBoxReseaux.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxReseaux.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxReseaux.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxReseaux.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxReseaux.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextBoxReseaux.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxReseaux.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxReseaux.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxReseaux.Location = new System.Drawing.Point(1461, 369);
            this.TextBoxReseaux.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxReseaux.Name = "TextBoxReseaux";
            this.TextBoxReseaux.PasswordChar = '\0';
            this.TextBoxReseaux.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextBoxReseaux.PlaceholderText = "entrez les réseaux sociaux du client";
            this.TextBoxReseaux.SelectedText = "";
            this.TextBoxReseaux.Size = new System.Drawing.Size(319, 44);
            this.TextBoxReseaux.TabIndex = 121;
            // 
            // TextBoxMail
            // 
            this.TextBoxMail.Animated = true;
            this.TextBoxMail.AutoRoundedCorners = true;
            this.TextBoxMail.BackgroundImage = global::Studio.Properties.Resources.eraser;
            this.TextBoxMail.BorderColor = System.Drawing.Color.Black;
            this.TextBoxMail.BorderRadius = 21;
            this.TextBoxMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxMail.DefaultText = "";
            this.TextBoxMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxMail.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextBoxMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxMail.Location = new System.Drawing.Point(1461, 282);
            this.TextBoxMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxMail.Name = "TextBoxMail";
            this.TextBoxMail.PasswordChar = '\0';
            this.TextBoxMail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextBoxMail.PlaceholderText = "entrez le mail du client";
            this.TextBoxMail.SelectedText = "";
            this.TextBoxMail.Size = new System.Drawing.Size(319, 44);
            this.TextBoxMail.TabIndex = 120;
            this.TextBoxMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxMail_KeyDown);
            // 
            // TextBoxTel
            // 
            this.TextBoxTel.Animated = true;
            this.TextBoxTel.AutoRoundedCorners = true;
            this.TextBoxTel.BackgroundImage = global::Studio.Properties.Resources.eraser;
            this.TextBoxTel.BorderColor = System.Drawing.Color.Transparent;
            this.TextBoxTel.BorderRadius = 18;
            this.TextBoxTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxTel.DefaultText = "";
            this.TextBoxTel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxTel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxTel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextBoxTel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxTel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTel.Location = new System.Drawing.Point(1461, 188);
            this.TextBoxTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxTel.MaxLength = 11;
            this.TextBoxTel.Name = "TextBoxTel";
            this.TextBoxTel.PasswordChar = '\0';
            this.TextBoxTel.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextBoxTel.PlaceholderText = "entrez le n° de tel du client";
            this.TextBoxTel.SelectedText = "";
            this.TextBoxTel.Size = new System.Drawing.Size(319, 39);
            this.TextBoxTel.TabIndex = 119;
            this.TextBoxTel.TextChanged += new System.EventHandler(this.TextBoxTel_TextChanged);
            this.TextBoxTel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxTel_KeyDown);
            this.TextBoxTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxTel_KeyPress);
            // 
            // TextBoxCodeClient
            // 
            this.TextBoxCodeClient.Animated = true;
            this.TextBoxCodeClient.AutoRoundedCorners = true;
            this.TextBoxCodeClient.BackgroundImage = global::Studio.Properties.Resources.eraser;
            this.TextBoxCodeClient.BorderColor = System.Drawing.Color.Black;
            this.TextBoxCodeClient.BorderRadius = 21;
            this.TextBoxCodeClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxCodeClient.DefaultText = "";
            this.TextBoxCodeClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxCodeClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxCodeClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxCodeClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxCodeClient.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextBoxCodeClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxCodeClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxCodeClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxCodeClient.Location = new System.Drawing.Point(1033, 188);
            this.TextBoxCodeClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxCodeClient.Name = "TextBoxCodeClient";
            this.TextBoxCodeClient.PasswordChar = '\0';
            this.TextBoxCodeClient.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextBoxCodeClient.PlaceholderText = "entrez un code client";
            this.TextBoxCodeClient.SelectedText = "";
            this.TextBoxCodeClient.Size = new System.Drawing.Size(319, 44);
            this.TextBoxCodeClient.TabIndex = 115;
            this.TextBoxCodeClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxCodeClient_KeyDown);
            this.TextBoxCodeClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCodeClient_KeyPress);
            // 
            // TextBoxAdresse
            // 
            this.TextBoxAdresse.Animated = true;
            this.TextBoxAdresse.AutoRoundedCorners = true;
            this.TextBoxAdresse.BackgroundImage = global::Studio.Properties.Resources.eraser;
            this.TextBoxAdresse.BorderColor = System.Drawing.Color.Black;
            this.TextBoxAdresse.BorderRadius = 21;
            this.TextBoxAdresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAdresse.DefaultText = "";
            this.TextBoxAdresse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxAdresse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxAdresse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxAdresse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxAdresse.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextBoxAdresse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxAdresse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxAdresse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxAdresse.Location = new System.Drawing.Point(1033, 457);
            this.TextBoxAdresse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxAdresse.Name = "TextBoxAdresse";
            this.TextBoxAdresse.PasswordChar = '\0';
            this.TextBoxAdresse.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextBoxAdresse.PlaceholderText = "entrez la ville du client";
            this.TextBoxAdresse.SelectedText = "";
            this.TextBoxAdresse.Size = new System.Drawing.Size(319, 44);
            this.TextBoxAdresse.TabIndex = 118;
            this.TextBoxAdresse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAdresse_KeyDown);
            // 
            // TextBoxNomClient
            // 
            this.TextBoxNomClient.Animated = true;
            this.TextBoxNomClient.AutoRoundedCorners = true;
            this.TextBoxNomClient.BackgroundImage = global::Studio.Properties.Resources.eraser;
            this.TextBoxNomClient.BorderColor = System.Drawing.Color.Black;
            this.TextBoxNomClient.BorderRadius = 21;
            this.TextBoxNomClient.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxNomClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxNomClient.DefaultText = "";
            this.TextBoxNomClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxNomClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxNomClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNomClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNomClient.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextBoxNomClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNomClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxNomClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNomClient.Location = new System.Drawing.Point(1033, 282);
            this.TextBoxNomClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxNomClient.Name = "TextBoxNomClient";
            this.TextBoxNomClient.PasswordChar = '\0';
            this.TextBoxNomClient.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextBoxNomClient.PlaceholderText = "entrez le nom du client";
            this.TextBoxNomClient.SelectedText = "";
            this.TextBoxNomClient.Size = new System.Drawing.Size(319, 44);
            this.TextBoxNomClient.TabIndex = 116;
            this.TextBoxNomClient.TextChanged += new System.EventHandler(this.TextBoxNomClient_TextChanged);
            this.TextBoxNomClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxNomClient_KeyDown);
            // 
            // TextBoxPrenomClient
            // 
            this.TextBoxPrenomClient.Animated = true;
            this.TextBoxPrenomClient.AutoRoundedCorners = true;
            this.TextBoxPrenomClient.BackgroundImage = global::Studio.Properties.Resources.eraser;
            this.TextBoxPrenomClient.BorderColor = System.Drawing.Color.Black;
            this.TextBoxPrenomClient.BorderRadius = 21;
            this.TextBoxPrenomClient.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxPrenomClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPrenomClient.DefaultText = "";
            this.TextBoxPrenomClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPrenomClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPrenomClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPrenomClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPrenomClient.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TextBoxPrenomClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPrenomClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPrenomClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPrenomClient.Location = new System.Drawing.Point(1033, 369);
            this.TextBoxPrenomClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxPrenomClient.Name = "TextBoxPrenomClient";
            this.TextBoxPrenomClient.PasswordChar = '\0';
            this.TextBoxPrenomClient.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextBoxPrenomClient.PlaceholderText = "entrez le prenom du client";
            this.TextBoxPrenomClient.SelectedText = "";
            this.TextBoxPrenomClient.Size = new System.Drawing.Size(319, 44);
            this.TextBoxPrenomClient.TabIndex = 117;
            this.TextBoxPrenomClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPrenomClient_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BackgroundImage = global::Studio.Properties.Resources.Capture_d_écran_2024_02_07_151248;
            this.panel2.Location = new System.Drawing.Point(1852, 160);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 700);
            this.panel2.TabIndex = 84;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.BackgroundImage = global::Studio.Properties.Resources.Capture_d_écran_2024_02_07_151248;
            this.panel4.Location = new System.Drawing.Point(391, 160);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(635, 570);
            this.panel4.TabIndex = 86;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BackgroundImage = global::Studio.Properties.Resources.Capture_d_écran_2024_02_07_151248;
            this.panel3.Location = new System.Drawing.Point(1012, 322);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(852, 521);
            this.panel3.TabIndex = 87;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewClient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2ButtonAjouter);
            this.Controls.Add(this.buttonRechercheNom);
            this.Controls.Add(this.buttonRechercheCode);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.buttonRechercheMail);
            this.Controls.Add(this.buttonRechercheTel);
            this.Controls.Add(this.buttonRechercheAdresse);
            this.Controls.Add(this.buttonRecherchePrenom);
            this.Controls.Add(this.TextBoxReseaux);
            this.Controls.Add(this.TextBoxMail);
            this.Controls.Add(this.TextBoxTel);
            this.Controls.Add(this.TextBoxCodeClient);
            this.Controls.Add(this.TextBoxAdresse);
            this.Controls.Add(this.TextBoxNomClient);
            this.Controls.Add(this.TextBoxPrenomClient);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView listViewClient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonRechercheNom;
        private System.Windows.Forms.Button buttonRechercheCode;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button buttonRechercheMail;
        private System.Windows.Forms.Button buttonRechercheTel;
        private System.Windows.Forms.Button buttonRechercheAdresse;
        private System.Windows.Forms.Button buttonRecherchePrenom;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxReseaux;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxMail;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxTel;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxCodeClient;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxAdresse;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxNomClient;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPrenomClient;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAjouter;
        private System.Windows.Forms.ProgressBar progressBarB;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar3;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar2;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}



