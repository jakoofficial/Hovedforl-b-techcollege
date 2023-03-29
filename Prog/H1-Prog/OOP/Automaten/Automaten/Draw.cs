using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    public class Draw
    {
        public static void DrawBox(int startX = 0, int startY = 0, int width = 0, char widthChar = '#', int height = 0, char heightChar = '|')
        {
            DrawFloor(startX, startY, width+1, widthChar);
            DrawWall(startX, startY+1, height, heightChar);
            DrawWall(width+startX, startY+1, height, heightChar);
            DrawFloor(startX, height+(startY+1), width+1, widthChar);
        }

        public static void DrawFloor(int posX, int posY, int length, char widthChar)
        {
            for (int i = 0; i < length; i++)
            {
                Console.SetCursorPosition(posX+i, posY);
                Console.Write(widthChar);
            }
            Console.Write("\n");
        }
        public static void DrawWall(int posX, int posY, int heigth, char horiChar)
        {
            for (int i = 0; i < heigth; i++)
            {
                Console.SetCursorPosition(posX, posY + i);
                Console.Write(horiChar);
            }
            Console.Write("\n");
        }
    }
}
