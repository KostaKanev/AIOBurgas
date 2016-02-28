namespace NOISSystem.Forms
{
    partial class PublicServicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublicServicesForm));
            this.blueZoneMapButton = new DevExpress.XtraEditors.SimpleButton();
            this.taxiServiceButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // blueZoneMapButton
            // 
            this.blueZoneMapButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueZoneMapButton.Appearance.Options.UseFont = true;
            this.blueZoneMapButton.Image = ((System.Drawing.Image)(resources.GetObject("blueZoneMapButton.Image")));
            this.blueZoneMapButton.Location = new System.Drawing.Point(12, 12);
            this.blueZoneMapButton.Name = "blueZoneMapButton";
            this.blueZoneMapButton.Size = new System.Drawing.Size(286, 144);
            this.blueZoneMapButton.TabIndex = 6;
            this.blueZoneMapButton.Text = "Синя Зона\r\nБургас\r\n";
            this.blueZoneMapButton.Click += new System.EventHandler(this.BlueZoneMapButton_Click);
            // 
            // taxiServiceButton
            // 
            this.taxiServiceButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxiServiceButton.Appearance.Options.UseFont = true;
            this.taxiServiceButton.Image = ((System.Drawing.Image)(resources.GetObject("taxiServiceButton.Image")));
            this.taxiServiceButton.Location = new System.Drawing.Point(12, 227);
            this.taxiServiceButton.Name = "taxiServiceButton";
            this.taxiServiceButton.Size = new System.Drawing.Size(286, 121);
            this.taxiServiceButton.TabIndex = 7;
            this.taxiServiceButton.Text = "Таксиметрови\r\nУслуги\r\n";
            this.taxiServiceButton.Click += new System.EventHandler(this.TaxiServiceButton_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(13, 162);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(285, 42);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Инвалидни паркоместа";
            // 
            // PublicServicesForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 360);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.taxiServiceButton);
            this.Controls.Add(this.blueZoneMapButton);
            this.LookAndFeel.SkinName = "Liquid Sky";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "PublicServicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AIOBurgas - PublicServices";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton blueZoneMapButton;
        private DevExpress.XtraEditors.SimpleButton taxiServiceButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}