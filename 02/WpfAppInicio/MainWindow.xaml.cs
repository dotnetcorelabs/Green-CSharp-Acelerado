using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppInicio.Models;

namespace WpfAppInicio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected ObservableCollection<Character> CharactersCollection = new ObservableCollection<Character>();

        public MainWindow()
        {
            InitializeComponent();
        }

        void LoadCharacters()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://rmauro-marvel-api.herokuapp.com");

                using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "/api/Characters"))
                {
                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var response = client.SendAsync(request).GetAwaiter().GetResult();

                    if (response.IsSuccessStatusCode)
                    {
                        string content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                        CharactersCollection = JsonConvert.DeserializeObject<ObservableCollection<Character>>(content);
                    }
                }
            }


        }
    }
}
