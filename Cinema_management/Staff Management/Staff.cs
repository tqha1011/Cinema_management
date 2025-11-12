using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_management.Staff_Management
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AccountUsername { get; set; }
        public string AccountPassword { get; set; }
        public string Gender { get; set; }
    }
}
