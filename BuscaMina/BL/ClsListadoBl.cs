using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ClsListadoBl
    {
        /// <summary>
        /// Genera el listado de casillas segun la dificultad lo que añadira más bombas y casillas
        /// </summary>
        /// <param name="dificultad">Entero que representa el nivel de dificultad</param>
        /// <returns>Devuelve un listado de casillas</returns>
        public static List<ClsCasilla> listadoCasillasBl(int dificultad)
        {
            List<ClsCasilla> lista = new List<ClsCasilla>();
            switch (dificultad)
            {
                // Listado con 16 casillas con 5 bombas
                case 1:
                    lista = ClsListadoBl.addCasillas(9, 4);
                    break;
            }
            return lista;
        }

        public static int numTiradasBl(int dificultad)
        {
            int tiradas = 0;
            switch (dificultad)
            {
                case 1:
                    tiradas = 5+1;
                    break;
            }
            return tiradas;
        }

        public static int maxBombasBl(int dificultad)
        {
            int bombas = 0;
            switch (dificultad)
            {
                case 1:
                    bombas = 4;
                    break;
            }
            return bombas;
        }

        /// <summary>
        /// Añade bombas y casillas al listado de casillas para la dificultad selecionada
        /// </summary>
        /// <param name="num">Número de casillas</param>
        /// <param name="bombas"> Número de bombas</param>
        /// <returns>Lista de casillas con bombas</returns>
        private static List<ClsCasilla> addCasillas(int num, int bombas)
        {
            int posicion = 0;
            
            Random rnd = new Random();
            List<ClsCasilla> casillas = new List<ClsCasilla>();
            for (int i = 0; i < num ; i++) {
                ClsCasilla casilla = new ClsCasilla();
                casillas.Add(casilla);
            }
            for(int i = 0; i < bombas; i++) {
                do
                {
                    posicion = rnd.Next(0, num - 1);
                }while (casillas[posicion].EsBomba);
                
                casillas[posicion].EsBomba = true;
                
            }

            return casillas;
        }
    }
}
