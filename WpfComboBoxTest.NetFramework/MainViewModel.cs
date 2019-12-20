using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WpfComboBoxTest.NetFramework
{
    public class MainViewModel
    {
        public IEnumerable<double> Values { get; set; } = new[] { 0.2, 0.3, 0.4, 1.0, 2.3, 4.5, 6.7 };

        public double SelectedValue { get; set; }

        public MainViewModel()
        {
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-EN");
            //CultureInfo.CurrentUICulture = new CultureInfo("en-EN");
        }
    }
}
