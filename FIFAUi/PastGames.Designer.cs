namespace FIFAUi
{
    partial class PastGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PastGames));
            this.creationTournoiLabel = new System.Windows.Forms.Label();
            this.LoadCompsDropDown = new System.Windows.Forms.ComboBox();
            this.LoadCompButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // creationTournoiLabel
            // 
            this.creationTournoiLabel.AutoSize = true;
            this.creationTournoiLabel.Font = new System.Drawing.Font("Montserrat Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationTournoiLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.creationTournoiLabel.Location = new System.Drawing.Point(200, 80);
            this.creationTournoiLabel.Name = "creationTournoiLabel";
            this.creationTournoiLabel.Size = new System.Drawing.Size(377, 38);
            this.creationTournoiLabel.TabIndex = 3;
            this.creationTournoiLabel.Text = "Compétitions en cours:";
            // 
            // LoadCompsDropDown
            // 
            this.LoadCompsDropDown.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadCompsDropDown.FormattingEnabled = true;
            this.LoadCompsDropDown.Location = new System.Drawing.Point(252, 137);
            this.LoadCompsDropDown.Name = "LoadCompsDropDown";
            this.LoadCompsDropDown.Size = new System.Drawing.Size(267, 33);
            this.LoadCompsDropDown.TabIndex = 4;
            // 
            // LoadCompButton
            // 
            this.LoadCompButton.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadCompButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LoadCompButton.Location = new System.Drawing.Point(252, 216);
            this.LoadCompButton.Name = "LoadCompButton";
            this.LoadCompButton.Size = new System.Drawing.Size(267, 67);
            this.LoadCompButton.TabIndex = 5;
            this.LoadCompButton.Text = "Charger Compétition";
            this.LoadCompButton.UseVisualStyleBackColor = true;
            this.LoadCompButton.Click += new System.EventHandler(this.LoadCompButton_Click);
            // 
            // PastGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadCompButton);
            this.Controls.Add(this.LoadCompsDropDown);
            this.Controls.Add(this.creationTournoiLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PastGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PastGames";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creationTournoiLabel;
        private System.Windows.Forms.ComboBox LoadCompsDropDown;
        private System.Windows.Forms.Button LoadCompButton;
    }
}