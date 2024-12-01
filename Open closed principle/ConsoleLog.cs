
namespace Open_closed_principle
{
    public class ConsoleLog : ILog
    {
        public void Write(string str)
        {
            Console.WriteLine(str);
        }
    }
}
