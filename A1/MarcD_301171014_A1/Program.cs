using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcD_301171014_A1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Sprite objects
            Sprite s1 = new Sprite("S1", 1);
            Sprite s2 = new Sprite("S2", 1, 1, 1);
            Sprite s3 = new Sprite("S3", 2, 3, 2);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            s1.Move(Direction.Right);
            s1.Move(Direction.Right);
            s1.Move(Direction.Up);
            s1.Move(Direction.Left);
            s1.Move(Direction.Up);
            s1.Move(Direction.Left);
            s1.Move(Direction.Up);
            s1.Move(Direction.Right);
            s1.Move(Direction.Up);
            s1.Move(Direction.Right);
            s1.Move(Direction.Right);

            s2.Move(Direction.Left);

            s1.Move(Direction.Down);
            s1.Move(Direction.Down);

        }
    }
}
