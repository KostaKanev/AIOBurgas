using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NOISSystem.Models;

namespace NOISSystem.Forms
{
    public partial class TaxiForm : DevExpress.XtraEditors.XtraForm
    {
        public TaxiForm(List<Taxi> taxiList )
        {
            InitializeComponent();
            this.locationView.OptionsView.ShowGroupPanel = false;
            
            var source = new BindingList<Taxi>(taxiList);
            this.taxiGridView.DataSource = source;
        }
    }
}