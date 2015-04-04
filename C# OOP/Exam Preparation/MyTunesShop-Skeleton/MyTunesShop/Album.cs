using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTunesShop
{
    public class Album : Media, IAlbum
    {
        private IPerformer performer;
        private string genre;
        private int year;
        private IList<ISong> songs;
        public Album(string title, decimal price, IPerformer performer, string genre, int year)
            : base(title, price)
        {
            this.Performer = performer;
            this.Genre = genre;
            this.Year = year;
            this.Songs = new List<ISong>();
        }
        public IPerformer Performer
        {
            get 
            {
                return this.performer;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Album performer is null");
                }
                this.performer = value;
            }
        }

        public string Genre
        {
            get 
            {
                return this.genre;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Album genre string is null or empty");
                }
                this.genre = value;
            }
        }

        public int Year
        {
            get 
            {
                return this.year;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Album year is invalid value");
                }
                this.year = value;
            }
        }

        public IList<ISong> Songs
        {
            get 
            {
                return this.songs;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Album list of songs is null");
                }
                this.songs = value;
            }
        }

        public void AddSong(ISong song)
        {
            this.Songs.Add(song);
        }
    }
}
