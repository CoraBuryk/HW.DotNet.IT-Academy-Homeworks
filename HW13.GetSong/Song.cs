using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13.GetSong
{
    internal class Song
    {
        public string title { get; set; }
        public string minutes { get; set; }
        public string artist { get; set; }
        public int albumYear { get; set; }

        public Song()
        { }
        public Song(string title, string minutes, int albumYear)
        {
            this.title = title;
            this.minutes = minutes;
            this.albumYear = albumYear;
        }
        public Song GetSongData()
        {   
            var song = new Song(title, minutes, albumYear);
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(song);
            // возвращает хранимые типы в виде упакованного объекта;
            Console.WriteLine(json);
            foreach (string name in Enum.GetNames(typeof(Genre)))
                Console.WriteLine(name);
            foreach (int i in Enum.GetValues(typeof(Genre)))
                Console.WriteLine(i);
            return song;
        }
        [Flags]
        enum Genre
        {
            Pop = 0,
            Rock = 1,
            Classical = 2,
            Jazz = 3,
            HipHop = 4,
        }

        public Song Serialiaze()
        {
            var song = new Song(title, minutes, albumYear);
            string js = System.Text.Json.JsonSerializer.Serialize(song);
            // возвращает значение типа object для любого из предствленных типов;
            Console.WriteLine(js);
            return song;
        }
    }
}