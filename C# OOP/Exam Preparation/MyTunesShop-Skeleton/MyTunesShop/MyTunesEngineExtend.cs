using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTunesShop
{
    class MyTunesEngineExtend : MyTunesEngine
    {
        protected override void ExecuteInsertCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "member_to_band":
                    this.ExecuteInsertBandMember(commandWords);
                    break;
                case "song_to_album":
                    this.ExecuteInsertSongToAlbum(commandWords);
                    break;
                default:
                    base.ExecuteInsertCommand(commandWords);
                    break;
            }
        }
        protected override void ExecuteInsertPerformerCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "singer":
                    var singer = new Singer(commandWords[3]);
                    this.InsertPerformer(singer);
                    break;
                case "band":
                    var band = new Band(commandWords[3]);
                    this.InsertPerformer(band);
                    break;
                default:
                    base.ExecuteInsertPerformerCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteReportPerformerCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "singer":
                    var singer = this.performers.FirstOrDefault(p => p is Singer && p.Name == commandWords[3]) as Singer;
                    if (singer == null)
                    {
                        this.Printer.PrintLine("The singer does not exist in the database.");
                        return;
                    }
                    this.Printer.PrintLine(this.GetSingerReport(singer));
                    break;
                case "band":
                    var band = this.performers.FirstOrDefault(b => b is Band && b.Name == commandWords[3]) as Performer;
                    if (band == null)
                    {
                        this.Printer.Print("The band does not exist in the database.");
                        return;
                    }
                    this.Printer.PrintLine(this.GetBandReport(band));// Print or PrintLine
                    break;
                default:
                    base.ExecuteReportPerformerCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteReportMediaCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "album":
                    var album = this.media.FirstOrDefault(m => m is IAlbum && m.Title == commandWords[3]) as IAlbum;
                    if (album == null)
                    {
                        this.Printer.PrintLine("The album does not exist in the database.");
                        return;
                    }

                    this.Printer.Print(this.GetAlbumReport(album));// Print or PrintLine
                    break;
                default:
                    base.ExecuteReportMediaCommand(commandWords);
                    break;
            }
        }


        protected override void ExecuteInsertMediaCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "album":
                    var performer = this.performers.FirstOrDefault(p => p.Name == commandWords[5]);
                    if (performer == null)
                    {
                        this.Printer.PrintLine("The performer does not exist in the database.");
                        return;
                    }
                    Album album = new Album(commandWords[3], decimal.Parse(commandWords[4]), performer, commandWords[6], int.Parse(commandWords[7]));
                    this.InsertAlbum(album, performer);
                    break;
                default:
                    base.ExecuteInsertMediaCommand(commandWords);
                    break;
            }
        }
        protected override void ExecuteRateCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "song":
                    this.ExecuteInsertSongRate(commandWords);
                    break;
                default:
                    break;
            }
        }
        protected override void ExecuteSupplyCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "album":
                    var album = this.media.FirstOrDefault(a => a is IAlbum && a.Title == commandWords[2]);
                    if (album == null)
                    {
                        this.Printer.PrintLine("The album does not exist in the database.");
                        return;
                    }

                    int albumQuantity = int.Parse(commandWords[3]);
                    this.mediaSupplies[album].Supply(albumQuantity);
                    this.Printer.PrintLine("{0} items of album {1} successfully supplied.", albumQuantity, album.Title);
                    break;
                default:
                    base.ExecuteSupplyCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteSellCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "album":
                    var album = this.media.FirstOrDefault(a => a is IAlbum && a.Title == commandWords[2]);
                    if (album == null)
                    {
                        this.Printer.PrintLine("The album does not exist in the database.");
                        return;
                    }

                    int albumQuantity = int.Parse(commandWords[3]);
                    this.mediaSupplies[album].Sell(albumQuantity);
                    this.Printer.PrintLine("{0} items of album {1} successfully sold.", albumQuantity, album.Title);
                    break;
                default:
                    base.ExecuteSellCommand(commandWords);
                    break;
            }
        }
        private void ExecuteInsertSongRate(string[] commandWords)
        {
            Song song = this.media.FirstOrDefault(m => m is Song && m.Title == commandWords[2]) as Song;
            
            if (song != null)
            {
                song.Ratings.Add(int.Parse(commandWords[3]));
                this.Printer.PrintLine("The rating has been placed successfully.");
            }

        }

        private void InsertAlbum(IAlbum album, IPerformer performer)
        {
            this.media.Add(album);
            this.mediaSupplies.Add(album, new SalesInfo());
            this.Printer.PrintLine("Album {0} by {1} added successfully", album.Title, performer.Name);
        }
        protected override string GetSongReport(ISong song)
        {
            var songSalesInfo = this.mediaSupplies[song];
            int averageRating = (int) Math.Round(((song as Song).Ratings.Count > 0 ? (song as Song).Ratings.Average() : 0),MidpointRounding.AwayFromZero);
            StringBuilder songInfo = new StringBuilder();
            songInfo.AppendFormat("{0} ({1}) by {2}", song.Title, song.Year, song.Performer.Name).AppendLine()
                .AppendFormat("Genre: {0}, Price: ${1:F2}", song.Genre, song.Price).AppendLine()
                .AppendFormat("Rating: {0}", averageRating).AppendLine()
                .AppendFormat("Supplies: {0}, Sold: {1}", songSalesInfo.Supplies, songSalesInfo.QuantitySold);
            return songInfo.ToString();
        }
        private string GetAlbumReport(IAlbum album)
        {
            StringBuilder albumInfo = new StringBuilder();
            albumInfo.AppendFormat("{0} ({1}) by {2}", album.Title, album.Year, album.Performer.Name).AppendLine();
            albumInfo.AppendFormat("Genre: {0}, Price: ${1:F2}", album.Genre, album.Price).AppendLine();
            var albumSalesInfo = this.mediaSupplies[album];
            albumInfo.AppendFormat("Supplies: {0}, Sold: {1}", albumSalesInfo.Supplies, albumSalesInfo.QuantitySold).AppendLine();
            if (album.Songs.Any())
            {
                albumInfo.AppendLine("Songs:");
                var songs = album.Songs
                    .Select(s => new { s.Title, s.Duration});
                foreach (var song in songs)
                {
                    albumInfo.AppendFormat("{0} ({1})", song.Title , song.Duration).AppendLine();
                }
            }
            else
            {
                albumInfo.AppendLine("No songs");
            }
            return albumInfo.ToString();
        }
        private string GetBandReport(Performer band)
        {
            StringBuilder bandInfo = new StringBuilder();
            bandInfo.AppendLine(band.Name + ": " + string.Join(", ", (band as Band).Members));
            if (band.Songs.Any())
            {
                var songs = band.Songs
                  .Select(s => s.Title)
                  .OrderBy(s => s);
                bandInfo.Append(string.Join("; ", songs));
            }
            else
            {
                bandInfo.Append("no songs");
            }

            return bandInfo.ToString();
        }
        private void ExecuteInsertSongToAlbum(string[] commandWords)
        {
            Album album = this.media.FirstOrDefault(m => m.GetType().Name == "Album" && m.Title == commandWords[2]) as Album;
            if (album == null)
            {
                this.Printer.PrintLine("The album does not exist in the database.");
                return;
            }
            Song song = this.media.FirstOrDefault(m => m.GetType().Name == "Song" && m.Title == commandWords[3]) as Song;
            if (song == null)
            {
                this.Printer.PrintLine("The song does not exist in the database.");
                return;
            }

            album.AddSong(song);
            this.Printer.PrintLine("The song {0} has been added to the album {1}.", song.Title, album.Title);
        }
        private void ExecuteInsertBandMember(string[] commandWords)
        {
            var band = this.performers.FirstOrDefault(p => p.Name == commandWords[2] && p.Type == PerformerType.Band) as Band;
            if (band != null)
            {
                band.Members.Add(commandWords[3]);
                this.Printer.PrintLine(string.Format("The member {0} has been added to the band {1}.", commandWords[3], band.Name));
            }
            else
            {
                this.Printer.PrintLine("The band does not exist in the database.");
            }
        }
    }
}
