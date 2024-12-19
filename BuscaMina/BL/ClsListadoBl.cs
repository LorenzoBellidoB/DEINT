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
            int bombas = maxBombasBl(dificultad);
            switch (dificultad)
            {
                case 1:
                    lista = ClsListadoBl.addCasillas(9, bombas);
                    break;
                case 2:
                    lista = ClsListadoBl.addCasillas(16, bombas);
                    break;
                case 3:
                    lista = ClsListadoBl.addCasillas(25, bombas);
                    break;

            }
            return lista;
        }

        /// <summary>
        /// Devuelve el numero de tiradas segun la dificultad selecionada
        /// </summary>
        /// <param name="dificultad">Entero que representa el nivel de dificultad</param>
        /// <returns>Numero de tiradas</returns>
        public static int numTiradasBl(int dificultad)
        {
            int tiradas = 0;
            switch (dificultad)
            {
                case 1:
                    tiradas = 7;
                    break;
                case 2:
                    tiradas = 10;
                    break;
                case 3: tiradas = 15;
                    break;
            }
            return tiradas;
        }

        /// <summary>
        /// Devuelve el numero de bombas segun la dificultad selecionada 
        /// </summary>
        /// <param name="dificultad">Entero que representa el nivel de dificultad</param>
        /// <returns>Maximo de bombas</returns>
        public static int maxBombasBl(int dificultad)
        {
            int bombas = 0;
            switch (dificultad)
            {
                case 1:
                    bombas = 3;
                    break;
                case 2:
                    bombas = 6;
                    break;
                case 3:
                    bombas = 10;
                    break;
            }
            return bombas;
        }

        /// <summary>
        /// Devuelve el numero de aciertos segun la dificultad selecionada
        /// </summary>
        /// <param name="dificultad">Entero que representa el nivel de dificultad</param>
        /// <returns>Maximo de aciertos</returns>
        public static int maxAciertosBl(int dificultad)
        {
            int aciertos = 0;
            switch (dificultad)
            {
                case 1:
                    aciertos = 5;
                    break;
                case 2:
                    aciertos = 7;
                    break;
            }
            return aciertos;
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
