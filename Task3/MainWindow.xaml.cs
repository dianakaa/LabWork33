using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Task3
{
    public partial class MainWindow : Window
    {
        public List<Game> Games;
        public List<string> Category;

        public MainWindow()
        {
            InitializeComponent();

            List<Game> games = new List<Game>
            {
                new Game { Name = "name1", Site = "site1", Price = 100 },
                new Game { Name = "name2", Site = "site2", Price = 200 },
                new Game { Name = "name3", Site = "site3", Price = 300 },
                new Game { Name = "name4", Site = "site4", Price = 400 },
                new Game { Name = "name5", Site = "site5", Price = 500 }
            };

            List<string> Categories = new List<string>
            { "Action", "Adventure", "Strategy" };

            dataGrid.ItemsSource = games;
        }

        private void DetailedButton_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                Game selectedGame = clickedButton.DataContext as Game;

                if (selectedGame != null)
                {
                    string message = $"Название: {selectedGame.Name}\nСайт: {selectedGame.Site}\nЦена: {selectedGame.Price}";

                    MessageBox.Show(message, "Подробная информация");
                }
            }
        }
    }

    public class Game
    {
        public string Name { get; set; }
        public string Site { get; set; }
        public double Price { get; set; }
        public double Category { get; set; }
    }
}