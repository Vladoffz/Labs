using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fttbll.Models;

namespace Fttbll.Data
{
    public class DbInitializer
    {
        public static void Initialize(FootballContext context)
        {
            context.Database.EnsureCreated();

            //// Look for any students.
            

            var players = new Player[]
            {
            new Player{FirstName="Carson",LastName="Alexander", Age = 21, Command = "Liverpool" },
            new Player{FirstName="Meredith",LastName="Alonso",Age = 22, Command = "Liverpool" },
            new Player{FirstName="Arturo",LastName="Anand",Age = 23, Command = "Liverpool" },
            new Player{FirstName="Gytis",LastName="Barzdukas",Age = 24, Command = "Liverpool" },
            new Player{FirstName="Yan",LastName="Li",Age = 26, Command = "Liverpool" },
            new Player{FirstName="Peggy",LastName="Justice",Age = 25, Command = "Liverpool" },
            new Player{FirstName="Laura",LastName="Norman",Age = 28, Command = "Liverpool" },
            new Player{FirstName="Nino",LastName="Olivetto",Age = 27, Command = "Liverpool" },
            new Player{FirstName="Nurs",LastName="Argos",Age = 29, Command = "Liverpool" },
            new Player{FirstName="Rico",LastName="Plup",Age = 22, Command = "Liverpool"},
            new Player{FirstName="Pico",LastName="Dudo",Age = 23, Command = "Liverpool"},

            new Player{FirstName="Nals",LastName="Buldo",Age = 24, Command = "Real Madrid" },
            new Player{FirstName="Gans",LastName="Olero",Age = 26, Command = "Real Madrid" },
            new Player{FirstName="Grap",LastName="Gripo",Age = 28, Command = "Real Madrid" },
            new Player{FirstName="Arni",LastName="Hron",Age = 29, Command = "Real Madrid" },
            new Player{FirstName="Ugo",LastName="Guso",Age = 20, Command = "Real Madrid" },
            new Player{FirstName="Guno",LastName="Traco",Age = 22, Command = "Real Madrid"},
            new Player{FirstName="Sapo",LastName="Baeto",Age = 23, Command = "Real Madrid" },
            new Player{FirstName="Toto",LastName="Primo",Age = 25, Command = "Real Madrid" },
            new Player{FirstName="Beet",LastName="Lutto",Age = 27, Command = "Real Madrid" },
            new Player{FirstName="Asto",LastName="Vargo",Age = 26, Command = "Real Madrid" },
            new Player{FirstName="Brak",LastName="Ginlo",Age = 29, Command = "Real Madrid" },
                
            new Player{FirstName="Van",LastName="Darkholme",Age = 24, Command = "Dinamo" },
            new Player{FirstName="Billy",LastName="Herrington",Age = 26, Command = "Dinamo" },
            new Player{FirstName="Robert",LastName="Gripgo",Age = 28, Command = "Dinamo" },
            new Player{FirstName="Arnid",LastName="Hrosn",Age = 29, Command = "Dinamo" },
            new Player{FirstName="Ugos",LastName="Gusto",Age = 20, Command = "Dinamo" },
            new Player{FirstName="Gunyo",LastName="Tracso",Age = 22, Command = "Dinamo"},
            new Player{FirstName="Sapdio",LastName="Baetsko",Age = 23, Command = "Dinamo" },
            new Player{FirstName="Totlo",LastName="Prinmo",Age = 25, Command = "Dinamo" },
            new Player{FirstName="Bert",LastName="Lungo",Age = 27, Command = "Dinamo" },
            new Player{FirstName="Astio",LastName="Varasgo",Age = 26, Command = "Dinamo" },
            new Player{FirstName="Brakio",LastName="Ginhlo",Age = 29, Command = "Dinamo" },
            
            new Player{FirstName="Nelson",LastName="Buldog",Age = 24, Command = "Chelsi" },
            new Player{FirstName="Gansir",LastName="Olbero",Age = 26, Command = "Chelsi" },
            new Player{FirstName="Getis",LastName="Gripho",Age = 28, Command = "Chelsi" },
            new Player{FirstName="Arnoldi",LastName="Hronis",Age = 29, Command = "Chelsi" },
            new Player{FirstName="Ugrus",LastName="Gussio",Age = 20, Command = "Chelsi" },
            new Player{FirstName="Gunnaro",LastName="Trappo",Age = 22, Command = "Chelsi" },
            new Player{FirstName="Saradil",LastName="Baetio",Age = 23, Command = "Chelsi" },
            new Player{FirstName="Totso",LastName="Prikmo",Age = 25, Command = "Chelsi" },
            new Player{FirstName="Brastet",LastName="Lumto",Age = 27, Command = "Chelsi" },
            new Player{FirstName="Asirto",LastName="Varsigo",Age = 26, Command = "Chelsi" },
            new Player{FirstName="Bratio",LastName="Ginlmo",Age = 29, Command = "Chelsi" },
            
            new Player{FirstName="Nmois",LastName="Bulndo",Age = 24, Command = "Marsto" },
            new Player{FirstName="Gerods",LastName="Olvero",Age = 26, Command = "Marsto" },
            new Player{FirstName="Grapios",LastName="Gripbo",Age = 28, Command = "Marsto" },
            new Player{FirstName="Aelit",LastName="Hsqron",Age = 29, Command = "Marsto" },
            new Player{FirstName="Ustio",LastName="Gusods",Age = 20, Command = "Marsto" },
            new Player{FirstName="Gerols",LastName="Travolco",Age = 22, Command = "Marsto" },
            new Player{FirstName="Safarago",LastName="Baezito",Age = 23, Command = "Marsto" },
            new Player{FirstName="Tonoso",LastName="Priasmo",Age = 25, Command = "Marsto" },
            new Player{FirstName="Biquot",LastName="Luatto",Age = 27, Command = "Marsto" },
            new Player{FirstName="Asiuto",LastName="Vargso",Age = 26, Command = "Marsto" },
            new Player{FirstName="Bradk",LastName="Ginitlo",Age = 29, Command = "Marsto" },
            
            new Player{FirstName="Nalass",LastName="Bulddfo",Age = 24, Command = "Rafosto" },
            new Player{FirstName="Gasans",LastName="Olefdro",Age = 26, Command = "Rafosto" },
            new Player{FirstName="Grasdap",LastName="Grasipo",Age = 28, Command = "Rafosto" },
            new Player{FirstName="Arnasi",LastName="Hrweson",Age = 29, Command = "Rafosto" },
            new Player{FirstName="Ugsao",LastName="Gussao",Age = 20, Command = "Rafosto" },
            new Player{FirstName="Gussadno",LastName="Trdraco",Age = 22, Command = "Rafosto" },
            new Player{FirstName="Sapsao",LastName="Baefdgto",Age = 23, Command = "Rafosto" },
            new Player{FirstName="Tosaato",LastName="Prfdgimo",Age = 25, Command = "Rafosto" },
            new Player{FirstName="Betoet",LastName="Lutsdto",Age = 27, Command = "Rafosto" },
            new Player{FirstName="Assgto",LastName="Vargzxdo",Age = 26, Command = "Rafosto" },
            new Player{FirstName="Brgfak",LastName="Gidgnlo",Age = 29, Command = "Rafosto" }
            };

            if (context.Players.Count() > players.Length )
            {
                return;   // DB has been seeded
            }

            foreach (Player p in players)
            {
                context.Players.Add(p);
            }
            context.SaveChanges();

            var commands = new Command[]
            {
            new Command{ Country = "Spain", Name = "Liverpool", PlayerID = 1},
            new Command{ Country = "Spain", Name = "Liverpool", PlayerID = 2},
            new Command{ Country = "Spain", Name = "Liverpool", PlayerID = 3},
            new Command{ Country = "Spain", Name = "Liverpool", PlayerID = 4},
            new Command{ Country = "Spain", Name = "Liverpool", PlayerID = 5},
            new Command{ Country = "Spain", Name = "Liverpool", PlayerID = 6},
            new Command{ Country = "Spain", Name = "Liverpool", PlayerID = 7},
            new Command{ Country = "Spain", Name = "Liverpool", PlayerID = 8},
            new Command{ Country = "Spain", Name = "Liverpool", PlayerID = 9},
            new Command{ Country = "Spain", Name = "Liverpool", PlayerID = 10},
            new Command{ Country = "Spain", Name = "Liverpool", PlayerID = 11},

            new Command{ Country = "Ukraine", Name = "Dinamo", PlayerID = 23},
            new Command{ Country = "Ukraine", Name = "Dinamo", PlayerID = 24},
            new Command{ Country = "Ukraine", Name = "Dinamo", PlayerID = 25},
            new Command{ Country = "Ukraine", Name = "Dinamo", PlayerID = 26},
            new Command{ Country = "Ukraine", Name = "Dinamo", PlayerID = 27},
            new Command{ Country = "Ukraine", Name = "Dinamo", PlayerID = 28},
            new Command{ Country = "Ukraine", Name = "Dinamo", PlayerID = 29},
            new Command{ Country = "Ukraine", Name = "Dinamo", PlayerID = 30},
            new Command{ Country = "Ukraine", Name = "Dinamo", PlayerID = 31},
            new Command{ Country = "Ukraine", Name = "Dinamo", PlayerID = 32},
            new Command{ Country = "Ukraine", Name = "Dinamo", PlayerID = 33},

            new Command{ Country = "Italy", Name = "Chelsi", PlayerID = 34},
            new Command{ Country = "Italy", Name = "Chelsi", PlayerID = 35},
            new Command{ Country = "Italy", Name = "Chelsi", PlayerID = 36},
            new Command{ Country = "Italy", Name = "Chelsi", PlayerID = 37},
            new Command{ Country = "Italy", Name = "Chelsi", PlayerID = 38},
            new Command{ Country = "Italy", Name = "Chelsi", PlayerID = 39},
            new Command{ Country = "Italy", Name = "Chelsi", PlayerID = 40},
            new Command{ Country = "Italy", Name = "Chelsi", PlayerID = 41},
            new Command{ Country = "Italy", Name = "Chelsi", PlayerID = 42},
            new Command{ Country = "Italy", Name = "Chelsi", PlayerID = 43},
            new Command{ Country = "Italy", Name = "Chelsi", PlayerID = 44},

            new Command{ Country = "Brasil", Name = "Real Madrid", PlayerID = 12},
            new Command{ Country = "Brasil", Name = "Real Madrid", PlayerID = 13},
            new Command{ Country = "Brasil", Name = "Real Madrid", PlayerID = 14},
            new Command{ Country = "Brasil", Name = "Real Madrid", PlayerID = 15},
            new Command{ Country = "Brasil", Name = "Real Madrid", PlayerID = 16},
            new Command{ Country = "Brasil", Name = "Real Madrid", PlayerID = 17},
            new Command{ Country = "Brasil", Name = "Real Madrid", PlayerID = 18},
            new Command{ Country = "Brasil", Name = "Real Madrid", PlayerID = 19},
            new Command{ Country = "Brasil", Name = "Real Madrid", PlayerID = 20},
            new Command{ Country = "Brasil", Name = "Real Madrid", PlayerID = 21},
            new Command{ Country = "Brasil", Name = "Real Madrid", PlayerID = 22},

            new Command{ Country = "China", Name = "Marsto", PlayerID = 45},
            new Command{ Country = "China", Name = "Marsto", PlayerID = 46},
            new Command{ Country = "China", Name = "Marsto", PlayerID = 47},
            new Command{ Country = "China", Name = "Marsto", PlayerID = 48},
            new Command{ Country = "China", Name = "Marsto", PlayerID = 49},
            new Command{ Country = "China", Name = "Marsto", PlayerID = 50},
            new Command{ Country = "China", Name = "Marsto", PlayerID = 51},
            new Command{ Country = "China", Name = "Marsto", PlayerID = 52},
            new Command{ Country = "China", Name = "Marsto", PlayerID = 53},
            new Command{ Country = "China", Name = "Marsto", PlayerID = 54},
            new Command{ Country = "China", Name = "Marsto", PlayerID = 55},

            new Command{ Country = "Swedish", Name = "Rafosto", PlayerID = 56},
            new Command{ Country = "Swedish", Name = "Rafosto", PlayerID = 57},
            new Command{ Country = "Swedish", Name = "Rafosto", PlayerID = 58},
            new Command{ Country = "Swedish", Name = "Rafosto", PlayerID = 59},
            new Command{ Country = "Swedish", Name = "Rafosto", PlayerID = 60},
            new Command{ Country = "Swedish", Name = "Rafosto", PlayerID = 61},
            new Command{ Country = "Swedish", Name = "Rafosto", PlayerID = 62},
            new Command{ Country = "Swedish", Name = "Rafosto", PlayerID = 63},
            new Command{ Country = "Swedish", Name = "Rafosto", PlayerID = 64},
            new Command{ Country = "Swedish", Name = "Rafosto", PlayerID = 65},
            new Command{ Country = "Swedish", Name = "Rafosto", PlayerID = 66}
            };
            foreach (Command c in commands)
            {
                context.Commands.Add(c);
            }
            context.SaveChanges();

            var championshipcommands = new ChampionshipCommand[]
            {
            new ChampionshipCommand{ChampionshipCommandID = 1, CommandID = 1324 },
            new ChampionshipCommand{ChampionshipCommandID = 2, CommandID = 1222 },
            new ChampionshipCommand{ChampionshipCommandID = 3, CommandID = 1456 },
            new ChampionshipCommand{ChampionshipCommandID = 4, CommandID = 1666 },
            new ChampionshipCommand{ChampionshipCommandID = 5, CommandID = 1242 },
            new ChampionshipCommand{ChampionshipCommandID = 6, CommandID = 1987 }
            
            };
            foreach (ChampionshipCommand e in championshipcommands)
            {
                context.ChampionshipCommands.Add(e);
            }
            context.SaveChanges();

            var matches = new Match[]
            {
                new Match { CommandID = 1222, Result = 3},
                new Match { CommandID = 1324, Result = 2},
                new Match { CommandID = 1222, Result = 4},
                new Match { CommandID = 1456, Result = 1},
                new Match { CommandID = 1666, Result = 0},
                new Match { CommandID = 1242, Result = 2},
                new Match { CommandID = 1987, Result = 3},
                new Match { CommandID = 1222, Result = 4}
            };
            foreach (Match m in matches)
            {
                context.Matches.Add(m);
            }

            context.SaveChanges();

            var championships = new Championship[]
            {
                new Championship {Name = "Great"}
            };
            foreach (Championship j  in championships)
            {
                context.Championships.Add(j);
            }

            context.SaveChanges();
        }
    }
}
    
