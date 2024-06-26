﻿using FilmesAPI.Data.Dtos;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
namespace FilmesAPI.Dtos
{
    public class ReadCinemaDto
    {
        public int Id {  get; set; }
        public string Nome { get; set; }
        public ReadEnderecoDto Endereco { get; set; }
        public ICollection<ReadSessaoDto> Sessoes { get; set; }


    }
}
