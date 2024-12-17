
using System;

class Conversor 
{
   static void Main()
      {
         // Declaración de variables y constantes.
         float cantidad;
         float resultadoDolar;
         float resultadoEuro;
         bool finished = false;

         const float dolar = 4318f;
         const float euro = 4530f;
         
         // Se crea un ciclo do while para ejecutar la lógica y las validaciones.
         do {

            Console.WriteLine("Ingresa la cantidad de pesos Colombianos que desea convertir:");
            string? input = Console.ReadLine();

            if(input == null) return;

             // Validamos que los datos ingresador sean correctos.
            if (float.TryParse(input, out cantidad) && cantidad > 0)
            {
               cantidad = float.Parse(input);

               resultadoDolar =  cantidad / dolar;
               resultadoEuro = cantidad / euro;

               // Redondeamos a 2 decimales
               resultadoDolar = (float)Math.Round(resultadoDolar, 2);
               resultadoEuro = (float)Math.Round(resultadoEuro, 2);

               Console.WriteLine($"La cantidad en Dólares es: ${resultadoDolar}");
               Console.WriteLine($"La cantidad en Euros es: €{resultadoEuro}");

               // Si los datos son correctos, este flag cambia a true para terminar el cilo do while.
               finished = true;
            }
            else
            {
               Console.WriteLine("El valor ingresado no es un número valido, está vacío o es un texto. Por favor, ingrese otro valor.");
            }
         } while (finished == false);
         
      }
}
