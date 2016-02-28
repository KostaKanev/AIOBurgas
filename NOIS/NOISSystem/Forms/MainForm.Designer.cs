﻿namespace NOISSystem.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.publicServicesButton = new DevExpress.XtraEditors.SimpleButton();
            this.transportButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // publicServicesButton
            // 
            this.publicServicesButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicServicesButton.Appearance.Options.UseFont = true;
            this.publicServicesButton.Location = new System.Drawing.Point(9, 103);
            this.publicServicesButton.Name = "publicServicesButton";
            this.publicServicesButton.Size = new System.Drawing.Size(196, 110);
            this.publicServicesButton.TabIndex = 6;
            this.publicServicesButton.Text = "Обществени\r\nУслуги";
            this.publicServicesButton.Click += new System.EventHandler(this.publicServicesButton_Click);
            // 
            // transportButton
            // 
            this.transportButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportButton.Appearance.Options.UseFont = true;
            this.transportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.transportButton.Location = new System.Drawing.Point(239, 103);
            this.transportButton.Name = "transportButton";
            this.transportButton.Size = new System.Drawing.Size(196, 110);
            this.transportButton.TabIndex = 7;
            this.transportButton.Text = "Транспорт";
            this.transportButton.Click += new System.EventHandler(this.TransportButton_Click);
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.None;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(447, 493);
            this.Controls.Add(this.transportButton);
            this.Controls.Add(this.publicServicesButton);
            this.DoubleBuffered = true;
            this.LookAndFeel.SkinName = "Liquid Sky";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AIOBurgas";
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton publicServicesButton;
        private DevExpress.XtraEditors.SimpleButton transportButton;
    }
}

