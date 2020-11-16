using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioBusqueda
{
	
    class ClaseNodo<Tipo>
    {

		public ClaseNodo(Tipo Objeto)
		{
			ObjetoConDatos = Objeto;
		}
		private Tipo _ObjetoConObjeto;

		public Tipo ObjetoConDatos
		{
			get { return _ObjetoConObjeto; }
			set { _ObjetoConObjeto = value; }
		}

		private ClaseNodo<Tipo> _hijoIzq;

		public ClaseNodo<Tipo> HijoIzquierdo
		{
			get { return _hijoIzq; }
			set { _hijoIzq = value; }
		}

		private ClaseNodo<Tipo> _HijoDer;	

		public ClaseNodo<Tipo> HijoDerecho
		{
			get { return _HijoDer; }
			set { _HijoDer = value; }
		}

		~ClaseNodo()
		{
			_ObjetoConObjeto = default;
		}

	}
}
