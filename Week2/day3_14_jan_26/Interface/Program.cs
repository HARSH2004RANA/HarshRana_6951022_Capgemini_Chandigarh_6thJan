namespace InterfaceBasics
{
    interface I1
    {
        void test();
    }
    interface I2
    {
        void test();
    }
    internal class Program:I1,I2
    {
        void I1.test() {
            Console.WriteLine("This is overriden method of interface 1");
        }
        void I2.test()
        {
            Console.WriteLine("This is overriden method interface2");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            I1 obj1 = new Program();
            I2 obj2 = new Program();
            I1 obj3=(I1) program;                              
            obj1.test();
            obj2.test();
            obj3.test();
        }
    }
}
