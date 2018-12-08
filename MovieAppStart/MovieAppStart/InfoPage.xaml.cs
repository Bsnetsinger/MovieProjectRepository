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
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MovieAppStart
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    public partial class InfoPage : Page
    {
        Movie MovieData;

        public bool Saved;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            MovieData = e.Parameter as Movie;

            this.Summary.Text = MovieData.Synopsis;
            this.Length.Text = MovieData.Length;
            this.Image.Source = new BitmapImage(new Uri(MovieData.Image));
            this.Title.Text = MovieData.Title;
            this.Genre.Text = MovieData.Genre;
            this.Rating.Text = MovieData.Rating;
            this.Director.Text = MovieData.Director;
            this.Saved = false;

        }
        public InfoPage()
        {
            this.InitializeComponent();

        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }

        private void FlipHeart()
        {
            if (this.Saved == false)
            {
                this.Heart.Source = new BitmapImage(new Uri("ms-appx:///Assets/fullheart.png"));
                this.Saved = true;
                return;
            }
            if (this.Saved == true)
            {
                this.Heart.Source = new BitmapImage(new Uri("ms-appx:///Assets/emptyheart.png"));
                this.Saved = false;
                return;
            }
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            //if(Movie is saved)
            //{
            //    remove movie from list
            //    this.Heart.Source = new BitmapImage(new Uri("ms-appx:///Assets/emptyheart.png"));
            //}
            //else
            //{
            //    add movie to list
            //    this.Heart.Source = new BitmapImage(new Uri("ms-appx:///Assets/fullheart.png"));
            //}

            FlipHeart();

        }
    }
    
}
