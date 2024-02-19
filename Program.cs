using System;
namespace FunWithMusic
{
    class Program
    {
        enum Genre
        {
            EDM,
            Rock,
            Metal,
            Pop,
            Progressive
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Time;
            private Genre? Genre;

            public Music(string title, string artist, string time, Genre genre)
            {
                Title = title;
                Artist = artist;
                Time = time;
                Genre = genre;
            }



            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setTime(string time)
            {
                Time = time;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }


            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nTime: " + Time + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite song?");
            string tempTitle=Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string tempArtist=Console.ReadLine();
            Console.WriteLine("How long is the song?");
            string tempTime=Console.ReadLine();
            Console.WriteLine("What is the genre?");
            Console.WriteLine("E - EDM\nR - Rock\nM - Metal\nP - Pop\nS - Progressive");
            Genre tempGenre=Genre.EDM;
            //Genre tempGenre=Genre.EDM;
            char g = char.Parse(Console.ReadLine());
            switch(g)
            {
                case 'E':
                    tempGenre = Genre.EDM; 
                    break;
                case 'R':
                    tempGenre = Genre.Rock;
                    break;
                case 'M':
                    tempGenre = Genre.Metal;
                    break;
                case 'P':
                    tempGenre = Genre.Pop;
                    break;
                case 'S':
                    tempGenre = Genre.Progressive;
                    break;
            }
            Music music= new Music(tempTitle,tempArtist,tempTime,tempGenre);
            //Console.WriteLine($"{music.Display()}");




            Music newMusic= music;
            //changing values in the new structure variable
            newMusic.setTime("5:19");
            newMusic.setTitle("Swagsvile");
            //newMusic.setGenre("EDM");
            newMusic.setArtist("Badklaat");

            //Printing the new music
            Console.WriteLine("\n Here's song #2");
            Console.WriteLine($"{newMusic.Display()}");
            Console.WriteLine();
            //Printing the original
            Console.WriteLine("Here's song #1");
            Console.WriteLine($"{music.Display()}");
            

        }
        
    }
}