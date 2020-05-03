namespace FIFAUi
{
    partial class TournoiViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournoiViewer));
            this.TournoiLabel = new System.Windows.Forms.Label();
            this.nomTournoiLabel = new System.Windows.Forms.Label();
            this.roundDropdown = new System.Windows.Forms.ComboBox();
            this.roundLabel = new System.Windows.Forms.Label();
            this.matchUpListBox = new System.Windows.Forms.ListBox();
            this.equipe1Label = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreEquipe1Value = new System.Windows.Forms.TextBox();
            this.scoreEquipe2Value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.equipe2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TournoiLabel
            // 
            this.TournoiLabel.AutoSize = true;
            this.TournoiLabel.Font = new System.Drawing.Font("Montserrat Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournoiLabel.Location = new System.Drawing.Point(25, 31);
            this.TournoiLabel.Name = "TournoiLabel";
            this.TournoiLabel.Size = new System.Drawing.Size(151, 38);
            this.TournoiLabel.TabIndex = 3;
            this.TournoiLabel.Text = "Tournoi :";
            // 
            // nomTournoiLabel
            // 
            this.nomTournoiLabel.AutoSize = true;
            this.nomTournoiLabel.Font = new System.Drawing.Font("Montserrat Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTournoiLabel.Location = new System.Drawing.Point(182, 31);
            this.nomTournoiLabel.Name = "nomTournoiLabel";
            this.nomTournoiLabel.Size = new System.Drawing.Size(49, 38);
            this.nomTournoiLabel.TabIndex = 4;
            this.nomTournoiLabel.Text = "<>";
            // 
            // roundDropdown
            // 
            this.roundDropdown.FormattingEnabled = true;
            this.roundDropdown.Location = new System.Drawing.Point(104, 121);
            this.roundDropdown.Name = "roundDropdown";
            this.roundDropdown.Size = new System.Drawing.Size(127, 27);
            this.roundDropdown.TabIndex = 9;
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.Location = new System.Drawing.Point(12, 123);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(86, 25);
            this.roundLabel.TabIndex = 8;
            this.roundLabel.Text = "Round:";
            // 
            // matchUpListBox
            // 
            this.matchUpListBox.FormattingEnabled = true;
            this.matchUpListBox.ItemHeight = 19;
            this.matchUpListBox.Location = new System.Drawing.Point(42, 173);
            this.matchUpListBox.Name = "matchUpListBox";
            this.matchUpListBox.Size = new System.Drawing.Size(203, 213);
            this.matchUpListBox.TabIndex = 14;
            // 
            // equipe1Label
            // 
            this.equipe1Label.AutoSize = true;
            this.equipe1Label.Font = new System.Drawing.Font("Montserrat Light", 18F);
            this.equipe1Label.Location = new System.Drawing.Point(374, 154);
            this.equipe1Label.Name = "equipe1Label";
            this.equipe1Label.Size = new System.Drawing.Size(128, 29);
            this.equipe1Label.TabIndex = 15;
            this.equipe1Label.Text = "<equipe1>";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Montserrat Light", 16F);
            this.scoreLabel.Location = new System.Drawing.Point(333, 202);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(71, 26);
            this.scoreLabel.TabIndex = 16;
            this.scoreLabel.Text = "Score";
            // 
            // scoreEquipe1Value
            // 
            this.scoreEquipe1Value.Location = new System.Drawing.Point(410, 204);
            this.scoreEquipe1Value.Name = "scoreEquipe1Value";
            this.scoreEquipe1Value.Size = new System.Drawing.Size(101, 27);
            this.scoreEquipe1Value.TabIndex = 17;
            // 
            // scoreEquipe2Value
            // 
            this.scoreEquipe2Value.Location = new System.Drawing.Point(410, 332);
            this.scoreEquipe2Value.Name = "scoreEquipe2Value";
            this.scoreEquipe2Value.Size = new System.Drawing.Size(101, 27);
            this.scoreEquipe2Value.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Light", 16F);
            this.label1.Location = new System.Drawing.Point(333, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Score";
            // 
            // equipe2Label
            // 
            this.equipe2Label.AutoSize = true;
            this.equipe2Label.Font = new System.Drawing.Font("Montserrat Light", 18F);
            this.equipe2Label.Location = new System.Drawing.Point(374, 282);
            this.equipe2Label.Name = "equipe2Label";
            this.equipe2Label.Size = new System.Drawing.Size(133, 29);
            this.equipe2Label.TabIndex = 18;
            this.equipe2Label.Text = "<equipe2>";
            // 
            // TournoiViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 434);
            this.Controls.Add(this.scoreEquipe2Value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equipe2Label);
            this.Controls.Add(this.scoreEquipe1Value);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.equipe1Label);
            this.Controls.Add(this.matchUpListBox);
            this.Controls.Add(this.roundDropdown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.nomTournoiLabel);
            this.Controls.Add(this.TournoiLabel);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TournoiViewer";
            this.Text = "Tournoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournoiLabel;
        private System.Windows.Forms.Label nomTournoiLabel;
        private System.Windows.Forms.ComboBox roundDropdown;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ListBox matchUpListBox;
        private System.Windows.Forms.Label equipe1Label;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox scoreEquipe1Value;
        private System.Windows.Forms.TextBox scoreEquipe2Value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label equipe2Label;
    }
}