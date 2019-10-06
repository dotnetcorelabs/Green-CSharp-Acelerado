using Marvel.Domain.Models;
using Marvel.Domain.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.WPFApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string pageTitle;
        public string PageTitle { get { return pageTitle; } set { Set(ref pageTitle, value); } }

        private readonly IPersonagemRepositorio personagemRepositorio;

        public ObservableCollection<Personagem> Personagens { get; set; }

        private string searchString;
        public string SearchString { get { return searchString; } set { Set(ref searchString, value); } }

        public MainViewModel(IPersonagemRepositorio personagemRepositorio)
        {
            PageTitle = "Personagens Marvel";

            Personagens = new ObservableCollection<Personagem>();
            this.personagemRepositorio = personagemRepositorio;

            _ = LoadAsync();

            PropertyChanged += MainViewModel_PropertyChanged;
        }

        private void MainViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (string.Equals(e.PropertyName, nameof(SearchString), StringComparison.CurrentCultureIgnoreCase))
            {
                PageTitle = $"Personagens Marvel ({SearchString})";
            }
        }

        async Task LoadAsync()
        {
            var personagensHttp = await personagemRepositorio.GetCharacters();
            foreach (var item in personagensHttp)
            {
                Personagens.Add(item);
            }
        }
    }
}
