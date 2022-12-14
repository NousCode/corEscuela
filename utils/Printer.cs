using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DrawLine(int tam = 24) 
        {
            WriteLine("".PadLeft(tam, '='));
        }

        public static void WriteTitle(string titulo)
        {
            DrawLine(titulo.Length + 6);
            WriteLine($"|  {titulo}  |");
            DrawLine(titulo.Length + 6);
        }

        public static void Beep(int cantidad = 1) 
        {
            while (cantidad > 0)
            {
                Console.Beep();
                cantidad -= 1   ;
            }
        }
    }    
}