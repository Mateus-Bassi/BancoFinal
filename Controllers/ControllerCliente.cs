using BancoAPI.Data;
using BancoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[Route("api/[controller]")]
[ApiController]
public class ControllerCliente : ControllerBase
{
    private readonly BancoDbContext _context;

    public ControllerCliente(BancoDbContext context)
    {
        _context = context;
    }

[HttpGet()]
    [Route("buscar/{CPF}")]
    public async Task<ActionResult<Cliente>> Buscar([FromRoute] string CPF)
    {
        if(_context.Cliente is null)
            return NotFound();
        var cliente = await _context.Cliente.FindAsync(CPF);
        if (cliente is null)
            return NotFound();
        return cliente;
    }

    [HttpPost]
    [Route("Cadastrar/ Cliente")]
    public IActionResult Cadastrar(Cliente cliente, string CPF )
    {
        var Cliente_verifi = _context.Cliente.Find(CPF);

        if (Cliente_verifi == null)
        {
            _context.Add(cliente);
            _context.SaveChanges();
            return Created("", cliente);
            // Se a conta não existe, retorna NotFound
            
        }
        return BadRequest("Cliente já existe");     
    }   
}