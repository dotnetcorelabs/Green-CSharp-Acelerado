using Marvel.Domain.Models;
using Marvel.Domain.Services;
using Marvel.WPFApp.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Marvel.WPFApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string pageTitle;
        public string PageTitle
        {
            get { return pageTitle; }
            set { Set(ref pageTitle, value); }
        }

        private readonly IPersonagemRepositorio personagemRepositorio;

        private ObservableCollection<Personagem> personagens;
        public ObservableCollection<Personagem> Personagens
        {
            get { return personagens; }
            set { Set<ObservableCollection<Personagem>>(ref personagens, value); }
        }

        private string searchString;
        public string SearchString { get { return searchString; } set { Set(ref searchString, value); } }

        public ICommand BuscarCmd { get; set; }

        public MainViewModel(IPersonagemRepositorio personagemRepositorio)
        {
            PageTitle = "Personagens Marvel";

            BuscarCmd = new RelayCommand<string>(async data => await BuscarFunc(data));

            Personagens = new ObservableCollection<Personagem>();
            this.personagemRepositorio = personagemRepositorio;

            _ = LoadAsync();

            PropertyChanged += MainViewModel_PropertyChanged;
        }

        async Task BuscarFunc(string searchString)
        {
            await LoadAsync(searchString);
        }

        private void MainViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (string.Equals(e.PropertyName, nameof(SearchString), StringComparison.CurrentCultureIgnoreCase))
            {
                PageTitle = $"Personagens Marvel ({SearchString})";
                //_ = LoadAsync(SearchString);
            }
        }

        async Task LoadAsync(string searchString = null)
        {
            IReadOnlyList<Personagem> personagensHttp = await personagemRepositorio.GetCharacters(searchString);
            Personagens = new ObservableCollection<Personagem>();
            foreach (var item in personagensHttp)
            {
                Personagens.Add(item);
            }
        }
    }
}
