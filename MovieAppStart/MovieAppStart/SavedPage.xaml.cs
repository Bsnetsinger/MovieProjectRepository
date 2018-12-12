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
    public sealed partial class SavedPage : Page
    {
        public SavedPage()
        {
            this.InitializeComponent();
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            User TestUser = new User();

            TestUser.addMovie(Goodfellas);
            TestUser.addMovie(AngryMen);
            TestUser.addMovie(CityOfGod);
            TestUser.addMovie(FightClub);
            TestUser.addMovie(ForrestGump);

            Movie[] MovieArray = TestUser.favoriteList.ToArray();

            int i = 5;
            int j = 0;

            for(j=0; j<i; j++)
            {
                if(MovieArray[j] == null)
                {
                    break;
                }
                else
                {
                    Movie MovieTemp = MovieArray[j];
                    var MovieImage = new Image { Source = new BitmapImage(new Uri(MovieTemp.Image)) };
                    string testtitle = MovieTemp.Title;
                    Button Button = new Button();
                    Button.Name = testtitle;
                    Button.HorizontalAlignment = HorizontalAlignment.Center;
                    Button.Height = 268;
                    Button.VerticalAlignment = VerticalAlignment.Center;
                    Button.Width = 182;
                    Button.FontSize = 48;
                    Button.BorderThickness = new Thickness(0, 0, 0, 0);
                    Button.Margin = new Thickness(25, 25, 24, 50);
                    Button.Content = MovieImage;

                    Button.Click += new RoutedEventHandler(ButtonClick);


                    this.WrapGrid.Children.Add(Button);

                }
 
            }



        }

        /// <summary>
        /// Generic Button Click method that checks the button name and
        /// send the user to the correct page.
        /// </summary>
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            var Temp = sender as Button;
            
            if(Temp.Name == "Goodfellas")
                this.Frame.Navigate(typeof(SavedInfoPage), Goodfellas);
            if(Temp.Name == "12 Angry Men")
                this.Frame.Navigate(typeof(SavedInfoPage), AngryMen);


        }

        Movie Goodfellas = new Movie("Goodfellas", "Martin Scorsese", "2:26", "Crime, Drama",
                                       "The story of Henry Hill and his life in the mob, covering his relationship with his wife Karen Hill and his mob partners Jimmy Conway and Tommy DeVito in the Italian-American crime syndicate.",
                                       "1990", "8.7", "ms-appx:///Assets/goodfellas.jpg");

        Movie AngryMen = new Movie("12 Angry Men", "Sidney Lumet", "1:36", "Crime, Drama",
                                  "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                                  "1957", "8.9", "ms-appx:///Assets/12 angry men.jpg");

        Movie CityOfGod = new Movie("City of God", "Fernando Meirelles", "2:10", "Crime, Drama",
                                    "In the slums of Rio, two kids' paths diverge as one struggles to become a photographer and the other a kingpin.",
                                    "2004", "8.6", "ms-appx:///Assets/city of god.jpg");

        Movie FightClub = new Movie("Fight Club", "David Fincher", "2:19", "Drama",
                                    "An insomniac office worker and a devil-may-care soapmaker form an underground fight club that evolves into something much, much more.",
                                    "1999", "8.8", "ms-appx:///Assets/fight club.jpg");

        Movie ForrestGump = new Movie("Forrest Gump", "Robert Zemeckis", "2:22", "Drama, Romance",
                                      "The presidencies of Kennedy and Johnson, Vietnam, Watergate, and other history unfold through the perspective of an Alabama man with an IQ of 75.",
                                      "1994", "8.8", "ms-appx:///Assets/forrest gump.jpg");


    }
}
