using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace pms_api.data;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Color { get; set; } = null!;
    public string Type { get; set; } = null!;
    [Column(TypeName = "decimal(16,2)")] public decimal Price { get; set; }
}