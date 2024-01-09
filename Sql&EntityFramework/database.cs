using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_EntityFramework
{
	internal class database : people
	{
		peopleEntities db = new peopleEntities();
		

		public void add(String name, String family, int age)
		{
			bool run=false;
			if (db.people.Any(n => n.Name == name && n.Family == family && n.Age == age))
			{ run = true; }
			if (run == false)
			{
				people p = new people();
				p.Name = name;
				p.Family = family;
				p.Age = age;
				db.people.Add(p);
				db.SaveChanges();
				Console.WriteLine("Contact Succeesfully Added...");

			}
			else { Console.WriteLine("This Contact exist..."); }
		}

			
		public void remove(String name)
		{

			try
			{
				var remov = db.people.First(p => p.Name == name);
				if (remov != null)
				{
					db.people.Remove(remov);
					db.SaveChanges();
					Console.WriteLine("contact removed");
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		public void editname(String Olename, String Newname)
		{
			var reult = db.people.SingleOrDefault(p => p.Name == Olename);
			if (reult != null)
			{
				reult.Name = Newname;
				db.SaveChanges();
				Console.WriteLine("contact saved");
			}
			else
			{
				Console.WriteLine("Contact Not Found...");
			}
		}
		public void editfamily(String name, String newfamily)
		{
			var reult = db.people.SingleOrDefault(p => p.Name == name);
			if (reult != null)
			{
				reult.Family = newfamily;
				db.SaveChanges();
				Console.WriteLine("contact saved");
			}
			else
			{
				Console.WriteLine("Contact Not Found...");
			}
		}
		public void editage(String name, int age)
		{
			var reult = db.people.SingleOrDefault(p => p.Name == name);
			if (reult != null)
			{
				reult.Age = age;
				db.SaveChanges();
				Console.WriteLine("contact saved");
			}
			else
			{
				Console.WriteLine("Contact Not Found...");
			}
		}

		public void showdatabase()
		{
			var result1 = db.people;
			foreach (var sana in result1) { Console.WriteLine($"name : {sana.Name} family :{sana.Family} age :{sana.Age} \n"); }
		}
	}
}

