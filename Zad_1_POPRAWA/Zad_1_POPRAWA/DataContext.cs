using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Zad_1_POPRAWA
{
	public class DataContext
	{
		public List<Gambler> gamblers;
		public Dictionary<string, Machine> machines;
		public Collection<Event> events;

		public DataContext()
		{
			gamblers = new List<Gambler>();
			machines = new Dictionary<string, Machine>();
			events = new Collection<Event>();
		}
	}
}
