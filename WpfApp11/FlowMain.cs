using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11
{
    class FlowMain
    {
        public int id { get; set; }
        public string Surname { get; set; }
        public string NameClient { get; set; }
        public string FatherName { get; set; }
        public string PhoneNumber { get; set; }
        public string email { get; set; }
        public FlowMain() { }
        public FlowMain(string surname, string nameClient, string fatherName, string phoneNumber, string email)
        {
            Surname = surname;
            NameClient = nameClient;
            FatherName = fatherName;
            PhoneNumber = phoneNumber;
            this.email = email;
        }
    }
}
