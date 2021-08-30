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


            List<string> colors = new List<string>
            {
                "Green",
                "Blue",
                "Red"
            };
            _view.Colors = colors;
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

    }
}
