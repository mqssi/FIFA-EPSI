namespace FIFAUi
{
    partial class infos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infos));
            this.creationTournoiLabel = new System.Windows.Forms.Label();
            this.infosLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nePAScliquerBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // creationTournoiLabel
            // 
            this.creationTournoiLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.creationTournoiLabel.AutoSize = true;
            this.creationTournoiLabel.Font = new System.Drawing.Font("Montserrat Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationTournoiLabel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.creationTournoiLabel.Location = new System.Drawing.Point(443, 95);
            this.creationTournoiLabel.Name = "creationTournoiLabel";
            this.creationTournoiLabel.Size = new System.Drawing.Size(263, 38);
            this.creationTournoiLabel.TabIndex = 6;
            this.creationTournoiLabel.Text = "CROSSED_EPSI";
            // 
            // infosLabel
            // 
            this.infosLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infosLabel.AutoSize = true;
            this.infosLabel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infosLabel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.infosLabel.Location = new System.Drawing.Point(101, 158);
            this.infosLabel.Name = "infosLabel";
            this.infosLabel.Size = new System.Drawing.Size(934, 400);
            this.infosLabel.TabIndex = 7;
            this.infosLabel.Text = resources.GetString("infosLabel.Text");
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nePAScliquerBtn
            // 
            this.nePAScliquerBtn.FlatAppearance.BorderSize = 3;
            this.nePAScliquerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nePAScliquerBtn.ForeColor = System.Drawing.Color.Red;
            this.nePAScliquerBtn.Image = global::FIFAUi.Properties.Resources.nukkke;
            this.nePAScliquerBtn.Location = new System.Drawing.Point(1000, 476);
            this.nePAScliquerBtn.Name = "nePAScliquerBtn";
            this.nePAScliquerBtn.Size = new System.Drawing.Size(74, 67);
            this.nePAScliquerBtn.TabIndex = 9;
            this.nePAScliquerBtn.UseVisualStyleBackColor = true;
            this.nePAScliquerBtn.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::FIFAUi.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(523, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // infos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1125, 599);
            this.Controls.Add(this.nePAScliquerBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.infosLabel);
            this.Controls.Add(this.creationTournoiLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "infos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "infos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label creationTournoiLabel;
        private System.Windows.Forms.Label infosLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nePAScliquerBtn;
    }
}