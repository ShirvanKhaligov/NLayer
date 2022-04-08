namespace NLayer.Core.Entities
{
    public class ProductFeature
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}
