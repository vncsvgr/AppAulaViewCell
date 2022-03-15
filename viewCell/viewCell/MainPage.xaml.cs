using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace viewCell
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            lstAlunos.ItemsSource = new List<Aluno>
            { 
                new Aluno { Nome="João", Curso="Desenvolvimento", Cidade="Jau"},
                new Aluno { Nome="José", Curso="Administração", Cidade="Bariri"},
                new Aluno { Nome="Paulo", Curso="Mecânica", Cidade="Bocaina"},
                new Aluno { Nome="Antonio", Curso="Edificações", Cidade="Bauru"}
            };
        }

        private void lstAlunos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var a = e.SelectedItem as Aluno;

            DisplayAlert("Aluno", "Aluno: " + a.Nome +
                                "\nCurso: " + a.Curso +
                                "\nCidade: " + a.Cidade, "OK");
        }
    }
}