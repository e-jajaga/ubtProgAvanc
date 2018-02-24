using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsole
{
    public interface ITransactions
    {
        // interface members
        void showTransaction();
        double getAmount();
    }

    public class TransactionDEN : ITransactions
    {
        private string tCode;
        private string date;
        private double amount;

        public TransactionDEN(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }

        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0} DEN", getAmount());
        }

        public double getAmount()
        {
            return amount;
        }
    }

    public class TransactionEU : ITransactions
    {
        private string tCode;
        private string date;
        private double amount;

        public TransactionEU()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }

        public TransactionEU(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }

        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0} EU", getAmount());
        }

        public double getAmount()
        {
            return amount;
        }
    }
    class Tester
    {
        
        static void Main(string[] args)
        {
            TransactionEU trans1 = new TransactionEU();
            TransactionEU trans2 = new TransactionEU("t001", "19/10/2018", 30);

            TransactionDEN trans3 = new TransactionDEN("den002", "12/12/2012", 500);

            trans1.showTransaction();

            trans2.showTransaction();

            trans3.showTransaction();

            Console.ReadKey();
        }
    }
}
