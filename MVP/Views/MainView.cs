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


        public string VendorText
        {
            get => txtBoxVendor.Text;
            set => txtBoxVendor.Text = value;
        }

        public string ModelText
        {
            get => txtBoxModel.Text;
            set => txtBoxModel.Text = value;
        }

        public string ColorText
        {
            get => comboBoxColor.Text;
            set => comboBoxColor.Text = value;
        }

        public string YearText
        {
            get => txtBoxYear.Text;
            set => txtBoxYear.Text = value;
        }

        public string TransmissionText
        {
            get => txtBoxTransmission.Text;
            set => txtBoxTransmission.Text = value;
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
                comboBoxColor.DataSource = value;
            }
        }



        private void btnAddCar_Click(object sender, EventArgs e)
        {
            AddButtonClicked.Invoke(sender, e);
        }

        private void btnLoadCars_Click(object sender, EventArgs e)
        {
            LoadButtonClicked.Invoke(sender, e);
        }

    }
}
