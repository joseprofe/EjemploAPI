﻿using System;
namespace KaynJungle.Core.DTO
{
    public class UsuarioDTO
    {
        public string Username { get; set; }

        public string Password { get; set; }
        public string Email { get; set; }
        public string Apellidos { get; set; }
        public string Name { get; set; }
        public string Rol { get; set; }

        public UsuarioDTO()
        {
        }
    }
}
