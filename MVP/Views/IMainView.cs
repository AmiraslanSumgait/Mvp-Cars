using MVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.Views
{
    public interface IMainView
    {
        EventHandler<EventArgs> AddButtonClicked { get; set; }
        EventHandler<EventArgs> LoadButtonClicked { get; set; }
        string VendorText { get; set; }
        string ModelText { get; set; }
        string ColorText { get; set; }
        string YearText { get; set; }
        string TransmissionText { get; set; }
        List<Car> Cars { set; }
        List<string> Colors { set; }
    }
}
