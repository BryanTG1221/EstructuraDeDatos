using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesED
{
    class ListaOrdenadaSimple<Tipo> where Tipo : IEquatable<Tipo>, IComparable<Tipo>, new()
    {
        public ListaOrdenadaSimple()
        {
            this._NodoInicial = null;
            return;
        }//Constructor

        private Nodo<Tipo> _NodoInicial;//Atributo

        private Nodo<Tipo> NodoInicial
        {
            get { return _NodoInicial; }
            set { _NodoInicial = value; }
        }//Propiedad

        public bool Vacia
        {
            get
            {
                if (this.NodoInicial == null)
                {
                    return true;
                }
                return false;

            }
        }

        public Tipo BuscarNodo(Tipo Objeto)
        {
            if (Vacia)
            {
                throw new Exception("Lista Vacia");
            }
            Nodo<Tipo> nodoActual = new Nodo<Tipo>();
            nodoActual = NodoInicial;
            do
            {
                if (Objeto.Equals(nodoActual.ObjetoConDatos))
                {
                    return (nodoActual.ObjetoConDatos);
                }
                else if (Objeto.CompareTo(nodoActual.ObjetoConDatos)==-1)
                {
                    throw new Exception("No existe");
                }
                else
                {
                    nodoActual = nodoActual.Siguiente;
                }
            } while (nodoActual != null);
            {
                throw new Exception("No encontrado");
            }
        }

        public void Vaciar()
        {
            if (Vacia)
            {
                return;
            }
            else
            {
                Nodo<Tipo> nodoPrevio = new Nodo<Tipo>();
                Nodo<Tipo> nodoActual = new Nodo<Tipo>();
                nodoActual = _NodoInicial;

                do
                {
                    nodoPrevio = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                    nodoPrevio = null;
                } while (nodoActual != null);
                {
                    _NodoInicial = null;
                    return;
                }
            }
        }

        ~ListaOrdenadaSimple()
        {
            Vaciar();
        }
        

        public void AgregarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                Nodo<Tipo> nodoNuevo = new Nodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoNuevo.Siguiente = null;
                this._NodoInicial = nodoNuevo;
            }
            else
            {
                Nodo<Tipo> nodoActual = new Nodo<Tipo>();
                nodoActual = this._NodoInicial;
                Nodo<Tipo> nodoPrevio = new Nodo<Tipo>();
                do
                {
                   
                    if (objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        throw new Exception("Duplicado");
                    }
                    if (objeto.CompareTo(nodoActual.ObjetoConDatos)==-1)
                    {
                        if (nodoActual.Equals(_NodoInicial))
                        {
                            Nodo<Tipo> nodoNuevo = new ActividadesED.Nodo<Tipo>();
                            nodoNuevo.ObjetoConDatos = objeto;
                            nodoNuevo.Siguiente = this._NodoInicial;
                            this._NodoInicial = nodoNuevo;
                        }
                        else
                        {
                            Nodo<Tipo> nodoNuevo = new Nodo<Tipo>();
                            nodoNuevo.ObjetoConDatos = objeto;
                            nodoNuevo.Siguiente = nodoPrevio.Siguiente;
                            nodoPrevio.Siguiente = nodoNuevo;
                        }

                    }
                    
                    
                        nodoPrevio = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    
                    

                } while (nodoActual != null);
            }
        }

        public IEnumerator<Tipo> GetEnumerator()
        {
            if (Vacia)
            {
                yield break;
            }
            else
            {
                Nodo<Tipo> nodoActual = new Nodo<Tipo>();
                nodoActual = NodoInicial;
                do
                {
                    yield return (nodoActual.ObjetoConDatos);
                    nodoActual = nodoActual.Siguiente;
                } while (nodoActual != null);
                yield break;
            }
        }


    }
}
