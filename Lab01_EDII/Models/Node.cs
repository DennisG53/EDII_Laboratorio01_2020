using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01_EDII.Models
{
    public class Node
    {
        public List<Soda> Values { get; private set; }
        public List<Node> Children { get; private set; }
        public Node Father { get; set; }

        public Node(Soda soda)
        {
            Values = new List<Soda>();
            Values.Add(soda);
            Children = new List<Node>();
            Father = new Node(null);
        }

        public void InsertSoda(Soda NewSoda)
        {
            for (int i = 0; i < Values.Count(); i++)
            {
                if ( string.Compare(NewSoda.Name, Values[i].Name) == -1 ) //aplicar método compare
                {
                    if (Children[i] == null)
                    {
                        Values.Insert(i, NewSoda); //se inserta en la hoja
                        return;
                    }
                    else
                    {
                        Children[i].InsertSoda(NewSoda); //se avanza al hijo correspondiente
                    }
                }
            }
        }

        public Soda SearchValue(string ValueSearch)
        {
            for (int i = 0; i < this.Values.Count(); i++)
            {
                if (string.Compare(ValueSearch, Values[i].Name) == 0)
                {
                    return Values[i]; //se encuentra el valor y se retorna la soda
                }
                //si es menor al valor en el nodo, se mueve a su hijo izquierdo
                //si es nulo el valor en el nodo, se mueve al hijo derecho
                else if ( (string.Compare(ValueSearch, Values[i].Name) == -1) || Values[i] == null)
                {
                    Children[i].SearchValue(ValueSearch);
                }
            }
            return null;
        }

        
    }
}
