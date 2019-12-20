using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfComboBox.NetCore
{
    public class MainViewModel
    {
        public IEnumerable<double> Values { get; set; } = new[] { 0.2, 0.3, 0.4, 1.0, 2.3, 4.5, 6.7 };

        public double SelectedValue { get; set; }
    }
}
