using ByteTech.Core.Interfaces;
using ByteTech.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace ByteTech.API.Controllers;

[ApiController]
[Route("api/[controller]")] // This makes the URL: api/discounts
public class DiscountsController : ControllerBase
{
    private readonly IDiscountService _discountService;

    // Constructor: Inject the service you built in BAL
    public DiscountsController(IDiscountService discountService)
    {
        _discountService = discountService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var discounts = await _discountService.GetAllDiscountsAsync();
        return Ok(discounts);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var discount = await _discountService.GetDiscountByIdAsync(id);
        if (discount == null) return NotFound();
        return Ok(discount);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Discount discount)
    {
        if (discount == null) return BadRequest("Ivalid data.");

        var result = await _discountService.CreateDiscountAsync(discount);
        if (result) return CreatedAtAction(nameof(GetById), new { id = discount.Id }, discount);

        return BadRequest("Unable to create discount. Check if the code already exists.");
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] Discount discount)
    {
        if (id != discount.Id) return BadRequest("ID mismatch");

        var result = await _discountService.UpdateDiscountAsync(discount);
        if (result) return NoContent();

        return NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _discountService.DeleteDiscountAsync(id);
        if (result) return Ok();

        return NotFound();
    }
}