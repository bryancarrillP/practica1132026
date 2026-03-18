using System;
using System.Collections;

class EjemploClase
{
    public static void Main(string[] args)
    {
        string user = "javier.garcia@catolica.edu.sv";
        string contrasena = "javier";

        ArrayList alumnos = new ArrayList();
        ArrayList contras = new ArrayList();
        ArrayList promedios = new ArrayList();

        alumnos.Add("2025GJ601");
        contras.Add("1234");
        promedios.Add(0.0);

        int opcion = 0;

        while (opcion != 3)
        {
            Console.WriteLine("\n1. Docente");
            Console.WriteLine("2. Alumno");
            Console.WriteLine("3. Salir");

            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Usuario: ");
                string usuarioDoc = Console.ReadLine();

                Console.Write("Contraseña: ");
                string passDoc = Console.ReadLine();

                if (usuarioDoc == user && passDoc == contrasena)
                {
                    int opDoc = 0;

                    while (opDoc != 6)
                    {
                        Console.WriteLine("\n1. Agregar alumno");
                        Console.WriteLine("2. Eliminar alumno");
                        Console.WriteLine("3. Editar alumno");
                        Console.WriteLine("4. Ingresar notas");
                        Console.WriteLine("5. Ver lista de alumnos");
                        Console.WriteLine("6. Salir");

                        opDoc = int.Parse(Console.ReadLine());

                        if (opDoc == 1)
                        {
                            Console.Write("Nuevo usuario: ");
                            string nuevo = Console.ReadLine();

                            bool existe = false;
                            for (int i = 0; i < alumnos.Count; i++)
                            {
                                if (alumnos[i].ToString() == nuevo)
                                {
                                    existe = true;
                                    break;
                                }
                            }

                            if (!existe)
                            {
                                Console.Write("Contraseña: ");
                                string contra = Console.ReadLine();

                                alumnos.Add(nuevo);
                                contras.Add(contra);
                                promedios.Add(0.0);
                            }
                            else
                            {
                                Console.WriteLine("El alumno ya existe.");
                            }
                        }
                        else if (opDoc == 2)
                        {
                            Console.Write("Usuario a eliminar: ");
                            string eliminar = Console.ReadLine();

                            bool encontrado = false;

                            for (int i = 0; i < alumnos.Count; i++)
                            {
                                if (alumnos[i].ToString() == eliminar)
                                {
                                    alumnos.RemoveAt(i);
                                    contras.RemoveAt(i);
                                    promedios.RemoveAt(i);
                                    encontrado = true;
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

                            for (int i = 0; i < alumnos.Count; i++)
                            {
                                if (alumnos[i].ToString() == buscar)
                                {
                                    Console.Write("Nuevo usuario: ");
                                    alumnos[i] = Console.ReadLine();

                                    Console.Write("Nueva contraseña: ");
                                    contras[i] = Console.ReadLine();

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

                            for (int i = 0; i < alumnos.Count; i++)
                            {
                                if (alumnos[i].ToString() == buscar)
                                {
                                    Console.Write("Nota 1: ");
                                    int n1 = int.Parse(Console.ReadLine());

                                    Console.Write("Nota 2: ");
                                    int n2 = int.Parse(Console.ReadLine());

                                    Console.Write("Parcial: ");
                                    int n3 = int.Parse(Console.ReadLine());

                                    double promedio = (n1 * 0.25) + (n2 * 0.25) + (n3 * 0.5);

                                    promedios[i] = promedio;
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
                            if (alumnos.Count == 0)
                            {
                                Console.WriteLine("No hay alumnos.");
                            }
                            else
                            {
                                for (int i = 0; i < alumnos.Count; i++)
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

                for (int i = 0; i < alumnos.Count; i++)
                {
                    if (alumnos[i].ToString() == usuarioAlu && contras[i].ToString() == passAlu)
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