using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieRentalSoftware
{
    public class Movies
    {
        /////////Attributes//////
        public string Title { get; private set; }
        public DateTime ReleaseYear { get; private set; }
        public string Genre { get; private set; }
        public string Description { get; private set; }
        public string[] Actors { get; private set; }
        public string ContentRating {get; private set;}
        public double IMBDrating { get;  private set; }
        public double Price { get; private set; }

        ////////Constructor//////
        public Movies(string title, DateTime releaseYear, string genre, string description, string contentRating, double iMDBRating, double price) 
        {
            Title = title;
            ReleaseYear = releaseYear;
            Genre = genre;
            Description = description;
            ContentRating = contentRating;
            IMBDrating = iMDBRating;
            Price = price;
        }
        ////////Methods/////////
        public void SetPrice(double NewPrice) 
        {
        }
        public double GetPrice() { return Price; }
    }
}
