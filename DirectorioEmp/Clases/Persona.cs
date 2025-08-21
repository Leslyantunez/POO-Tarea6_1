using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioEmp.Clases
{
    public class Persona
    {
        private string NumeroID { set; get; }
        private string Nombres { set; get; }
        private string Apellidos { set; get; }
        private DateTime FechaNacimiento { set; get; }
        private string Telefono { set; get; }
        private string Celular { set; get; }
        private string Pais { set; get; }
        private string Ciudad { set; get; }
        private string Direccion { set; get; }
        private string Profesion { set; get; }



        List<Grado> Grado = new List<Grado>();



        public Grado NumGrado { get; set; }
        public Grado NivelEducativo { get; set; }
        public Grado Institucion { get; set; }
        public Grado NombreTitulo { get; set; }
        public Grado FechaInicio { get; set; }
        public Grado FechaFinal { get; set; }
        public Grado TipoGrado { get; set; }
        public Grado FechaExpiracion { get; set; }
        public Grado PaisGrado { get; set; }

        List<Cargo> Cargos = new List<Cargo>();

        public Cargo NumCargo { get; set; }
        public Cargo Titulo { get; set; }
        public Cargo fechaInicio { get; set; }
        public Cargo fechaFinal { get; set; }
        public Cargo EmpleoActaul { get; set; }
        public Cargo Empresa { get; set; }
        public Cargo Salario { get; set; }
        public Cargo Detalles { get; set; }
   
       
        
    }
 
}



