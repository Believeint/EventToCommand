using EventToCommand1.Models;
using EventToCommand1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EventToCommand1.ViewModel
{
    public class PessoaListarViewModel
    {
        public ICommand ItemSelectedCommand { get; private set; }
        public ObservableCollection<Pessoa> Pessoas { get; private set; }
        public PessoaListarViewModel() 
        {
            Pessoas = new ObservableCollection<Pessoa>()
            {
                new Pessoa(1, "Elias", 23, "Brasília", "DF"),
                new Pessoa(2, "José", 26, "Anápolis", "GO"),
                new Pessoa(3, "Maria", 43, "Rio de Janeiro", "RJ"),
                new Pessoa(4, "Joana", 53, "Planaltina", "DF"),
                new Pessoa(5, "John Doe", 13, "São Paulo", "SP"),
                new Pessoa(6, "Mark", 24, "Brasília", "DF"),
                new Pessoa(7, "Justin", 27, "Anápolis", "GO"),
                new Pessoa(8, "Sofia", 48, "Rio de Janeiro", "RJ"),
                new Pessoa(9, "Jandir", 59, "Planaltina", "DF"),
                new Pessoa(10, "Maradona", 15, "São Paulo", "SP")
            };

            ItemSelectedCommand = new Command<Pessoa>(DetalharPessoa);
        }

        private void DetalharPessoa(Pessoa obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new PessoaExibirPage(obj));
        }
    }
}
