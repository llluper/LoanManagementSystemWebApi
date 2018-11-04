using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using LoanManagementSystemWebApi.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace LoanManagementSystemWebApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LoanController : ControllerBase
  {
    private readonly LoanContext _context;

    public LoanController(LoanContext context)
    {
      _context = context;
    }

    [HttpGet]
    public ActionResult<List<LoanItem>> GetAll()
    {
      var items = _context.LoanList.ToList();
      if (items == null)
      {
        return NotFound();
      }
      return _context.LoanList.ToList();
    }
  }
}