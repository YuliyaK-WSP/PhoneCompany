using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonsCompany.Model
{
    public class Abonent
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Фамилия обязательна")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Имя обязательно")]
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        
    }
}
