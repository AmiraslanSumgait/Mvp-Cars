using MVP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }
        public EventHandler<EventArgs> AddButtonClicked { get; set; }
        public EventHandler<EventArgs> LoadButtonClicked { get; set; }
        public EventHandler<EventArgs> VendorIndexChanged { get; set; }
       
        public string VendorText
        {
            get => cbxVendor.Text;
            set => cbxVendor.Text = value;
        }

        public string ModelText
        {
            get => cbxModel.Text;
            set => cbxModel.Text = value;
        }

        public string ColorText
        {
            get => comboBoxColor.Text;
            set => comboBoxColor.Text = value;
        }

        public string YearText
        {
            get => cbxYears.Text;
            set => cbxYears.Text = value;
        }
        public string TransmissionText
        {
            get => cbxTransmission.Text;
            set => cbxTransmission.Text = value;
        }
        public List<Car> Cars
        {
            set
            {
                listBoxCar.DataSource = value;
            }
        }
        public List<string> Colors
        {
            set
            {
                comboBoxColor.DataSource = typeof(Color).GetProperties()
               .Where(x => x.PropertyType == typeof(Color))
               .Select(x => x.GetValue(null)).ToList(); 
            }
        }

       public List<string> Vendors { set => cbxVendor.DataSource=value; }
        public List<string> Models { set => cbxModel.DataSource = value; }
        public List<int> Years
        {
            set
            {
                for (int i = 1950; i <= 2050; i++)
                {
                    cbxYears.Items.Add(i);
                }
            }
        }
        public List<string> Transmissions { set => cbxTransmission.DataSource=value; }
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            AddButtonClicked.Invoke(sender, e);
        }
        private void btnLoadCars_Click(object sender, EventArgs e)
        {
            LoadButtonClicked.Invoke(sender, e);
        }
        private void cbxVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            VendorIndexChanged.Invoke(sender, e);
        }
    }
}
