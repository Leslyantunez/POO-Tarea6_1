using DirectorioEmp.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            List<Grado> Grado = new List<Grado>();
            

            Grado NumGrado = new Grado("3");
            Grado NivelEducativo = new Grado("Primaria");
            Grado Institucion = new Grado("Jose Cecilio del Valle");
            Grado NombreTitulo = new Grado("Certificado de primaria");
            Grado FechaInicio = new Grado("2/3/2010");
            Grado FechaFinal = new Grado("15/12/2016");
            Grado TipoGrado = new Grado("Primaria");
            Grado FechaExpiracion = new Grado("15/8/2024");
            Grado PaisGrado = new Grado("Honduras");

            //Declaracion de objetos Grado
            
            Grado.Add(NumGrado);
            Grado.Add(NivelEducativo);
            Grado.Add(Institucion);
            Grado.Add(NombreTitulo);
            Grado.Add(FechaInicio);
            Grado.Add(FechaFinal);
            Grado.Add(TipoGrado);
            Grado.Add(FechaExpiracion);
            Grado.Add(PaisGrado);

            foreach (Grado g in Grado)
            {
                Console.WriteLine(Grado);
              
            }
           
            List<Cargo> cargos = new List<Cargo>();

            Cargo NumCargo = new Cargo();
            Cargo Titulo = new Cargo();
            Cargo fechaInicio = new Cargo();
            Cargo fechaFinal = new Cargo();
            Cargo EmpleoActual = new Cargo();
            Cargo Empresa = new Cargo();
            Cargo Salario = new Cargo();
            Cargo Detalles = new Cargo();

            cargos.Add(NumCargo);
            cargos.Add(Titulo);
            cargos.Add(fechaInicio);
            cargos.Add(fechaFinal);
            cargos.Add(EmpleoActual);
            cargos.Add(Empresa);
            cargos.Add(Salario);
            cargos.Add(Detalles);

            Console.ReadLine();
    }
  

    }
}
