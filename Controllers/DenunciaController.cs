using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using carteiravacina.Models;
using CarteiraVacina_BackEnd.Data;
using CarteiraVacinacao.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace carteiravacina.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DenunciaController : ControllerBase
    {
        private readonly DataContext _context;

        public DenunciaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("ListarR")]
        public async Task<IActionResult> ListarAsyncV()
        {
            try
            {
                List<RGA> rga = await _context.RGA.ToListAsync(); 
                return Ok(rga);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ListarC")]


        public async Task<IActionResult> ListarAsyncC()
        {
            try
            {
                List<Animal> animais = await _context.Animal.ToListAsync(); 
                return Ok(animais);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ListarT")]
        public async Task<IActionResult> ListarAsyncT()
        {
            try
            {
                List<Tutor> tutor = await _context.Tutor.ToListAsync(); 
                return Ok(tutor);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
  }