namespace Bank_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingAccount Scust1=new SavingAccount("7865657","Harsh");
            //ba.Account_No = "7865657";
            Scust1.Credit(5000);
            Scust1.Debit(6000);
            Console.WriteLine(Scust1.GetSummary());
        }
    }
}
