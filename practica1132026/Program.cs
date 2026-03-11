using System.Net.Mail;

class EjemploClase
{
    public static void Main(string[] args)
    {
        double nota1, nota2, nota3, promedio;
        string usuario, password, usuario_alu, contraalumno;
        int op, intentos;
        string user = "javier.garcia@catolica.edu.sv";
        string contrasena = "javier";
        string alumno = "2025GJ601";
        string contraseñaAlumno = "1234";
        intentos = 0;

       while (intentos < 3)
        {
            Console.WriteLine("Usuario:");
            usuario = Console.ReadLine();
            Console.WriteLine("Contraseña:");
            password = Console.ReadLine();
            if (usuario == user && password==contrasena) 
            { 
                    Console.WriteLine("Acceso correcto");
                Console.WriteLine("Perfil de docente");
                    Console.WriteLine("1. Notas");
                    Console.WriteLine("2. Salir");
                    Console.WriteLine("Ingresar una opción");
                    op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        Console.WriteLine("Ingresar notas del período 1");
                        Console.WriteLine("Ingresar la nota de Actividad 1:");
                        nota1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresar la nota de Actividad 2:");
                        nota2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresar la nota del Parcial:");
                        nota3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nota Primer Período");
                        promedio = (nota1 * .25) + (nota2 * .25) + (nota3 * .5);
                        Console.WriteLine(promedio);

                    }
                    else
                    {
                        Console.WriteLine("Saliendo..."); break;
                    }
               
            }
            else
            {
                Console.WriteLine("Usuario y contraseña incorrecta");
            }
            intentos++;
        }
      
        if (intentos == 3)
        {
            Console.WriteLine("Cuenta bloqueada");
        }
    }
}
        