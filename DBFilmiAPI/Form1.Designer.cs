namespace DBFilmiAPI
{
    partial class PridobiPodatke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PridobiPodatke));
            this.PridobiPodatkeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // PridobiPodatkeButton
            // 
            this.PridobiPodatkeButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.PridobiPodatkeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.PridobiPodatkeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PridobiPodatkeButton.BorderRadius = 0;
            this.PridobiPodatkeButton.ButtonText = "Pridobi podatke";
            this.PridobiPodatkeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PridobiPodatkeButton.DisabledColor = System.Drawing.Color.Gray;
            this.PridobiPodatkeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.PridobiPodatkeButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("PridobiPodatkeButton.Iconimage")));
            this.PridobiPodatkeButton.Iconimage_right = null;
            this.PridobiPodatkeButton.Iconimage_right_Selected = null;
            this.PridobiPodatkeButton.Iconimage_Selected = null;
            this.PridobiPodatkeButton.IconMarginLeft = 0;
            this.PridobiPodatkeButton.IconMarginRight = 0;
            this.PridobiPodatkeButton.IconRightVisible = true;
            this.PridobiPodatkeButton.IconRightZoom = 0D;
            this.PridobiPodatkeButton.IconVisible = true;
            this.PridobiPodatkeButton.IconZoom = 90D;
            this.PridobiPodatkeButton.IsTab = false;
            this.PridobiPodatkeButton.Location = new System.Drawing.Point(272, 206);
            this.PridobiPodatkeButton.Name = "PridobiPodatkeButton";
            this.PridobiPodatkeButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.PridobiPodatkeButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.PridobiPodatkeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.PridobiPodatkeButton.selected = false;
            this.PridobiPodatkeButton.Size = new System.Drawing.Size(241, 48);
            this.PridobiPodatkeButton.TabIndex = 0;
            this.PridobiPodatkeButton.Text = "Pridobi podatke";
            this.PridobiPodatkeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PridobiPodatkeButton.Textcolor = System.Drawing.Color.White;
            this.PridobiPodatkeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PridobiPodatkeButton.Click += new System.EventHandler(this.PridobiPodatkeButton_Click);
            // 
            // PridobiPodatke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.PridobiPodatkeButton);
            this.Name = "PridobiPodatke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pridobi Podatke";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton PridobiPodatkeButton;
    }
}

