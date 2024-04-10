using PhonsCompany.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonsCompany.ViewModel
{
    public class StreetInfo
    {
        public string StreetName { get; set; }
        public int AbonentCount { get; set; }

        public StreetInfo(Street street, int abonentCount)
        {
            StreetName = street.Name;
            AbonentCount = abonentCount;
        }
    }
}
