namespace NOISSystem.Forms
{
    partial class TransportForm
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
            this.trainTransport = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // trainTransport
            // 
            this.trainTransport.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.trainTransport.Appearance.Options.UseFont = true;
            this.trainTransport.Location = new System.Drawing.Point(12, 12);
            this.trainTransport.Name = "trainTransport";
            this.trainTransport.Size = new System.Drawing.Size(119, 113);
            this.trainTransport.TabIndex = 0;
            this.trainTransport.Text = "Железопътен\r\nТранспорт";
            this.trainTransport.Click += new System.EventHandler(this.TrainTransport_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(137, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(119, 113);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Автобусен\r\nТранспорт";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(262, 12);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(119, 113);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Въздушен\r\nТранспорт";
            // 
            // TransportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 140);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.trainTransport);
            this.LookAndFeel.SkinName = "Liquid Sky";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "TransportForm";
            this.Text = "TransportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton trainTransport;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}