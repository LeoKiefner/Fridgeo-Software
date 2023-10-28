namespace What_s_in_my_fridge
{
    partial class frmRecettes
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblRetour = new System.Windows.Forms.Label();
            this.gbp_recette = new System.Windows.Forms.GroupBox();
            this.lbl_page = new System.Windows.Forms.Label();
            this.lblFermer = new System.Windows.Forms.Label();
            this.pcbFermer = new System.Windows.Forms.PictureBox();
            this.pcb_fleche_avancer = new System.Windows.Forms.PictureBox();
            this.pcb_fleche_reculer = new System.Windows.Forms.PictureBox();
            this.pcbRetour = new System.Windows.Forms.PictureBox();
            this.pcbFondRecettes = new System.Windows.Forms.PictureBox();
            this.pcbFridgeo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFermer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fleche_avancer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fleche_reculer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRetour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFondRecettes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFridgeo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Gray;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Snow;
            this.lblTitre.Location = new System.Drawing.Point(281, 108);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(101, 30);
            this.lblTitre.TabIndex = 19;
            this.lblTitre.Text = "Recettes";
            // 
            // lblRetour
            // 
            this.lblRetour.AutoSize = true;
            this.lblRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(226)))));
            this.lblRetour.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lblRetour.Location = new System.Drawing.Point(38, 29);
            this.lblRetour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRetour.Name = "lblRetour";
            this.lblRetour.Size = new System.Drawing.Size(73, 25);
            this.lblRetour.TabIndex = 39;
            this.lblRetour.Text = "Retour";
            this.lblRetour.Click += new System.EventHandler(this.lblRetour_Click);
            // 
            // gbp_recette
            // 
            this.gbp_recette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.gbp_recette.Location = new System.Drawing.Point(26, 167);
            this.gbp_recette.Name = "gbp_recette";
            this.gbp_recette.Size = new System.Drawing.Size(615, 448);
            this.gbp_recette.TabIndex = 40;
            this.gbp_recette.TabStop = false;
            // 
            // lbl_page
            // 
            this.lbl_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lbl_page.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_page.ForeColor = System.Drawing.Color.White;
            this.lbl_page.Location = new System.Drawing.Point(272, 631);
            this.lbl_page.Name = "lbl_page";
            this.lbl_page.Size = new System.Drawing.Size(122, 29);
            this.lbl_page.TabIndex = 41;
            this.lbl_page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFermer
            // 
            this.lblFermer.AutoSize = true;
            this.lblFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(226)))));
            this.lblFermer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFermer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.lblFermer.Location = new System.Drawing.Point(555, 29);
            this.lblFermer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFermer.Name = "lblFermer";
            this.lblFermer.Size = new System.Drawing.Size(75, 25);
            this.lblFermer.TabIndex = 52;
            this.lblFermer.Text = "Fermer";
            this.lblFermer.Click += new System.EventHandler(this.lblFermer_Click);
            // 
            // pcbFermer
            // 
            this.pcbFermer.Image = global::What_s_in_my_fridge.Properties.Resources.carreblanc;
            this.pcbFermer.Location = new System.Drawing.Point(536, 18);
            this.pcbFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcbFermer.Name = "pcbFermer";
            this.pcbFermer.Size = new System.Drawing.Size(113, 48);
            this.pcbFermer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFermer.TabIndex = 51;
            this.pcbFermer.TabStop = false;
            this.pcbFermer.Click += new System.EventHandler(this.pcbFermer_Click);
            // 
            // pcb_fleche_avancer
            // 
            this.pcb_fleche_avancer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.pcb_fleche_avancer.Image = global::What_s_in_my_fridge.Properties.Resources.flechedroite;
            this.pcb_fleche_avancer.Location = new System.Drawing.Point(400, 618);
            this.pcb_fleche_avancer.Name = "pcb_fleche_avancer";
            this.pcb_fleche_avancer.Size = new System.Drawing.Size(52, 57);
            this.pcb_fleche_avancer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_fleche_avancer.TabIndex = 43;
            this.pcb_fleche_avancer.TabStop = false;
            this.pcb_fleche_avancer.Click += new System.EventHandler(this.pcb_fleche_avancer_Click);
            // 
            // pcb_fleche_reculer
            // 
            this.pcb_fleche_reculer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.pcb_fleche_reculer.Image = global::What_s_in_my_fridge.Properties.Resources.flechegauche;
            this.pcb_fleche_reculer.Location = new System.Drawing.Point(214, 618);
            this.pcb_fleche_reculer.Name = "pcb_fleche_reculer";
            this.pcb_fleche_reculer.Size = new System.Drawing.Size(52, 57);
            this.pcb_fleche_reculer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_fleche_reculer.TabIndex = 42;
            this.pcb_fleche_reculer.TabStop = false;
            this.pcb_fleche_reculer.Click += new System.EventHandler(this.pcb_fleche_reculer_Click);
            // 
            // pcbRetour
            // 
            this.pcbRetour.Image = global::What_s_in_my_fridge.Properties.Resources.carreblanc;
            this.pcbRetour.Location = new System.Drawing.Point(17, 19);
            this.pcbRetour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcbRetour.Name = "pcbRetour";
            this.pcbRetour.Size = new System.Drawing.Size(113, 48);
            this.pcbRetour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRetour.TabIndex = 38;
            this.pcbRetour.TabStop = false;
            this.pcbRetour.Click += new System.EventHandler(this.pcbRetour_Click);
            // 
            // pcbFondRecettes
            // 
            this.pcbFondRecettes.Image = global::What_s_in_my_fridge.Properties.Resources.fondfrmRecettes;
            this.pcbFondRecettes.Location = new System.Drawing.Point(1, 89);
            this.pcbFondRecettes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcbFondRecettes.Name = "pcbFondRecettes";
            this.pcbFondRecettes.Size = new System.Drawing.Size(668, 595);
            this.pcbFondRecettes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFondRecettes.TabIndex = 18;
            this.pcbFondRecettes.TabStop = false;
            // 
            // pcbFridgeo
            // 
            this.pcbFridgeo.Image = global::What_s_in_my_fridge.Properties.Resources.image_2023_05_15_163741969;
            this.pcbFridgeo.Location = new System.Drawing.Point(248, 29);
            this.pcbFridgeo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcbFridgeo.Name = "pcbFridgeo";
            this.pcbFridgeo.Size = new System.Drawing.Size(167, 65);
            this.pcbFridgeo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFridgeo.TabIndex = 17;
            this.pcbFridgeo.TabStop = false;
            // 
            // frmRecettes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(662, 693);
            this.Controls.Add(this.lblFermer);
            this.Controls.Add(this.pcbFermer);
            this.Controls.Add(this.pcb_fleche_avancer);
            this.Controls.Add(this.pcb_fleche_reculer);
            this.Controls.Add(this.lbl_page);
            this.Controls.Add(this.gbp_recette);
            this.Controls.Add(this.lblRetour);
            this.Controls.Add(this.pcbRetour);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.pcbFondRecettes);
            this.Controls.Add(this.pcbFridgeo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRecettes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fridgeo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmRecettes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFermer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fleche_avancer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_fleche_reculer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRetour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFondRecettes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFridgeo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbFridgeo;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox pcbRetour;
        private System.Windows.Forms.Label lblRetour;
        private System.Windows.Forms.PictureBox pcbFondRecettes;
        private System.Windows.Forms.GroupBox gbp_recette;
        private System.Windows.Forms.Label lbl_page;
        private System.Windows.Forms.PictureBox pcb_fleche_reculer;
        private System.Windows.Forms.PictureBox pcb_fleche_avancer;
        private System.Windows.Forms.Label lblFermer;
        private System.Windows.Forms.PictureBox pcbFermer;
    }
}