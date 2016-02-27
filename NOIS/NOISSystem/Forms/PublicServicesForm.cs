using System;

namespace NOISSystem.Forms
{
    public partial class PublicServicesForm : DevExpress.XtraEditors.XtraForm
    {
        public PublicServicesForm()
        {
            InitializeComponent();
        }

        private void BlueZoneMapButton_Click(object sender, EventArgs e)
        {
            var blueZoneMap = new BlueZoneForm();
            blueZoneMap.Show();
        }

        private void TaxiServiceButton_Click(object sender, EventArgs e)
        {
            var taxiPlaces = BurgasService.Taxis();

            var taxiForm = new TaxiForm(taxiPlaces);
            taxiForm.Show();

            

        }
    }
}