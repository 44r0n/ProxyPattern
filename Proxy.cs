namespace ProxyPattern
{
    public class Proxy : Subject
    {
        private RealSubject realSubject = null;

        public void Request()
        {
            System.Console.WriteLine("Executing Proxy Request");
            if(realSubject == null)
            {
                realSubject = new RealSubject();
            }
            realSubject.Request();
        }
    }
}