using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X") //ToUpper() vai transformar um X minúsculo em maiúsculo se for o caso
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: adicionar aluno
                        int indiceAluno = 0;

                        Console.WriteLine("Informe o nome do aluno");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");
                        
                        //Modos de converter valores decimais
                        //var nota = decimal.Parse(Console.ReadLine());
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal!");                        
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;
                    case "2":
                        //TODO: listar alunos

                        foreach(var a in alunos)
                        {
                        if(!string.IsNullOrEmpty(a.Nome))
                            Console.WriteLine($"Aluno: {a.Nome} Nota: {a.Nota}");    
                        }
                        break;
                    case "3":
                        //TODO: calcular média
                        decimal notaTotal = 0;
                        decimal mediaGeral = 0;
                        int numAlunos = 0;

                        for(int i = 0; i < alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                numAlunos++;
                            }
                        }

                        mediaGeral = notaTotal / numAlunos;
                        Conceito conceitoGeral;

                        if(mediaGeral < 2)
                            conceitoGeral = Conceito.E;
                        else if(mediaGeral < 4)
                            conceitoGeral = Conceito.D;
                        else if(mediaGeral < 6)
                            conceitoGeral = Conceito.C;
                        else if(mediaGeral < 8)
                            conceitoGeral = Conceito.B;
                        else
                            conceitoGeral = Conceito.A;

                        Console.WriteLine($"Média Geral é: {mediaGeral}");

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}
