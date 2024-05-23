using ProjetoSistemaHospedagem.Common;

class Program{
    static void Main()
    {
        Reserva r = new Reserva();

        r.CadastrarHospedes();
        r.CadastrarSuites();
        r.ObterQuandidadeHospedes();
        Console.WriteLine(" VALOR DIARIA FINAL" + r.CalcularDiaria());
        
    }
}
