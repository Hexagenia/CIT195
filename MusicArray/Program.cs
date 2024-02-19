using System;

namespace MusicArray
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
            public string Title;
            public string Artist;
            public string Time;
            public Genre Genre;

            public Music(string title, string artist, string time, Genre genre)
            {
                Title = title;
                Artist = artist;
                Time = time;
                Genre = genre;
            }

            public string DisplayOutput()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nTime: " + Time + "\nGenre: " + Genre;
            }
        }

        static Genre GetGenreFromInput(string input)
        {
           switch (input.ToUpper())
           {
               case "E":
                return Genre.EDM;
               case "R":
                return Genre.Rock;
               case "M":
                return Genre.Metal;
               case "P":
                return Genre.Pop;
               case "S":
                return Genre.Progressive;
               default:
                throw new ArgumentException("Please type E, R, M, P, or S");
           }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int size;
            try
            {
                size = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            Music[] collection = new Music[size];

            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Please enter the song title:");
                    string title = Console.ReadLine();

                    Console.WriteLine("Who is the artist?");
                    string artist = Console.ReadLine();

                    Console.WriteLine("How long is the song?");
                    string time = Console.ReadLine();

                    Console.WriteLine("What is the genre? (E - EDM, R - Rock, M - Metal, P - Pop, S - Progressive)");

                    Genre genre;
                    while (true)
                    {
                        try
                        {
                            genre = GetGenreFromInput(Console.ReadLine());
                            break;
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                    collection[i] = new Music(title, artist, time, genre);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Displaying songs and information
            Console.WriteLine("\nHere's your music collection:");
            foreach (Music music in collection)
            {
                Console.WriteLine("\n" + music.DisplayOutput());
            }
        }
    }
}