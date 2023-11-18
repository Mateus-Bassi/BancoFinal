using BancoAPI.Data;
using BancoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class CartaoCreditoController : ControllerBase
{
    private readonly BancoDbContext _context;

    public CartaoCreditoController(BancoDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("listar")]
    public async Task<ActionResult<IEnumerable<CartaoCredito>>> GetCartoes()
    {
        var cartoes = await _context.CartaoCredito.ToListAsync();
        
        if (cartoes == null || cartoes.Count == 0)
            return NotFound(); 

        return cartoes;
    }

    [HttpGet]
    [Route("buscar/{CartaoID}")]
    public async Task<ActionResult<CartaoCredito>> GetCartao(int cartaoID)
    {
        var cartao = await _context.CartaoCredito.FindAsync(cartaoID);

        if (cartao == null)
            return NotFound();

        return cartao;
    }

    [HttpPost]
    [Route("criar_cartao")]
    public async Task<ActionResult<CartaoCredito>> CriarCartao(CartaoCredito cartao)
    {
        if(_context is null) return NotFound();

        if(_context.CartaoCredito is null) return NotFound();

        if (cartao == null) return BadRequest("Dados inválidos para o cartão de crédito.");

        _context.CartaoCredito.Add(cartao);

        await _context.SaveChangesAsync();

        cartao.Id = _context.CartaoCredito.Count() + 1;
        
        _context.CartaoCredito.Add(cartao);

        await _context.SaveChangesAsync();

        return Created("",cartao);
        
    } 
    [HttpPost]
    [Route("AumentarLimite")]
    public async Task<ActionResult<CartaoCredito>> AumentarLimite(int cartaoID, decimal Limite)
    {
        var cartao = await _context.CartaoCredito.FindAsync(cartaoID);

        if (cartao == null)
            return NotFound("Cartão de crédito não encontrado.");
    
        cartao.Limite += Limite;
    
        _context.Entry(cartao).State = EntityState.Modified;
    
        await _context.SaveChangesAsync();

        return Ok("Limite aumentado com sucesso.");
    }
    [HttpPost]
    [Route("Bloqueado")]
   public async Task<ActionResult<CartaoCredito>> Bloqueado(int cartaoID, bool bloquear)
    {
        var cartao = await _context.CartaoCredito.FindAsync(cartaoID);

        if (cartao == null) return NotFound("Cartão de crédito não encontrado.");
        
        cartao.Bloqueado = bloquear;

        _context.Entry(cartao).State = EntityState.Modified;

        await _context.SaveChangesAsync();


        string status = bloquear ? "bloqueado" : "desbloqueado";

        return Ok($"O cartão foi {status} com sucesso.");
}
}
