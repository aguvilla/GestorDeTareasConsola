using _3._Clase___Lista.Class;

namespace _3._Clase___Lista
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            List<Tarea> tareas = new List<Tarea>();
            string opcion = "";

            while (opcion != "5")
            {
                Console.Clear();

                Console.WriteLine("Bienvenido al gestor de Tareas:\n Selecciones una opcion");
                Console.WriteLine("1_ Crear Tarea \n2_ Ver Tareas \n3_ Marcar como completada \n4_ Borrar una tarea \n5_ Salir");
                opcion = Console.ReadLine();
                Console.Clear();

                switch (opcion)
                {

                    case "1":
                        Console.WriteLine("Ingrese descripcion de la tarea:");
                        string descripcion = Console.ReadLine();
                        int id = tareas.Count + 1; // Genera un ID basado en la cantidad de tareas
                        Tarea tarea = new Tarea(id, descripcion);
                        tareas.Add(tarea);
                        Console.Clear() ;
                        Console.WriteLine("Tarea agregada con éxito.");
                        Console.WriteLine("Presione una tecla para volver al menu...");
                        Console.ReadKey();
                        break;

                    case "2":
                        MostrarTareas(tareas);
                        Console.WriteLine("Presione una tecla para volver al menu...");
                        Console.ReadKey();
                        break;

                    case "3":
                        if (tareas.Count > 0)
                        {
                            Console.WriteLine("Selecciona una tarea por su numero para marcar como completada o no");
                            int idTarea;
                            MostrarTareas(tareas);
                            string idEntrada = Console.ReadLine();

                            if (int.TryParse(idEntrada, out idTarea))
                            {
                                Tarea tEdit = tareas.Find(x => x.Id == idTarea);

                                if (tEdit == null) 
                                    Console.WriteLine("No se encontro el ID");
                                else
                                {
                                    tEdit.MarcarCompletada();
                                    Console.WriteLine("Cambio exitoso");
                                }
                            }
                             else 
                                 Console.WriteLine("Entrada invalida. Intente nuevamente");
                        }
                        else
                        {
                            Console.WriteLine("No hay tareas registradas");
                        }

                        Console.WriteLine("Presione una tecla para volver al menu...");
                        Console.ReadKey();
                        break;

                    case "4":
                        if (tareas.Count > 0)
                        {
                            Console.WriteLine("Selecciona una tarea por su numero para eliminarla de tu lista");
                            int idTarea;
                            MostrarTareas(tareas);
                            string idEntrada = Console.ReadLine();

                            if (int.TryParse(idEntrada, out idTarea))
                            {
                                Tarea tEdit = tareas.Find(x => x.Id == idTarea);

                                if (tEdit == null) 
                                    Console.WriteLine("No se encontro el ID");
                                else
                                {
                                    tareas.Remove(tEdit);
                                    Console.WriteLine("Se borro exitosamente");
                                    foreach(var t in tareas)
                                    {
                                        t.Id = tareas.IndexOf(t) + 1;
                                    }
                                }
                            }
                             else 
                                 Console.WriteLine("Entrada invalida. Intente nuevamente");
                        }
                        else
                            Console.WriteLine("No hay tareas registradas");
                        Console.WriteLine("Presione una tecla para volver al menu...");
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Ingrese una opcion valida: Presione una tecla para volver al menu.");
                        Console.ReadKey();
                        break;


                }
            }
        }
        static void MostrarTareas(List<Tarea> tareas)
        {
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay ninguna tarea registrada.");
            }
            else
            {
                Console.WriteLine("Tareas: ");

                foreach (Tarea t in tareas) {
                
                    Console.WriteLine(t.Id + " - " + t.Descripcion + (t.Completada ? " - Completado" : " - No Completado"));
                }
            }
        }
    }
}
