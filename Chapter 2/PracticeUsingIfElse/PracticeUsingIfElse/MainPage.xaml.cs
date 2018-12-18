using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PracticeUsingIfElse
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void changeText_Click(object sender, RoutedEventArgs e)
        {
            if(enableCheckbox.IsChecked == true)
            {
                if (labelToChange.Text == "Right")
                {
                    labelToChange.Text = "Left";
                    labelToChange.HorizontalAlignment = HorizontalAlignment.Left;
                }
                else
                {
                    labelToChange.Text = "Right";
                    labelToChange.HorizontalAlignment = HorizontalAlignment.Right;
                }
               
            }
            else
            {
                //labelToChange.Text = "Text changing is disabled";
                //labelToChange.TextAlignment = TextAlignment.Center;

                // poem = poem + " ";       poem = poem + "noys ";
                // poem = poem + "a";       poem = poem + "oise ";
                // poem = poem + "n";       poem = poem + " oyster ";
                // poem = poem + "an";      poem = poem + "annoys";
                //                          poem = poem + "noise";

                // x > 0    x = x + 1;
                // x < 1    x = x + 2;
                // x > 1    x = x - 2;
                // x > 3    x = x -1;
                // x < 4 

                // a noise annoys an oyster

                int x = 0;
                string poem = "";

                while(x < 4)
                {
                    poem = poem + "a";

                    if (x < 1)
                    {
                        poem = poem + " ";
                    }
                    poem = poem + "n";

                    if (x > 1)
                    {
                        poem = poem + " oyster ";
                        x = x + 2;                       
                    }

                    if (x == 1)
                    {
                        poem = poem + "noys ";
                    }
                    if (x < 1)
                    {
                        poem = poem + "oise ";
                    }
                    x = x + 1;

                }

                labelToChange.Text = poem;
            }
            
        }
    }
}
