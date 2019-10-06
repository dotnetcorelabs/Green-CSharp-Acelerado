using Marvel.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Marvel.Domain.Services
{
    public interface IPersonagemRepositorio
    {
        Task<IReadOnlyList<Personagem>> GetCharacters(string searchString = null, int limit = 10, CancellationToken cancellationToken = default);
    }
}
