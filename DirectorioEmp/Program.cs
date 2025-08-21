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
            


            //Declaracion de objetos Grado

            Grado g1 = new Grado("5");  
            Grado g2 = new Grado("UNAH");
            Grado g3 = new Grado("Licenciatura");
            Grado g4 = new Grado("Ingenieria en sistemas");
            Grado g5 = new Grado("2024-08-15");
            Grado g6 = new Grado("2020-09-20");
            Grado g7 = new Grado("Licenciatura en Informatica");
            Grado g8 = new Grado("2026-12-31");
            Grado g9 = new Grado("Honduras");
            

            Grado.Add(g1);
            Grado.Add(g2);
            Grado.Add(g3);
            Grado.Add(g4);
            Grado.Add(g5);
            Grado.Add(g6);
            Grado.Add(g7);
            Grado.Add(g8);
            Grado.Add(g9);


            foreach (Grado g in Grado)
            {
                Console.WriteLine("Grado");
                Console.WriteLine(g.getnumeroGrado());
                Console.WriteLine(g.getnivelEducativo());
                Console.WriteLine(g.getinstitucion());
                Console.WriteLine(g.getnombreTitulo());
                Console.WriteLine(g.getfechaInicio());
                Console.WriteLine(g.getfechaFinal());
                Console.WriteLine(g.gettipoGrado());
                Console.WriteLine(g.getfechaExpiracion());
                Console.WriteLine(g.getpais());

            }
           
            List<Cargo> cargos = new List<Cargo>();

            Cargo Cargo1 = new Cargo();

           

            Cargo1.setnumeroCargo(1);
            Cargo1.settitulo("Desarrollador de Software");
            Cargo1.setfechaInicio(new DateTime(2018, 1, 1));
            Cargo1.setfechaFinal(new DateTime(2020, 12, 31));
            Cargo1.setempleoActual(true);
            Cargo1.setempresa("Tech Solutions");
            Cargo1.setsalario(50000);
            Cargo1.setdetalles("Desarrollo de aplicaciones web.");

            cargos.Add(Cargo1);
            foreach (Cargo g in cargos)
            {
                Console.WriteLine("Cargo");
                Console.WriteLine(g.getnumeroCargo());
                Console.WriteLine(g.gettitulo());
                Console.WriteLine(g.getfechaInicio());
                Console.WriteLine(g.getfechaFinal());
                Console.WriteLine(g.getempleoActual());
                Console.WriteLine(g.getempresa());
                Console.WriteLine(g.getsalario());
                Console.WriteLine(g.getdetalles());

            }

            Console.ReadLine();
    }
  

    }
}
