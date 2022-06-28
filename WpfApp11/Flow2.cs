using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11
{
    class Flow2
    {
        public int id { get; set; }
        public string email { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public Flow2() { }
        public Flow2(string email, int code, string name)
        {
            this.email = email;
            ProductCode = code;
            ProductName = name;
        }
    }
}
