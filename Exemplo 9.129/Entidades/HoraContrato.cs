using System;
using Exemplo_9._129.Entidades;
using Exemplo_9._129.Entidades.Enums;
using System.Collections.Generic;
using System.Text;


namespace Exemplo_9._129.Entidades
{
    class HoraContrato
    {
        public DateTime Date { get; set; }
        public double ValorPorHora { get; set; }
        public int Hora { get; set; }

        public HoraContrato()
        {

        }

        public HoraContrato(DateTime date, double valorPorHora, int hora)
        {
            Date = date;
            ValorPorHora = valorPorHora;
            Hora = hora;
        }
        public double ValorTotal()
        {
            return Hora * ValorPorHora;
        }
    }
}
