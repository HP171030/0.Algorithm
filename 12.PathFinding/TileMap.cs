using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.PathFinding
{
    internal class Tilemap
    {
        /****************************************************************
         * 타일맵 (Tilemap)
         * 
         * 2차원 평면의 그래프를 정점이 아닌 위치를 통해 표현하는 그래프
         * 위치의 이동가능 유무만을 표현하는 bool 이차원 타일맵
         * 타일의 종류를 표현한 이차원 타일맵이 있음
         * 인접한 이동가능한 위치간 간선이 있으며 가중치는 동일함
         ****************************************************************/

        // <타일맵 그래프>
        // 예시 - 위치의 이동가능 표현한 이차원 타일맵
        bool[,] tileMap1 = new bool[7, 7]
        {                                                                   //getLength(0),GetLength(1),GetLength(1),GetLength(1)      //첫번째칸이 가로로 표현되어 있으니까 x축
            { false, false, false, false, false, false, false },            //getLength(0)
            { false,  true, false,  true, false, false, false },            //getLength(0)
            { false,  true, false,  true, false,  true, false },            //getLength(0)
            { false,  true, false,  true,  true,  true, false },            //getLength(0)
            { false,  true, false,  true, false, false, false },            //getLength(0)
            { false,  true,  true,  true,  true,  true, false },            //getLength(0)
            { false, false, false, false, false, false, false },            //getLength(0)
        };                                                                  //getLength(0)
                                                                            //첫번째 줄이 세로로 표현되어있으니까 y축

        // 예시 - 타일의 종류를 표현한 이차원 타일맵
        enum TileType
        {
            None = ' ',
            Wall = '#',
            Door = '*',
            Shop = 'S',
            Gate = 'G',
        }

        char[,] tileMap2 = new char[9, 9]
        {
            { '#', '#', '#', '#', '#', '#', '#', '#', '#' },
            { '#', ' ', '#', '#', ' ', ' ', '#', '#', '#' },
            { '#', ' ', '#', '#', ' ', '#', '#', ' ', '#' },
            { '#', ' ', '#', '#', '*', '#', '#', '*', '#' },
            { '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#' },
            { '#', ' ', '#', ' ', '#', '#', '#', ' ', '#' },
            { '#', ' ', '#', ' ', '#', '#', '#', ' ', '#' },
            { '#', ' ', ' ', 'S', ' ', ' ', ' ', 'G', '#' },
            { '#', '#', '#', '#', '#', '#', '#', '#', '#' },
        };
    }
}
