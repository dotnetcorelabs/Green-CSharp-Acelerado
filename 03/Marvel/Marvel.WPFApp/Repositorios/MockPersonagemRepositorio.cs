using Marvel.Domain.Models;
using Marvel.Domain.Services;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Marvel.WPFApp.Repositorios
{
    public class MockPersonagemRepositorio : IPersonagemRepositorio
    {
        static List<Personagem> CarregarDoDisco()
        {
            return new List<Personagem>()
            {
                new Personagem()
                {
                    Id = 1,
                    Descricao = "Rick Jones has been Hulk's best bud since day one, but now he's more than a friend...he's a teammate! Transformed by a Gamma energy explosion, A-Bomb's thick, armored skin is just as strong and powerful as it is blue. And when he curls into action, he uses it like a giant bowling ball of destruction! ",
                    Nome = "A-Bomb (HAS)",
                    Thumbnail = new Imagem
                    {
                        Extencao = ".jpg",
                        Caminho = "http://i.annihil.us/u/prod/marvel/i/mg/3/20/5232158de5b16"
                    }
                },
                new Personagem()
                {
                    Id = 2,
                    Descricao = "AIM is a terrorist organization bent on destroying the world.",
                    Nome = "A.I.M.",
                    Thumbnail = new Imagem
                    {
                        Extencao = ".jpg",
                        Caminho = "http://i.annihil.us/u/prod/marvel/i/mg/6/20/52602f21f29ec"
                    }
                }
            };
        }

        public async Task<IReadOnlyList<Personagem>> GetCharacters(string searchString = null, int limit = 10, CancellationToken cancellationToken = default)
        {
            return await Task.FromResult(CarregarDoDisco());
        }
    }
}
