using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hierarchie_de_classes_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // trouver l'annee pour laquelle il y a le plus d'albums et l'annee ou il y a le plus de musiques.

         var readMusic = File.ReadAllLines(@"C:\Users\Administrateur\source\repos\exercice weekend 1106\Hier-class-2\Hierarchie de classes 2\Hierarchie de classes 2\SongCSV.csv");
        
            var donneesMusic = readMusic.Skip(1).Select(x => x.Split(',')).ToList();
            var musicsByYear = donneesMusic.Skip(1).GroupBy(x => x[17]).OrderBy(x => x.Count()).Reverse().ToList();

            Artist artists = new Artist();
            Band bands = new Band();
            Album albums = new Album();

            
            var getArtists = artists.GetAllArtists();
            var getAlbums = albums.GetAllAlbums();

            for(int i = 0; i < 10; i++)
            {

                Console.WriteLine($"Top  {(i + 1)} - {musicsByYear[(i + 1)].Key} - Musics Produced: {musicsByYear[i].Count()}  ");
            }
            

            
        }
    }
}
