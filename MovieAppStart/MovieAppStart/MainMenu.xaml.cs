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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MovieAppStart
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainMenu : Page
    {
        Movie Goodfellas = new Movie("Goodfellas", "Martin Scorsese", "2:26", "Crime, Drama",
                                       "the story of Henry Hill and his life in the mob, covering his relationship with his wife Karen Hill and his mob partners Jimmy Conway and Tommy DeVito in the Italian-American crime syndicate.",
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

        Movie GodFather2 = new Movie("The Godfather: Part II", "Francis Ford Copola", "3:22", "Crime, Drama",
                                     "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                                     "1974", "9.0", "ms-appx:///Assets/godfather part 2.jpg");

        Movie AmericanHistoryX = new Movie("American History X", "Tony Kaye", "1:59", "Crime, Drama",
                                           "A former neo-nazi skinhead tries to prevent his younger brother from going down the same wrong path that he did.",
                                           "1998", "8.5", "ms-appx:///Assets/american history X.jpg");

        Movie Casablanca = new Movie("Casablanca", "Michael Curtiz", "1:42", "Drama, Romance, War",
                                     "A cynical nightclub owner protects an old flame and her husband from Nazis in Morocco.",
                                     "1942", "8.5", "ms-appx:///Assets/casablanca.jpg");

        Movie CityLights = new Movie("City Lights", "Charles Chaplin", "1:27", "Comedy, Drama, Romance",
                                     "With the aid of a wealthy erratic tippler, a dewy-eyed tramp who has fallen in love with a sightless flower girl accumulates money to be able to help her medically.",
                                     "1931", "8.5", "ms-appx:///Assets/city lights.jpg");

        public MainMenu()
        {
            this.InitializeComponent();
            
        }
        private void MovieClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage), Goodfellas);
        }

        private void AngryMenClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage), AngryMen);
        }
        private void CityOfGodClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage), CityOfGod);
        }
        private void FightClubClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage), FightClub);
        }
        private void ForrestGumpClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage), ForrestGump);
        }
        private void GodFather2Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage), GodFather2);
        }
        private void GoodfellasClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage), Goodfellas);
        }
        private void InceptionClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
        }
        private void LORReturnofKingClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
        }
        private void LORFellowshipClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
        }
        private void LORTwoTowersClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
        }
        private void CuckoosNestClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
        }
        private void PulpFictionClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
        }
        private void SchindlersListClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
        }
        private void SevenSamuraiClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
        }
        private void ShawShankClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
        }
        private void StarWarsVClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
        }
        
        private void TheDarkKnightClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
        }
        private void TheGodFatherClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
        }
        private void GoodBadClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
        }
        private void TheMatrixClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
        }
        private void AmericanHistoryClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage), AmericanHistoryX);
        }
        private void CasaBlancaClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage), Casablanca);
        }
        private void CityLightsClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage), CityLights);
        }
        private void InterstellarClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
        }
        private void ItsAWonderfulLifeClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
        }
        private void LeonClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
        }
    private void LIBClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
    }
    private void ModernTimesClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
    }
    private void OnceUponATimeClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
    }
    private void PsychoClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
    }
    private void PrivateRyanClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
    }
    private void SevenClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
    }
    private void SpiritedAwayClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
    }
    private void StarWars4Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
    }
    private void TheDepartedClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
    }
    private void GreenMileClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
    }
    private void IntouchablesClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
    }
    private void ThePianistClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
    }
    private void SilenceLambsClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
    }
    private void UsualSuspectsClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage));
    }
    


}

}
