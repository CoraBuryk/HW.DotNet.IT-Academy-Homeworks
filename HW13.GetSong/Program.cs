namespace HW13.GetSong
{
    class Program
    {
        static void Main()
        {
            Song song = new Song();
            song.GetSongData();
            song.Serialiaze();
        }
    }
}