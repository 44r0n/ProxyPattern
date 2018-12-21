namespace ProxyPattern
{
    public class RealSubject : Subject
    {
        public RealSubject()
        {
            System.Console.WriteLine("Instantiating RealSubject");
        }
        public void Request()
        {
            System.Console.WriteLine("Executing RealSubject Request");
        }
    }
}