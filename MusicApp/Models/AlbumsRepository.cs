using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MusicApp.Models
{
    public class AlbumsRepository : IDisposable, IAlbumsRepository
    {
        private MusicAppContext db = new MusicAppContext();
        private readonly ILogger<AlbumsRepository> _logger;

        public AlbumsRepository(ILogger<AlbumsRepository> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> GetAlbumAsync(int id)
        {
            return await Task.FromResult(GetAlbum(id));
        }

        public IActionResult GetAlbum(int id)
        {
            _logger.LogTrace("Getting Albums by ID");
            return new ObjectResult(db.Albums.FirstOrDefault(a => a.Id == id));
        }

        public IEnumerable<Albums> GetAll()
        {
            _logger.LogTrace("Getting All Albums");
            return db.Albums;
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
