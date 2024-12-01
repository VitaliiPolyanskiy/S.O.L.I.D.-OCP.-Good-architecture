
namespace Open_closed_principle
{
    class PrintManager
    {
        ILog? log;
        public void SetLog(ILog log)
        {
            this.log = log;
        }
        public void Print(List<Human>? list)
        {
            if (list?.Count == 0)
            {
                log?.Write("Список пуст!");
                return;
            }
            foreach (Human j in list)
            {
                log?.Write(j.Name + "\t" + j.Age);
            }
        }        
    }
}
