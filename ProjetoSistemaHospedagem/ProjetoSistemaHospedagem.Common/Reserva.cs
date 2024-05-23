namespace ProjetoSistemaHospedagem.Common;

public class Reserva
{
    //Criando uma lista da classe Pessoas..
    List<Pessoa> listaDePessoa = new List<Pessoa>();
    //Criando uma lista da classe Suite..
    List<Suite> listaDeSuite = new List<Suite>();
    //Criando uma probriedade da classe Suite..
    public Suite SuitePropriedade {get;set;}
    
    //Metodo criado para fazer o cadastro dos Hospedes
    public void CadastrarHospedes(){
        Console.WriteLine("----CADASTRO HOTEL----");
        inicio:
        //Pergunta para o usuário o nome dele..
        Console.Write("NOME:");
        string nomeParaCadastro = Console.ReadLine();

        //Ira passar o nome para dentro da minha instanciação de objeto abaixo..
        Pessoa pessoa = new Pessoa(nomeParaCadastro);

        //Ira passar o valor fornecido acima, para dentro da minha Lista de Pessoas, assim minha Lista possuira todos o valores registrados
        listaDePessoa.Add(pessoa);
        

        Console.WriteLine("CADASTRAR MAIS ALGUÉM? [S/N]");
        string respostaSimOUNao = Console.ReadLine().ToUpper();

        if(respostaSimOUNao == "S" || respostaSimOUNao == "SIM"){

            goto inicio;

        }else{

            Console.WriteLine("----CADASTRADOS----");
            foreach(var hospedes in listaDePessoa){
                Console.WriteLine($"NOME: {hospedes.Nome}");
            }

            Console.WriteLine("------------------");
        }
    } 

    public void CadastrarSuites(){
        inicio:
        Console.WriteLine("----CADASTRO SUITE----");
        //Pergunta o tipo de suite escolhido..
        Console.WriteLine("TIPO SUITE:");
        string tipoDeSuite = Console.ReadLine();
        

        //Pergunta a capacidade de hospedes que podem caber na suite.. 
        Console.WriteLine("CAPACIDADE:");
        int capacidadeDeHospedes = Convert.ToInt32(Console.ReadLine());
        
        //Verifica se a capacidade de hospedes colocada é menor que a quantia de pessoas cadastradas..
        if(capacidadeDeHospedes < listaDePessoa.Count()){
            Console.WriteLine("Está suite não tem espaço suficinete para as pessoas cadastradas!");
            Console.WriteLine("Tente Mais uma Vez!");
            goto inicio;

        //Verifica se a capacidade de hospedes colocada é maior que a quantia de pessoas cadastradas..
        }else if(capacidadeDeHospedes > listaDePessoa.Count()){
            Console.WriteLine("Está suite tem espaço a mais que o numero de pessoas cadastradas!");
            Console.WriteLine("Tente Mais uma Vez!");
            goto inicio;        
        }else{
        
            //Caso nenhumas das opções acima venha acontecer, ele continuara o programa pedindo o valor da diária e o total de dias irão ficar..
            Console.WriteLine("VALOR DIÁRIA:");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("!!FIQUE 10 DIAS OU MAIS, E RECEBA  DESCONTO DE 10% NO PAGAMENTO!!");

            //Serve para pedir ao cliente, quantos dias ele quer para reservar..
            Console.WriteLine("DIAS DE LOCAÇÃO: ");
            int diasReservar = Convert.ToInt32(Console.ReadLine());
            
            //Passando os valor fornecidos acima, para dentro do meu objeto
            Suite suite = new Suite(tipoDeSuite,capacidadeDeHospedes,valor,diasReservar);

            //Passando o valor suite(objeto acima), para SuitePropriedadae(para que futuramente, ele não venha ficar nulo na criação de outros métodos..)
            SuitePropriedade = suite;

            //Colocando meu objeto criado dentro da Lista abaixo, assim minha lista possuira todos os valores adicionados..
            listaDeSuite.Add(suite);

            Console.WriteLine("----------------------");
        }
    }   

    //Método simples, que serve apenas para informar o total de hospedes cadastrados..
    public void ObterQuandidadeHospedes(){
        Console.WriteLine("Quantidade de Hospedes: {0}",listaDePessoa.Count());
    }


  
    //Método que ira retornar o valor final da reserva..
    public decimal CalcularDiaria(){
      //Se o total de dias reservados for maior que 10 ou até igual a 10, o valor da diária tera um desconto de 10% do total..  
      if(SuitePropriedade.DiasReservados >= 10){
        //Variavel criada para fazer o calculo de desconto..
        decimal desconto10Porcento = SuitePropriedade.ValorDiaria * SuitePropriedade.DiasReservados * 0.1M;
        //Retorara o valor total da reservar, com 10% de desconto..
        return SuitePropriedade.ValorDiaria * SuitePropriedade.DiasReservados - desconto10Porcento;
      }else{
        //Retornara o valor total da reserva, mas sem 10% de desconto..
          return SuitePropriedade.ValorDiaria * SuitePropriedade.DiasReservados;
      }
      
    }

    //Método que serva para listar o nome das pessoas cadastradas..
    public void MostrarNomesCadastrados(){
        Console.WriteLine("--------LISTA CADASTRADOS--------");
        foreach(var mostrarNomes in listaDePessoa){
            Console.WriteLine($"NOME: {mostrarNomes.Nome}");
        }
        Console.WriteLine("---------------------------------");
    }

    

}
