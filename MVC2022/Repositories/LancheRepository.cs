﻿using Microsoft.EntityFrameworkCore;
using MVC2022.Context;
using MVC2022.Models;
using MVC2022.Repositories.Interfaces;

namespace MVC2022.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext contexto) {
        _context = contexto;    
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPReferidos => _context.Lanches.
            Where(l => l.IsLanchePreferido).Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l =>  l.LancheId == lancheId);
        }
    }
}
