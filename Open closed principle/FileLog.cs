
namespace Open_closed_principle
{
    public class FileLog : ILog
    {
        public void Write(string str)
        {
            StreamWriter sw = new StreamWriter("User.log", true);
            sw.WriteLine(str);
            sw.Close();
        }
    }
}
