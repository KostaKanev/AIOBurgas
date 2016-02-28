namespace NOISSystem.Forms
{
    public partial class TransportForm : DevExpress.XtraEditors.XtraForm
    {
        public TransportForm()
        {
            InitializeComponent();
        }

        private void TrainTransport_Click(object sender, System.EventArgs e)
        {
            var trainsArrivals = BurgasService.TrainsArrival();
            var trainsDeparture = BurgasService.TrainsDeparture();

            var trainTransportForm = new TrainTransportForm(trainsArrivals, trainsDeparture);
            trainTransportForm.Show();

        }
    }
}