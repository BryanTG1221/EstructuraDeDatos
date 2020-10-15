using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesED
{
	class Nodo<Tipo>
	{
		public Nodo()
		{

		}
		private Tipo _ObjetoConDatos;

		public Tipo ObjetoConDatos
		{
			get { return _ObjetoConDatos; }
			set { _ObjetoConDatos = value; }
		}

		private Nodo<Tipo> _Siguiente;

		public Nodo<Tipo> Siguiente
		{
			get { return _Siguiente; }
			set { _Siguiente = value; }
		}

		~Nodo()
		{
			ObjetoConDatos = default(Tipo);
		}


	}
}
