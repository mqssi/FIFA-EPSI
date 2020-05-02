namespace FIFAUi
{
    partial class Creation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creation));
            this.creationLabel = new System.Windows.Forms.Label();
            this.nomTournoiLabel = new System.Windows.Forms.Label();
            this.nomTournoiValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.joueursTournoiDropdown = new System.Windows.Forms.ComboBox();
            this.ajouterJoueurBox = new System.Windows.Forms.GroupBox();
            this.creationJoueurButton = new System.Windows.Forms.Button();
            this.equipeJoueurValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mailJoueurValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prenomJoueurValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nomJoueurValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pseudoJoueurValue = new System.Windows.Forms.TextBox();
            this.pseudoJoueurLabel = new System.Windows.Forms.Label();
            this.creationTournoiButton = new System.Windows.Forms.Button();
            this.joueursListBox = new System.Windows.Forms.ListBox();
            this.supprimerJoueurButton = new System.Windows.Forms.Button();
            this.ajouterJoueurTournoiButton = new System.Windows.Forms.Button();
            this.ajouterJoueurBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // creationLabel
            // 
            this.creationLabel.AutoSize = true;
            this.creationLabel.Font = new System.Drawing.Font("Montserrat Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationLabel.Location = new System.Drawing.Point(431, 41);
            this.creationLabel.Name = "creationLabel";
            this.creationLabel.Size = new System.Drawing.Size(278, 38);
            this.creationLabel.TabIndex = 1;
            this.creationLabel.Text = "Création Tournoi";
            // 
            // nomTournoiLabel
            // 
            this.nomTournoiLabel.AutoSize = true;
            this.nomTournoiLabel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTournoiLabel.Location = new System.Drawing.Point(41, 139);
            this.nomTournoiLabel.Name = "nomTournoiLabel";
            this.nomTournoiLabel.Size = new System.Drawing.Size(185, 25);
            this.nomTournoiLabel.TabIndex = 2;
            this.nomTournoiLabel.Text = "Nom du Tournoi:";
            // 
            // nomTournoiValue
            // 
            this.nomTournoiValue.Location = new System.Drawing.Point(253, 139);
            this.nomTournoiValue.Name = "nomTournoiValue";
            this.nomTournoiValue.Size = new System.Drawing.Size(206, 30);
            this.nomTournoiValue.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Joueurs du Tournoi:";
            // 
            // joueursTournoiDropdown
            // 
            this.joueursTournoiDropdown.FormattingEnabled = true;
            this.joueursTournoiDropdown.Location = new System.Drawing.Point(253, 214);
            this.joueursTournoiDropdown.Name = "joueursTournoiDropdown";
            this.joueursTournoiDropdown.Size = new System.Drawing.Size(206, 31);
            this.joueursTournoiDropdown.TabIndex = 5;
            // 
            // ajouterJoueurBox
            // 
            this.ajouterJoueurBox.Controls.Add(this.creationJoueurButton);
            this.ajouterJoueurBox.Controls.Add(this.equipeJoueurValue);
            this.ajouterJoueurBox.Controls.Add(this.label5);
            this.ajouterJoueurBox.Controls.Add(this.mailJoueurValue);
            this.ajouterJoueurBox.Controls.Add(this.label4);
            this.ajouterJoueurBox.Controls.Add(this.prenomJoueurValue);
            this.ajouterJoueurBox.Controls.Add(this.label3);
            this.ajouterJoueurBox.Controls.Add(this.nomJoueurValue);
            this.ajouterJoueurBox.Controls.Add(this.label2);
            this.ajouterJoueurBox.Controls.Add(this.pseudoJoueurValue);
            this.ajouterJoueurBox.Controls.Add(this.pseudoJoueurLabel);
            this.ajouterJoueurBox.Location = new System.Drawing.Point(74, 345);
            this.ajouterJoueurBox.Name = "ajouterJoueurBox";
            this.ajouterJoueurBox.Size = new System.Drawing.Size(385, 404);
            this.ajouterJoueurBox.TabIndex = 6;
            this.ajouterJoueurBox.TabStop = false;
            this.ajouterJoueurBox.Text = "Ajouter un joueur:";
            // 
            // creationJoueurButton
            // 
            this.creationJoueurButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.creationJoueurButton.FlatAppearance.BorderSize = 2;
            this.creationJoueurButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.creationJoueurButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.creationJoueurButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creationJoueurButton.Location = new System.Drawing.Point(110, 337);
            this.creationJoueurButton.Name = "creationJoueurButton";
            this.creationJoueurButton.Size = new System.Drawing.Size(169, 42);
            this.creationJoueurButton.TabIndex = 7;
            this.creationJoueurButton.Text = "Créer Joueur";
            this.creationJoueurButton.UseVisualStyleBackColor = true;
            this.creationJoueurButton.Click += new System.EventHandler(this.creationJoueurButton_Click);
            // 
            // equipeJoueurValue
            // 
            this.equipeJoueurValue.Location = new System.Drawing.Point(179, 261);
            this.equipeJoueurValue.Name = "equipeJoueurValue";
            this.equipeJoueurValue.Size = new System.Drawing.Size(171, 30);
            this.equipeJoueurValue.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Equipe:";
            // 
            // mailJoueurValue
            // 
            this.mailJoueurValue.Location = new System.Drawing.Point(179, 205);
            this.mailJoueurValue.Name = "mailJoueurValue";
            this.mailJoueurValue.Size = new System.Drawing.Size(171, 30);
            this.mailJoueurValue.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mail:";
            // 
            // prenomJoueurValue
            // 
            this.prenomJoueurValue.Location = new System.Drawing.Point(179, 151);
            this.prenomJoueurValue.Name = "prenomJoueurValue";
            this.prenomJoueurValue.Size = new System.Drawing.Size(171, 30);
            this.prenomJoueurValue.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prénom:";
            // 
            // nomJoueurValue
            // 
            this.nomJoueurValue.Location = new System.Drawing.Point(179, 97);
            this.nomJoueurValue.Name = "nomJoueurValue";
            this.nomJoueurValue.Size = new System.Drawing.Size(171, 30);
            this.nomJoueurValue.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom:";
            // 
            // pseudoJoueurValue
            // 
            this.pseudoJoueurValue.Location = new System.Drawing.Point(179, 43);
            this.pseudoJoueurValue.Name = "pseudoJoueurValue";
            this.pseudoJoueurValue.Size = new System.Drawing.Size(171, 30);
            this.pseudoJoueurValue.TabIndex = 4;
            // 
            // pseudoJoueurLabel
            // 
            this.pseudoJoueurLabel.AutoSize = true;
            this.pseudoJoueurLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pseudoJoueurLabel.Location = new System.Drawing.Point(42, 46);
            this.pseudoJoueurLabel.Name = "pseudoJoueurLabel";
            this.pseudoJoueurLabel.Size = new System.Drawing.Size(84, 23);
            this.pseudoJoueurLabel.TabIndex = 3;
            this.pseudoJoueurLabel.Text = "Pseudo:";
            // 
            // creationTournoiButton
            // 
            this.creationTournoiButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.creationTournoiButton.FlatAppearance.BorderSize = 2;
            this.creationTournoiButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.creationTournoiButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.creationTournoiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creationTournoiButton.Location = new System.Drawing.Point(407, 734);
            this.creationTournoiButton.Name = "creationTournoiButton";
            this.creationTournoiButton.Size = new System.Drawing.Size(247, 78);
            this.creationTournoiButton.TabIndex = 8;
            this.creationTournoiButton.Text = "Créer le Tournoi";
            this.creationTournoiButton.UseVisualStyleBackColor = true;
            // 
            // joueursListBox
            // 
            this.joueursListBox.FormattingEnabled = true;
            this.joueursListBox.ItemHeight = 23;
            this.joueursListBox.Location = new System.Drawing.Point(556, 127);
            this.joueursListBox.Name = "joueursListBox";
            this.joueursListBox.Size = new System.Drawing.Size(309, 556);
            this.joueursListBox.TabIndex = 9;
            // 
            // supprimerJoueurButton
            // 
            this.supprimerJoueurButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.supprimerJoueurButton.FlatAppearance.BorderSize = 2;
            this.supprimerJoueurButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.supprimerJoueurButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.supprimerJoueurButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimerJoueurButton.ForeColor = System.Drawing.Color.Red;
            this.supprimerJoueurButton.Location = new System.Drawing.Point(907, 306);
            this.supprimerJoueurButton.Name = "supprimerJoueurButton";
            this.supprimerJoueurButton.Size = new System.Drawing.Size(158, 62);
            this.supprimerJoueurButton.TabIndex = 10;
            this.supprimerJoueurButton.Text = "Supprimer Joueur";
            this.supprimerJoueurButton.UseVisualStyleBackColor = true;
            // 
            // ajouterJoueurTournoiButton
            // 
            this.ajouterJoueurTournoiButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.ajouterJoueurTournoiButton.FlatAppearance.BorderSize = 2;
            this.ajouterJoueurTournoiButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.ajouterJoueurTournoiButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ajouterJoueurTournoiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouterJoueurTournoiButton.Location = new System.Drawing.Point(156, 266);
            this.ajouterJoueurTournoiButton.Name = "ajouterJoueurTournoiButton";
            this.ajouterJoueurTournoiButton.Size = new System.Drawing.Size(212, 51);
            this.ajouterJoueurTournoiButton.TabIndex = 11;
            this.ajouterJoueurTournoiButton.Text = "Ajouter au tournoi";
            this.ajouterJoueurTournoiButton.UseVisualStyleBackColor = true;
            this.ajouterJoueurTournoiButton.Click += new System.EventHandler(this.ajouterJoueurTournoiButton_Click);
            // 
            // Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1123, 862);
            this.Controls.Add(this.ajouterJoueurTournoiButton);
            this.Controls.Add(this.supprimerJoueurButton);
            this.Controls.Add(this.joueursListBox);
            this.Controls.Add(this.creationTournoiButton);
            this.Controls.Add(this.ajouterJoueurBox);
            this.Controls.Add(this.joueursTournoiDropdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomTournoiValue);
            this.Controls.Add(this.nomTournoiLabel);
            this.Controls.Add(this.creationLabel);
            this.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Creation";
            this.Text = "Creation";
            this.ajouterJoueurBox.ResumeLayout(false);
            this.ajouterJoueurBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creationLabel;
        private System.Windows.Forms.Label nomTournoiLabel;
        private System.Windows.Forms.TextBox nomTournoiValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox joueursTournoiDropdown;
        private System.Windows.Forms.GroupBox ajouterJoueurBox;
        private System.Windows.Forms.Label pseudoJoueurLabel;
        private System.Windows.Forms.TextBox prenomJoueurValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomJoueurValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox equipeJoueurValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mailJoueurValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button creationJoueurButton;
        private System.Windows.Forms.Button creationTournoiButton;
        private System.Windows.Forms.ListBox joueursListBox;
        private System.Windows.Forms.Button supprimerJoueurButton;
        private System.Windows.Forms.TextBox pseudoJoueurValue;
        private System.Windows.Forms.Button ajouterJoueurTournoiButton;
    }
}