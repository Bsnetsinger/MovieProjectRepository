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
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MovieAppStart
{
    /// <summary>
    /// Creating the login page. 
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private String admin = "admin";
        private String adminKey = "admin";
        private String user1 = "user1";
        private String user2 = "user2";
        private String userKey1 = "password";
        private String userKey2 = "password";

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void SkipClick(object sender, RoutedEventArgs e) //Event handler to skip login screen for quick debugging
        {
            this.Frame.Navigate(typeof(MainMenu));
        }
        private void HyperlinkButton_Click(object sender, RoutedEventArgs e) //Event handlers for button click for login
        {
            if (userName.Text == admin)
            {
                if (passWord.Password == adminKey)
                {
                    MessageDialog msg = new MessageDialog("Login Successful, Welcome " + userName.Text);
                    msg.ShowAsync();
                    this.Frame.Navigate(typeof(MainMenu));
                    //TODO: Add event handler for admin access
                }
                else
                {
                    MessageDialog msg = new MessageDialog("Login Failed, Try Again");
                    msg.ShowAsync();
                }
            }

            if (userName.Text == user1)
            {
                if (passWord.Password == userKey1)
                {
                    MessageDialog msg = new MessageDialog("Login Successful, Welcome " + userName.Text);
                    msg.ShowAsync();
                    this.Frame.Navigate(typeof(MainMenu));
                    //TODO: Add event handler for user1 access
                }
                else
                {
                    MessageDialog msg = new MessageDialog("Login Failed, Try Again");
                    msg.ShowAsync();
                }
            }

            if (userName.Text == user2)
            {
                if (passWord.Password == userKey2)
                {
                    MessageDialog msg = new MessageDialog("Login Successful, Welcome " + userName.Text);
                    msg.ShowAsync();
                    this.Frame.Navigate(typeof(MainMenu));
                    //TODO: Add event handler for user2 access
                }
                else
                {
                    MessageDialog msg = new MessageDialog("Login Failed, Try Again");
                    msg.ShowAsync();
                }
            }

            else if (userName.Text != admin && userName.Text != user1 && userName.Text != user2)
            {
                MessageDialog msg = new MessageDialog("User not found");
                msg.ShowAsync();
            }

        }

        private void EnterPressed(object sender, KeyRoutedEventArgs e) //Event handlers for enter press for login
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                if (userName.Text == admin)
                {
                    if (passWord.Password == adminKey)
                    {
                        MessageDialog msg = new MessageDialog("Login Successful, Welcome " + userName.Text);
                        msg.ShowAsync();
                        this.Frame.Navigate(typeof(MainMenu));
                        //TODO: Add event handler for admin access
                    }
                    else
                    {
                        MessageDialog msg = new MessageDialog("Login Failed, Try Again");
                        msg.ShowAsync();
                    }
                }

                if (userName.Text == user1)
                {
                    if (passWord.Password == userKey1)
                    {
                        MessageDialog msg = new MessageDialog("Login Successful, Welcome " + userName.Text);
                        msg.ShowAsync();
                        this.Frame.Navigate(typeof(MainMenu));
                        //TODO: Add event handler for user1 access
                    }
                    else
                    {
                        MessageDialog msg = new MessageDialog("Login Failed, Try Again");
                        msg.ShowAsync();
                    }
                }

                if (userName.Text == user2)
                {
                    if (passWord.Password == userKey2)
                    {
                        MessageDialog msg = new MessageDialog("Login Successful, Welcome " + userName.Text);
                        msg.ShowAsync();
                        this.Frame.Navigate(typeof(MainMenu));
                        //TODO: Add event handler for user2 access
                    }
                    else
                    {
                        MessageDialog msg = new MessageDialog("Login Failed, Try Again");
                        msg.ShowAsync();
                    }
                }
                else if (userName.Text != admin && userName.Text != user1 && userName.Text != user2)
                {
                    MessageDialog msg = new MessageDialog("User not found");
                    msg.ShowAsync();
                }
            }
        }
    }
}
