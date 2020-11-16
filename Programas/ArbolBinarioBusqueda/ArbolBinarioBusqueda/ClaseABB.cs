using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioBusqueda
{
    class ClaseABB<Tipo> where Tipo : IComparable<Tipo>, IEquatable<Tipo>
    {
		public ClaseABB()
		{
			Raiz = null;
		}

		private ClaseNodo<Tipo> _raiz;
		
		private ClaseNodo<Tipo> Raiz
		{
			get { return _raiz; }
			set { _raiz = value; }
		}

		public bool Vacio
		{
			get
			{
				if (Raiz == null)
				{
					return true;
				}else { return false; }
			}
		}

		
		public void InsertarNodo(Tipo Objeto)
		{
			ClaseNodo<Tipo> Hoja = new ClaseNodo<Tipo>(Objeto);
			if (Vacio)
			{
				Raiz = Hoja;
				
			}
			else
			{
				ClaseNodo<Tipo> nodoActual = Raiz;
				
				bool noInsertado = true;
				while (noInsertado)
				{
					if (Objeto.CompareTo(nodoActual.ObjetoConDatos) == -1)
					{
						if (nodoActual.HijoIzquierdo == null)
						{
							nodoActual.HijoIzquierdo = Hoja;
							noInsertado = false;
						}
						else
						{
							nodoActual = nodoActual.HijoIzquierdo;
							
						}
					}
					else if (Objeto.CompareTo(nodoActual.ObjetoConDatos) == 1)
					{
						if (nodoActual.HijoDerecho == null)
						{
							nodoActual.HijoDerecho = Hoja;
							noInsertado = false;
						}
						else
						{
							nodoActual = nodoActual.HijoDerecho;
						}
					}
					else
					{
						throw new Exception("No se permiten duplicados");
					}
				}
					
			}

		}

		public Tipo Eliminar (Tipo Objeto)
		{
			if (Vacio) throw new Exception("Esta vacia");
			ClaseNodo<Tipo> nodoActual = Raiz, Padre = null;
			// Búsqueda del nodo que se desea eliminar 
			while (!Objeto.Equals(nodoActual.ObjetoConDatos))
			{
				if (Objeto.CompareTo(nodoActual.ObjetoConDatos) == -1)
				{
					Padre = nodoActual; nodoActual = nodoActual.HijoIzquierdo;
					// Recorre el subárbol izquierdo
				}
				else
				{
					if (Objeto.CompareTo(nodoActual.ObjetoConDatos) == 1)
					{
						Padre = nodoActual; nodoActual = nodoActual.HijoDerecho;
						// Recorre el subárbol derecho 
					}
				}
				if (nodoActual == null) throw new Exception("No se encontro");
				// No se eliminó ... no existe el nodo 
			} // Se encontró el nodo que se desea eliminar 
			  // Caso 1: Si el NodoActual no tiene hijo derecho entonces su hijo izquierdo se convierte en // el nodo apuntado por su Padre 
			if (nodoActual.HijoDerecho == null)
			{
				if (Padre == null) Raiz = nodoActual.HijoIzquierdo;
				else
				{
					if (Padre.ObjetoConDatos.CompareTo(nodoActual.ObjetoConDatos) == 1) Padre.HijoIzquierdo = nodoActual.HijoIzquierdo;
					else
					{
						if (Padre.ObjetoConDatos.CompareTo(nodoActual.ObjetoConDatos) == -1) Padre.HijoDerecho = nodoActual.HijoDerecho;
					}
				}
			}
			else
			{
				// Caso 2: Si el hijo derecho del NodoActual no tiene hijo izquierdo entonces el hijo derecho // del NodoActual reemplaza al NodoActual 
				if (nodoActual.HijoDerecho.HijoIzquierdo == null)
				{
					nodoActual.HijoDerecho.HijoIzquierdo = nodoActual.HijoIzquierdo;
					if (Padre == null) Raiz = nodoActual.HijoDerecho;
					else
					{
						if (Padre.ObjetoConDatos.CompareTo(nodoActual.ObjetoConDatos) == 1) Padre.HijoIzquierdo = nodoActual.HijoDerecho;
						else
						{
							if (Padre.ObjetoConDatos.CompareTo(nodoActual.ObjetoConDatos) == -1) Padre.HijoDerecho = nodoActual.HijoDerecho;
						}
					}
				}
				else
				{
					// Caso 3: Si el hijo derecho del NodoActual tiene hijo izquierdo se reemplaza el // NodoActual con el hijo menor del subárbol derecho 
					// Inicia la búsqueda del nodo ubicado más a la izquierda de la rama derecha 
					ClaseNodo<Tipo> NodoMenor = nodoActual.HijoDerecho.HijoIzquierdo, PadreDelNodoMenor = nodoActual.HijoDerecho;
					while (NodoMenor.HijoIzquierdo != null)
					{
						PadreDelNodoMenor = NodoMenor;
						NodoMenor = NodoMenor.HijoIzquierdo;
					}
					// El subárbol izquierdo de su padre se convierte en el subárbol derecho del NodoMenor 
					PadreDelNodoMenor.HijoIzquierdo = NodoMenor.HijoDerecho;
					// Asigna los hijos del NodoMenor a los hijos del NodoActual 
					NodoMenor.HijoIzquierdo = nodoActual.HijoIzquierdo;
					NodoMenor.HijoDerecho = nodoActual.HijoDerecho;
					if (Padre == null) Raiz = NodoMenor;
					else
					{
						if (Padre.ObjetoConDatos.CompareTo(nodoActual.ObjetoConDatos) == 1) Padre.HijoIzquierdo = NodoMenor;
						else
						{
							if (Padre.ObjetoConDatos.CompareTo(nodoActual.ObjetoConDatos) == -1) Padre.HijoDerecho = NodoMenor;
						}
					}
				}
			}
			return (nodoActual.ObjetoConDatos);
		}


		public Tipo Buscar (Tipo Objeto)
		{
			if (Vacio)
			{
				throw new Exception("No se puede buscar el dato, el arbol esta vacio");
			}
			ClaseNodo<Tipo> nodoActual = Raiz;
			do
			{
				if (nodoActual.ObjetoConDatos.Equals(Objeto))
				{
					return nodoActual.ObjetoConDatos;
				}
				else 
				{
					if (Objeto.CompareTo(nodoActual.ObjetoConDatos) == 1)
					{
						nodoActual = nodoActual.HijoDerecho;
					}
					else
					{
						nodoActual = nodoActual.HijoIzquierdo;
					}

				}
			} while (nodoActual != null);
			throw new Exception("No se encontro el nodo seleccionado");
		}



		public IEnumerable<Tipo> RecorrerPreOrden()
		{
			foreach (Tipo miNodo in RecorrerPreOrden(this.Raiz))
			{
				yield return (miNodo);
			}
			yield break;
		}
		private IEnumerable<Tipo> RecorrerPreOrden(ClaseNodo<Tipo> nodoActual)
		{
			if (nodoActual != null)
			{
				yield return (nodoActual.ObjetoConDatos);
				foreach (Tipo miNodo in RecorrerPreOrden(nodoActual.HijoIzquierdo))
				{
					yield return (miNodo);
				}
				foreach (Tipo miNodo in RecorrerPreOrden(nodoActual.HijoDerecho))
				{
					yield return (miNodo);
				}

			}

		}
		public IEnumerable<Tipo> RecorrerInOrden()
		{
			foreach (Tipo miNodo in RecorrerInOrden(this.Raiz))
			{
				yield return (miNodo);
			}
			yield break;
		}
		private IEnumerable<Tipo> RecorrerInOrden(ClaseNodo<Tipo> nodoActual)
		{
			if (nodoActual != null)
			{
				foreach (Tipo miNodo in RecorrerInOrden(nodoActual.HijoIzquierdo))
				{
					yield return (miNodo);
				}
				yield return (nodoActual.ObjetoConDatos);
				foreach (Tipo miNodo in RecorrerInOrden(nodoActual.HijoDerecho))
				{
					yield return (miNodo);
				}
				
			}
		}
		public IEnumerable<Tipo> RecorrerPostOrden()
		{
			foreach (Tipo miNodo in RecorrerPostOrden(this.Raiz))
			{
				yield return (miNodo);
			}
			yield break;
		}

		private IEnumerable<Tipo> RecorrerPostOrden(ClaseNodo<Tipo> nodoActual)
		{
			if (nodoActual != null)
			{
				foreach (Tipo miNodo in RecorrerPostOrden(nodoActual.HijoIzquierdo))
				{
					yield return (miNodo);
				}
				foreach (Tipo miNodo in RecorrerPostOrden(nodoActual.HijoDerecho))
				{
					yield return (miNodo);
				}
				yield return (nodoActual.ObjetoConDatos);
			}
		}

		private void RecorrerNodos(ClaseNodo<Tipo> nodoActual, ref string resultado)
		{
			if (nodoActual != null)
			{
				if (nodoActual.HijoIzquierdo != null)
					resultado = resultado + "\n" + nodoActual.ObjetoConDatos.ToString() + "->" + nodoActual.HijoIzquierdo.ObjetoConDatos.ToString() + ";";

				if (nodoActual.HijoDerecho != null)
					resultado = resultado + "\n" + nodoActual.ObjetoConDatos.ToString() + "->" + nodoActual.HijoDerecho.ObjetoConDatos.ToString() + ";";

				RecorrerNodos(nodoActual.HijoIzquierdo, ref resultado);
				RecorrerNodos(nodoActual.HijoDerecho, ref resultado);

			}
		}


		public void CrearArchivoDot(ref string Resultado)
		{
			if (Vacio == false)
			{
				Resultado = Resultado + "digraph Figura {";
				Resultado = Resultado + "\nRaiz->" + Raiz.ObjetoConDatos.ToString() + ";";
				RecorrerNodos(Raiz, ref Resultado);
				Resultado = Resultado + "\n}";
			}
		}
	}
}
