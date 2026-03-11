namespace QuestionMarksChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Type1 Questions Marks :");
            int X=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Type2 Questions Marks :");
            int Y=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of type 1 Questions :");
            int N1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of type 2 Questions :");
            int N2=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks scored by the student :");
            int M=int.Parse(Console.ReadLine());
            CheckValid(X, Y, N1, N2, M);
        }
        static void CheckValid(int X,int Y,int N1,int N2,int M)
        {
            bool isValid = false;
            int NumX = -1;
            int NumY = -1;
            for(int a = N1; a >= 0; a--)
            {
                int Pending = (M - X * a);
                if (Pending < 0) { continue; }
                if (Pending % Y == 0)
                {
                    int b = Pending / Y;
                    if (b > 0)
                    {
                        isValid = true;
                        NumX = a;
                        NumY = b;
                        break;
                    }
                }
                
            }
            if (isValid)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(NumX);
                Console.WriteLine(NumY);
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
        }
    }
}
