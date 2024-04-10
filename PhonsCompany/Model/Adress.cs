using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonsCompany.Model
{
    public class Adress
    {
        public int AbonentId { get; set; }
        public string City {  get; set; }
        public string Region { get; set; }
        public string HousNumber {  get; set; }
        public int StreetId { get; set; }
    }
}
