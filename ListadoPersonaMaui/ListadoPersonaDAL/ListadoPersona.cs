using ListadoPersonaENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadoPersonaDAL
{
    public class ListadoPersona
    {
        	
   	/// <summary>
    	/// Función que nos devuelve un listado de todas las personas de nuestra BBDD
    	/// </summary>
        /// 
    	/// <returns>Listado de personas</returns>
    	public static List<Persona> GetListadoCompleto()
        {

            List<Persona> listado = new List<Persona>();

            Persona p1 = new Persona();
            p1.Nombre = "Lorenzo";
            p1.Apellidos = "Bellido Barrena";
            p1.Edad = 19;

            Persona p2 = new Persona();
            p2.Nombre = "Marco";
            p2.Apellidos = "Holguín Cascajo";
            p2.Edad = 19;

            Persona p3 = new Persona();
            p3.Nombre = "Raul";
            p3.Apellidos = "Romera Pavon";
            p3.Edad = 19;

            Persona p4 = new Persona();
            p4.Nombre = "Hector";
            p4.Apellidos = "Arias Martin";
            p4.Edad = 19;

            Persona p5 = new Persona();
            p5.Nombre = "Pablo";
            p5.Apellidos = "Carbonero Almellones";
            p5.Edad = 19;

            Persona p6 = new Persona();
            p6.Nombre = "Eduardo";
            p6.Apellidos = "Arneso Roman";
            p6.Edad = 19;

            Persona p7 = new Persona();
            p7.Nombre = "Pepelu";
            p7.Apellidos = "Mejorada Calvo";
            p7.Edad = 19;

            Persona p8 = new Persona();
            p8.Nombre = "Amaro";
            p8.Apellidos = "Suarez Villegas";
            p8.Edad = 19;

            Persona p9 = new Persona();
            p9.Nombre = "Ruben";
            p9.Apellidos = "Ruiz Auri";
            p9.Edad = 19;

            Persona p10 = new Persona();
            p10.Nombre = "Antonio";
            p10.Apellidos = "Vizarraga Vizarraga";
            p10.Edad = 19;

            listado.Add(p1);
            listado.Add(p2);
            listado.Add(p3);
            listado.Add(p4);
            listado.Add(p5);
            listado.Add(p6);
            listado.Add(p7);
            listado.Add(p8);
            listado.Add(p9);
            listado.Add(p10);

            return listado;
        }
    }

}

