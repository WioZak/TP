using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Zad_1_POPRAWA
{
	public class DataContext
	{
		private List<Gambler> gamblers;
		private Dictionary<string, Machine> machines;
		private Collection<Event> events;

		public DataContext()
		{
			gamblers = new List<Gambler>();
			machines = new Dictionary<string, Machine>();
			events = new Collection<Event>();
		}
	}
}
