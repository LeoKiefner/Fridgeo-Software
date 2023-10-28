namespace What_s_in_my_fridge
{
    partial class frmRecetteUnique
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
            this.tcRecette = new System.Windows.Forms.TabControl();
            this.tpRecette = new System.Windows.Forms.TabPage();
            this.lblGenerPDF = new System.Windows.Forms.Label();
            this.pcbGenerPDF = new System.Windows.Forms.PictureBox();
            this.pcb_etape = new System.Windows.Forms.PictureBox();
            this.lbl_etape = new System.Windows.Forms.Label();
            this.pcb_fleche_avancer = new System.Windows.Forms.PictureBox();
            this.pcb_fleche_reculer = new System.Windows.Forms.PictureBox();
            this.lbl_page = new System.Windows.Forms.Label();
            this.gbp_ingredients = new System.Windows.Forms.GroupBox();
            this.gbp_titre = new System.Windows.Forms.GroupBox();
            this.lbl_personnes_prix = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pcbFondRecettes = new System.Windows.Forms.PictureBox();
            this.tpDetail = new System.Windows.Forms.TabPage();
            this.pcb_etape_bd = new System.Windows.Forms.PictureBox();
            this.pcb_fleche_debut = new System.Windows.Forms.PictureBox();
            this.pcb_fleche_fin = new System.Windows.Forms.PictureBox();
            this.pcb_fleche_suivante = new System.Windows.Forms.PictureBox();
            this.pcb_debut_etape = new System.Windows.Forms.PictureBox();
            this.lbl_etape_bd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.process1 = new System.Diagnostics.Process();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_detaillee = new System.Windows.Forms.Label();
            this.lbl_globale = new System.Windows.Forms.Label();
            this.lblFermer = new System.Windows.Forms.Label();
            this.pcbFermer = new System.Windows.Forms.PictureBox();
            this.pcb_globale = new System.Windows.Forms.PictureBox();
            this.pcbFiltre = new System.Windows.Forms.PictureBox();
            this.pcbFridgeo = new System.Windows.Forms.PictureBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.pcbNote = new System.Windows.Forms.PictureBox();
            this.tcRecette.SuspendLayout();
            this.tpRecette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGenerPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_etape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fleche_avancer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fleche_reculer)).BeginInit();
            this.gbp_titre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFondRecettes)).BeginInit();
            this.tpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_etape_bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fleche_debut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fleche_fin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fleche_suivante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_debut_etape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFermer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_globale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFiltre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFridgeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNote)).BeginInit();
            this.SuspendLayout();
            // 
            // tcRecette
            // 
            this.tcRecette.Controls.Add(this.tpRecette);
            this.tcRecette.Controls.Add(this.tpDetail);
            this.tcRecette.Location = new System.Drawing.Point(12, 57);
            this.tcRecette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcRecette.Name = "tcRecette";
            this.tcRecette.SelectedIndex = 0;
            this.tcRecette.Size = new System.Drawing.Size(859, 784);
            this.tcRecette.TabIndex = 23;
            // 
            // tpRecette
            // 
            this.tpRecette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tpRecette.Controls.Add(this.lblGenerPDF);
            this.tpRecette.Controls.Add(this.pcbGenerPDF);
            this.tpRecette.Controls.Add(this.pcb_etape);
            this.tpRecette.Controls.Add(this.lbl_etape);
            this.tpRecette.Controls.Add(this.pcb_fleche_avancer);
            this.tpRecette.Controls.Add(this.pcb_fleche_reculer);
            this.tpRecette.Controls.Add(this.lbl_page);
            this.tpRecette.Controls.Add(this.gbp_ingredients);
            this.tpRecette.Controls.Add(this.gbp_titre);
            this.tpRecette.Controls.Add(this.lblIngredients);
            this.tpRecette.Controls.Add(this.lblTitre);
            this.tpRecette.Controls.Add(this.pcbFondRecettes);
            this.tpRecette.Location = new System.Drawing.Point(4, 25);
            this.tpRecette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRecette.Name = "tpRecette";
            this.tpRecette.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRecette.Size = new System.Drawing.Size(851, 755);
            this.tpRecette.TabIndex = 0;
            this.tpRecette.Text = "Recette globale";
            // 
            // lblGenerPDF
            // 
            this.lblGenerPDF.AutoSize = true;
            this.lblGenerPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lblGenerPDF.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerPDF.ForeColor = System.Drawing.Color.Snow;
            this.lblGenerPDF.Location = new System.Drawing.Point(664, 41);
            this.lblGenerPDF.Name = "lblGenerPDF";
            this.lblGenerPDF.Size = new System.Drawing.Size(110, 23);
            this.lblGenerPDF.TabIndex = 50;
            this.lblGenerPDF.Text = "Générer PDF";
            this.lblGenerPDF.Click += new System.EventHandler(this.lblGenerPDF_Click);
            // 
            // pcbGenerPDF
            // 
            this.pcbGenerPDF.BackColor = System.Drawing.Color.Gray;
            this.pcbGenerPDF.Image = global::What_s_in_my_fridge.Properties.Resources.carregrisfonce;
            this.pcbGenerPDF.Location = new System.Drawing.Point(629, 30);
            this.pcbGenerPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbGenerPDF.Name = "pcbGenerPDF";
            this.pcbGenerPDF.Size = new System.Drawing.Size(184, 50);
            this.pcbGenerPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGenerPDF.TabIndex = 49;
            this.pcbGenerPDF.TabStop = false;
            this.pcbGenerPDF.Click += new System.EventHandler(this.pcbGenerPDF_Click);
            // 
            // pcb_etape
            // 
            this.pcb_etape.Location = new System.Drawing.Point(100, 236);
            this.pcb_etape.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcb_etape.Name = "pcb_etape";
            this.pcb_etape.Size = new System.Drawing.Size(276, 255);
            this.pcb_etape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_etape.TabIndex = 48;
            this.pcb_etape.TabStop = false;
            // 
            // lbl_etape
            // 
            this.lbl_etape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lbl_etape.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_etape.ForeColor = System.Drawing.Color.White;
            this.lbl_etape.Location = new System.Drawing.Point(29, 495);
            this.lbl_etape.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_etape.Name = "lbl_etape";
            this.lbl_etape.Size = new System.Drawing.Size(423, 164);
            this.lbl_etape.TabIndex = 47;
            this.lbl_etape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcb_fleche_avancer
            // 
            this.pcb_fleche_avancer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.pcb_fleche_avancer.Image = global::What_s_in_my_fridge.Properties.Resources.flechedroite;
            this.pcb_fleche_avancer.Location = new System.Drawing.Point(323, 662);
            this.pcb_fleche_avancer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcb_fleche_avancer.Name = "pcb_fleche_avancer";
            this.pcb_fleche_avancer.Size = new System.Drawing.Size(67, 62);
            this.pcb_fleche_avancer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_fleche_avancer.TabIndex = 46;
            this.pcb_fleche_avancer.TabStop = false;
            this.pcb_fleche_avancer.Click += new System.EventHandler(this.pcb_fleche_avancer_Click);
            // 
            // pcb_fleche_reculer
            // 
            this.pcb_fleche_reculer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.pcb_fleche_reculer.Image = global::What_s_in_my_fridge.Properties.Resources.flechegauche;
            this.pcb_fleche_reculer.Location = new System.Drawing.Point(79, 662);
            this.pcb_fleche_reculer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcb_fleche_reculer.Name = "pcb_fleche_reculer";
            this.pcb_fleche_reculer.Size = new System.Drawing.Size(67, 62);
            this.pcb_fleche_reculer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_fleche_reculer.TabIndex = 45;
            this.pcb_fleche_reculer.TabStop = false;
            this.pcb_fleche_reculer.Click += new System.EventHandler(this.pcb_fleche_reculer_Click);
            // 
            // lbl_page
            // 
            this.lbl_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lbl_page.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_page.ForeColor = System.Drawing.Color.White;
            this.lbl_page.Location = new System.Drawing.Point(152, 674);
            this.lbl_page.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_page.Name = "lbl_page";
            this.lbl_page.Size = new System.Drawing.Size(163, 36);
            this.lbl_page.TabIndex = 44;
            this.lbl_page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbp_ingredients
            // 
            this.gbp_ingredients.Location = new System.Drawing.Point(469, 121);
            this.gbp_ingredients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbp_ingredients.Name = "gbp_ingredients";
            this.gbp_ingredients.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbp_ingredients.Size = new System.Drawing.Size(345, 603);
            this.gbp_ingredients.TabIndex = 28;
            this.gbp_ingredients.TabStop = false;
            // 
            // gbp_titre
            // 
            this.gbp_titre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.gbp_titre.Controls.Add(this.lblNote);
            this.gbp_titre.Controls.Add(this.lbl_personnes_prix);
            this.gbp_titre.Controls.Add(this.pcbNote);
            this.gbp_titre.Controls.Add(this.lbl_description);
            this.gbp_titre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.gbp_titre.Location = new System.Drawing.Point(29, 86);
            this.gbp_titre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbp_titre.Name = "gbp_titre";
            this.gbp_titre.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbp_titre.Size = new System.Drawing.Size(423, 150);
            this.gbp_titre.TabIndex = 27;
            this.gbp_titre.TabStop = false;
            // 
            // lbl_personnes_prix
            // 
            this.lbl_personnes_prix.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_personnes_prix.ForeColor = System.Drawing.Color.White;
            this.lbl_personnes_prix.Location = new System.Drawing.Point(3, 11);
            this.lbl_personnes_prix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_personnes_prix.Name = "lbl_personnes_prix";
            this.lbl_personnes_prix.Size = new System.Drawing.Size(232, 53);
            this.lbl_personnes_prix.TabIndex = 2;
            this.lbl_personnes_prix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_description
            // 
            this.lbl_description.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lbl_description.Location = new System.Drawing.Point(8, 64);
            this.lbl_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(405, 82);
            this.lbl_description.TabIndex = 1;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lblIngredients.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.ForeColor = System.Drawing.Color.Snow;
            this.lblIngredients.Location = new System.Drawing.Point(573, 86);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(145, 32);
            this.lblIngredients.TabIndex = 24;
            this.lblIngredients.Text = "Ingrédients";
            // 
            // lblTitre
            // 
            this.lblTitre.BackColor = System.Drawing.Color.Gray;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Snow;
            this.lblTitre.Location = new System.Drawing.Point(29, 33);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(797, 37);
            this.lblTitre.TabIndex = 21;
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pcbFondRecettes
            // 
            this.pcbFondRecettes.Image = global::What_s_in_my_fridge.Properties.Resources.fondfrmRecettes;
            this.pcbFondRecettes.Location = new System.Drawing.Point(3, 5);
            this.pcbFondRecettes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbFondRecettes.Name = "pcbFondRecettes";
            this.pcbFondRecettes.Size = new System.Drawing.Size(852, 742);
            this.pcbFondRecettes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFondRecettes.TabIndex = 20;
            this.pcbFondRecettes.TabStop = false;
            // 
            // tpDetail
            // 
            this.tpDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tpDetail.Controls.Add(this.pcb_etape_bd);
            this.tpDetail.Controls.Add(this.pcb_fleche_debut);
            this.tpDetail.Controls.Add(this.pcb_fleche_fin);
            this.tpDetail.Controls.Add(this.pcb_fleche_suivante);
            this.tpDetail.Controls.Add(this.pcb_debut_etape);
            this.tpDetail.Controls.Add(this.lbl_etape_bd);
            this.tpDetail.Controls.Add(this.label1);
            this.tpDetail.Controls.Add(this.pictureBox2);
            this.tpDetail.Location = new System.Drawing.Point(4, 25);
            this.tpDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDetail.Name = "tpDetail";
            this.tpDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDetail.Size = new System.Drawing.Size(851, 755);
            this.tpDetail.TabIndex = 1;
            this.tpDetail.Text = "Recette détaillée";
            // 
            // pcb_etape_bd
            // 
            this.pcb_etape_bd.Location = new System.Drawing.Point(305, 105);
            this.pcb_etape_bd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcb_etape_bd.Name = "pcb_etape_bd";
            this.pcb_etape_bd.Size = new System.Drawing.Size(279, 257);
            this.pcb_etape_bd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_etape_bd.TabIndex = 29;
            this.pcb_etape_bd.TabStop = false;
            // 
            // pcb_fleche_debut
            // 
            this.pcb_fleche_debut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.pcb_fleche_debut.Image = global::What_s_in_my_fridge.Properties.Resources.flechedebut;
            this.pcb_fleche_debut.Location = new System.Drawing.Point(84, 617);
            this.pcb_fleche_debut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcb_fleche_debut.Name = "pcb_fleche_debut";
            this.pcb_fleche_debut.Size = new System.Drawing.Size(93, 86);
            this.pcb_fleche_debut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_fleche_debut.TabIndex = 28;
            this.pcb_fleche_debut.TabStop = false;
            this.pcb_fleche_debut.Click += new System.EventHandler(this.pcb_fleche_debut_Click);
            // 
            // pcb_fleche_fin
            // 
            this.pcb_fleche_fin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.pcb_fleche_fin.Image = global::What_s_in_my_fridge.Properties.Resources.flechefin;
            this.pcb_fleche_fin.Location = new System.Drawing.Point(648, 617);
            this.pcb_fleche_fin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcb_fleche_fin.Name = "pcb_fleche_fin";
            this.pcb_fleche_fin.Size = new System.Drawing.Size(93, 86);
            this.pcb_fleche_fin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_fleche_fin.TabIndex = 27;
            this.pcb_fleche_fin.TabStop = false;
            this.pcb_fleche_fin.Click += new System.EventHandler(this.pcb_fleche_fin_Click);
            // 
            // pcb_fleche_suivante
            // 
            this.pcb_fleche_suivante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.pcb_fleche_suivante.Image = global::What_s_in_my_fridge.Properties.Resources.flechedroite;
            this.pcb_fleche_suivante.Location = new System.Drawing.Point(460, 617);
            this.pcb_fleche_suivante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcb_fleche_suivante.Name = "pcb_fleche_suivante";
            this.pcb_fleche_suivante.Size = new System.Drawing.Size(93, 86);
            this.pcb_fleche_suivante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_fleche_suivante.TabIndex = 26;
            this.pcb_fleche_suivante.TabStop = false;
            this.pcb_fleche_suivante.Click += new System.EventHandler(this.pcb_fleche_suivante_Click);
            // 
            // pcb_debut_etape
            // 
            this.pcb_debut_etape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.pcb_debut_etape.Image = global::What_s_in_my_fridge.Properties.Resources.flechegauche;
            this.pcb_debut_etape.Location = new System.Drawing.Point(257, 617);
            this.pcb_debut_etape.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcb_debut_etape.Name = "pcb_debut_etape";
            this.pcb_debut_etape.Size = new System.Drawing.Size(93, 86);
            this.pcb_debut_etape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_debut_etape.TabIndex = 25;
            this.pcb_debut_etape.TabStop = false;
            this.pcb_debut_etape.Click += new System.EventHandler(this.pcb_debut_etape_Click);
            // 
            // lbl_etape_bd
            // 
            this.lbl_etape_bd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lbl_etape_bd.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_etape_bd.ForeColor = System.Drawing.Color.White;
            this.lbl_etape_bd.Location = new System.Drawing.Point(29, 379);
            this.lbl_etape_bd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_etape_bd.Name = "lbl_etape_bd";
            this.lbl_etape_bd.Size = new System.Drawing.Size(795, 159);
            this.lbl_etape_bd.TabIndex = 24;
            this.lbl_etape_bd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(320, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 38);
            this.label1.TabIndex = 23;
            this.label1.Text = "Recette détaillée";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::What_s_in_my_fridge.Properties.Resources.fondfrmRecettes;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(852, 716);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // lbl_detaillee
            // 
            this.lbl_detaillee.AutoSize = true;
            this.lbl_detaillee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lbl_detaillee.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detaillee.ForeColor = System.Drawing.Color.White;
            this.lbl_detaillee.Location = new System.Drawing.Point(167, 21);
            this.lbl_detaillee.Name = "lbl_detaillee";
            this.lbl_detaillee.Size = new System.Drawing.Size(113, 28);
            this.lbl_detaillee.TabIndex = 46;
            this.lbl_detaillee.Text = "Détaillée";
            this.lbl_detaillee.Click += new System.EventHandler(this.lbl_detaillee_Click);
            // 
            // lbl_globale
            // 
            this.lbl_globale.AutoSize = true;
            this.lbl_globale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(126)))), ((int)(((byte)(8)))));
            this.lbl_globale.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_globale.ForeColor = System.Drawing.Color.White;
            this.lbl_globale.Location = new System.Drawing.Point(28, 20);
            this.lbl_globale.Name = "lbl_globale";
            this.lbl_globale.Size = new System.Drawing.Size(98, 28);
            this.lbl_globale.TabIndex = 48;
            this.lbl_globale.Text = "Globale";
            this.lbl_globale.Click += new System.EventHandler(this.lbl_globale_Click);
            // 
            // lblFermer
            // 
            this.lblFermer.AutoSize = true;
            this.lblFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(226)))));
            this.lblFermer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFermer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lblFermer.Location = new System.Drawing.Point(741, 25);
            this.lblFermer.Name = "lblFermer";
            this.lblFermer.Size = new System.Drawing.Size(89, 31);
            this.lblFermer.TabIndex = 52;
            this.lblFermer.Text = "Fermer";
            this.lblFermer.Click += new System.EventHandler(this.lblFermer_Click);
            // 
            // pcbFermer
            // 
            this.pcbFermer.Image = global::What_s_in_my_fridge.Properties.Resources.carreblanc;
            this.pcbFermer.Location = new System.Drawing.Point(716, 10);
            this.pcbFermer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbFermer.Name = "pcbFermer";
            this.pcbFermer.Size = new System.Drawing.Size(151, 59);
            this.pcbFermer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFermer.TabIndex = 51;
            this.pcbFermer.TabStop = false;
            this.pcbFermer.Click += new System.EventHandler(this.pcbFermer_Click);
            // 
            // pcb_globale
            // 
            this.pcb_globale.Image = global::What_s_in_my_fridge.Properties.Resources.carreabordsemirondfonce;
            this.pcb_globale.Location = new System.Drawing.Point(11, 15);
            this.pcb_globale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcb_globale.Name = "pcb_globale";
            this.pcb_globale.Size = new System.Drawing.Size(147, 39);
            this.pcb_globale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_globale.TabIndex = 47;
            this.pcb_globale.TabStop = false;
            this.pcb_globale.Click += new System.EventHandler(this.pcb_globale_Click);
            // 
            // pcbFiltre
            // 
            this.pcbFiltre.Image = global::What_s_in_my_fridge.Properties.Resources.carreabordsemirond;
            this.pcbFiltre.Location = new System.Drawing.Point(156, 15);
            this.pcbFiltre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbFiltre.Name = "pcbFiltre";
            this.pcbFiltre.Size = new System.Drawing.Size(147, 39);
            this.pcbFiltre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFiltre.TabIndex = 45;
            this.pcbFiltre.TabStop = false;
            this.pcbFiltre.Click += new System.EventHandler(this.pcbFiltre_Click);
            // 
            // pcbFridgeo
            // 
            this.pcbFridgeo.Image = global::What_s_in_my_fridge.Properties.Resources.image_2023_05_15_163741969;
            this.pcbFridgeo.Location = new System.Drawing.Point(336, 2);
            this.pcbFridgeo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbFridgeo.Name = "pcbFridgeo";
            this.pcbFridgeo.Size = new System.Drawing.Size(235, 89);
            this.pcbFridgeo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFridgeo.TabIndex = 24;
            this.pcbFridgeo.TabStop = false;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.Snow;
            this.lblNote.Location = new System.Drawing.Point(255, 23);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(136, 23);
            this.lblNote.TabIndex = 52;
            this.lblNote.Text = "Noter la recette";
            this.lblNote.Click += new System.EventHandler(this.lblNote_Click);
            // 
            // pcbNote
            // 
            this.pcbNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.pcbNote.Image = global::What_s_in_my_fridge.Properties.Resources.carregrisfonce;
            this.pcbNote.Location = new System.Drawing.Point(239, 11);
            this.pcbNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbNote.Name = "pcbNote";
            this.pcbNote.Size = new System.Drawing.Size(181, 50);
            this.pcbNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbNote.TabIndex = 51;
            this.pcbNote.TabStop = false;
            this.pcbNote.Click += new System.EventHandler(this.pcbNote_Click);
            // 
            // frmRecetteUnique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(883, 853);
            this.Controls.Add(this.lblFermer);
            this.Controls.Add(this.pcbFermer);
            this.Controls.Add(this.lbl_globale);
            this.Controls.Add(this.pcb_globale);
            this.Controls.Add(this.lbl_detaillee);
            this.Controls.Add(this.pcbFiltre);
            this.Controls.Add(this.pcbFridgeo);
            this.Controls.Add(this.tcRecette);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRecetteUnique";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fridgeo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmRecetteUnique_Load);
            this.tcRecette.ResumeLayout(false);
            this.tpRecette.ResumeLayout(false);
            this.tpRecette.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGenerPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_etape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fleche_avancer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fleche_reculer)).EndInit();
            this.gbp_titre.ResumeLayout(false);
            this.gbp_titre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFondRecettes)).EndInit();
            this.tpDetail.ResumeLayout(false);
            this.tpDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_etape_bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fleche_debut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fleche_fin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fleche_suivante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_debut_etape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFermer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_globale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFiltre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFridgeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcRecette;
        private System.Windows.Forms.TabPage tpRecette;
        private System.Windows.Forms.TabPage tpDetail;
        private System.Windows.Forms.PictureBox pcbFridgeo;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox pcbFondRecettes;
        private System.Windows.Forms.Label lblIngredients;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbp_ingredients;
        private System.Windows.Forms.GroupBox gbp_titre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_personnes_prix;
        private System.Windows.Forms.Label lbl_globale;
        private System.Windows.Forms.PictureBox pcb_globale;
        private System.Windows.Forms.Label lbl_detaillee;
        private System.Windows.Forms.PictureBox pcbFiltre;
        private System.Windows.Forms.PictureBox pcb_fleche_avancer;
        private System.Windows.Forms.PictureBox pcb_fleche_reculer;
        private System.Windows.Forms.Label lbl_page;
        private System.Windows.Forms.Label lbl_etape;
        private System.Windows.Forms.PictureBox pcb_etape;
        private System.Windows.Forms.Label lblFermer;
        private System.Windows.Forms.PictureBox pcbFermer;
        private System.Windows.Forms.PictureBox pcbGenerPDF;
        private System.Windows.Forms.Label lblGenerPDF;
        private System.Windows.Forms.PictureBox pcb_fleche_debut;
        private System.Windows.Forms.PictureBox pcb_fleche_fin;
        private System.Windows.Forms.PictureBox pcb_fleche_suivante;
        private System.Windows.Forms.PictureBox pcb_debut_etape;
        private System.Windows.Forms.Label lbl_etape_bd;
        private System.Windows.Forms.PictureBox pcb_etape_bd;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.PictureBox pcbNote;
    }
}