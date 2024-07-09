using MVC2022.Models;

namespace MVC2022.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPReferidos { get; }
        Lanche GetLancheById(int lancheId);
    }
}
