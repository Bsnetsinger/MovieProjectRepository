using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppStart
{
    /// <summary>
    /// How Movies are created. Gets/Sets Title, Director, Length, Genre, Synopsis, Release Date, Rating, and image in order to use in program. 
    /// Contains default constructor and explicit value constructor.
    /// </summary>
    class Movie : IComparable<Movie>
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Length { get; set; }
        public string Genre { get; set; }
        public string Synopsis { get; set; }
        public string ReleaseDate { get; set; }
        public string Rating { get; set; }
        public string Image { get; set; }


        public Movie()
        {
            Title = "No title yet";
            Director = "No director yet";
            Length = "0";
            Genre = " No genre yet";
            Synopsis = "No synopsis yet";
            ReleaseDate = "Never";
            Rating = "0.0";
            Image = "ms-appx:///Assets/noimage.jpg";
        }

        public Movie(string title, String director, string length, String genre, String synopsis,
            string releaseDate, string rating, string image)
        {
            Title = title;
            Director = director;
            Length = length;
            Genre = genre;
            Synopsis = synopsis;
            ReleaseDate = releaseDate;
            Rating = rating;
            Image = image;
        }
        //public string getImage() => Image;
        //public string getTitle() => Title;
        //public int getLength() => Length;
        //public string getDirector() => Director;
        //public string getGenre() => Genre;
        //public string getSynopsis() => Synopsis;
        //public string getReleaseDate() => ReleaseDate;
        //public double getRating() => Rating;

        public int CompareTo(Movie obj)
        {
            if (obj == null) return 1;

            return this.Title.CompareTo(obj.Title);

        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (this.Title.Equals(((Movie)obj).Title) && this.Director.Equals(((Movie)obj).Director)
                && this.Length == ((Movie)obj).Length && this.Genre.Equals(((Movie)obj).Genre)
                && this.ReleaseDate.Equals(((Movie)obj).ReleaseDate)) return true;

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Title: {this.Title}\nDirector: {this.Director}\nLength: {this.Length} Genre: {this.Genre}";
        }
    }
}
