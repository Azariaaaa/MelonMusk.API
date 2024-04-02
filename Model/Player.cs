using clickelon.api.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace clickelon.api.Model
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public static void CreateAPlayerByName(string name)
        {
            using (DatabaseContext database = new DatabaseContext())
            {
                database.Players.Add(new Player { Name = name });
                database.SaveChanges();
            }
        }
        public static Player GetAPlayerById(int id)
        {
            using (DatabaseContext database = new DatabaseContext())
            {
                return database.Players.Where(x => x.Id == id).SingleOrDefault();
            }
        }
        
    }
}
