using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AaronBurnsProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            random_Color();
        }

        //Global Variables
        Ellipse elpCurrent;
        int count = 4;
        int randomColor;

        //Method to change the color of the Ellipse
        private void Ellipse_Tapped(object sender, TappedRoutedEventArgs e)
        {
            canvasColor.Visibility = Visibility;
            elpCurrent = (Ellipse)sender;
        }//Ellipse_Tapped

        //Method that actually sets a colour to an Ellipse
        private void color_elps_0_Tapped(object sender, TappedRoutedEventArgs e)
        {
            elpCurrent.Fill = ((Ellipse)sender).Fill;
        }//color_elps_0_Tapped

        //Advances the game every time it's clicked
        private void button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (count == 4)
            {
                count--;
                turn1.Visibility = Visibility.Visible;
            }
            else if (count == 3)
            {
                count--;
                turn2.Visibility = Visibility.Visible;
            }
            else if (count == 2)
            {
                count--;
                turn3.Visibility = Visibility.Visible;
            }
            else if (count == 1)
            {
                count--;
                turn4.Visibility = Visibility.Visible;
            }
            else if (count == 0)
            {
                count--;
                answerPanel.Visibility = Visibility.Visible;
            }
        }//button_Tapped

        //Sets the answer panels to a random colour
        public void random_Color()
        {
            Random random = new Random();
            randomColor = random.Next(1, 7);

            if (randomColor == 1)
            {
                ans1.Fill = new SolidColorBrush(Colors.Blue);
            }
            else if (randomColor == 2)
            {
                ans1.Fill = new SolidColorBrush(Colors.Red);
            }
            else if (randomColor == 3)
            {
                ans1.Fill = new SolidColorBrush(Colors.Green);
            }
            else if (randomColor == 4)
            {
                ans1.Fill = new SolidColorBrush(Colors.Black);
            }
            else if (randomColor == 5)
            {
                ans1.Fill = new SolidColorBrush(Colors.Orange);
            }
            else if (randomColor == 6)
            {
                ans1.Fill = new SolidColorBrush(Colors.Yellow);
            }
            else if (randomColor == 7)
            {
                ans1.Fill = new SolidColorBrush(Colors.Purple);
            }

            randomColor = random.Next(1, 7);

            if (randomColor == 1)
            {
                ans2.Fill = new SolidColorBrush(Colors.Blue);
            }
            else if (randomColor == 2)
            {
                ans2.Fill = new SolidColorBrush(Colors.Red);
            }
            else if (randomColor == 3)
            {
                ans2.Fill = new SolidColorBrush(Colors.Green);
            }
            else if (randomColor == 4)
            {
                ans2.Fill = new SolidColorBrush(Colors.Black);
            }
            else if (randomColor == 5)
            {
                ans2.Fill = new SolidColorBrush(Colors.Orange);
            }
            else if (randomColor == 6)
            {
                ans2.Fill = new SolidColorBrush(Colors.Yellow);
            }
            else if (randomColor == 7)
            {
                ans2.Fill = new SolidColorBrush(Colors.Purple);
            }

            randomColor = random.Next(1, 7);

            if (randomColor == 1)
            {
                ans3.Fill = new SolidColorBrush(Colors.Blue);
            }
            else if (randomColor == 2)
            {
                ans3.Fill = new SolidColorBrush(Colors.Red);
            }
            else if (randomColor == 3)
            {
                ans3.Fill = new SolidColorBrush(Colors.Green);
            }
            else if (randomColor == 4)
            {
                ans3.Fill = new SolidColorBrush(Colors.Black);
            }
            else if (randomColor == 5)
            {
                ans3.Fill = new SolidColorBrush(Colors.Orange);
            }
            else if (randomColor == 6)
            {
                ans3.Fill = new SolidColorBrush(Colors.Yellow);
            }
            else if (randomColor == 7)
            {
                ans3.Fill = new SolidColorBrush(Colors.Purple);
            }

            randomColor = random.Next(1, 7);

            if (randomColor == 1)
            {
                ans4.Fill = new SolidColorBrush(Colors.Blue);
            }
            else if (randomColor == 2)
            {
                ans4.Fill = new SolidColorBrush(Colors.Red);
            }
            else if (randomColor == 3)
            {
                ans4.Fill = new SolidColorBrush(Colors.Green);
            }
            else if (randomColor == 4)
            {
                ans4.Fill = new SolidColorBrush(Colors.Black);
            }
            else if (randomColor == 5)
            {
                ans4.Fill = new SolidColorBrush(Colors.Orange);
            }
            else if (randomColor == 6)
            {
                ans4.Fill = new SolidColorBrush(Colors.Yellow);
            }
            else if (randomColor == 7)
            {
                ans4.Fill = new SolidColorBrush(Colors.Purple);
            }
        }//random_Color
 
    }//mainpage
}//AaronBurnsProject
