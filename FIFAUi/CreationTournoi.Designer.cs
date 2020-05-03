namespace FIFAUi
{
    partial class CreationTournoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreationTournoi));
            this.creationTournoiLabel = new System.Windows.Forms.Label();
            this.nomTournoiValue = new System.Windows.Forms.TextBox();
            this.nomTournoiLabel = new System.Windows.Forms.Label();
            this.selectEquipeDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createEquipelinkLabel = new System.Windows.Forms.LinkLabel();
            this.ajouterEquipeTournoiButton = new System.Windows.Forms.Button();
            this.equipesTournoisLabel = new System.Windows.Forms.Label();
            this.equipesTournoiListBox = new System.Windows.Forms.ListBox();
            this.retirerEquipeButton = new System.Windows.Forms.Button();
            this.creationTournoiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // creationTournoiLabel
            // 
            this.creationTournoiLabel.AutoSize = true;
            this.creationTournoiLabel.Font = new System.Drawing.Font("Montserrat Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationTournoiLabel.Location = new System.Drawing.Point(350, 38);
            this.creationTournoiLabel.Name = "creationTournoiLabel";
            this.creationTournoiLabel.Size = new System.Drawing.Size(278, 38);
            this.creationTournoiLabel.TabIndex = 2;
            this.creationTournoiLabel.Text = "Création Tournoi";
            // 
            // nomTournoiValue
            // 
            this.nomTournoiValue.Location = new System.Drawing.Point(253, 176);
            this.nomTournoiValue.Name = "nomTournoiValue";
            this.nomTournoiValue.Size = new System.Drawing.Size(210, 27);
            this.nomTournoiValue.TabIndex = 5;
            // 
            // nomTournoiLabel
            // 
            this.nomTournoiLabel.AutoSize = true;
            this.nomTournoiLabel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTournoiLabel.Location = new System.Drawing.Point(45, 176);
            this.nomTournoiLabel.Name = "nomTournoiLabel";
            this.nomTournoiLabel.Size = new System.Drawing.Size(181, 25);
            this.nomTournoiLabel.TabIndex = 4;
            this.nomTournoiLabel.Text = "Nom du Tournoi";
            // 
            // selectEquipeDropdown
            // 
            this.selectEquipeDropdown.FormattingEnabled = true;
            this.selectEquipeDropdown.Location = new System.Drawing.Point(253, 251);
            this.selectEquipeDropdown.Name = "selectEquipeDropdown";
            this.selectEquipeDropdown.Size = new System.Drawing.Size(210, 27);
            this.selectEquipeDropdown.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choisir équipe:";
            // 
            // createEquipelinkLabel
            // 
            this.createEquipelinkLabel.AutoSize = true;
            this.createEquipelinkLabel.Location = new System.Drawing.Point(353, 229);
            this.createEquipelinkLabel.Name = "createEquipelinkLabel";
            this.createEquipelinkLabel.Size = new System.Drawing.Size(110, 19);
            this.createEquipelinkLabel.TabIndex = 8;
            this.createEquipelinkLabel.TabStop = true;
            this.createEquipelinkLabel.Text = "Créer Equipe";
            this.createEquipelinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createEquipelinkLabel_LinkClicked);
            // 
            // ajouterEquipeTournoiButton
            // 
            this.ajouterEquipeTournoiButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.ajouterEquipeTournoiButton.FlatAppearance.BorderSize = 2;
            this.ajouterEquipeTournoiButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.ajouterEquipeTournoiButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ajouterEquipeTournoiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouterEquipeTournoiButton.Location = new System.Drawing.Point(153, 347);
            this.ajouterEquipeTournoiButton.Name = "ajouterEquipeTournoiButton";
            this.ajouterEquipeTournoiButton.Size = new System.Drawing.Size(212, 51);
            this.ajouterEquipeTournoiButton.TabIndex = 12;
            this.ajouterEquipeTournoiButton.Text = "Ajouter l\'équipe";
            this.ajouterEquipeTournoiButton.UseVisualStyleBackColor = true;
            this.ajouterEquipeTournoiButton.Click += new System.EventHandler(this.ajouterEquipeTournoiButton_Click);
            // 
            // equipesTournoisLabel
            // 
            this.equipesTournoisLabel.AutoSize = true;
            this.equipesTournoisLabel.Font = new System.Drawing.Font("Montserrat Light", 16F);
            this.equipesTournoisLabel.Location = new System.Drawing.Point(595, 128);
            this.equipesTournoisLabel.Name = "equipesTournoisLabel";
            this.equipesTournoisLabel.Size = new System.Drawing.Size(220, 26);
            this.equipesTournoisLabel.TabIndex = 14;
            this.equipesTournoisLabel.Text = "Equipes du Tournoi";
            // 
            // equipesTournoiListBox
            // 
            this.equipesTournoiListBox.FormattingEnabled = true;
            this.equipesTournoiListBox.ItemHeight = 19;
            this.equipesTournoiListBox.Location = new System.Drawing.Point(600, 157);
            this.equipesTournoiListBox.Name = "equipesTournoiListBox";
            this.equipesTournoiListBox.Size = new System.Drawing.Size(240, 270);
            this.equipesTournoiListBox.TabIndex = 13;
            // 
            // retirerEquipeButton
            // 
            this.retirerEquipeButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.retirerEquipeButton.FlatAppearance.BorderSize = 2;
            this.retirerEquipeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.retirerEquipeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.retirerEquipeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retirerEquipeButton.ForeColor = System.Drawing.Color.Red;
            this.retirerEquipeButton.Location = new System.Drawing.Point(867, 251);
            this.retirerEquipeButton.Name = "retirerEquipeButton";
            this.retirerEquipeButton.Size = new System.Drawing.Size(130, 62);
            this.retirerEquipeButton.TabIndex = 15;
            this.retirerEquipeButton.Text = "Retirer Equipe";
            this.retirerEquipeButton.UseVisualStyleBackColor = true;
            this.retirerEquipeButton.Click += new System.EventHandler(this.retirerEquipeButton_Click);
            // 
            // creationTournoiButton
            // 
            this.creationTournoiButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.creationTournoiButton.FlatAppearance.BorderSize = 2;
            this.creationTournoiButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.creationTournoiButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.creationTournoiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creationTournoiButton.Location = new System.Drawing.Point(402, 477);
            this.creationTournoiButton.Name = "creationTournoiButton";
            this.creationTournoiButton.Size = new System.Drawing.Size(214, 73);
            this.creationTournoiButton.TabIndex = 16;
            this.creationTournoiButton.Text = "Créer Tournoi";
            this.creationTournoiButton.UseVisualStyleBackColor = true;
            this.creationTournoiButton.Click += new System.EventHandler(this.creationTournoiButton_Click);
            // 
            // CreationTournoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 608);
            this.Controls.Add(this.creationTournoiButton);
            this.Controls.Add(this.retirerEquipeButton);
            this.Controls.Add(this.equipesTournoisLabel);
            this.Controls.Add(this.equipesTournoiListBox);
            this.Controls.Add(this.ajouterEquipeTournoiButton);
            this.Controls.Add(this.createEquipelinkLabel);
            this.Controls.Add(this.selectEquipeDropdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomTournoiValue);
            this.Controls.Add(this.nomTournoiLabel);
            this.Controls.Add(this.creationTournoiLabel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CreationTournoi";
            this.Text = "Créer Tournoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creationTournoiLabel;
        private System.Windows.Forms.TextBox nomTournoiValue;
        private System.Windows.Forms.Label nomTournoiLabel;
        private System.Windows.Forms.ComboBox selectEquipeDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel createEquipelinkLabel;
        private System.Windows.Forms.Button ajouterEquipeTournoiButton;
        private System.Windows.Forms.Label equipesTournoisLabel;
        private System.Windows.Forms.ListBox equipesTournoiListBox;
        private System.Windows.Forms.Button retirerEquipeButton;
        private System.Windows.Forms.Button creationTournoiButton;
    }
}