namespace FIFAUi
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.label1 = new System.Windows.Forms.Label();
            this.infosButton = new System.Windows.Forms.Button();
            this.jouerButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.musicButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(280, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "CROSSED_EPSI";
            // 
            // infosButton
            // 
            this.infosButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infosButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.infosButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.infosButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.infosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infosButton.ForeColor = System.Drawing.Color.Azure;
            this.infosButton.Location = new System.Drawing.Point(80, 381);
            this.infosButton.Name = "infosButton";
            this.infosButton.Size = new System.Drawing.Size(168, 73);
            this.infosButton.TabIndex = 1;
            this.infosButton.Text = "Infos";
            this.infosButton.UseVisualStyleBackColor = true;
            this.infosButton.Click += new System.EventHandler(this.infosButton_Click);
            // 
            // jouerButton
            // 
            this.jouerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.jouerButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.jouerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.jouerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.jouerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jouerButton.ForeColor = System.Drawing.Color.Azure;
            this.jouerButton.Location = new System.Drawing.Point(331, 381);
            this.jouerButton.Name = "jouerButton";
            this.jouerButton.Size = new System.Drawing.Size(168, 73);
            this.jouerButton.TabIndex = 2;
            this.jouerButton.Text = "Jouer";
            this.jouerButton.UseVisualStyleBackColor = true;
            this.jouerButton.Click += new System.EventHandler(this.jouerButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Azure;
            this.button2.Location = new System.Drawing.Point(570, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 73);
            this.button2.TabIndex = 3;
            this.button2.Text = "Parties en cours";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // musicButton
            // 
            this.musicButton.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.musicButton.Location = new System.Drawing.Point(80, 122);
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(77, 61);
            this.musicButton.TabIndex = 5;
            this.musicButton.Text = "music";
            this.musicButton.UseVisualStyleBackColor = true;
            this.musicButton.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Location = new System.Drawing.Point(80, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "pause";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::FIFAUi.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(304, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(797, 572);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.musicButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.jouerButton);
            this.Controls.Add(this.infosButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIFAEPSI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button infosButton;
        private System.Windows.Forms.Button jouerButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button musicButton;
        private System.Windows.Forms.Button button1;
    }
}

