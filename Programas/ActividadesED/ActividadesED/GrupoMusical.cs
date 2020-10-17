using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesED
{
    class GrupoMusical:IEquatable<GrupoMusical>, IComparable<GrupoMusical> 
    {
		private string _strNombreGrupo;

		public string NombreGrupo
		{
			get { return _strNombreGrupo; }
			set { _strNombreGrupo = value; }
		}

		private double _dblPrecioHora;

		public double PrecioHora
		{
			get { return _dblPrecioHora; }
			set { _dblPrecioHora = value; }
		}

		private int _intCantidadIntegrantes;

		public int CantidadIntegrantes
		{
			get { return _intCantidadIntegrantes; }
			set { _intCantidadIntegrantes = value; }
		}

		private string _strNombreDueño;

		public string NombreDueño
		{
			get { return _strNombreDueño; }
			set { _strNombreDueño = value; }
		}

		private string _strGenero;

		public string Genero
		{
			get { return _strGenero; }
			set { _strGenero = value; }
		}

		private char _chrClasificacion;

		public char Clasificacion
		{
			get { return _chrClasificacion; }
			set { _chrClasificacion = value; }
		}

		private string _FechaFundacion;

		public string FechaFundacion
		{
			get { return _FechaFundacion; }
			set { _FechaFundacion = value; }
		}

		private bool _bolEstado;

		public bool Estado
		{
			get { return _bolEstado; }
			set { _bolEstado = value; }
		}

		private string _strLogoGrupo;

		public string LogoGrupo
		{
			get { return _strLogoGrupo; }
			set { _strLogoGrupo = value; }
		}

		private string _strConverionEstado;

		public string ConversionEstado
		{
			get { return _strConverionEstado; }
			set { _strConverionEstado = value; }
		}




		public bool Equals(GrupoMusical grupoMusical)
		{
			return (this._strNombreGrupo == grupoMusical._strNombreGrupo && this._strNombreDueño == grupoMusical._strNombreDueño && this._dblPrecioHora == grupoMusical._dblPrecioHora && this._chrClasificacion == grupoMusical._chrClasificacion && this._bolEstado == grupoMusical._bolEstado && this._FechaFundacion == grupoMusical._FechaFundacion && this._intCantidadIntegrantes == grupoMusical._intCantidadIntegrantes&&this.LogoGrupo==grupoMusical.LogoGrupo);
			
		}

		public int CompareTo(GrupoMusical grupoMusical)
			=> string.Compare(NombreGrupo, grupoMusical.NombreGrupo);
		
			
		



	}
}
