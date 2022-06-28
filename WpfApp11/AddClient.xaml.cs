using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp11
{
    /// <summary>
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Window
    {
        public event Action<string, string, string, string, string> DataEvent;

        public AddClient()
        {
            InitializeComponent();
            cancelBtn.Click += delegate { DialogResult = false; };
            okBtn.Click += delegate
            {
                DialogResult = true;
                DataEvent?.Invoke(txtSurname.Text, txtName.Text, txtFatherName.Text, txtPhoneNumber.Text, txtemail.Text);
            };
        }
    }
}
