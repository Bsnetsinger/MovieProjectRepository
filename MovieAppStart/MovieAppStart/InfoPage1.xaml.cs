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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MovieAppStart
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class InfoPage1 : Page
    {
        private Movie movie;
        public InfoPage1()
        {
            this.InitializeComponent();

            this.setMovie();   //We need to figure out how to send a Movie object to this page!!!!!!!!!!!!!!!!!!!

            this.image.Source = new BitmapImage(new Uri(movie.getImage()));
            this.Title.Text = movie.getTitle();
            this.director.Text = movie.getDirector();
            this.length.Text = $"{movie.getLength()}";
            this.summary.Text = movie.getSynopsis();

        }
        private void BackClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }

        // ------ Test method, will create a Movie object for movie variable
        private void setMovie()
        {
            movie = new Movie("Goodfellas", "Martin Scor", 130, "Drama",
               "The story of henry hill and his life in the mob, covering his relationship with his wife karen hill and his mob partners jimmy conway and tommy devito in the italian-american crime syndicate.",
               "1990/09/19", 8.7, "https://m.media-amazon.com/images/M/MV5BY2NkZjEzMDgtN2RjYy00YzM1LWI4ZmQtMjIwYjFjNmI3ZGEwXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX667_CR0,0,667,999_AL_.jpg");

        }
        
    }
}
