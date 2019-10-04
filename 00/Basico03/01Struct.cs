using System;
using System.Collections.Generic;

namespace Basico03
{
    /// <summary>
    /// Referencia Microsoft: https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/struct
    /// Referencia 2? https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/using-structs
    /// </summary>


    //Os structs também podem conter construtores, 
    //constantes, campos, métodos, propriedades, indexadores, 
    //operadores, eventos e tipos aninhados, embora, 
    //se vários desses membros forem necessários, 
    //você deva considerar tonar seu tipo uma classe.
    public struct Coords
    {
        public int x, y;

        public Coords(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

    //este eh so um exemplo
    public class ProgramaLocalizacao
    {
        public List<Coords> Coordenadas { get; private set; }

        public ProgramaLocalizacao()
        {
            Coordenadas = new List<Coords>();
        }

        public void AdicionarPonto(int ptX, int ptY)
        {
            var point = new Coords();
            point.x = ptX;
            point.y = ptY;

            Coordenadas.Add(point);

            var point2 = new Coords(ptX, ptY);
            Coordenadas.Add(point2);

            Coords coord;
            coord.x = ptX;
            coord.y = ptY;

            Coordenadas.Add(coord);
        }
    }
}
