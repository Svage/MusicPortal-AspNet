using Microsoft.AspNetCore.Identity;
using MusicPortal.DAL.Enum;
using MusicPortal.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicPortal.WEB.Models.ViewModels
{
    public class AuthorVM: IdentityUser
    {
        public string NickName { get; set; }
        public ICollection<Music>? Musics { get; set; }
     
        public DateTime? Age { get; set; }

        public GenreEnum? mainGenre { get; set; }

        public string? Biography { get; set; }

        public string? linkInstagram { get; set; }

        public string? linkVK { get; set; }

        public string? linkYouTube { get; set; }

        public string? linkOther { get; set; }
    }
}
