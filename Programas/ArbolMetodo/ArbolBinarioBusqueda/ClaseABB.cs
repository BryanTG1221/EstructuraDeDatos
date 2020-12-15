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
			
			while (!Objeto.Equals(nodoActual.ObjetoConDatos))
			{
				if (Objeto.CompareTo(nodoActual.ObjetoConDatos) == -1)
				{
					Padre = nodoActual; nodoActual = nodoActual.HijoIzquierdo;
				
				}
				else
				{
					if (Objeto.CompareTo(nodoActual.ObjetoConDatos) == 1)
					{
						Padre = nodoActual; nodoActual = nodoActual.HijoDerecho;
						
					}
				}
				if (nodoActual == null) throw new Exception("No se encontro");
				
			}  
 
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

					ClaseNodo<Tipo> NodoMenor = nodoActual.HijoDerecho.HijoIzquierdo, PadreDelNodoMenor = nodoActual.HijoDerecho;
					while (NodoMenor.HijoIzquierdo != null)
					{
						PadreDelNodoMenor = NodoMenor;
						NodoMenor = NodoMenor.HijoIzquierdo;
					}
					 
					PadreDelNodoMenor.HijoIzquierdo = NodoMenor.HijoDerecho;
					 
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

		public void Vaciar()
		{
			if (Vacio == false)
			{
				this.RecorrerYBuscar(this.Raiz);
				this.Raiz = null;
				return;
			}
			return;
		}

		private void RecorrerYBuscar(ClaseNodo<Tipo> nodoActual)
		{
			if (nodoActual != null)
			{
				this.RecorrerYBuscar(nodoActual.HijoIzquierdo);
				this.RecorrerYBuscar(nodoActual.HijoDerecho);
				this.Eliminar(nodoActual.ObjetoConDatos);
				return;
			}
			return;
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

		

	

		
		public IEnumerable<Tipo> FiltrarDatos(Tipo NodoMain)
		{
			foreach (Tipo miNodo in FiltrarDatos(this.Raiz,NodoMain))
			{
				yield return (miNodo);
			}
			yield break;
		}

		private IEnumerable<Tipo> FiltrarDatos(ClaseNodo<Tipo> nodoActual, Tipo nodoMain)
		{
			
			if (nodoActual != null)
			{
				foreach (Tipo miNodo in RecorrerPreOrden())
				{
					if (miNodo.CompareTo(nodoMain) == -1)
					{
						yield return (miNodo);
					}
				}

			}
				//-------------------------------------------------------------------------------\\
				

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
