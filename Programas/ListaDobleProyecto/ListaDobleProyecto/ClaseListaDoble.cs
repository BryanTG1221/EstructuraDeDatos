using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleProyecto
{
   
    class ClaseListaDoble<Tipo> where Tipo: IEquatable<Tipo>,IComparable<Tipo>, new ()
    {
        private ClaseNodo<Tipo> _nodoInicial;

        public ClaseNodo<Tipo> nodoInicial
        {
            get { return _nodoInicial; }
            set { _nodoInicial = value; }
        }
        private ClaseNodo<Tipo> _nodoFinal;

        public ClaseNodo<Tipo> nodoFinal
        {
            get { return _nodoFinal; }
            set { _nodoFinal = value; }
        }

        private ClaseNodo<Tipo> _nodoPrevio;

        public ClaseNodo<Tipo> nodoPrevio
        {
            get { return _nodoPrevio; }
            set { _nodoPrevio = value; }
        }



        private Tipo _nodoAnterior;

        public Tipo nodoAnterior
        {
            get { return _nodoAnterior; }
            set { _nodoAnterior = value; }
        }


        public ClaseListaDoble()
        {
            this.nodoInicial = null;
            this.nodoFinal = null;
            return;
        }
        public bool Vacia
        {
            get
            {
                if (this.nodoInicial == null)
                {
                    return true;
                }
                else { return false; }
            }
        }
        public void AgregarNodo(Tipo Objeto)
        {
            if (Vacia)
            {
                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = Objeto;
                nodoNuevo.Siguiente = null;
                nodoNuevo.Anterior = null;
                nodoInicial = nodoNuevo;
                nodoFinal = nodoInicial;
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                nodoActual = nodoInicial;
                do
                {
                    if (Objeto.Equals(nodoActual.ObjetoConDatos))
                        {
                        throw new Exception("Ya tenemos un Grupo Musical registrado con los mismos datos.");
                    }
                    else
                    {
                        nodoPrevio = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    }
                } while (nodoActual != null);

                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = Objeto;
                nodoPrevio.Siguiente = nodoNuevo;
                nodoNuevo.Siguiente = null;
                nodoFinal = nodoActual;
            }
        }

        public Tipo EliminarNodo(Tipo Objeto)
        {
            if (Vacia)
            {
                throw new Exception("La lista esta vacia");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                nodoActual = nodoInicial;
                nodoPrevio = nodoInicial;
                do
                {
                    if (Objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
                        nodoEliminado = nodoActual;
                        if (nodoInicial.Equals(nodoInicial))
                        {
                            nodoInicial = null;
                            nodoFinal = null;
                            nodoActual = null;
                            return (nodoEliminado.ObjetoConDatos);
                        }
                        else
                        {
                            if (nodoActual.Equals(nodoInicial))
                            {
                                nodoInicial = nodoActual.Siguiente;
                                nodoInicial.Anterior = null;
                                nodoActual = null;
                                return (nodoEliminado.ObjetoConDatos);
                            }
                            else
                            {
                                if (nodoActual.Equals(nodoFinal))
                                {
                                    nodoFinal = nodoActual.Anterior;
                                    nodoFinal.Siguiente = null;
                                    nodoActual = null;
                                    return (nodoEliminado.ObjetoConDatos);
                                }
                                else
                                {
                                    nodoPrevio.Siguiente = nodoActual.Siguiente;
                                    nodoActual.Siguiente.Anterior = nodoActual.Anterior;
                                    nodoActual = null;
                                }
                            }
                        }

                    }
                    else
                    {
                        nodoPrevio = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    }
                } while (nodoActual != null);
                throw new Exception("No se encontro el Grupo Musical, que desea eliminar");
            }
        }

        public Tipo Buscar(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("La lista esta vacia");
            }
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = nodoInicial;
            
            do
            {
                if (objeto.Equals(nodoActual.ObjetoConDatos))
                {
                    return (nodoActual.ObjetoConDatos);
                }
                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != null);
            throw new Exception("El nodo no existe");
        }

        public void Vaciar()
        {
            if (Vacia)
            {
                return;
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoAnterior = new ClaseNodo<Tipo>();
                nodoActual = nodoInicial;
                while (nodoActual != null)
                {
                    nodoAnterior = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                    nodoAnterior = default;
                }
                nodoAnterior = default;
                nodoInicial = null;
                nodoFinal = null;
                return;
            }
        }
            public IEnumerable<Tipo> HaciaAdelante
        {
            get
            {
                if (Vacia)
                {
                    yield break;
                }
                else
                {
                    ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                    nodoActual = nodoInicial;
                    do
                    {
                        yield return nodoActual.ObjetoConDatos;
                        nodoActual = nodoActual.Siguiente;
                    } while (nodoActual != null);
                    yield break;
                }
            }

        }

        public IEnumerable<Tipo> HaciaAtras
        {
            get
            {
                if (Vacia)
                {
                    yield break;
                }
                else
                {
                    ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                    nodoActual = nodoFinal;
                    do
                    {
                        yield return nodoActual.ObjetoConDatos;
                        nodoActual = nodoActual.Anterior;
                    } while (nodoActual != null);
                    yield break;
                }
            }
        }

            
                
            
        }
    }

