using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleProyecto
{
    class ClaseNodo<Tipo>
    {
		private Tipo _objetoConDatos;

		public Tipo ObjetoConDatos
		{
			get { return _objetoConDatos; }
			set { _objetoConDatos = value; }
		}

		private ClaseNodo<Tipo> _Siguiente;

		public ClaseNodo<Tipo> Siguiente
		{
			get { return _Siguiente; }
			set { _Siguiente = value; }
		}

		private ClaseNodo<Tipo> _Anterior;

		public ClaseNodo<Tipo> Anterior
		{
			get { return _Anterior; }
			set { _Anterior = value; }
		}




		~ClaseNodo()
		{
			ObjetoConDatos = default(Tipo);
		}


	}
}
