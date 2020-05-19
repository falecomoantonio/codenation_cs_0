using System;
using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Math
    {
        public List<int> Fibonacci()
        {
            List<int> listNumbers = new List<int>();
            int numberMin = 1, numberMax = 0, aux = 0;

            listNumbers.Add(aux);
            listNumbers.Add(aux + 1);
            while (aux <= 350)
            {
                aux = numberMin + numberMax;
                numberMax = numberMin;
                numberMin = aux;

                if (aux <= 350)
                {
                    listNumbers.Add(aux);
                }
            }


            return listNumbers;
        }

        public bool IsFibonacci(int numberToTest)
        {
            List<int> list = Fibonacci();

            foreach(int i in list)
            {
                if (i == numberToTest)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
