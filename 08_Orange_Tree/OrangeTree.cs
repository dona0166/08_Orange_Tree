using System;

namespace _08_Orange_Tree
{
    public class OrangeTree 
    {
        private int a1;
        private int h1;

        public OrangeTree(int a1, int h1)
        {
            this.a1 = a1;
            this.h1 = h1;
        }

        private int age;
        public int Age {
            get { return this.age; }
            set { this.age = value; }
        }

        private int height;
        public int Height {
            get { return this.height; }
            set { this.height = value;  }
        }

        public bool TreeAlive
        {
            get { return this.die; }
            set { this.die = value; }
        }
        public int NumOranges
        {
            get { return this.num; }
            set { this.num = value;  }
        }
        private int orangeseaten;
        public int OrangesEaten {
            get { return this.orangeseaten; }
            set { this.orangeseaten = value; }
        }

        int count = 1;
        private bool die;
        private int num;
        public void OneYearPasses()
        {

            this.age = this.a1 + 1;
            this.height = this.h1 + 2;
            count++;
            if(count < 80)
            {
                this.die = true;
            }
            else
            {
                this.die = false;
            }
            if(count == 2)
            {
                this.num = 0;
            }
            if(count > 2)
            {
                this.num = 5;

            }
            if(count > 3)
            {
                this.num = this.num + 5;
                
            }
            

        }

        public void EatOrange(int e)
        {   
            if(e <= 1)
            {
                this.orangeseaten = e;
            }
            else
            {
                this.orangeseaten = e + 1;
            }
            if(count == 1)
            {
                throw new IndexOutOfRangeException("You can't eat an orange that isn't there!There are 0 oranges available to eat");

            }
        }

      
    }
}