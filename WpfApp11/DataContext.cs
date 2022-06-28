using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WpfApp11
{
    class DataContext:DbContext
    {
        public DataContext() : base("DBConnection") { }
        public DbSet<FlowMain> FlowMains { get; set; }
        public DbSet<Flow2> Flow2s { get; set; }
    }
}
