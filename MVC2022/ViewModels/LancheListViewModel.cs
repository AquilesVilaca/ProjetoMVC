﻿using MVC2022.Models;

namespace MVC2022.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> lanches{ get; set; }
        public string CategoriaAtual { get; set; }
    }
}
