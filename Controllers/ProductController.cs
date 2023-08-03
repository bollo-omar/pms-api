using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pms_api.data;

namespace pms_api.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : Controller
{
    private readonly PMSContext _context;

    public ProductController(PMSContext context)
    {
        this._context = context;
    }

    // GET
    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var products = await _context.Products.ToListAsync();

        return Ok(products);
    }

    [HttpPost]
    public async Task<IActionResult> AddProduct([FromBody] Product product)
    {
        product.Id = Guid.NewGuid();
        await _context.AddAsync(product);
        await _context.SaveChangesAsync();

        return Ok(product);
    }


    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetProduct(Guid id)
    {
        var product = await _context.Products.FirstOrDefaultAsync(product => product.Id == id);

        if (product == null) return NotFound();
        return Ok(product);
    }

    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateProduct([FromRoute] Guid id, Product productPayload)
    {
        var product = await _context.Products.FindAsync(id);

        if (product == null) return NotFound();

        product.Name = productPayload.Name;
        product.Type = productPayload.Type;
        product.Color = productPayload.Color;
        product.Price = productPayload.Price;

        await _context.SaveChangesAsync();
        return Ok(product);
    }


    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> DeleteProduct(Guid id)
    {
        var product = await _context.Products.FirstAsync(product => product.Id == id);
        if (product==null)
        {
          return  NotFound();
        }
          
        _context.Products.Remove(product);
        await _context.SaveChangesAsync();

        return Ok(product);
    }
}