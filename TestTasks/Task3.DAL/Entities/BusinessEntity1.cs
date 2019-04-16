namespace Task3.DAL.Entities
{
    public class BusinessEntity1 : IBusinessEntity1
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"[Id = {Id}, Name={Name}]";
        }
    }
}