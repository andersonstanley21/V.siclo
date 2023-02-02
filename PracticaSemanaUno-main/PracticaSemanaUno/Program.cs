using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSemanaUno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo miCaballo = new Caballo("Boni");
            Humano miHumano = new Humano("Pedro");
            Gorila miGorila = new Gorila("Rochi");
            Ballena miBallena = new Ballena("Wally");
            Cocodrilo miCocodrilo = new Cocodrilo("Modelon");

            Mamifero[] almacenAnimales = new Mamifero[4];
            almacenAnimales[0] = miCaballo;
            almacenAnimales[1] = miHumano;
            almacenAnimales[2] = miGorila;
            almacenAnimales[3] = miBallena;

            for(int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }

            Mamifero miMamifero = new Mamifero("");
            miMamifero.pensar();

            miCaballo.cuidarCrias();
            miHumano.getNombre();
            miGorila.trepar();

        }


    }

    abstract class Animales
    {
        public void respirar()
        {
            Console.WriteLine("Soy Capaz de respirar");
        }

        public abstract void getNombre();
    }

    interface IAnimalesTerrestres
    {
        int numeroPatas();
    }

    class Reptil:Animales
    {
        public Reptil(String nombre)
        {
            String nombreSerVivo = nombre;
        }

        public override void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
        }

        private String nombreSerVivo;
    }

    class Mamifero:Animales
    {
        public Mamifero(String nombre)
        {
            String nombreSerVivo = nombre;
        }

        

        public void pensar()
        {
            Console.WriteLine("Pensamientos básico instintivos");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuidar de las crias hasta que se valgan por si solar");
        }

       
        public override void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
        }

        private String nombreSerVivo;


    }

    class Ballena : Mamifero
    {
        public Ballena(String nombreBallena) : base(nombreBallena)
        {

        }

        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }

class Caballo: Mamifero, IAnimalesTerrestres
{
    public Caballo(String nombreCaballo):base(nombreCaballo)
    {

    }

    public void galopar()
        {
            Console.WriteLine("Soy Capaz de galopar");
        }

    public int numeroPatas()
        {
            return 4;
        }

    }

    class Humano: Mamifero
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }

        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");
        }
    }

    class Gorila:Mamifero, IAnimalesTerrestres
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }

        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
        public int numeroPatas()
        {
            return 2;
        }
    }

    class Cocodrilo:Reptil,IAnimalesTerrestres
    {
        public Cocodrilo(String nombreCocodrilo) : base(nombreCocodrilo)
        {

        }

        public void muerde()
        {
            Console.WriteLine("Soy Capaz de morder");
        }
        public int numeroPatas()
        {
            return 4;
        }
    }


}
