using System; 
using System.Data.Entity; 
using System.Windows; 

namespace WpfApp11
{
     
    public partial class MainWindow : Window
    {
        DataContext db;
        FlowMain fm;
        AddClient client;
        public MainWindow()
        {
            InitializeComponent(); 
            db = new DataContext(); 
            db.FlowMains.Load();
            gridView.DataContext = db.FlowMains.Local.ToBindingList(); 
        }
        private void GVCurrebtCellChanged(object sender, EventArgs e)
        {
            fm = (FlowMain)gridView.SelectedItem;
            var ct = db.FlowMains.Find(fm.id);
            ct = fm;
            db.SaveChanges();
        }
        private void ProductViewClick(object sender, RoutedEventArgs e)
        {
            try
            {
                new ProductView(((FlowMain)gridView.SelectedItem).email).ShowDialog();
            }
            catch(InvalidCastException)
            {
                MessageBox.Show("Выберите клиента"); 
            }
        }
        private void AddClientClick(object sender, RoutedEventArgs e)
        {
            client = new AddClient();
            client.DataEvent += (a1, a2, a3, a4, a5) =>
            {
                db.FlowMains.Add(new FlowMain(a1, a2, a3, a4, a5));
                db.SaveChanges();
                gridView.DataContext = db.FlowMains.Local.ToBindingList();
            };
            client.ShowDialog(); 
        }
        private void DeleteClientClick(object sender, RoutedEventArgs e)
        {
            fm = (FlowMain)gridView.SelectedItem;
            db.FlowMains.Remove(fm);
            foreach (var item in db.Flow2s) if (item.email.Equals(fm.email)) db.Flow2s.Remove(item);
            db.SaveChanges();
        }
    }
}
