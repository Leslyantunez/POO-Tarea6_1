using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioEmp.Clases
{
    public class Cargo
    {

        private int numeroCargo { set; get; }
        private string titulo { set; get; }
        private DateTime fechaInicio { set; get; }
        private DateTime fechaFinal { set; get; }
        private bool empleoActual { set; get; }
        private string empresa { set; get; }
        private decimal salario { set; get; }
        private string detalles { set; get; }


        public Cargo()
        { }

        public Cargo(int numeroCargo)
        {
            this.numeroCargo = numeroCargo;
            this.titulo = titulo;


        }
        public int getnumeroCargo()
        {
            return this.numeroCargo;

        }
        public void setnumeroCargo(int numeroCargo)
        {
            this.numeroCargo = numeroCargo;

        }
        public string gettitulo()
        {
            return this.titulo = titulo;
        }
        public void settitulo(string titulo)
        {
            this.titulo = titulo;
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
        public bool getempleoActual()
        {
            return this.empleoActual;
        }
        public void setempleoActual(bool empleoActual)
        {
            this.empleoActual = empleoActual;
        }
        public string getempresa()
        {
            return this.empresa;
        }
        public void setempresa(string empresa)
        {
            this.empresa = empresa;
        }
        public decimal getsalario()
        {
            return this.salario;
        }
        public void setsalario(decimal salario)
        {
            this.salario = salario;
        }
        public string getdetalles()
        {
            return this.detalles;
        }
        public void setdetalles(string detalles)
        {
            this.detalles = detalles;
        }

    }
}
