using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.OnlineRadioDatabasse
{
    public class Playlist
    {
        public Playlist()
        {
            this.songs = new List<Song>();
        }

        private List<Song> songs;
        public IReadOnlyList<Song> Songs
        {
            get { return this.songs; }
        }

        public void TryAddSong(string dataString)
        {
            var tokens = dataString.Split(';');

            var artist = tokens[0];
            var name = tokens[1];
            var timeTokens = tokens[2].Split(':');

            var song = new Song(artist, name, int.Parse(timeTokens[0]), int.Parse(timeTokens[1]));

            songs.Add(song);
        }

        public string Length
        {
            get
            {
                var totalTicks = songs.Sum(x => x.Length.Ticks);
                var totalLen = new TimeSpan(totalTicks);

                return $"{totalLen.Hours}h {totalLen.Minutes}m {totalLen.Seconds}s";
            }
        }
    }
}
