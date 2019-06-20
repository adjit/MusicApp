using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.Models
{
    interface IAlbumsRepository
    {
        IEnumerable<Albums> GetAll();
        IActionResult GetAlbum(int id);
        Task<IActionResult> GetAlbumAsync(int id);
    }
}
