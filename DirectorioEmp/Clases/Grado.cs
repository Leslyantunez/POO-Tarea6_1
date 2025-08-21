using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioEmp.Clases
{
    public class Grado
    {

        private int numerogrado { set; get; }
        private string nivelEducativo { set; get; }
        private string institucion { set; get; }
        private string nombreTitulo {set; get; }
        private DateTime fechaInicio { set; get; }
        private DateTime fechaFinal { set; get; }
        private string tipoGrado { set; get; }
        private DateTime fechaExpiracion { set; get; }
        private string pais { set; get; }

        public Grado()
        { }

        public int getnumeroGrado()
        {
            return this.numerogrado;

        }
        public void setnumeroGrado(int numeroGrado)
        {
            this.numerogrado = numerogrado; 
        }
        public string getnivelEducativo()
        {
            return this.nivelEducativo; 
        }
        public void setnivelEducativo(string nivelEducativo)
        {
            this.nivelEducativo = nivelEducativo;
        }
        public string getinstitucion()
        {
            return this.institucion;
        }
        public void setinstitucion(string institucion)
        {
            this.institucion = institucion;
        }
        public string getnombreTitulo()
        {
            return this.nombreTitulo;
        }
        public void setnombreTitulo(string nombreTitulo)
        {
            this.nombreTitulo = nombreTitulo;
        }
        public DateTime getfechaInicio()
        {
            return this.fechaInicio;
        }
        public void setfechaInicio(DateTime fechaInicio)
        {
            this.fechaInicio = fechaInicio;
        }
        public DateTime getfechaFinal()
        {
            return this.fechaFinal;
        }
        public void setfechaFinal(DateTime fechaFinal)
        {
            this.fechaFinal = fechaFinal;
        }
        public string gettipoGrado()
        {
            return this.tipoGrado;
        }
        public void settipoGrado(string tipoGrado)
        {
            this.tipoGrado = tipoGrado;
        }
        public DateTime getfechaExpiracion()
        {
            return this.fechaExpiracion;
        }
        public void setfechaExpiracion(DateTime fechaExpiracion)
        {
            this.fechaExpiracion = fechaExpiracion;
        }
        public string getpais()
        {
            return this.pais = pais;
        }
        public string setpais(string pais)
        {
            return this.pais;
        }

        public Grado(int numeroGrado)
        {
            this.numerogrado = numeroGrado;
        }
        public Grado(string nivelEducativo)
        {
            this.nivelEducativo = nivelEducativo;
        }
    }
}
