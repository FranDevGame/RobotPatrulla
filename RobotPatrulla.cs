using System;

namespace RobotPatrulla
{
    class RobotPatrulla
    {
        static void Main(string[] args)
        {
            bool continueSoftwareExecution = false; //Declaramos una variable booleana para que el Robot tenga la condición de continuar la ejecución en falsa, por defecto.

            do
            {
                Console.WriteLine("Presentamos el remake de ROBOCOP; Escribe 0 para que Robocop entre en modo PATRULLA, escribe 1 para que detecte UN SOLO intruso, " +
                    "2 para que detecte VARIOS intrusos, " +
                    "3 si quieres salir del modo PATRULLA");

                int KeepGoing = Convert.ToInt16(Console.ReadLine()); /*Declaramos una variable KeepGoing con tipo de valor entero y la clase convert con el método toint16, 
                                                                      * para decir "Oye, el valor 0 es un valor int, pero está vinculado a "Modo Patrulla" y transforma a valor int de 16 bites,
                                                                      * la entrada y salida de datos de tipo string (lo que queremos que lea la consola en cada caso de if y else)"*/
                
                if (KeepGoing == 0)
                {
                    Console.WriteLine("Hello World! Modo PATRULLA CONECTADO");
                    continueSoftwareExecution = true;
                }
                else if (KeepGoing == 1)
                {
                    Console.WriteLine("el robot detecta a 1 único intruso en modo PATRULLA");
                    continueSoftwareExecution = true;
                }
                else if (KeepGoing == 2)
                {
                    Console.WriteLine("el robot detecta VARIOS intrusos en modo PATRULLA");
                    continueSoftwareExecution = true;
                }
                else if (KeepGoing == 3)
                {
                    Console.WriteLine("el robot sale del MODO PATRULLA");
                    continueSoftwareExecution = false;
                }


                else
                    Console.WriteLine("Dato inválido, inténtalo de nuevo");
            }while (continueSoftwareExecution == true);
        }
    }
}
