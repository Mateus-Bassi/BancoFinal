using BancoAPI.Data;
using BancoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class InvestimentoController : ControllerBase
{
    private readonly BancoDbContext _context;

    public InvestimentoController(BancoDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("listar")]
    public async Task<ActionResult<IEnumerable<Investimento>>> GetInvestimentos()
    {
        var investimentos = await _context.Investimento.ToListAsync();

        if (investimentos == null || investimentos.Count == 0)
            return NotFound();

        return investimentos;
    }

    [HttpGet]
    [Route("buscar/{InvestimentoID}")]
    public async Task<ActionResult<Investimento>> GetInvestimento(int Id)
    {
        var investimento = await _context.Investimento.FindAsync(Id);

        if (investimento == null)
            return NotFound();

        return investimento;
    }

    [HttpPost]
    [Route("criar")]
    public async Task<ActionResult<Investimento>> CriarInvestimento(Investimento investimento)
    {
        if (investimento == null)
            return BadRequest("Dados inválidos para o investimento.");

        if (investimento.Tipo == TipoInvestimento.CDB)
        {
            investimento.Taxa = 0.05; 
        }
        else if (investimento.Tipo == TipoInvestimento.TesouroDireto)
        {
            investimento.Taxa = 0.03; 
        }
        else if (investimento.Tipo == TipoInvestimento.FundoImobiliario)
        {
            investimento.Taxa = 0.08; 
        }
        else
        {
            return BadRequest("Tipo de investimento não localizado.");
        }

        _context.Investimento.Add(investimento);

        await _context.SaveChangesAsync();

        return Created("", investimento);
    }
}
