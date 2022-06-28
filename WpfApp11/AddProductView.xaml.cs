using System; 
using System.Windows; 

namespace WpfApp11
{ 
    public partial class AddProductView : Window
    {
        public event Action<int, string> DataEvent;
        public AddProductView()
        {
            InitializeComponent();
            cancelBtn.Click += delegate { DialogResult = false; };
            okBtn.Click += delegate
            {
                DataEvent?.Invoke(Convert.ToInt32(txtCode.Text), txtName.Text);
                DialogResult = true;
            };
        }
    }
}
