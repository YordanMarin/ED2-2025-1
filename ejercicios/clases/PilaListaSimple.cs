using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios.clases
{
    internal class PilaListaSimple
    {
        Pila p = new Pila();

        public bool EsOperador(string c)
        {
            return c == "+" || c == "-" || c == "*" || c == "/";
        }

        public int ObtenerPrioridad(string operador)
        {
            if(operador == "*" || operador == "/")
                return 2;
            if (operador == "+" || operador == "-")
                return 1;
            return 0;
        }

        public string InfijaAprefija(string infija)
        {
            StringBuilder prefija = new StringBuilder();

            for(int i = infija.Length-1; i >= 0; i--)
            {
                string c = infija[i].ToString();

                if (char.IsLetterOrDigit(infija[i]))
                {
                    prefija.Insert(0, c);
                }else if (c == ")")
                {
                    p.Push(c);
                }else if (c == "(")
                {
                    while(!p.EstaVacio() && p.Peek() != ")")
                    {
                        prefija.Insert(0, p.Pop());
                    }
                    p.Pop();
                }else if(EsOperador(c))
                {
                    while (!p.EstaVacio() && ObtenerPrioridad(c) < ObtenerPrioridad(p.Peek()))
                    {
                        prefija.Insert(0, p.Pop());
                    }
                    p.Push(c);
                }
            }
            while (!p.EstaVacio())
            {
                prefija.Insert(0, p.Pop());
            }

            return prefija.ToString();
        }

        public string InfijaApostfija(string infija)
        {
            StringBuilder postfija = new StringBuilder();

            for (int i = 0; i <infija.Length; i++)
            {
                string c = infija[i].ToString();

                if (char.IsLetterOrDigit(infija[i]))
                {
                    postfija.Append(c);
                }
                else if (c == "(")
                {
                    p.Push(c);
                }
                else if (c == ")")
                {
                    while (!p.EstaVacio() && p.Peek() != "(")
                    {
                        postfija.Append(p.Pop());
                    }
                    p.Pop();
                }
                else if (EsOperador(c))
                {
                    while (!p.EstaVacio() && ObtenerPrioridad(c) < ObtenerPrioridad(p.Peek()))
                    {
                        postfija.Append(p.Pop());
                    }
                    p.Push(c);
                }
            }
            while (!p.EstaVacio())
            {
                postfija.Append(p.Pop());
            }

            return postfija.ToString();
        }

        private Nodo primero = null;
        private Nodo ultimo = null;

        public void insertar(string infi, string pre, string post)
        {
            Nodo nuevo = new Nodo();
            nuevo.Infija = infi;
            nuevo.Prefija = pre;
            nuevo.Postfija = post;

            if(primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }
        }

        public void mostrar(ListView list)
        {
            Nodo actual = primero;

            while (actual != null)
            {
                ListViewItem item = new ListViewItem(actual.Infija);
                item.SubItems.Add(actual.Prefija);
                item.SubItems.Add(actual.Postfija);
                list.Items.Add(item);
                actual = actual.Siguiente;
            }
        }
    }
}
