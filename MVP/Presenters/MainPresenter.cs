using MVP.Data;
using MVP.Models;
using MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenters
{
    public class MainPresenter
    {
        private readonly CarContext _carContext;
        private readonly IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;
            _carContext = new CarContext();
            _view.AddButtonClicked += ViewAddButtonClicked;
            _view.LoadButtonClicked += ViewLoadButtonClicked;
            _view.VendorIndexChanged += ViewVendorIndexChanged;
            List<string> colors = new List<string>();
            List<string> vendors = new List<string>();
            List<int> years = new List<int>();
            _view.Transmissions = new List<string> { "Manual", "Automatic" };
            vendors.Add("Bmw");
            vendors.Add("Mercedes");
            vendors.Add("Ford");
            _view.Vendors = vendors;
            _view.Colors = colors;
            _view.Years = years;
        }
        private void ViewAddButtonClicked(object sender, EventArgs e)
        {
            Car car = new Car
            {
                Vendor = _view.VendorText,
                Model = _view.ModelText,
                Year = int.Parse(_view.YearText),
                Color = _view.ColorText,
                Transmission = _view.TransmissionText
            };
            _carContext.Cars.Add(car);
            _carContext.SaveChanges();
        }
        private void ViewLoadButtonClicked(object sender, EventArgs e)
        {
            _view.Cars = _carContext.Cars.ToList();
        }
        private void ViewVendorIndexChanged(object sender, EventArgs e)
        {
            if (_view.VendorText == "Bmw")
            {
                List<string> models = new List<string> { "M4 Coupe", "M4 Competition Convertible","THE X6 M","M5","M6" };
                _view.Models = models;
            }
            else if (_view.VendorText == "Mercedes")
            {
                List<string> models = new List<string> { "G-Class", "AMG GT", "CLA","EQ","GLB" };
                _view.Models = models;
            }
            else if (_view.VendorText == "Ford")
            {
                List<string> models = new List<string> { "Focus", "Mustang", "Bronco","Edge","Super Duty" };
                _view.Models = models;
            }
        }
    }
}
