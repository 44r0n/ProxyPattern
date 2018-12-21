using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = CreateSubject();
            subject.Request();
        }

        static Subject CreateSubject() => new Proxy();
    }
}
