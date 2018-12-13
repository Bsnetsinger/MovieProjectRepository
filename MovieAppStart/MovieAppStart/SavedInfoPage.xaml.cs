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


namespace MovieAppStart
{

    public partial class SavedInfoPage : Page
    {
        Movie MovieData = new Movie();

        User TempUser = new User();


        /// <summary>
        /// Recieve parameter e from specific movie button on main menu,
        /// set e to Movie object Moviedata,
        /// set information sources for info page equal MovieData information
        /// </summary>
        /// <param name="e"></param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            TempUser = e.Parameter as User;

            MovieData = TempUser.MovieTemp;

            //MovieData = e.Parameter as Movie;

            this.Summary.Text = MovieData.Synopsis;
            this.Length.Text = MovieData.Length;
            this.Image.Source = new BitmapImage(new Uri(MovieData.Image));
            this.Title.Text = MovieData.Title;
            this.Genre.Text = MovieData.Genre;
            this.Rating.Text = MovieData.Rating;
            this.Director.Text = MovieData.Director;

            if (TempUser.favoriteList.Contains(MovieData) == true)
            {
                this.Heart.Source = new BitmapImage(new Uri("ms-appx:///Assets/fullheart.png"));
            }
            else
            {
                this.Heart.Source = new BitmapImage(new Uri("ms-appx:///Assets/emptyheart.png"));
            }

        }
        public SavedInfoPage()
        {
            this.InitializeComponent();

        }

        /// <summary>
        /// On back button click, navigate back to main menu
        /// </summary>
        private void SaveBackClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SavedPage), TempUser);
        }

        /// <summary>
        /// On save button click, check if movie is stored on user list,
        /// if false, add movie
        /// if true, remove movie,
        /// </summary>
        private void SaveClick(object sender, RoutedEventArgs e)
        {

            if (TempUser.favoriteList.Contains(MovieData) == false)
            {
                TempUser.addMovie(MovieData);
                this.Heart.Source = new BitmapImage(new Uri("ms-appx:///Assets/fullheart.png"));

            }
            else
            {
                TempUser.removeMovie(MovieData);
                this.Heart.Source = new BitmapImage(new Uri("ms-appx:///Assets/emptyheart.png"));

            }
        }

        
    }

}
