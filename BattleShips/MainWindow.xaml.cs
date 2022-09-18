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
        List<Button> player1List = new List<Button>();
        List<Button> player2List = new List<Button>();
        bool rotateVertical = true;
        int maxValue = 99;
        int a = 10;
        int b = 20;
        int c = 30;
        int ah = 1;
        int bh = 2;
        int ch = 3;
        public MainWindow() {
            InitializeComponent();
        }

        private void StartGameClick(object sender, RoutedEventArgs e) {
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    Button b1 = new Button() { Background = Brushes.DarkBlue };
                    Button b2 = new Button() { Background = Brushes.DarkBlue };
                    b1.Click += B1_Click;
                    b1.MouseEnter += B1_MouseEnter;
                    b1.MouseLeave += B1_MouseLeave;
                    b2.Click += B2_Click;
                    b2.MouseEnter += B2_MouseEnter;
                    Grid.SetRow(b1, i);
                    Grid.SetColumn(b1, j);
                    Grid.SetRow(b2, i);
                    Grid.SetColumn(b2, j);
                    Player1Grid.Children.Add(b1);
                    Player2Grid.Children.Add(b2);
                    player1List.Add(b1);
                    player2List.Add(b2);
                }
            }
            StartGameButton.IsEnabled = false;
            RotateButton.IsEnabled = true;
        }

        private void B1_MouseLeave(object sender, MouseEventArgs e) {
            int i = player1List.IndexOf((Button)e.Source);
            if (rotateVertical) {

                if (i + a <= 99 && i + b <= 99) {
                    player1List[i + a].Background = Brushes.DarkBlue;
                    player1List[i + b].Background = Brushes.DarkBlue;
                }



            } else {
                if (i + ah <= 99 && i + bh <= 99) {
                    player1List[i + ah].Background = Brushes.DarkBlue;
                    player1List[i + bh].Background = Brushes.DarkBlue;
                }
            }
        }

        private void B2_MouseEnter(object sender, MouseEventArgs e) {
            throw new NotImplementedException();
        }

        private void B1_MouseEnter(object sender, MouseEventArgs e) {
            int i = player1List.IndexOf((Button)e.Source);
            if (rotateVertical) {

                if (i + a <= 99 && i + b <= 99) {
                    player1List[i + a].Background = Brushes.Yellow;
                    player1List[i + b].Background = Brushes.Yellow;
                }

            } else {
                if (i + ah <= 99 && i + bh <= 99) {
                    player1List[i + ah].Background = Brushes.Yellow;
                    player1List[i + bh].Background = Brushes.Yellow;
                }
            }
        }

        private void B2_Click(object sender, RoutedEventArgs e) {

        }

        private void B1_Click(object sender, RoutedEventArgs e) {

        }

        private void RotateButtonClick(object sender, RoutedEventArgs e) {
            rotateVertical = !rotateVertical;
        }
    }
}
