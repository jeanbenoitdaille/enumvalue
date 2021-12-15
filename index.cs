    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
           
           [Flags]
            enum Names
            {
                Albert = 1,
                Alice = 2,
                Robert = 4,
                David = 8,
                Cynthia = 16
            }
     
            public void Main()
            {
                var names = Names.Albert | Names.Robert;
                Console.WriteLine(names);
            }
        }
    }