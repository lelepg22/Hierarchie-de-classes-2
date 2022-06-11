using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchie_de_classes_2
{
    public class Album
    {
        public List<string> GetAllAlbums() { return File.ReadAllLines(@"C:\Users\Administrateur\source\repos\exercice weekend 1106\Hier-class-2\Hierarchie de classes 2\Hierarchie de classes 2\SongCSV.csv").Skip(1).Select(x => x.Split(',')).Select(x => x[3]).GroupBy(x => x).Select(x => x.First().Replace("b'", "")).ToList(); }
        // public List<string>
        public Album()
        {
        string album;
        Artist artist;
        Track track;
        }
    }
}
