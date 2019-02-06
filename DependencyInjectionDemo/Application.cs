using DemoLibrary;

namespace DependencyInjectionDemo
{
    public class Application : IApplication
    {
        private IBusinessLogic _businessLogic;

        public Application(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        public void Run()
        {
            _businessLogic.ProcessData();
        }
    }
}
