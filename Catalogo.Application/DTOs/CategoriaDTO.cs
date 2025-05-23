﻿using Catalogo.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Catalogo.Application.DTOs;

public class CategoriaDTO
{
    public int ID { get; set; }

    [Required(ErrorMessage = "Informe o nome da categoria.")]
    [MinLength(3)]
    [MaxLength(100)]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Informe o nome da imagem!")]
    [MinLength(5)]
    [MaxLength(250)]
    public string ImagemURL { get; set; }

}
