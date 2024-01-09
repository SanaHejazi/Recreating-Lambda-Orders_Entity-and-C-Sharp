using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_EntityFramework
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			database database =new database();
			peopleEntities db = new peopleEntities();
			//database.add("nika", "forghani",27);
			//database.showdatabase();
			//----------------------
			var result2 = db.people.OrderByDescending(n => n.Age).ToArray();
			foreach(var person in result2) { Console.WriteLine($"name : {person.Name} \n age :{person.Age} "); }
			Console.ReadKey();
		}
	}
}
