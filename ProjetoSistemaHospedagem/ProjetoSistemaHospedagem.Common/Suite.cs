using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSistemaHospedagem.Common
{
    public class Suite
    {
        private string tipoSuite;
        private int capacidade;
        private decimal valorDiaria;
        
        private int diasReservados;

        public string TipoSuite{get;set;}
        public int Capacidade{get;set;}
        public decimal ValorDiaria{get;set;}
        
        public int DiasReservados {get;set;}

        public Suite(string tipoSuite,int capacidadeDeHospedes,decimal valorDiaria,int diasReservados)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidadeDeHospedes;
            ValorDiaria = valorDiaria;
            DiasReservados = diasReservados;
        }

       
    }
}