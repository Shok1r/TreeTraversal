using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal
{

    public class CNode
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        public CNode Left { get; set; } = null;
        public CNode Right { get; set; } = null;

        public char Data { get; set; }
        public int Interval_X { get; set; }

        public bool Selected { get; set; }

        public CNode(char data, int interval_x)
        {
    
            Left = Right = null;
            Data = data;
            X = 0;
            Y = 0;
            Interval_X = interval_x;
            Selected = false;
        }

        public void AddChildren(char Ldata, char Rdata, int root_x, int root_y, int interval_x)
        {
            Left = new CNode(Ldata, interval_x / 2);
            Left.X = root_x - interval_x / 2;
            Left.Y = root_y + 100;

            Right = new CNode(Rdata, interval_x / 2);
            Right.X = root_x + interval_x / 2;
            Right.Y = root_y + 100;
        }

    }
    
    public class CTree
    {
        public CNode Root { get; set; }
        public string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ01234567890";
        public Random rnd = new Random();

        public CTree(bool generateFull, int levels, int width)
        {

            Root = new CNode(characters[rnd.Next(0, characters.Length)], 480);
            Root.X = width;
            Root.Y = 50;
            if (generateFull) Generate(Root, levels, Root.Interval_X);
            else RandomGenerate(Root, levels, Root.Interval_X);
        }

        public void Generate(CNode r, int levels, int interval_x)
        {
            if (r == Root)
            {
                if (r.Left != null) { r.Left = null; }
                if (r.Right != null) { r.Left = null; }
            }
            if (levels > 1)
            {
                r.Data = characters[rnd.Next(0, characters.Length)];

                char ldata = characters[rnd.Next(0, characters.Length)];
                char rdata = characters[rnd.Next(0, characters.Length)];

                r.AddChildren(ldata, rdata, r.X, r.Y, r.Interval_X);

                Generate(r.Left, levels - 1, r.Interval_X);
                Generate(r.Right, levels - 1, r.Interval_X);
            }
        }

        public void RandomGenerate(CNode r, int levels, int interval_x)
        {
            if (r == Root)
            {
                if (r.Left != null) { r.Left = null; }
                if (r.Right != null) { r.Right = null; }
            }
            if (levels > 1 && levels < 5)
            {

                int choose = (rnd.Next(0, 50)) % 4;

                switch (choose)
                {
                    case 0:
                        {

                            break;
                        }
                    case 1:
                        {
                            char ldata = characters[rnd.Next(0, characters.Length)];
                            char rdata = characters[rnd.Next(0, characters.Length)];
                            r.AddChildren(ldata, rdata, r.X, r.Y, r.Interval_X);
                            RandomGenerate(r.Left, levels - 1, r.Interval_X);
                            RandomGenerate(r.Right, levels - 1, r.Interval_X);
                            break;
                        }
                    case 2:
                        {
                            char ldata = characters[rnd.Next(0, characters.Length)];
                            char rdata = characters[rnd.Next(0, characters.Length)];
                            r.AddChildren(ldata, rdata, r.X, r.Y, r.Interval_X);
                            RandomGenerate(r.Left, levels - 1, r.Interval_X);
                            break;
                        }
                    case 3:
                        {
                            char ldata = characters[rnd.Next(0, characters.Length)];
                            char rdata = characters[rnd.Next(0, characters.Length)];
                            r.AddChildren(ldata, rdata, r.X, r.Y, r.Interval_X);
                            RandomGenerate(r.Right, levels - 1, r.Interval_X);
                            break;
                        }
                }
            }
            if (levels == 5)
            {
                char ldata = characters[rnd.Next(0, characters.Length)];
                char rdata = characters[rnd.Next(0, characters.Length)];
                r.AddChildren(ldata, rdata, r.X, r.Y, r.Interval_X);
                RandomGenerate(r.Left, levels - 1, r.Interval_X);
                RandomGenerate(r.Right, levels - 1, r.Interval_X);
            }
        }
    }
}
