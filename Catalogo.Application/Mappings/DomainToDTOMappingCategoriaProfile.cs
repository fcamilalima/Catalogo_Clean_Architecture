﻿using Catalogo.Application.DTOs;
using Catalogo.Domain.Entities;

namespace Catalogo.Application.Mappings;

public static class DomainToDTOMappingCategoriaProfile
{
    public static Categoria? ToCategoria(this CategoriaDTO categoriaDTO) {
        if (categoriaDTO is null) return null;

        return new Categoria(categoriaDTO.ID, categoriaDTO.Nome, categoriaDTO.ImagemURL);
    }

    public static CategoriaDTO? ToCategoriaDTO(this Categoria categoria)
    {
        if (categoria is null) return null;
        return new CategoriaDTO
        {
            ID = categoria.ID,
            Nome = categoria.Nome,
            ImagemURL = categoria.ImagemURL
        };
    }

    public static IEnumerable<CategoriaDTO> ToCategoriaDTOList(this IEnumerable<Categoria> categorias)
    {
        if (categorias is null || !categorias.Any())
            return new List<CategoriaDTO>();

        return categorias.Select(c => c.ToCategoriaDTO()).ToList();
    }

}
