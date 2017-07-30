using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.OnlineRadioDatabasse
{
    public class Song
    {
        public Song(string artist, string name, int minutes, int seconds)
        {
            this.Artist = artist;
            this.Name = name;
            this.Minutes = minutes;
            this.Seconds = seconds;

            this.length = new TimeSpan(0, this.Minutes, this.Seconds);
        }

        private string artist;
        public string Artist
        {
            get
            {
                return this.artist;
            }
            set
            {
                if(value.Length < 3 || value.Length > 20)
                {
                    throw new Exception("Artist name should be between 3 and 20 symbols.");
                }

                this.artist = value;
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new Exception("Song name should be between 3 and 30 symbols.");
                }

                this.name = value;
            }
        }

        private int minutes;
        public int Minutes
        {
            get
            {
                return this.minutes;
            }
            set
            {
                if(value < 0 || value > 14)
                {
                    throw new Exception("Song minutes should be between 0 and 14.");
                }

                this.minutes = value;
            }
        }

        private int seconds;
        public int Seconds
        {
            get
            {
                return this.seconds;
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new Exception("Song seconds should be between 0 and 59.");
                }

                this.seconds = value;
            }
        }

        //private string Length
        //{
        //    get
        //    {
        //        var len = new StringBuilder();

        //        if(this.minutes < 10)
        //        {
        //            len.Append("0");
        //        }

        //        len.Append(this.minutes);
        //        len.Append(":");

        //        if(this.seconds < 10)
        //        {
        //            len.Append("0");
        //        }

        //        len.Append(this.seconds);

        //        return len.ToString();
        //    }
        //}

        private TimeSpan length;
        public TimeSpan Length
        {
            get
            {
                return this.length;
            }
        }
    }
}
