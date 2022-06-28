using System.Linq; 
using System.Windows; 
using System.Data.Entity;
 

namespace WpfApp11
{ 
    public partial class ProductView : Window
    {
        DataContext db;
        AddProductView add;
        string email;
        public ProductView(string email)
        {
            InitializeComponent();
            this.email = email;
            db = new DataContext(); 
            db.Flow2s.Load();
            var req = db.Flow2s.Where(e => e.email == email);
            var r = from e in req
                    select new {id=e.id, email = e.email, КодПродукта = e.ProductCode, НазваниеПродукта = e.ProductName };
            gridAllView.DataContext = r.ToList(); 
        }
        private void AddProductClick(object sender,RoutedEventArgs e)
        {
            add = new AddProductView();
            add.DataEvent += (a1, a2) =>
            {
                db.Flow2s.Add(new Flow2(email, a1, a2));
                db.SaveChanges();
            };
            add.ShowDialog(); 
        }
    }
}
