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
using System.Collections.ObjectModel;

namespace ObserveableCollection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Player> players = new ObservableCollection<Player>();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this.GetPalyer();
        }

        public ObservableCollection<Player> GetPalyer()
        {
            players.Add(new Player { Id = 1, Name = "Prem Rajah" });
            players.Add(new Player { Id = 2, Name = "Bruce Wayne" });
            players.Add(new Player { Id = 3, Name = "Clark Kent" });

            return players;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddPlayer();
        }

        private void AddPlayer()
        {   
            if(name_tbox.Text != String.Empty)
            {
                int c = players.Count();
                players.Add(new Player { Id = c + 1, Name = name_tbox.Text });

                name_tbox.Text = String.Empty;
            }
        }
        
    }
}
