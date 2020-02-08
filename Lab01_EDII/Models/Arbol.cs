using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01_EDII.Models
{
    public class Arbol
    {
		private static Arbol _instance = null;
		public static Arbol Instance
		{
			get
			{
				if (_instance == null) _instance = new Arbol();
				return _instance;
			}
		}

		public Node Root = new Node(null);
		public Arbol()
		{
			Root = null;
		}

		public int Grade = new int();

		public void AddSoda(Soda NewSoda)
		{
			if (Root == null)
			{
				Root = new Node(NewSoda);
			}
			else
			{
				Root.InsertSoda(NewSoda);
			}
		}

		public Soda	SearchSoda(string ValueSearch)
		{
			return Root.SearchValue(ValueSearch);
		}
    }
}
