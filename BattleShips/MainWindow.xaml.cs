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

namespace BattleShips {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void StartGameClick(object sender, RoutedEventArgs e) {            
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    Button b1 = new Button() {Background = Brushes.Black};
                    Button b2 = new Button() {Background = Brushes.Black};
                    b1.Style = (Style)FindResource("btnStyle");
                    b2.Style = (Style)FindResource("btnStyle");
                    Grid.SetRow(b1, i);
                    Grid.SetColumn(b1, j);
                    Grid.SetRow(b2, i);
                    Grid.SetColumn(b2, j);
                    Player1Grid.Children.Add(b1);
                    Player2Grid.Children.Add(b2);
                }
            }
            Player1Grid.Background = Brushes.Black;
            Player2Grid.Background = Brushes.Black;
        }
    }
}
