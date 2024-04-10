using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonsCompany.Model
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public int AbonentId { get; set; }
        public  int TypeId { get; set; }
        public string Number { get; set; }
        

    }
}
