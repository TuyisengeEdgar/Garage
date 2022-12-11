namespace Garage
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDesEmployesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesPiecesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesFonctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesEmployesToolStripMenuItem,
            this.gestionDesClientsToolStripMenuItem,
            this.gestionDesPiecesToolStripMenuItem,
            this.gestionDesServicesToolStripMenuItem,
            this.gestionDesFonctionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1253, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDesEmployesToolStripMenuItem
            // 
            this.gestionDesEmployesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDesEmployesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gestionDesEmployesToolStripMenuItem.Name = "gestionDesEmployesToolStripMenuItem";
            this.gestionDesEmployesToolStripMenuItem.Size = new System.Drawing.Size(216, 29);
            this.gestionDesEmployesToolStripMenuItem.Text = "Gestion des employes";
            this.gestionDesEmployesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesEmployesToolStripMenuItem_Click);
            // 
            // gestionDesClientsToolStripMenuItem
            // 
            this.gestionDesClientsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDesClientsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gestionDesClientsToolStripMenuItem.Name = "gestionDesClientsToolStripMenuItem";
            this.gestionDesClientsToolStripMenuItem.Size = new System.Drawing.Size(188, 29);
            this.gestionDesClientsToolStripMenuItem.Text = "Gestion des clients";
            this.gestionDesClientsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesClientsToolStripMenuItem_Click);
            // 
            // gestionDesPiecesToolStripMenuItem
            // 
            this.gestionDesPiecesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.gestionDesPiecesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gestionDesPiecesToolStripMenuItem.Name = "gestionDesPiecesToolStripMenuItem";
            this.gestionDesPiecesToolStripMenuItem.Size = new System.Drawing.Size(186, 29);
            this.gestionDesPiecesToolStripMenuItem.Text = "Gestion des pieces";
            this.gestionDesPiecesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesPiecesToolStripMenuItem_Click);
            // 
            // gestionDesServicesToolStripMenuItem
            // 
            this.gestionDesServicesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.gestionDesServicesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gestionDesServicesToolStripMenuItem.Name = "gestionDesServicesToolStripMenuItem";
            this.gestionDesServicesToolStripMenuItem.Size = new System.Drawing.Size(204, 29);
            this.gestionDesServicesToolStripMenuItem.Text = "Gestion des Services";
            // 
            // gestionDesFonctionToolStripMenuItem
            // 
            this.gestionDesFonctionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.gestionDesFonctionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gestionDesFonctionToolStripMenuItem.Name = "gestionDesFonctionToolStripMenuItem";
            this.gestionDesFonctionToolStripMenuItem.Size = new System.Drawing.Size(208, 29);
            this.gestionDesFonctionToolStripMenuItem.Text = "Gestion des fonction";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 594);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "                                                                      Bienvenue s" +
                "ur la page de l\'Administrateur";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesEmployesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesPiecesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesFonctionToolStripMenuItem;
    }
}