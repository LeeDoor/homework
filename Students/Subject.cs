using System;
namespace learn
{
	public class Subject
	{
		// list of avaliable subject titles
		private static readonly string[] NAMES = new string[] {
			"Phys", "PE", "Math", "Rus", "Eng", "Fren", "Hist", "Geog", "Chem", "Inform"
		};
		private static List<string> takenNames;
		public string _name;

		static Subject()
        {
			takenNames = new List<string>();

			foreach (var name in NAMES)
			{
				takenNames.Add(name);
			}
		}

		/// <summary>
		/// default random constructor
		/// </summary>
		public Subject()
        {
			_name = getRandomName();
        }
		public Subject(string name)
		{
			_name = name;
        }

		/// <summary>
		/// random name generator
		/// </summary>
		/// <returns>returns random name</returns>
		public string getRandomName()
        {
			Random random = new Random();
			int size = takenNames.Count;
			int id = random.Next(size);
			string newName = takenNames[id];
			takenNames.Remove(NAMES[id]);
			return newName;
        }
	}
}
