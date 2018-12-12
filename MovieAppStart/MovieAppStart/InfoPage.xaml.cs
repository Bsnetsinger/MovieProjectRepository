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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    public partial class InfoPage : Page
    {
        Movie MovieData;


        /// <summary>
        /// Recieve parameter e from specific movie button on main menu,
        /// set e to Movie object Moviedata,
        /// set information sources for info page equal MovieData information
        /// </summary>
        /// <param name="e"></param>
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

        }
        public InfoPage()
        {
            this.InitializeComponent();

        }

        /// <summary>
        /// On back button click, navigate back to main menu
        /// </summary>
        private void BackClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }


        User NewUser = new User();

        /// <summary>
        /// On save button click, check if movie is stored on user list,
        /// if false, add movie
        /// if true, remove movie,
        /// </summary>
        private void SaveClick(object sender, RoutedEventArgs e)
        {

            if (NewUser.favoriteList.Contains(MovieData) == false)
            {
                NewUser.addMovie(MovieData);
                this.Heart.Source = new BitmapImage(new Uri("ms-appx:///Assets/fullheart.png"));

                Movie[] MovieArray = NewUser.getMovieList();
                Movie test = MovieArray[0];                             //display movie title for testing purposes
                this.ListTest.Text = test.Title; 

            }
            else
            {
                NewUser.removeMovie(MovieData);
                this.Heart.Source = new BitmapImage(new Uri("ms-appx:///Assets/emptyheart.png"));

                this.ListTest.Text = ""; 
            }

        }
    }
    
}
