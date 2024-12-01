namespace Open_closed_principle
{
    class HumanRepository
    {
        ISerializer? serialize;
        public void SetSerializer(ISerializer serialize)
        {
            this.serialize = serialize;
        }  
        public void Save(List<Human> list)
        {
            serialize?.Save(list);
        }
        public List<Human>? Load()
        {
            List<Human>? list = serialize?.Load();
            return list;
        }
    }
}
