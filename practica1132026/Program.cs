using System;

class EjemploClase
{
    public static void Main(string[] args)
    {
        string user = "javier.garcia@catolica.edu.sv";
        string contrasena = "javier";

        string[] alumnos = new string[100];
        string[] contras = new string[100];
        double[] promedios = new double[100];

        int totalAlumnos = 1;

        // Alumno inicial
        alumnos[0] = "2025GJ601";
        contras[0] = "1234";
        promedios[0] = 0;

        int opcion = 0;

        while (opcion != 3)
        {
            Console.WriteLine("\n1. Docente");
            Console.WriteLine("2. Alumno");
            Console.WriteLine("3. Salir");

            opcion = int.Parse(Console.ReadLine());

            // ================= DOCENTE =================
            if (opcion == 1)
            {
                Console.Write("Usuario: ");
                string usuarioDoc = Console.ReadLine();

                Console.Write("Contraseña: ");
                string passDoc = Console.ReadLine();

                if (usuarioDoc == user && passDoc == contrasena)
                {
                    Console.WriteLine("Acceso correcto");

                    int opDoc = 0;

                    while (opDoc != 6)
                    {
                        Console.WriteLine("\n--- MENÚ DOCENTE ---");
                        Console.WriteLine("1. Agregar alumno");
                        Console.WriteLine("2. Eliminar alumno");
                        Console.WriteLine("3. Editar alumno");
                        Console.WriteLine("4. Ingresar notas");
                        Console.WriteLine("5. Ver lista de alumnos");
                        Console.WriteLine("6. Salir");

                        opDoc = int.Parse(Console.ReadLine());

                        
                        if (opDoc == 1)
                        {
                            Console.Write("Nuevo usuario: ");
                            string nuevoUsuario = Console.ReadLine();

                            
                            bool existe = false;
                            for (int i = 0; i < totalAlumnos; i++)
                            {
                                if (alumnos[i] == nuevoUsuario)
                                {
                                    existe = true;
                                    break;
                                }
                            }

                            if (existe)
                            {
                                Console.WriteLine("El alumno ya existe.");
                            }
                            else
                            {
                                Console.Write("Contraseña: ");
                                string nuevaContra = Console.ReadLine();

                                alumnos[totalAlumnos] = nuevoUsuario;
                                contras[totalAlumnos] = nuevaContra;
                                promedios[totalAlumnos] = 0;

                                totalAlumnos++;
                                Console.WriteLine("Alumno agregado.");
                            }
                        }

                     
                        else if (opDoc == 2)
                        {
                            Console.Write("Usuario a eliminar: ");
                            string eliminar = Console.ReadLine();

                            bool encontrado = false;

                            for (int i = 0; i < totalAlumnos; i++)
                            {
                                if (alumnos[i] == eliminar)
                                {
                                    for (int j = i; j < totalAlumnos - 1; j++)
                                    {
                                        alumnos[j] = alumnos[j + 1];
                                        contras[j] = contras[j + 1];
                                        promedios[j] = promedios[j + 1];
                                    }

                                    totalAlumnos--;
                                    encontrado = true;
                                    Console.WriteLine("Alumno eliminado.");
                                    break;
                                }
                            }

                            if (!encontrado)
                            {
                                Console.WriteLine("Alumno no encontrado.");
                            }
                        }

                        else if (opDoc == 3)
                        {
                            Console.Write("Usuario a editar: ");
                            string buscar = Console.ReadLine();

                            bool encontrado = false;

                            for (int i = 0; i < totalAlumnos; i++)
                            {
                                if (alumnos[i] == buscar)
                                {
                                    Console.Write("Nuevo usuario: ");
                                    alumnos[i] = Console.ReadLine();

                                    Console.Write("Nueva contraseña: ");
                                    contras[i] = Console.ReadLine();

                                    Console.WriteLine("Alumno actualizado.");
                                    encontrado = true;
                                    break;
                                }
                            }

                            if (!encontrado)
                            {
                                Console.WriteLine("Alumno no encontrado.");
                            }
                        }

               
                        else if (opDoc == 4)
                        {
                            Console.Write("Usuario: ");
                            string buscar = Console.ReadLine();

                            bool encontrado = false;

                            for (int i = 0; i < totalAlumnos; i++)
                            {
                                if (alumnos[i] == buscar)
                                {
                                    Console.Write("Nota 1: ");
                                    double n1 = double.Parse(Console.ReadLine());

                                    Console.Write("Nota 2: ");
                                    double n2 = double.Parse(Console.ReadLine());

                                    Console.Write("Parcial: ");
                                    double n3 = double.Parse(Console.ReadLine());

                                    promedios[i] = (n1 * 0.25) + (n2 * 0.25) + (n3 * 0.5);

                                    Console.WriteLine("Promedio guardado.");
                                    encontrado = true;
                                    break;
                                }
                            }

                            if (!encontrado)
                            {
                                Console.WriteLine("Alumno no encontrado.");
                            }
                        }

                        
                        else if (opDoc == 5)
                        {
                            Console.WriteLine("\n--- LISTA DE ALUMNOS ---");

                            if (totalAlumnos == 0)
                            {
                                Console.WriteLine("No hay alumnos.");
                            }
                            else
                            {
                                for (int i = 0; i < totalAlumnos; i++)
                                {
                                    Console.WriteLine((i + 1) + ". " + alumnos[i] + " | Promedio: " + promedios[i]);
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Credenciales incorrectas.");
                }
            }

            
            else if (opcion == 2)
            {
                Console.Write("Usuario: ");
                string usuarioAlu = Console.ReadLine();

                Console.Write("Contraseña: ");
                string passAlu = Console.ReadLine();

                bool acceso = false;

                for (int i = 0; i < totalAlumnos; i++)
                {
                    if (alumnos[i] == usuarioAlu && contras[i] == passAlu)
                    {
                        Console.WriteLine("Bienvenido " + alumnos[i]);
                        Console.WriteLine("Promedio: " + promedios[i]);
                        acceso = true;
                        break;
                    }
                }

                if (!acceso)
                {
                    Console.WriteLine("Credenciales incorrectas.");
                }
            }
        }
    }
}