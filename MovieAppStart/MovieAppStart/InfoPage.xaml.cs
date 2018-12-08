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

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            MovieData = e.Parameter as Movie;

            this.Summary.Text = MovieData.getSynopsis();
            this.Length.Text = MovieData.getLength();
            this.Image.Source = new BitmapImage(new Uri(MovieData.getImage()));
            this.Title.Text = MovieData.getTitle();
            this.genre.Text = MovieData.getGenre();
            this.rating.Text = MovieData.getRating();
            this.director.Text = MovieData.getDirector();

        }
        public InfoPage()
        {
            this.InitializeComponent();

        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }


    }
    
}
