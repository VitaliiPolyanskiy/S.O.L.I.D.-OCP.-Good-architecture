namespace Open_closed_principle
{
    class Program
    {
        static void Client(ILog log, ISerializer serializer)
        {
            Сontainer c = new Сontainer();
            c.Add(new Human("Larry Page", 50));
            c.Add(new Human("Satya Nadella", 56));
            c.Add(new Human("Tim Cook", 62));
            PrintManager manager = new PrintManager();
            List<Human>? list = c.Get();
            manager.SetLog(log);
            manager.Print(list);
            HumanRepository repository = new HumanRepository();
            repository.SetSerializer(serializer);
            repository.Save(list);
            c.RemoveAll();
            list = c.Get();
            manager.Print(list);
            list = repository.Load();
            manager.Print(list);
        }
        static void Main(string[] args)
        {
            ILog log = new ConsoleLog();           
            ISerializer serializer = new XMLFormatter();
            Client(log, serializer);
            log = new FileLog();
            serializer = new JSONSerializer();
            Client(log, serializer);
        }
    }
}
