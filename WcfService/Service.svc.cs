using System;

namespace WcfService
{
    public class Service : IService
    {
        public int Count(int nr1, int nr2)
        {
            throw new NotImplementedException();
        }

        public string GetHelloWorld()
        {
            return "Hello World";
        }

        public string GetName(string name)
        {
            return $"Hello {name}";
        }
    }
}
