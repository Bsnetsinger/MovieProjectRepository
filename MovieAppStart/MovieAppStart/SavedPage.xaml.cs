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

            int i = MovieArray.Length;
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
                    Button Button = new Button();
                    Button.Name = MovieTemp.Title;
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
            string s = Temp.Name.ToString();

            switch(s)
            {
                case "Goodfellas":
                    this.Frame.Navigate(typeof(SavedInfoPage), Goodfellas);
                    break;

                case "12 Angry Men":
                    this.Frame.Navigate(typeof(SavedInfoPage), AngryMen);
                    break;

                case "City of God":
                    this.Frame.Navigate(typeof(SavedInfoPage), CityOfGod);
                    break;

                case "Fight Club":
                    this.Frame.Navigate(typeof(SavedInfoPage), FightClub);
                    break;

                case "Forrest Gump":
                    this.Frame.Navigate(typeof(SavedInfoPage), ForrestGump);
                    break;

                case "The Godfather: Part II":
                    this.Frame.Navigate(typeof(SavedInfoPage), GodFather2);
                    break;

                case "American History X":
                    this.Frame.Navigate(typeof(SavedInfoPage), AmericanHistoryX);
                    break;

                case "Casablanca":
                    this.Frame.Navigate(typeof(SavedInfoPage), Casablanca);
                    break;

                case "CityLights":
                    this.Frame.Navigate(typeof(SavedInfoPage), CityLights);
                    break;

                case "Inception":
                    this.Frame.Navigate(typeof(SavedInfoPage), Inception);
                    break;

                case "Lord of the Rings: The Return of the King":
                    this.Frame.Navigate(typeof(SavedInfoPage), LORReturnOfTheKing);
                    break;

                case "Lord of the Rings: The Fellowship of the Ring":
                    this.Frame.Navigate(typeof(SavedInfoPage), LORFellowship);
                    break;

                case "One Flew Over the Cuckoos Nest":
                    this.Frame.Navigate(typeof(SavedInfoPage), CukoosNest);
                    break;

                case "Pulp Fiction":
                    this.Frame.Navigate(typeof(SavedInfoPage), PulpFiction);
                    break;

                case "Schindler's List":
                    this.Frame.Navigate(typeof(SavedInfoPage), SchindlersList);
                    break;

                case "Se7en":
                    this.Frame.Navigate(typeof(SavedInfoPage), Seven);
                    break;

                case "Seven Samurai":
                    this.Frame.Navigate(typeof(SavedInfoPage), SevenSamurai);
                    break;

                case "The Shawshank Redemption":
                    this.Frame.Navigate(typeof(SavedInfoPage), ShawshankRedemption);
                    break;

                case "Spirited Away":
                    this.Frame.Navigate(typeof(SavedInfoPage), SpiritedAway);
                    break;
            }


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


        Movie Inception = new Movie("Inception", "Christopher Nolan", "2:28", "Action, Adventure, Sci-Fi",
                                    "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.",
                                    "16 July 2010", "8.8", "ms-appx:///Assets/Inception.jpg");

        Movie LORReturnOfTheKing = new Movie("Lord of the Rings: The Return of the King", "Peter Jackson", "3:21", "Action, Adventure, Drama",
                                            "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                                            "17 December 2003", "8.9", "ms-appx:///Assets/lord of the rings_the return of the king.jpg");

        Movie LORFellowship = new Movie("Lord of the Rings: The Fellowship of the Ring", "Peter Jackson", "2:58", "Action, Drama, Fantasy",
                                        "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                                        "19 December 2001", "8.8", "ms-appx:///Assets/lord of the rings_the fellowship of the ring.jpg");

        Movie LORTwoTowers = new Movie("The Lord of the Rings: The Two Towers", "2:59", "Adventure, Drama, Fantasy", "Peter Jackson",
                                        "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.",
                                        "18 December 2002", "8.7", "ms-appx:///Assets/lord of the rings_the two towers.jpg");

        Movie CukoosNest = new Movie("One Flew Over the Cuckoos Nest", "Milos Forman", "2:13", "Drama",
                                    "A criminal pleads insanity after getting into trouble again and once in the mental institution rebels against the oppressive nurse and rallies up the scared patients.",
                                    "19 November 1975", "8.7", "ms-appx:///Assets/one flew over the cuckoos nest.jpg");

        Movie PulpFiction = new Movie("Pulp Fiction", "Ouentin Tarantino", "2:34", "Crime, Drama",
                                    "The lives of two mob hitmen, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                                    "14 October 1994", "8.9", "ms-appx:///Assets/pulp fiction.jpg");

        Movie SchindlersList = new Movie("Schindler's List", "Steven Speilberg", "3:15", "Biography, Drama, History",
                                        "In German-occupied Poland during World War II, Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazi Germans.",
                                        "4 February 1994", "8.9", "ms-appx:///Assets/schindlers list.jpg");

        Movie Seven = new Movie("Se7en", "David Fincher", "2:07", "Crime, Drama, Mystery",
                                "Two detectives, a rookie and a veteran, hunt a serial killer who uses the seven deadly sins as his motives.",
                                "1995", "8.6", "ms-appx:///Assets/Se7en.jpg");

        Movie SevenSamurai = new Movie("Seven Samurai", "Akira Kurosawa", "3:27", "Adventure, Drama",
                                       "A poor village under attack by bandits recruits seven unemployed samurai to help them defend themselves.",
                                       "1956", "8.7", "ms-appx:///Assets/seven samurai.jpg");

        Movie ShawshankRedemption = new Movie("The Shawshank Redemption", "Frank Darabont", "2:22", "Drama",
                                              "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                                              "1994", "9.3", "ms-appx:///Assets/shawshank redemption.jpg");

        Movie SpiritedAway = new Movie("Spirited Away", "Hayao Miyazaki", "2:05", "Animation, Adventure, Family",
                                       "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches, and spirits, and where humans are changed into beasts.",
                                       "2001", "8.6", "ms-appx:///Assets/spirited away.jpg");

        Movie StarWarsIV = new Movie("Star Wars: Episode IV - A New Hope", "George Lucas", "2:01", "Action, Adventure, Fantasy",
                                     "Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a Wookiee and two droids to save the galaxy from the Empire's world-destroying battle station, while also attempting to rescue Princess Leia from the evil Darth Vader.",
                                     "1977", "8.6", "ms-appx:///Assets/star wars_episode 4 a new hope.jpg");

        Movie StarWarsV = new Movie("Star Wars: Episode V - The Empire Strikes Back", "George Lucas", "2:04", "Action, Adventure, Fantasy",
                                    "After the rebels are brutally overpowered by the Empire on the ice planet Hoth, Luke Skywalker begins Jedi training with Yoda, while his friends are pursued by Darth Vader.",
                                    "1980", "8.8", "ms-appx:///Assets/star wars episode V.jpg");

        Movie TheDarkKnight = new Movie("The Dark Knight", "Christopher Nolan", "2:32", "Action, Crime, Drama",
                                        "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                                        "2008", "9.0", "ms-appx:///Assets/the dark knight.jpg");

        Movie TheDeparted = new Movie("The Departed", "Martin Scorsese", "2:31", "Crime, Drama, Thriller",
                                      "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang in South Boston.",
                                      "2006", "8.5", "ms-appx:///Assets/the departed.jpg");

        Movie TheGodfather = new Movie("The Godfather", "Francis Ford Coppola", "2:55", "Crime, Drama",
                                       "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                                       "1972", "9.2", "ms-appx:///Assets/the godfather.jpg");

        Movie TGTBTU = new Movie("The Good, The Bad and The Ugly", "Sergio Leone", "2:58", "Western",
                                 "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
                                 "1966", "8.9", "ms-appx:///Assets/the good, the bad and the ugly.jpg");

        Movie GreenMile = new Movie("The Green Mile", "Frank Darabont", "3:09", "Crime, Drama, Fantasy",
                                    "The lives of guards on Death Row are affected by one of their charges: a black man accused of child murder and rape, yet who has a mysterious gift.",
                                    "1999", "8.5", "ms-appx:///Assets/the green mile.jpg");

        Movie Intouchables = new Movie("The Intouchables", "Olivier Nakache", "1:52", "Biography, Comedy, Drama",
                                       "After he becomes a quadriplegic from a paragliding accident, an aristocrat hires a young man from the projects to be his caregiver.",
                                       "2011", "8.5", "ms-appx:///Assets/the intouchables.jpg");

        Movie Matrix = new Movie("The Matrix", "The Wachowski Brothers", "2:16", "Action, Sci-Fi",
                                 "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
                                 "1999", "8.7", "ms-appx:///Assets/the matrix.jpg");

        Movie Pianist = new Movie("The Pianist", "Roman Polanski", "2:30", "Biography, Drama, Music",
                                  "A Polish Jewish musician struggles to survive the destruction of the Warsaw ghetto of World War II.",
                                  "2002", "8.5", "ms-appx:///Assets/the pianist.jpg");

        Movie Lambs = new Movie("The Silence of The Lambs", "Jonathan Demme", "1:58", "Crime, Drama, Thriller",
                                "A young FBI cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.",
                                "1991", "8.6", "ms-appx:///Assets/the silence of the lambs.jpg");

        Movie UsualSuspects = new Movie("The Usual Suspects", "Bryan Singer", "1:46", "Crime, Mystery, Thriller",
                                        "A sole survivor tells of the twisty events leading up to a horrific gun battle on a boat, which began when five criminals met at a seemingly random police lineup.",
                                        "1995", "8.6", "ms-appx:///Assets/the usual suspects.jpg");

        Movie Interstellar = new Movie("Interstellar", "Christopher Nolan", "2:49", "Adventure, Drama, Sci-Fi",
                                       "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                                       "2014", "8.6", "ms-appx:///Assets/interstellar.jpg");

        Movie WonderfulLife = new Movie("It's a Wonderful Life", "Frank Capra", "2:10", "Drama, Fantasy, Family",
                                        "An angel is sent from Heaven to help a desperately frustrated businessman by showing him what life would have been like if he had never existed.",
                                        "1947", "8.6", "ms-appx:///Assets/its a wonderful life.jpg");

        Movie Leon = new Movie("Leon: The Professional", "Luc Besson", "1:50", "Crime, Drama, Thriller",
                               "Mathilda, a 12-year-old girl, is reluctantly taken in by Léon, a professional assassin, after her family is murdered. Léon and Mathilda form an unusual relationship, as she becomes his protégée and learns the assassin's trade.",
                               "1994", "8.6", "ms-appx:///Assets/Leon the professional.jpg");

        Movie LIB = new Movie("Life is Beautiful", "Robert Benigni", "1:56", "Comedy, Drama, Romance",
                              "When an open-minded Jewish librarian and his son become victims of the Holocaust, he uses a perfect mixture of will, humor, and imagination to protect his son from the dangers around their camp.",
                              "1997", "8.6", "ms-appx:///Assets/life is beautiful.jpg");

        Movie ModernTimes = new Movie("Modern Times", "Charles Chaplin", "1:27", "Comedy, Drama, Family",
                                      "The Tramp struggles to live in modern industrial society with the help of a young homeless woman.",
                                      "1936", "8.5", "ms-appx:///Assets/modern times.jpg");

        Movie OnceUponATime = new Movie("Once Upon a Time in The West", "Sergio Leone", "2:45", "Western",
                                        "A mysterious stranger with a harmonica joins forces with a notorious desperado to protect a beautiful widow from a ruthless assassin working for the railroad.",
                                        "1968", "8.5", "ms-appx:///Assets/once upon a time in the west.jpg");

        Movie Psycho = new Movie("Psycho", "Alfred Hitchcock", "1:49", "Horror, Mystery, Thriller",
                                 "A Phoenix secretary embezzles forty thousand dollars from her employer's client, goes on the run, and checks into a remote motel run by a young man under the domination of his mother.",
                                 "1960", "8.5", "ms-appx:///Assets/psycho.jpg");

        Movie PrivateRyan = new Movie("Saving Private Ryan", "Steven Spielberg", "2:49", "Drama, War",
                                      "Following the Normandy Landings, a group of U.S. soldiers go behind enemy lines to retrieve a paratrooper whose brothers have been killed in action.",
                                      "1998", "8.6", "ms-appx:///Assets/saving private ryan.jpg");

    }
}
