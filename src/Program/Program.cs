using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greeter.Instance.SayHiToTheWorld();
            
            Greeter g1=Singleton<Greeter>.Instance;
            g1.SayHiToTheWorld();
            
            Singleton<Greeter>.Instance.SayHiToTheWorld();
        }
    }
}
