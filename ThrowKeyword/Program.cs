using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //int ourMoney = OurMoney(10, -10);
            EveryonesMoney();
        }

        public static int EveryonesMoney()
        {
            int everyonesMoney = 0;

            try
            {
                everyonesMoney = OurMoney(10, 10) + TheirMoney(10 ,-10);
            }
            catch(Exception ex)
            {
                //log in db etc
                throw new Exception("Some extra info", ex);
            }

            return everyonesMoney;
        }

        public static int TheirMoney(int hisMoney, int herMoney)
        {
            if (hisMoney < 0 || herMoney < 0) throw new ArithmeticException($"her money or his money is not valid");
            return hisMoney + herMoney;
        }

        public static int OurMoney(int myMoney, int yourMoney)
        {
            if (myMoney < 0 || yourMoney < 0) throw new ArithmeticException($"my money or your money is not valid");
            return myMoney + yourMoney;
        }
    }
}