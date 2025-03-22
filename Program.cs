    using System;

    namespace practicaClases
    {
        public class Celulares 
        {
            public string marca;
            public string modelo;
            public int almacenamiento;
            public string ram;

            public void llamar()
                {
                    Console.WriteLine("se realiza la llamada");
                }
            public void fotografiar()
                {
                    Console.WriteLine("se saca una foto con su " + marca);
                }    

        }
         public class GrupoFamiliar
        {
            public string nombre;
            public string puestoFamiliar;
            public int edad;
            public string sexo;

            public void presentarse()
                {
                    Console.WriteLine("me llamos" + nombre + " y soy el " + puestoFamiliar + ",tengo " + edad + " años");
                }
            public void trabajar()
                {
                    Console.WriteLine("solo los padres trabajan");
                }    

        }
    } 