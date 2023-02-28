using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cntriangulo
{
    /// <summary>
    /// 22/02/2023
    /// Jaider Andres Oquendo zapata
    /// programa que carga los lados de un triángulo e implemente los siguientes métodos: 
    /// inicializa los atributos, imprime el valor del lado mayor y muestra si es equilátero o no.
    /// </summary>

    internal class Program
    {
        
        double Lado1 ;
        double Lado2 ;
        double Lado3 ;
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO A LA APLICACION TRIANGULO");
            //invoca los metodos de la clase
            Program triangulo =new Program();
            triangulo.inicializar();
            triangulo.ValorLadoMayor();
            triangulo.Equilatero();

            Console.ReadKey();
        }
        //metodos
        #region

        // inicializa los atributos
        public void inicializar()
        {
            Console.WriteLine("Por favor ingrese el valor del primer lado del triangulo");
            Lado1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Por favor ingrese el valor del segundo lado del triangulo");
            Lado2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Por favor ingrese el valor del tercer lado del triangulo");
            Lado3= Convert.ToDouble(Console.ReadLine());

        }
        // selecciona con estructura de desicion logica e imprime el valor del lado mayor.
        public void ValorLadoMayor()
        {
            
            if ( Lado1>Lado2 && Lado1>Lado3 )
            {
                Console.WriteLine("el lado mayor es: ");
                Console.WriteLine("El primer lado el cual tiene un valor de: " + Lado1);
            }
            if  (Lado2>Lado3 && Lado2>Lado3 ) 
            {
                Console.WriteLine("el lado mayor es: ");
                Console.WriteLine("El segundo lado el cual tiene un valor de: " + Lado2);
            }
            if (Lado3 > Lado2 && Lado3 > Lado1)
            {
                Console.WriteLine("el lado mayor es: ");
                Console.WriteLine("El tercer lado el cual tiene un valor de: " + Lado3);
            }
            else
            {

                Console.WriteLine("Todos los lados tienen el mismo valor que es: " +Lado1 );
            }
            
               
        }
        //con estructura de desicion logica muestra si es equilátero o no.
        public void Equilatero()
        {
            if ( Lado1==Lado2 && Lado1==Lado3 )
            {
                Console.WriteLine("El triangulo es un triangulo equilatero." );
            }
            else
            {
                Console.WriteLine("El triangulo NO es un triangulo equilatero.");
            }

        }
        #endregion

    }
}
