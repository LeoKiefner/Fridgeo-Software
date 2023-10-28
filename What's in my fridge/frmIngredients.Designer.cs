namespace What_s_in_my_fridge
{
    partial class frmIngredients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngredients));
            this.lbl_zone_famille = new System.Windows.Forms.Label();
            this.lbl_famille = new System.Windows.Forms.Label();
            this.tabc_choix = new System.Windows.Forms.TabControl();
            this.taPIngredients = new System.Windows.Forms.TabPage();
            this.pcbCroix3 = new System.Windows.Forms.PictureBox();
            this.pcbCroix2 = new System.Windows.Forms.PictureBox();
            this.pcbCroix1 = new System.Windows.Forms.PictureBox();
            this.gb_ingredients = new System.Windows.Forms.GroupBox();
            this.lbl_ing3 = new System.Windows.Forms.Label();
            this.lbl_ing2 = new System.Windows.Forms.Label();
            this.lbl_ing1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.taPFiltres = new System.Windows.Forms.TabPage();
            this.lblmax = new System.Windows.Forms.Label();
            this.lblmoy = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.gb_categories = new System.Windows.Forms.GroupBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.txtTemps = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRepas = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.transitionPanel = new System.Windows.Forms.Panel();
            this.lblFiltre = new System.Windows.Forms.Label();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.pcbFiltre = new System.Windows.Forms.PictureBox();
            this.pcbIngredient = new System.Windows.Forms.PictureBox();
            this.lblFermer = new System.Windows.Forms.Label();
            this.pcbFermer = new System.Windows.Forms.PictureBox();
            this.lblValider = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabc_choix.SuspendLayout();
            this.taPIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCroix3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCroix2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCroix1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.taPFiltres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.transitionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFiltre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIngredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFermer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_zone_famille
            // 
            this.lbl_zone_famille.AutoSize = true;
            this.lbl_zone_famille.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lbl_zone_famille.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zone_famille.ForeColor = System.Drawing.Color.Snow;
            this.lbl_zone_famille.Location = new System.Drawing.Point(21, 22);
            this.lbl_zone_famille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_zone_famille.Name = "lbl_zone_famille";
            this.lbl_zone_famille.Size = new System.Drawing.Size(229, 30);
            this.lbl_zone_famille.TabIndex = 1;
            this.lbl_zone_famille.Text = "Famille d\'ingrédients";
            // 
            // lbl_famille
            // 
            this.lbl_famille.BackColor = System.Drawing.Color.Gray;
            this.lbl_famille.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_famille.ForeColor = System.Drawing.Color.Snow;
            this.lbl_famille.Location = new System.Drawing.Point(277, 20);
            this.lbl_famille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_famille.Name = "lbl_famille";
            this.lbl_famille.Size = new System.Drawing.Size(359, 41);
            this.lbl_famille.TabIndex = 3;
            this.lbl_famille.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabc_choix
            // 
            this.tabc_choix.Controls.Add(this.taPIngredients);
            this.tabc_choix.Controls.Add(this.taPFiltres);
            this.tabc_choix.Location = new System.Drawing.Point(26, 54);
            this.tabc_choix.Margin = new System.Windows.Forms.Padding(2);
            this.tabc_choix.Name = "tabc_choix";
            this.tabc_choix.SelectedIndex = 0;
            this.tabc_choix.Size = new System.Drawing.Size(657, 586);
            this.tabc_choix.TabIndex = 13;
            // 
            // taPIngredients
            // 
            this.taPIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.taPIngredients.Controls.Add(this.pcbCroix3);
            this.taPIngredients.Controls.Add(this.pcbCroix2);
            this.taPIngredients.Controls.Add(this.pcbCroix1);
            this.taPIngredients.Controls.Add(this.gb_ingredients);
            this.taPIngredients.Controls.Add(this.lbl_ing3);
            this.taPIngredients.Controls.Add(this.lbl_ing2);
            this.taPIngredients.Controls.Add(this.lbl_ing1);
            this.taPIngredients.Controls.Add(this.label7);
            this.taPIngredients.Controls.Add(this.label6);
            this.taPIngredients.Controls.Add(this.label5);
            this.taPIngredients.Controls.Add(this.label2);
            this.taPIngredients.Controls.Add(this.pictureBox4);
            this.taPIngredients.Controls.Add(this.lbl_famille);
            this.taPIngredients.Controls.Add(this.lbl_zone_famille);
            this.taPIngredients.Controls.Add(this.pictureBox1);
            this.taPIngredients.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taPIngredients.Location = new System.Drawing.Point(4, 22);
            this.taPIngredients.Margin = new System.Windows.Forms.Padding(2);
            this.taPIngredients.Name = "taPIngredients";
            this.taPIngredients.Padding = new System.Windows.Forms.Padding(2);
            this.taPIngredients.Size = new System.Drawing.Size(649, 560);
            this.taPIngredients.TabIndex = 0;
            this.taPIngredients.Text = "Ingredients";
            // 
            // pcbCroix3
            // 
            this.pcbCroix3.Image = global::What_s_in_my_fridge.Properties.Resources.croix;
            this.pcbCroix3.Location = new System.Drawing.Point(286, 497);
            this.pcbCroix3.Margin = new System.Windows.Forms.Padding(2);
            this.pcbCroix3.Name = "pcbCroix3";
            this.pcbCroix3.Size = new System.Drawing.Size(19, 20);
            this.pcbCroix3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCroix3.TabIndex = 36;
            this.pcbCroix3.TabStop = false;
            this.pcbCroix3.Tag = "3";
            this.pcbCroix3.Visible = false;
            this.pcbCroix3.Click += new System.EventHandler(this.pcbCroix3_Click);
            // 
            // pcbCroix2
            // 
            this.pcbCroix2.Image = global::What_s_in_my_fridge.Properties.Resources.croix;
            this.pcbCroix2.Location = new System.Drawing.Point(286, 472);
            this.pcbCroix2.Margin = new System.Windows.Forms.Padding(2);
            this.pcbCroix2.Name = "pcbCroix2";
            this.pcbCroix2.Size = new System.Drawing.Size(19, 20);
            this.pcbCroix2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCroix2.TabIndex = 35;
            this.pcbCroix2.TabStop = false;
            this.pcbCroix2.Tag = "2";
            this.pcbCroix2.Visible = false;
            this.pcbCroix2.Click += new System.EventHandler(this.pcbCroix2_Click);
            // 
            // pcbCroix1
            // 
            this.pcbCroix1.Image = global::What_s_in_my_fridge.Properties.Resources.croix;
            this.pcbCroix1.Location = new System.Drawing.Point(286, 447);
            this.pcbCroix1.Margin = new System.Windows.Forms.Padding(2);
            this.pcbCroix1.Name = "pcbCroix1";
            this.pcbCroix1.Size = new System.Drawing.Size(19, 20);
            this.pcbCroix1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCroix1.TabIndex = 34;
            this.pcbCroix1.TabStop = false;
            this.pcbCroix1.Tag = "1";
            this.pcbCroix1.Visible = false;
            this.pcbCroix1.Click += new System.EventHandler(this.pcbCroix1_Click);
            // 
            // gb_ingredients
            // 
            this.gb_ingredients.BackColor = System.Drawing.Color.Gray;
            this.gb_ingredients.ForeColor = System.Drawing.Color.Gray;
            this.gb_ingredients.Location = new System.Drawing.Point(277, 55);
            this.gb_ingredients.Name = "gb_ingredients";
            this.gb_ingredients.Size = new System.Drawing.Size(359, 341);
            this.gb_ingredients.TabIndex = 33;
            this.gb_ingredients.TabStop = false;
            // 
            // lbl_ing3
            // 
            this.lbl_ing3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lbl_ing3.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ing3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lbl_ing3.Location = new System.Drawing.Point(442, 491);
            this.lbl_ing3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ing3.Name = "lbl_ing3";
            this.lbl_ing3.Size = new System.Drawing.Size(189, 25);
            this.lbl_ing3.TabIndex = 32;
            this.lbl_ing3.Tag = "3";
            this.lbl_ing3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_ing2
            // 
            this.lbl_ing2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lbl_ing2.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ing2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lbl_ing2.Location = new System.Drawing.Point(442, 466);
            this.lbl_ing2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ing2.Name = "lbl_ing2";
            this.lbl_ing2.Size = new System.Drawing.Size(189, 25);
            this.lbl_ing2.TabIndex = 31;
            this.lbl_ing2.Tag = "2";
            this.lbl_ing2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_ing1
            // 
            this.lbl_ing1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lbl_ing1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ing1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lbl_ing1.Location = new System.Drawing.Point(442, 442);
            this.lbl_ing1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ing1.Name = "lbl_ing1";
            this.lbl_ing1.Size = new System.Drawing.Size(189, 25);
            this.lbl_ing1.TabIndex = 30;
            this.lbl_ing1.Tag = "1";
            this.lbl_ing1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.label7.Location = new System.Drawing.Point(310, 491);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ingrédient 3 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.label6.Location = new System.Drawing.Point(310, 466);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ingrédient 2 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.label5.Location = new System.Drawing.Point(310, 442);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ingrédient 1 : ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.label2.Location = new System.Drawing.Point(289, 417);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ingrédients choisi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Gray;
            this.pictureBox4.Image = global::What_s_in_my_fridge.Properties.Resources.carrenoir;
            this.pictureBox4.Location = new System.Drawing.Point(277, 401);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(363, 144);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::What_s_in_my_fridge.Properties.Resources.carre;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 664);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // taPFiltres
            // 
            this.taPFiltres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.taPFiltres.Controls.Add(this.lblmax);
            this.taPFiltres.Controls.Add(this.lblmoy);
            this.taPFiltres.Controls.Add(this.lblmin);
            this.taPFiltres.Controls.Add(this.hScrollBar1);
            this.taPFiltres.Controls.Add(this.gb_categories);
            this.taPFiltres.Controls.Add(this.lblMinutes);
            this.taPFiltres.Controls.Add(this.txtTemps);
            this.taPFiltres.Controls.Add(this.label4);
            this.taPFiltres.Controls.Add(this.label1);
            this.taPFiltres.Controls.Add(this.lblRepas);
            this.taPFiltres.Controls.Add(this.pictureBox2);
            this.taPFiltres.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taPFiltres.Location = new System.Drawing.Point(4, 22);
            this.taPFiltres.Margin = new System.Windows.Forms.Padding(2);
            this.taPFiltres.Name = "taPFiltres";
            this.taPFiltres.Padding = new System.Windows.Forms.Padding(2);
            this.taPFiltres.Size = new System.Drawing.Size(649, 560);
            this.taPFiltres.TabIndex = 1;
            this.taPFiltres.Text = "Filtres";
            // 
            // lblmax
            // 
            this.lblmax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lblmax.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmax.Location = new System.Drawing.Point(412, 414);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(161, 36);
            this.lblmax.TabIndex = 22;
            this.lblmax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblmoy
            // 
            this.lblmoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lblmoy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmoy.Location = new System.Drawing.Point(252, 414);
            this.lblmoy.Name = "lblmoy";
            this.lblmoy.Size = new System.Drawing.Size(161, 36);
            this.lblmoy.TabIndex = 21;
            this.lblmoy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblmin
            // 
            this.lblmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lblmin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmin.Location = new System.Drawing.Point(85, 414);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(161, 36);
            this.lblmin.TabIndex = 20;
            this.lblmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(88, 329);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(485, 85);
            this.hScrollBar1.TabIndex = 19;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // gb_categories
            // 
            this.gb_categories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.gb_categories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.gb_categories.Location = new System.Drawing.Point(23, 89);
            this.gb_categories.Name = "gb_categories";
            this.gb_categories.Size = new System.Drawing.Size(608, 161);
            this.gb_categories.TabIndex = 18;
            this.gb_categories.TabStop = false;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lblMinutes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.ForeColor = System.Drawing.Color.Snow;
            this.lblMinutes.Location = new System.Drawing.Point(348, 509);
            this.lblMinutes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(72, 21);
            this.lblMinutes.TabIndex = 17;
            this.lblMinutes.Text = "minutes";
            // 
            // txtTemps
            // 
            this.txtTemps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.txtTemps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTemps.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemps.ForeColor = System.Drawing.Color.White;
            this.txtTemps.Location = new System.Drawing.Point(256, 509);
            this.txtTemps.Margin = new System.Windows.Forms.Padding(2);
            this.txtTemps.Name = "txtTemps";
            this.txtTemps.ShortcutsEnabled = false;
            this.txtTemps.Size = new System.Drawing.Size(88, 27);
            this.txtTemps.TabIndex = 16;
            this.txtTemps.Text = "0";
            this.txtTemps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(242, 468);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Temps disponible";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(287, 277);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Budget";
            // 
            // lblRepas
            // 
            this.lblRepas.AutoSize = true;
            this.lblRepas.BackColor = System.Drawing.Color.Gray;
            this.lblRepas.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepas.ForeColor = System.Drawing.Color.Snow;
            this.lblRepas.Location = new System.Drawing.Point(256, 31);
            this.lblRepas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepas.Name = "lblRepas";
            this.lblRepas.Size = new System.Drawing.Size(158, 30);
            this.lblRepas.TabIndex = 4;
            this.lblRepas.Text = "Type de repas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::What_s_in_my_fridge.Properties.Resources.doublecarre1;
            this.pictureBox2.Location = new System.Drawing.Point(4, 19);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(652, 539);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // transitionPanel
            // 
            this.transitionPanel.Controls.Add(this.lblFiltre);
            this.transitionPanel.Controls.Add(this.lblIngredient);
            this.transitionPanel.Controls.Add(this.pcbFiltre);
            this.transitionPanel.Controls.Add(this.pcbIngredient);
            this.transitionPanel.Controls.Add(this.lblFermer);
            this.transitionPanel.Controls.Add(this.pcbFermer);
            this.transitionPanel.Controls.Add(this.lblValider);
            this.transitionPanel.Controls.Add(this.pictureBox3);
            this.transitionPanel.Controls.Add(this.tabc_choix);
            this.transitionPanel.Controls.Add(this.pictureBox5);
            this.transitionPanel.Location = new System.Drawing.Point(-25, -9);
            this.transitionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.transitionPanel.Name = "transitionPanel";
            this.transitionPanel.Size = new System.Drawing.Size(686, 700);
            this.transitionPanel.TabIndex = 15;
            // 
            // lblFiltre
            // 
            this.lblFiltre.AutoSize = true;
            this.lblFiltre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lblFiltre.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltre.Location = new System.Drawing.Point(184, 47);
            this.lblFiltre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltre.Name = "lblFiltre";
            this.lblFiltre.Size = new System.Drawing.Size(59, 23);
            this.lblFiltre.TabIndex = 44;
            this.lblFiltre.Text = "Filtre";
            this.lblFiltre.Click += new System.EventHandler(this.lblFiltre_Click);
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(126)))), ((int)(((byte)(8)))));
            this.lblIngredient.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredient.Location = new System.Drawing.Point(35, 47);
            this.lblIngredient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(119, 23);
            this.lblIngredient.TabIndex = 43;
            this.lblIngredient.Text = "Ingrédients";
            this.lblIngredient.Click += new System.EventHandler(this.lblIngredient_Click);
            // 
            // pcbFiltre
            // 
            this.pcbFiltre.Image = global::What_s_in_my_fridge.Properties.Resources.carreabordsemirond;
            this.pcbFiltre.Location = new System.Drawing.Point(159, 42);
            this.pcbFiltre.Margin = new System.Windows.Forms.Padding(2);
            this.pcbFiltre.Name = "pcbFiltre";
            this.pcbFiltre.Size = new System.Drawing.Size(110, 32);
            this.pcbFiltre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFiltre.TabIndex = 42;
            this.pcbFiltre.TabStop = false;
            // 
            // pcbIngredient
            // 
            this.pcbIngredient.Image = global::What_s_in_my_fridge.Properties.Resources.carreabordsemirondfonce;
            this.pcbIngredient.Location = new System.Drawing.Point(27, 42);
            this.pcbIngredient.Margin = new System.Windows.Forms.Padding(2);
            this.pcbIngredient.Name = "pcbIngredient";
            this.pcbIngredient.Size = new System.Drawing.Size(133, 32);
            this.pcbIngredient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIngredient.TabIndex = 37;
            this.pcbIngredient.TabStop = false;
            // 
            // lblFermer
            // 
            this.lblFermer.AutoSize = true;
            this.lblFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(226)))));
            this.lblFermer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFermer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lblFermer.Location = new System.Drawing.Point(586, 26);
            this.lblFermer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFermer.Name = "lblFermer";
            this.lblFermer.Size = new System.Drawing.Size(75, 25);
            this.lblFermer.TabIndex = 41;
            this.lblFermer.Text = "Fermer";
            this.lblFermer.Click += new System.EventHandler(this.lblFermer_Click);
            // 
            // pcbFermer
            // 
            this.pcbFermer.Image = global::What_s_in_my_fridge.Properties.Resources.carreblanc;
            this.pcbFermer.Location = new System.Drawing.Point(567, 15);
            this.pcbFermer.Margin = new System.Windows.Forms.Padding(2);
            this.pcbFermer.Name = "pcbFermer";
            this.pcbFermer.Size = new System.Drawing.Size(113, 48);
            this.pcbFermer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFermer.TabIndex = 40;
            this.pcbFermer.TabStop = false;
            this.pcbFermer.Click += new System.EventHandler(this.pcbFermer_Click);
            // 
            // lblValider
            // 
            this.lblValider.AutoSize = true;
            this.lblValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblValider.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lblValider.Location = new System.Drawing.Point(318, 656);
            this.lblValider.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValider.Name = "lblValider";
            this.lblValider.Size = new System.Drawing.Size(71, 25);
            this.lblValider.TabIndex = 16;
            this.lblValider.Text = "Valider";
            this.lblValider.Click += new System.EventHandler(this.lblValider_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::What_s_in_my_fridge.Properties.Resources.image_2023_05_15_163741969;
            this.pictureBox3.Location = new System.Drawing.Point(279, 19);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(167, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = global::What_s_in_my_fridge.Properties.Resources.carrenoir;
            this.pictureBox5.Location = new System.Drawing.Point(293, 644);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(123, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // frmIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(662, 693);
            this.Controls.Add(this.transitionPanel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmIngredients";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fridgeo";
            this.Load += new System.EventHandler(this.Ingredients_Load);
            this.tabc_choix.ResumeLayout(false);
            this.taPIngredients.ResumeLayout(false);
            this.taPIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCroix3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCroix2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCroix1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.taPFiltres.ResumeLayout(false);
            this.taPFiltres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.transitionPanel.ResumeLayout(false);
            this.transitionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFiltre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIngredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFermer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_zone_famille;
        private System.Windows.Forms.Label lbl_famille;
        private System.Windows.Forms.TabControl tabc_choix;
        private System.Windows.Forms.TabPage taPIngredients;
        private System.Windows.Forms.TabPage taPFiltres;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel transitionPanel;
        private System.Windows.Forms.Label lblValider;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblRepas;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.TextBox txtTemps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_ing3;
        private System.Windows.Forms.Label lbl_ing2;
        private System.Windows.Forms.Label lbl_ing1;
        private System.Windows.Forms.Label lblFermer;
        private System.Windows.Forms.PictureBox pcbFermer;
        private System.Windows.Forms.GroupBox gb_ingredients;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pcbCroix1;
        private System.Windows.Forms.PictureBox pcbCroix3;
        private System.Windows.Forms.PictureBox pcbCroix2;
        private System.Windows.Forms.PictureBox pcbIngredient;
        private System.Windows.Forms.PictureBox pcbFiltre;
        private System.Windows.Forms.Label lblFiltre;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.GroupBox gb_categories;
        private System.Windows.Forms.Label lblmax;
        private System.Windows.Forms.Label lblmoy;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}