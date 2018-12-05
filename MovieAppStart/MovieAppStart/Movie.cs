using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppStart
{
    class Movie : IComparable<Movie>
    {
        private string Title;                  //comment test
        private string Director;
        private string Length;
        private string Genre;
        private string Synopsis;
        private string ReleaseDate;
        private string Rating;
        private string Image;


        public Movie()
        {
            Title = "No title yet";
            Director = "No director yet";
            Length = "No length yet";
            Genre = " No genre yet";
            Synopsis = "No synopsis yet";
            ReleaseDate = "Never";
            Rating = "No rating yet";
        }

        public Movie(string title, string director, string length, string genre, string synopsis,
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

        public string getImage() => Image;
        public string getTitle() => Title;
        public string getLength() => Length;
        public string getDirector() => Director;
        public string getGenre() => Genre;
        public string getSynopsis() => Synopsis;
        public string getReleaseDate() => ReleaseDate;
        public string getRating() => Rating;
        
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
