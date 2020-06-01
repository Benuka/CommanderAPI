// using System.Collections.Generic;
// using Commander.Models;

// namespace Commander.Data
// {
//     public class MockCommanderRepo : ICommanderRepo
//     {
//         public void CreateCommand(Command cmd)
//         {
//             throw new System.NotImplementedException();
//         }

//         public IEnumerable<Command> GetAllCommands()
//         {
//             var commands = new List<Command>
//             {
//                 new Command{Id=0, HowTo="Boil an Egg", Line="boil water", Platform="Kettle and Pan"},
//                 new Command{Id=1, HowTo="Cut Bread", Line="get a knife", Platform="knife and chopping board"},
//                 new Command{Id=1, HowTo="Make cup of Tea", Line="place tea bag in cup", Platform="kettle and cup"}
//             };

//             return commands;
//         }

//         public Command GetCommandById(int id)
//         {
//             return new Command{Id=0, HowTo="Boil an Egg", Line="boil water", Platform="Kettle and Pan"};
//         }

//         public bool SaveChanges()
//         {
//             throw new System.NotImplementedException();
//         }
//     }
// }
