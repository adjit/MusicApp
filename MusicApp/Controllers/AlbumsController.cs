using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicApp.Models;

namespace MusicApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        private readonly IAlbumsRepository _context;

        public AlbumsController(IAlbumsRepository context)
        {
            _context = context;
        }

        // GET: api/Albums
        [HttpGet]
        public IEnumerable<Albums> GetAlbums()
        {
            return _context.GetAll();
        }

        // GET: api/Albums/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAlbums([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var albums = await _context.GetAlbumAsync(id);

            if (albums == null)
            {
                return NotFound();
            }

            return Ok(albums);
        }

        //// PUT: api/Albums/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAlbums([FromRoute] int id, [FromBody] Albums albums)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != albums.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(albums).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AlbumsExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Albums
        //[HttpPost]
        //public async Task<IActionResult> PostAlbums([FromBody] Albums albums)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Albums.Add(albums);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (AlbumsExists(albums.Id))
        //        {
        //            return new StatusCodeResult(StatusCodes.Status409Conflict);
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetAlbums", new { id = albums.Id }, albums);
        //}

        //// DELETE: api/Albums/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteAlbums([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var albums = await _context.Albums.FindAsync(id);
        //    if (albums == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Albums.Remove(albums);
        //    await _context.SaveChangesAsync();

        //    return Ok(albums);
        //}

        //private bool AlbumsExists(int id)
        //{
        //    return _context.Albums.Any(e => e.Id == id);
        //}
    }
}