// Para testear tu código en nuestros servidores debes mantener la estructura expuesta abajo.
// Eres libre de crear nuevas funciones/procedimientos.
// Recuerda que el código que escribas podrá ser visto por las empresas a las que te postules.
// Para validar los 'vecinos', ten presente las posiciones arriba, abajo, izquierda y derecha.
// Las posiciones diagonales NO deben ser tenidas en cuenta.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Functions
{
    // int[,] relieve = {
    //{9, 2, 2, 2, 3, 5}, 
    //{9, 8, 3, 2, 4, 5}, 
    //{9, 7, 2, 2, 4, 3}, 
    //{9, 9, 2, 4, 4, 3}, 
    //{9, 2, 3, 4, 3, 5}};
    // int[,] resultado = new int[5,6];
    public void encontrar_bordes(int[,] relieve, ref int[,] result)
    {
        // int[5,6] matriz ={ 
        //{ 0, 1, 1, 1, 0, 0}, 
        //{ 0, 0, 0, 1, 0, 0}, 
        //{ 0, 0, 1, 1, 0, 1}, 
        //{ 0, 0, 1, 0, 0, 1}, 
        //{ 0, 1, 0, 0, 1, 0 } };

        var matrix = (int[,])result.Clone();
        int matrixHeight = relieve.GetLength(0);
        int matrixLength = relieve.GetLength(1);

        for (int i = 0; i < matrixHeight; i++)
        {
            for (int j = 0; j < matrixLength; j++)
            {
                int center = relieve[i, j];
                bool localMin = true;

                if (j > 0)
                {
                    int left = relieve[i, j - 1];
                    if (center > left)
                    {
                        localMin = false;
                    }
                }
                if (j < matrixLength - 1 && localMin)
                {
                    int right = relieve[i, j + 1];
                    if (center > right)
                    {
                        localMin = false;
                    }
                }
                if (i > 0 && localMin)
                {
                    int up = relieve[i - 1, j];
                    if (center > up)
                    {
                        localMin = false;
                    }
                }
                if (i < matrixHeight - 1 && localMin)
                {
                    int down = relieve[i + 1, j];
                    if (center > down)
                    {
                        localMin = false;
                    }
                }

                matrix[i, j] = localMin ? 1 : 0;
            }
        }

        result = matrix;
    }
}

//La función main será ejecutada en nuestros servidores llamando a la expuesta arriba.