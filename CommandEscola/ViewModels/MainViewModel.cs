using CommandEscola.Commands;
using CommandEscola.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace CommandEscola.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _nomeAluno;
        private Aluno _alunoSelecionado;

        public ObservableCollection<Aluno> Alunos { get; set; }

        public string NomeAluno
        {
            get => _nomeAluno;
            set
            {
                _nomeAluno = value;
                OnPropertyChanged();
            }
        }

        public Aluno AlunoSelecionado
        {
            get => _alunoSelecionado;
            set
            {
                _alunoSelecionado = value;
                OnPropertyChanged();
            }
        }

        // COMMANDS
        public ICommand AdicionarCommand { get; set; }
        public ICommand RemoverCommand { get; set; }

        public MainViewModel()
        {
            Alunos = new ObservableCollection<Aluno>();

            AdicionarCommand = new RelayCommand(AdicionarAluno);
            RemoverCommand = new RelayCommand(RemoverAluno, PodeRemover);
        }

        private void AdicionarAluno(object obj)
        {
            if (!string.IsNullOrWhiteSpace(NomeAluno))
            {
                Alunos.Add(new Aluno { Nome = NomeAluno });
                NomeAluno = "";
            }
        }

        private void RemoverAluno(object obj)
        {
            if (AlunoSelecionado != null)
            {
                Alunos.Remove(AlunoSelecionado);
            }
        }

        private bool PodeRemover(object obj)
        {
            return AlunoSelecionado != null;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}