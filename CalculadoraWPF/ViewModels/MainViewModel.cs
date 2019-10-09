using CalculadoraWPF.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalculadoraWPF.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int resultado;

        public int Resultado
        {
            get { return resultado; }
            set
            {
                resultado = value;
                PropertyChanged?
                    .Invoke(this, new PropertyChangedEventArgs(nameof(Resultado)));
            }
        }

        public MainViewModel()
        {
            Resultado = 10;

            Task.Delay(2 * 1000).ContinueWith(Change);

            SomarCmd = new RelayCommand(Somar);
        }

        Task Change(Task previous)
        {
            Resultado = 20;
            return Task.CompletedTask;
        }

        public ICommand SomarCmd { get; set; }

        void Somar(object parametro)
        {
            int numero = Convert.ToInt32(parametro);
            Resultado = numero;
        }
    }
}
