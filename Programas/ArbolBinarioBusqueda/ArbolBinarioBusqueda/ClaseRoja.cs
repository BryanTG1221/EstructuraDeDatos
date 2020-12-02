using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioBusqueda
{
    class ClaseRoja : IEquatable<ClaseRoja> , IComparable<ClaseRoja>
    {

		private int _strNombre;

		public int Edad
		{
			get { return _strNombre; }
			set { _strNombre = value; }
		}

		private string _strPuesto;

		public string Puesto
		{
			get { return _strPuesto; }
			set { _strPuesto = value; }
		}

		private bool _bolHomeOffice;

		public bool HomeOffice
		{
			get { return _bolHomeOffice; }
			set { _bolHomeOffice = value; }
		}

		private DateTime _dtmHora;

		public DateTime Hora
		{
			get { return _dtmHora; }
			set { _dtmHora = value; }
		}

		public override string ToString()
		{
			return this.Salario.ToString();
		}

		private double _dblSalario;

		public double Salario
		{
			get { return _dblSalario; }
			set { _dblSalario = value; }
		}





		public bool Equals(ClaseRoja Objeto)
		{
			if (Objeto.Hora == this.Hora && Objeto.Edad == this.Edad && Objeto.Puesto == this.Puesto)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public int CompareTo(ClaseRoja Objeto)
		{
			if (this.Salario > Objeto.Salario)
				return 1;
			if(this.Salario < Objeto.Salario)
			{
				return -1;
			}
			return 0;
		}
		
			
		
	}
}
