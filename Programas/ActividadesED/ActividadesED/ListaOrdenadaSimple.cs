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

        private Nodo<Tipo> _nodoFinal;

        public Nodo<Tipo> NodoFinal
        {
            get { return _nodoFinal; }
            set { _nodoFinal = value; }
        }


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
                throw new Exception("La lista esta vacia");
            }
            Nodo<Tipo> nodoActual = new Nodo<Tipo>();
            nodoActual = NodoInicial;

            do
            {
                if (Objeto.Equals(nodoActual.ObjetoConDatos))
                {
                    return (nodoActual.ObjetoConDatos);
                }
                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != null);
            throw new Exception("El nodo no existe");
        }

        public Tipo EliminarNodo(Tipo Objeto)
        {
            if (Vacia)
            {
                throw new Exception("Lista Vacia");
            }
            else
            {
                Nodo<Tipo> nodoActual = new Nodo<Tipo>();
                Nodo<Tipo> nodoPrevio = new Nodo<Tipo>();
                nodoActual = NodoInicial;
                nodoPrevio = null;
                do
                {
                    if (nodoActual.ObjetoConDatos.Equals(Objeto))
                    {
                        Nodo<Tipo> nodoEliminado = new Nodo<Tipo>();
                        nodoEliminado = nodoActual;
                        if (nodoActual.Equals(NodoInicial))
                        {
                            NodoInicial = NodoInicial.Siguiente;
                            nodoActual = null;
                            return (nodoEliminado.ObjetoConDatos);
                        }
                        else if (nodoActual.Equals(NodoFinal))
                        {
                            nodoPrevio.Siguiente = nodoActual.Siguiente;
                            nodoActual = null;
                            return (nodoEliminado.ObjetoConDatos);
                        }
                        else
                        {
                            nodoPrevio.Siguiente = nodoActual.Siguiente;
                            nodoActual = null;
                            return (nodoEliminado.ObjetoConDatos);
                        }
                    }
                    else
                    {
                        nodoPrevio = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    }
                                   
                } while (NodoInicial != null);
                throw new Exception("No se encontro el Grupo a a Eliminar");
            }
        }

        public void Vaciar()
        {
            if (Vacia)
            {
                throw new Exception("La lista no contienen ningun Grupo Musical");
            }
            else
            {
                Nodo<Tipo> nodoPrevio = new Nodo<Tipo>();
                Nodo<Tipo> nodoActual = new Nodo<Tipo>();
                nodoActual = NodoInicial;
                do
                {
                    nodoPrevio = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                    nodoPrevio = null;
                } while (nodoActual != null);
                NodoInicial = null;
                return;
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
                this.NodoInicial = nodoNuevo;
                return;
            }
            else
            {
                Nodo<Tipo> nodoActual = new Nodo<Tipo>();
                nodoActual = this.NodoInicial;
                Nodo<Tipo> nodoPrevio = new Nodo<Tipo>();
                do
                {
                    if (objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        throw new Exception("Duplicado");
                    }
                    else
                    {
                        if (objeto.CompareTo(nodoActual.ObjetoConDatos) == -1)
                        {
                            if (nodoActual.Equals(NodoInicial))
                            {
                                Nodo<Tipo> nodoNuevo2 = new Nodo<Tipo>();
                                nodoNuevo2.ObjetoConDatos = objeto;
                                nodoNuevo2.Siguiente = this.NodoInicial;
                                this.NodoInicial = nodoNuevo2;
                                return;
                            }
                            else
                            {
                                Nodo<Tipo> nodoNuevo2 = new Nodo<Tipo>();
                                nodoNuevo2.ObjetoConDatos = objeto;
                                nodoNuevo2.Siguiente = nodoPrevio.Siguiente;
                                nodoPrevio.Siguiente = nodoNuevo2;
                                return;
                            }
                        }
                        else
                        {
                            nodoPrevio = nodoActual;
                            nodoActual = nodoActual.Siguiente;    
                        }
                        
                    }
                } while (nodoActual != null);
                Nodo<Tipo> nodoNuevo = new Nodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoPrevio.Siguiente = nodoNuevo;
                nodoNuevo.Siguiente = null;
                return;
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
