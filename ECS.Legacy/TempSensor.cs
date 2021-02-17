using System;

namespace ECS.Legacy
{
    internal class TempSensor
    {
        private Random gen = new Random();

        public int GetTemp()
        {
            return gen.Next(-5, 45);
        }
<<<<<<< HEAD
        //hej med dig
=======
        //hello world
>>>>>>> 743dff3f41be27b3f50cfa1b3027f9cc14540918
        public bool RunSelfTest()
            //hej med jer alle
            //hbaas
        {
            return true;
        }
    }
}