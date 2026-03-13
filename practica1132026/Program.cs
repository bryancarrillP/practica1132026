using System.Net.Mail;

class EjemploClase
{
    public static void Main(string[] args)
    {
        double nota1 = 0, nota2 = 0, nota3 = 0, promedio = 0;
        string usuario, password, usuario_alu, contraalumno;
        int op, intentos, opcion2, opcion;

        string user = "javier.garcia@catolica.edu.sv";
        string contrasena = "javier";

        string alumno = "2025GJ601";
        string contraseñaAlumno = "1234";
        opcion2 = 0;
        intentos = 0;
        while (opcion2 != 3)
        {
            Console.WriteLine("Bienvenido al sistema de notas");
            Console.WriteLine("Ingresa una opción");
            Console.WriteLine("1. Docente");
            Console.WriteLine("2. Alumno");
            Console.WriteLine("3. Salir");

            opcion2 = int.Parse(Console.ReadLine());

            if (opcion2 == 1)
            {
                Console.WriteLine("Perfil de docente");

                while (intentos < 3)
                {
                    Console.WriteLine("Usuario:");
                    usuario = Console.ReadLine();

                    Console.WriteLine("Contraseña:");
                    password = Console.ReadLine();

                    if (usuario == user && password == contrasena)
                    {
                        Console.WriteLine("Acceso correcto");

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

                            promedio = (nota1 * .25) + (nota2 * .25) + (nota3 * .5);

                            Console.WriteLine("Nota Primer Período: " + promedio);
                        }
                        else
                        {
                            Console.WriteLine("Saliendo...");
                            break;
                        }

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Usuario y contraseña incorrecta");
                        intentos++;
                    }
                }
            }
            else if (opcion2 == 2)
            {
                Console.WriteLine("Perfil de alumno");

                intentos = 0;

                while (intentos < 3)
                {
                    Console.WriteLine("Ingrese su usuario");
                    usuario_alu = Console.ReadLine();

                    Console.WriteLine("Ingrese su contraseña");
                    contraalumno = Console.ReadLine();

                    if (usuario_alu == alumno && contraalumno == contraseñaAlumno)
                    {
                        Console.WriteLine("Acceso correcto");

                        Console.WriteLine("1. Ver notas");
                        Console.WriteLine("2. Salir");

                        opcion = int.Parse(Console.ReadLine());

                        if (opcion == 1)
                        {
                            Console.WriteLine("Notas del alumno " + alumno);
                            Console.WriteLine("Nota Primer Período: " + promedio);
                        }
                        else if (opcion == 2)
                        {
                            Console.WriteLine("Saliendo...");
                            break;
                        }

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Usuario y contraseña incorrecta");
                        intentos++;
                    }
                }
                Console.WriteLine("Saliendo...");
            }
        }
    }
}