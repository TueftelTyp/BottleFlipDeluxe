namespace BottleFlip
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFlip = new System.Windows.Forms.Button();
            this.timerFlip = new System.Windows.Forms.Timer(this.components);
            this.picBottle = new System.Windows.Forms.PictureBox();
            this.picTable = new System.Windows.Forms.PictureBox();
            this.linkGitHub = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBottle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFlip
            // 
            this.btnFlip.FlatAppearance.BorderSize = 2;
            this.btnFlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlip.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlip.Location = new System.Drawing.Point(68, 283);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(100, 42);
            this.btnFlip.TabIndex = 0;
            this.btnFlip.Text = "Flip";
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click_1);
            // 
            // picBottle
            // 
            this.picBottle.BackColor = System.Drawing.Color.Transparent;
            this.picBottle.Image = ((System.Drawing.Image)(resources.GetObject("picBottle.Image")));
            this.picBottle.Location = new System.Drawing.Point(6, 26);
            this.picBottle.Name = "picBottle";
            this.picBottle.Size = new System.Drawing.Size(120, 151);
            this.picBottle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBottle.TabIndex = 1;
            this.picBottle.TabStop = false;
            // 
            // picTable
            // 
            this.picTable.BackColor = System.Drawing.Color.Transparent;
            this.picTable.Image = global::BottleFlip.Properties.Resources.table;
            this.picTable.Location = new System.Drawing.Point(-33, 214);
            this.picTable.Name = "picTable";
            this.picTable.Size = new System.Drawing.Size(305, 158);
            this.picTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTable.TabIndex = 2;
            this.picTable.TabStop = false;
            // 
            // linkGitHub
            // 
            this.linkGitHub.AutoSize = true;
            this.linkGitHub.BackColor = System.Drawing.Color.Transparent;
            this.linkGitHub.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.linkGitHub.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkGitHub.ForeColor = System.Drawing.Color.Black;
            this.linkGitHub.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkGitHub.Location = new System.Drawing.Point(210, 1);
            this.linkGitHub.Name = "linkGitHub";
            this.linkGitHub.Size = new System.Drawing.Size(29, 9);
            this.linkGitHub.TabIndex = 1;
            this.linkGitHub.Text = "GitHub";
            this.linkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGitHub_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 334);
            this.Controls.Add(this.linkGitHub);
            this.Controls.Add(this.picBottle);
            this.Controls.Add(this.btnFlip);
            this.Controls.Add(this.picTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BottleFlip deluxe";
            ((System.ComponentModel.ISupportInitialize)(this.picBottle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFlip;
        private System.Windows.Forms.PictureBox picBottle;
        private System.Windows.Forms.Timer timerFlip;
        private System.Windows.Forms.PictureBox picTable;
        private System.Windows.Forms.LinkLabel linkGitHub;
    }
}

