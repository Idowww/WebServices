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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApplicationJAXWSUserServiceClient.UserServiceReference;

namespace WpfApplicationJAXWSUserServiceClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<user> Users { get; set; }
        private UserServiceClient userService = new UserServiceClient();

        public MainWindow()
        {
            InitializeComponent();
            init();

            DataContext = this;
        }

        private void init()
        {
            Users = new List<user>();

            user[] users = userService.getAllUsers();
            Users = users.Cast<user>().ToList();
        }

        private void DeleteUser(object sender, RoutedEventArgs e)
        {
            user user = (user)MainDataGrid.SelectedItem;
            userService.deleteUser(user.id);
            Users.RemoveAll(u => u.id == user.id);

            MainDataGrid.Items.Refresh();

        }
    }
}
