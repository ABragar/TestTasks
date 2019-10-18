namespace Task3.DAL.Entities
{
    public interface IItem
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get;set;}
    }
}