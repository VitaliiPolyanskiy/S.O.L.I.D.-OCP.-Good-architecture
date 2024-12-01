namespace Open_closed_principle
{
    public interface ISerializer
    {
        void Save(List<Human> collection);
        List<Human> Load();
    }
}
