namespace NOISSystem.Forms
{
    partial class TaxiForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.taxiGridView = new DevExpress.XtraGrid.GridControl();
            this.locationView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.taxiGrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Локация = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 388);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // taxiGridView
            // 
            this.taxiGridView.Location = new System.Drawing.Point(481, 12);
            this.taxiGridView.MainView = this.locationView;
            this.taxiGridView.Name = "taxiGridView";
            this.taxiGridView.Size = new System.Drawing.Size(285, 388);
            this.taxiGridView.TabIndex = 1;
            this.taxiGridView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.locationView});
            // 
            // locationView
            // 
            this.locationView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.taxiGrid});
            this.locationView.GridControl = this.taxiGridView;
            this.locationView.Name = "locationView";
            // 
            // taxiGrid
            // 
            this.taxiGrid.Caption = "Локация";
            this.taxiGrid.FieldName = "title";
            this.taxiGrid.Name = "taxiGrid";
            this.taxiGrid.Visible = true;
            this.taxiGrid.VisibleIndex = 0;
            this.taxiGrid.Width = 225;
            // 
            // Локация
            // 
            this.Локация.Caption = "gridColumn1";
            this.Локация.Name = "Локация";
            // 
            // TaxiForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 412);
            this.Controls.Add(this.taxiGridView);
            this.Controls.Add(this.pictureBox1);
            this.LookAndFeel.SkinName = "Liquid Sky";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "TaxiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaxiForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxiGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraGrid.GridControl taxiGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView locationView;
        private DevExpress.XtraGrid.Columns.GridColumn taxiGrid;
        private DevExpress.XtraGrid.Columns.GridColumn Локация;
    }
}