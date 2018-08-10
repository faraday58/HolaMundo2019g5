using System;

namespace TarifaLlamadas
{
    class Program
    {
        static void Main()
        {
            int bandera = 0;
            do
            {
                float Tot=0;
                Console.WriteLine("¿Qué tipo de llamada realizó? \n A)Internacional  \n B) Nacional \n C)Local \n x)Terminar  ");
                //char.Parse Convierte una cadena o un valor a Carácter
                char Tipo = char.Parse( Console.ReadLine());
                switch (Tipo)
                {
                    case 'A':
                        float Min = 5.02f;
                        float Adi = 3.03f;
                        Console.WriteLine("¿Cuánto tiempo duró la llamada");
                        int duracion = int.Parse(Console.ReadLine());
                        if(duracion == -1  )
                        {
                            bandera = 1;
                        }
                        else
                        {
                            if (duracion > 3)
                            {
                                 Tot = Min + Adi * (duracion - 3);
                            }   
                            else
                            {
                                 Tot = Min;
                            }
                            Console.WriteLine("El costo total de su llamada es: {0}",Tot);
                        }

                        break;

                }

            } while (bandera == 1);

        }
    }
}
