using clickelon.api.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clickelon.api.Model
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public int Score { get; set; }
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }

        public static void Create(int score, int playerId)
        {
            using (DatabaseContext database = new DatabaseContext())
            {
                database.Games.Add(new Game { Score = score, PlayerId =  playerId });
                database.SaveChanges();
            }
        }
        public static List<Game> GetTwentyBestGames()
        {
            using (DatabaseContext database = new DatabaseContext())
            {
                return database.Games
                    .OrderByDescending(x => x.Score)
                    .Take(20)
                    .ToList();
            }
        }

    }
}
