using System;
using System.Collections.Generic;

namespace HeightOfTreeDataStructure
{
    public class Saka
    {
        private List<Saka> Sakos = new List<Saka>();
        private int data;

        public Saka(int data)
        {
            this.data = data;
        }

        public List<Saka> getSakos()
        {
            return Sakos;
        }

        public void addSaka(Saka saka)
        {
            this.Sakos.Add(saka);
        }

        public int getHeight(Saka saka)
        {
            if (saka == null) return 0;
            else
            {
                int maxHeight = 0;
                foreach (Saka item in saka.getSakos())
                {
                    maxHeight = Math.Max(maxHeight, getHeight(item));
                }
                return maxHeight + 1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Saka root = new Saka(1);
            Saka c1 = new Saka(101);
            Saka c2 = new Saka(102);
            root.addSaka(c1);
            root.addSaka(c2);
            Saka c3 = new Saka(201);
            Saka c4 = new Saka(202);
            c1.addSaka(c3);
            c1.addSaka(c4);
            Saka c5 = new Saka(203);
            Saka c6 = new Saka(206);
            c2.addSaka(c5);
            c2.addSaka(c6);
            Saka c7 = new Saka(301);
            Saka c8 = new Saka(302);
            c3.addSaka(c7);
            c3.addSaka(c8);
            Saka c9 = new Saka(401);
            Saka c10 = new Saka(402);
            c7.addSaka(c9);
            c7.addSaka(c10);

            Console.WriteLine("Max tree data structure height: " + root.getHeight(root));
            Console.Read();
        }
    }
}
