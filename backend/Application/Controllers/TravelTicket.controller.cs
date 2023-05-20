using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Domain.Services;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class TravelTicketController : ControllerBase
{
    // private static readonly string[] Summaries = new[]
    // {
    //     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    // };

    // private readonly ILogger<TravelTicketController> _logger;

    // public TravelTicketController(ILogger<TravelTicketController> logger)
    // {
    //     _logger = logger;
    // }

    private readonly DomainReport _reportService;

    public TravelTicketController(DomainReport reportService)
    {
        _reportService = reportService;
    }

    [HttpGet(Name = "GetAllTravelTickets")]
    public ActionResult<IEnumerable<TravelTicket>> Get()
    {
        try
        {
            var result = _reportService.GetAllTickets();
            return Ok(result);
        }
        catch
        {
            return StatusCode(500);
        }
    }

    [HttpGet("{id}")]
    public ActionResult<TravelTicket> Get(int id)
    {
        try
        {
            var result = _reportService.GetTicket(id);
            if (result == null) { return NotFound(); }
            return Ok(result);
        }
        catch
        {
            return StatusCode(500);
        }

    }

    [HttpPost]
    public ActionResult Post([FromBody] TravelTicket ticket)
    {
        try
        {
            _reportService.CreateTicket(ticket);
            return StatusCode(StatusCodes.Status201Created);
        }
        catch (FluentValidation.ValidationException ex)
        {
            return BadRequest(ex.Errors);
        }
        catch
        {
            return StatusCode(500);
        }
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        try
        {
            if (_reportService.DeleteTicket(id))
            {
                return StatusCode(StatusCodes.Status200OK);
            }
            return NotFound();
        }
        catch
        {
            return StatusCode(500);
        }
    }
}
