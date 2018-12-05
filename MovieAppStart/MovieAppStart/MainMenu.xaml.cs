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
        Movie Goodfellas = new Movie("Goodfellas", "Martin", "2:10", "Genre",
                                        "the story of Henry Hill and his life in the mob, covering his relationship with his wife Karen Hill and his mob partners Jimmy Conway and Tommy DeVito in the Italian-American crime syndicate.",
                                        "1990", "10", "https://m.media-amazon.com/images/M/MV5BY2NkZjEzMDgtN2RjYy00YzM1LWI4ZmQtMjIwYjFjNmI3ZGEwXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX667_CR0,0,667,999_AL_.jpg");
                        

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
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void CityOfGodClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void FightClubClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void ForrestGumpClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void GodFather2Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void GoodfellasClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void InceptionClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void LORReturnofKingClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void LORFellowshipClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void LORTwoTowersClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void CuckoosNestClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void PulpFictionClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void SchindlersListClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void SevenSamuraiClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void ShawShankClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void StarWarsVClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        
        private void TheDarkKnightClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void TheGodFatherClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void GoodBadClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void TheMatrixClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void AmericanHistoryClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void CasaBlancaClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void CityLightsClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void InterstellarClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void ItsAWonderfulLifeClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
        private void LeonClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
        }
    private void LIBClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
    }
    private void ModernTimesClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
    }
    private void OnceUponATimeClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
    }
    private void PsychoClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
    }
    private void PrivateRyanClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
    }
    private void SevenClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
    }
    private void SpiritedAwayClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
    }
    private void StarWars4Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
    }
    private void TheDepartedClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
    }
    private void GreenMileClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
    }
    private void IntouchablesClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
    }
    private void ThePianistClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
    }
    private void SilenceLambsClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
    }
    private void UsualSuspectsClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InfoPage1));
    }
    


}

}
