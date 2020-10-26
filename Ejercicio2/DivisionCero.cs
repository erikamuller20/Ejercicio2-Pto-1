using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class DivisionCero
    {
        public void Division(int i, int j)
        {
            try
            {
                int division = i / j;
                Console.WriteLine($"El resultado es { division }");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error division entre cero. Mensaje: { ex.Message }");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Mensaje: { ex.Message }");
            }
            finally
            {
                Console.WriteLine("Ejecucion Realizada");
                Console.ReadKey();
            }

        }

    }
}
