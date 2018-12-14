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

namespace Chapter_2_Group_Up_App
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // this is a comment
            string name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            myLabel.Text = "name is " + name + "\nx is " + x + "\nd is " + d;


        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 10;
            if (x == 10)
            {
                myLabel.Text = "x must be 10";
            }
            else
            {
                myLabel.Text = "x isn't 10";
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 3;
            string name = "Joe";
            if ((someValue == 3) && (name == "Joe"))
            {
                myLabel.Text = "x is 3 and the name is Joe";
            }
            else
            {
                myLabel.Text = "this line runs no matter what";
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            while (count < 10)
            {
                count = count + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }
            myLabel.Text = "The answer is " + count;
            
        }

        public void blank()
        {
            string result = "";
            int x = 3;

            while (x > 0)
            {

                if (x > 2)
                {
                    result = result + "a";
                }

                if (x == 2)
                {
                    result = result + "b c";
                }
                x = x - 1;
                result = result + "-";

                if (x == 1)
                {
                    result = result + "d";
                    x = x - 1;
                }


            }
            myLabel.Text = result;
        }
    }
}
