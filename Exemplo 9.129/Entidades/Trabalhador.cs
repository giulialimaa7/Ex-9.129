using System;
using Exemplo_9._129.Entidades.Enums;
using Exemplo_9._129.Entidades;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_9._129.Entidades
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public NivelTrabalhador Nivel { get; set; }
        public double SalárioBase { get; set; }

        public Departamento Departamento { get; set; }
        public List<HoraContrato> Contratos { get; set; } = new List<HoraContrato>();

        public Trabalhador()
        {

        }
        public Trabalhador(string nome, NivelTrabalhador nivel, double salárioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalárioBase = salárioBase;
            Departamento = departamento;
        }
        public void AddContrato (HoraContrato contrato)
        {
            Contratos.Add(contrato);
        }
        public void RemoverContrato (HoraContrato contrato)
        {
            Contratos.Remove(contrato);
        }
        public double Renda (int ano, int mês)
        {
            double soma = SalárioBase;
            foreach (HoraContrato contrato in Contratos)
            {
                if (contrato.Date.Year == ano && contrato.Date.Month == mês)
                {
                    soma = soma + contrato.ValorTotal();
                }
            }
            return soma;

        }
    }
}