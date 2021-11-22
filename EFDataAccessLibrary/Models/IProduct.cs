namespace EFDataAccessLibrary.Models
{
    public interface IProduct
    {
        string Category { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
    }
}