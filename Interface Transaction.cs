using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApplication
{
    public interface ITranscations
    {
        //interface members
        void showTransaction();
        double getAmount();
    }
    public class Transaction : ITranscations
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }
        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }
        public double getAmount ()
        {
            return amount;
        }
        public void showTransaction()
        {
            Console.WriteLine("Transaction : {0}", tCode);
            Console.WriteLine("Date : {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }
        class Tester
        {
            static void Main(string[] args)
            {
                Transaction t1 = new Transaction("001", "8/10/2018", 7894.00);
                Transaction t2 = new Transaction("002", "10/10/2018", 5048.00);

                t1.showTransaction();
                t2.showTransaction();
                Console.ReadKey();
            }
        }
    }
}
