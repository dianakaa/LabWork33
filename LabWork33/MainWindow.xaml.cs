using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabWork33
{
    public partial class MainWindow : Window
    {
        public List<Game> Games;

        public MainWindow()
        {
            InitializeComponent();

            Games = new List<Game>
            {
                new Game { IdGame = 1, Name = "name1", Category = "category1", Site = "site1", Price = 100 },
                new Game { IdGame = 2, Name = "name2", Category = "category2", Site = "site2", Price = 200 },
                new Game { IdGame = 3, Name = "name3", Category = "category3", Site = "site3", Price = 300 },
                new Game { IdGame = 4, Name = "name4", Category = "category4", Site = "site4", Price = 400 },
                new Game { IdGame = 5, Name = "name5", Category = "category5", Site = "site5", Price = 500 }
            };

            listView.ItemsSource = Games;
        }
    }
}