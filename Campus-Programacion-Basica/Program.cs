using System;
using System.Globalization;
using System.IO;

namespace Campus_Programacion_Basica
{
    internal class Program
    {

        static String direccionArchivoEntrada = "";
        static String direccionArchivoSalida = "";
        static String nombreArchivoEntrada = "countries.txt";
        static String nombreArchivoSalida = "";

        static IFormatProvider culture = new CultureInfo("en-US", true);
        static void Main(string[] args)
        {
            // esta variable obtiene el directorio del ejecutable:
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;

            try
            {
                MyException error = new MyException();
                error.Fail();
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            // despues se guarda el directorio en esta variable:
            var directory = System.IO.Path.GetDirectoryName(path);

            //Console.WriteLine(directory+"\n");

            // se agrega el nombre del archivo de entrada al directorio:
            direccionArchivoEntrada = System.IO.Path.Combine(directory, nombreArchivoEntrada);

            // Verify the path that you have constructed.
            //Console.WriteLine("Path to my file: {0}\n", direccionArchivoEntrada);


            //Console.WriteLine("Hello World!\n");

            // Esta variable obtiene la fecha actual en formato [yyyy-MM-dd]
            String DateString = DateTime.Today.ToString("yyyy-MM-dd");

            // Esta variable inicializa un array de strings provenientes del substring que genera split:
            string[] subStringDate = DateString.Split('-');

            //Console.WriteLine(subStringDate[1]);

            // Switch - case para obtener el nombre de los meses
            switch (subStringDate[1])
            {
                case "01":
                    subStringDate[1] = "Jan";
                    break;
                case "02":
                    subStringDate[1] = "Feb";
                    break;
                case "03":
                    subStringDate[1] = "Mar";
                    break;
                case "04":
                    subStringDate[1] = "Apri";
                    break;
                case "05":
                    subStringDate[1] = "May";
                    break; 
                case "06":
                    subStringDate[1] = "Jun";
                    break;
                case "07":
                    subStringDate[1] = "Jul";
                    break;
                case "08":
                    subStringDate[1] = "Aug";
                    break;
                case "09":
                    subStringDate[1] = "Sep"; 
                    break;
                case "10":
                    subStringDate[1] = "Oct";
                    break;
                case "11":
                    subStringDate[1] = "Nov";
                    break;
                case "12":
                    subStringDate[1] = "Dec";
                    break;
            }
            // se inicializa un string vacio para la nueva fecha:
            String newDateString = "";

            // se recorre el array de substrings almacenado en subStringData
            // despues se concatena el string newDateString con los elementos y al final un -
            // excepto en el caso del elemento del ultimo indice.
            for(int i = 0; i < subStringDate.Length; i++)
            {
                //Console.WriteLine(i);
                newDateString += subStringDate[i] + (i == subStringDate.Length-1 ? ("") : "-");
            }

            //Console.WriteLine(newDateString);
            // se define el nombre del archivo de salida, en caso hipotetico, seria Countries yyyy-MM-dd
            nombreArchivoSalida = "Countries " + newDateString + ".txt";

            // se agrega el nombre del archivo al directorio:
            direccionArchivoSalida = System.IO.Path.Combine(directory, nombreArchivoSalida);
            Console.WriteLine();
            //Console.WriteLine(direccionArchivoSalida);
            GreetCountries(direccionArchivoEntrada, direccionArchivoSalida);

            Console.WriteLine();

            // inicializando la clase rectangulo, la cual, es subclase de la clase abstracta forma:
            Rectangulo rectangulo = new Rectangulo("Jerry", 2, 10); // instancia un objeto con parametros del constructor
            Console.WriteLine(@"El area del Rectangulo {0} es: {1}", rectangulo.GetNombreRectangulo(), rectangulo.GetAreaRectangulo()); // imprime los datos del objeto

            // Mantiene la consola abierta en el modo debug:
            System.Console.WriteLine("Pulsa cualquier tecla para salir de la aplicacion.");
            System.Console.ReadKey();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="archivoEntrada"></param>
        /// <param name="archivoSalida"></param>
        static void GreetCountries(string archivoEntrada, string archivoSalida)
        {
            string contenidoArchivoSalida = "";
            try
            {
                
                using (StreamReader sr = new StreamReader(archivoEntrada))
                {
                    while (sr.Peek() >= 0)
                    {
                        //Console.WriteLine(sr.ReadLine());
                        contenidoArchivoSalida += "Saludos hasta " + sr.ReadLine() + "\n";
                    }
                }
                Console.Write(contenidoArchivoSalida);
                if (File.Exists(archivoSalida))
                {
                    File.Delete(archivoSalida);
                }
                using (StreamWriter sw = new StreamWriter(archivoSalida))
                {
                    sw.WriteLine(contenidoArchivoSalida);
                }
                Console.WriteLine();
                Console.WriteLine("El archivo fue generado exitosamente.");
                Console.WriteLine(@"El directorio de salida es: " + archivoSalida);
            }
        
            catch (FileNotFoundException)
            {
                Console.WriteLine("No se encontro el directorio del archivo de entrada.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
