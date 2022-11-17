using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditCard C1 = new platinumFact().Makecard();
            if( C1!=null)
            {
                Console.WriteLine("CardType:" + C1.GetCardType());
                Console.WriteLine("Annual Charge:" + C1.GetAnnualCharge());
                Console.WriteLine("CardLimit:" + C1.CardLimit());
            }
            else
            {
                Console.WriteLine("Invalid Card Type________");
            }
            ICreditCard C2 = new TatniumFact().Makecard();
            if(C2!=null)
            {
                if (C2 != null)
                {
                    Console.WriteLine("CardType:" + C2.GetCardType());
                    Console.WriteLine("Annual Charge:" + C2.GetAnnualCharge());
                    Console.WriteLine("CardLimit:" + C2.CardLimit());
                }
                else
                {
                    Console.WriteLine("Invalid Card Type________");
                }
            }

            Console.ReadKey();
        }
    }
   public interface ICreditCard
    {
        string GetCardType();
        int CardLimit();
        int GetAnnualCharge();

    }
    class Platinum : ICreditCard
    {
        public int CardLimit()
        {
            return 350000;
        }

        public int GetAnnualCharge()
        {
            return 20000;
        }

        public string GetCardType()
        {
            return "Platinum Plus";
        }
    }
    class Tatinum : ICreditCard
    {
        public int CardLimit()
        {
            return 200000;
        }

        public int GetAnnualCharge()
        {
            return 3000;
        }

        public string GetCardType()
        {
            return "Tatinum Plus";

        }

    }
    public abstract class Creation
    {
        protected abstract ICreditCard GetDetails();
        public ICreditCard Makecard()
        {
            return this.GetDetails();
        }
    }
    public class platinumFact : Creation
    {
        protected override ICreditCard GetDetails()
        {
            ICreditCard Cred = new Platinum();
            return Cred;
        }
    }
    public class TatniumFact : Creation
    {
        protected override ICreditCard GetDetails()
        {
            ICreditCard Cred = new Tatinum();
            return Cred;
        }
    }



}
