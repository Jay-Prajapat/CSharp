using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3_Inheritance
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Team team = new Team();
            Sponser teamSponser= new Sponser();
            team.printInfo();
            teamSponser.printInfo();
            Sponser sponser2 = new Team();
            sponser2.printInfo();
        }
    }
    public class Sponser
    {
        protected string owner = "Rakuteen";
        /// <summary>
        /// This method will print the owner name.
        /// </summary>
        public void printInfo()
        {
            Console.WriteLine($"Owner of team is {owner}");
        }
    }
    public class Team : Sponser
    {
        private string teamName = "Titans";
       /// <summary>
       /// This method will print the name and owner of the team.
       /// </summary>
        public void printInfo()
        {
            Console.WriteLine($"Team name is {teamName} and the owner is {owner}");
        }
    }

}
