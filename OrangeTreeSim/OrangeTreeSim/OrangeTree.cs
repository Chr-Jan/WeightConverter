using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {

        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        /*
                public void SetAge(int age)
                {
                    this.age = age;
                }
                public int GetAge()
                {
                    return age;
                }
                public void SetHeight(int height)
                {
                    this.height = height;
                }
                public int GetHeight()
                {
                    return height;
                }
                public void SetTreeAlive(bool treeAlive)
                {
                    this.treeAlive = treeAlive;
                }
                public bool GetTreeAlive()
                {
                    return treeAlive;
                }
                public int GetNumOranges()
                {
                    return numberOfOranges;
                }
                public int GetOrangesEaten()
                {
                    return orangesEaten;
                }
                public void OneYearPasses()
                {
                    age++; //add one to age
                    orangesEaten = 0;

                    int addHeight = 2; //the increase of heigh for one year

                    if (age < 80)
                    {
                        height = addHeight + height; //add height at current year + 2
                    }
                    else
                    {
                        treeAlive = false; //if equal or above 80, then tree is dead.
                        numberOfOranges = 0;
                    }

                    if (age > 1 && age < 80) //first year age don't produce oranges, equal or above 80 tree is dead
                    {
                        numberOfOranges = (age - 1) * 5;
                    }

                }
                public void EatOrange(int count)
                {
                    if (count <= numberOfOranges)
                    {
                        orangesEaten = orangesEaten + count;
                        numberOfOranges = numberOfOranges - count;
                    }
                }
                */
        //exercise for 23-09

        public int Age
        {
            get { return age; }
            set { 
                //age = value;
                if (value < 80 && value > 0)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }
            }
        }
        public int Height
        { 
            get { return height; }
            set { height = value; }
        }
        public bool TreeAlive
        {
            get { return treeAlive; }
            set { treeAlive = value; }
        }
        public int NumOranges
        {
            get { return numOranges; }
        }
        public int OrangesEaten
        {
            get { return orangesEaten; }
        }
        public void OneYearPasses()
        {
            age++; //add one to age
            orangesEaten = 0;

            int addHeight = 2; //the increase of heigh for one year

            if (age < 80)
            {
                height = addHeight + height; //add height at current year + 2
            }
            else
            {
                treeAlive = false; //if equal or above 80, then tree is dead.
                numOranges = 0;
            }

            if (age > 1 && age < 80) //first year age don't produce oranges, equal or above 80 tree is dead
            {
                numOranges = (age - 1) * 5;
            }

        }
        public void EatOrange(int count)
        {
            if (count <= numOranges)
            {
                orangesEaten = orangesEaten + count;
                //smartere alternative nedenunder
                //numOranges = numOranges - count;

                numOranges -= count;

            }
        }
    }
}
