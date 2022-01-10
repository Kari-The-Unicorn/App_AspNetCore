using System.ServiceModel;

namespace WcfService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string GetHelloWorld();

        [OperationContract]
        string GetName(string name);

        [OperationContract]
        int Count(int nr1, int nr2);
    }
}
