﻿namespace ChainOfResponsibility.Desconto
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }

        double Calcula(Orcamento orcamento);
    }
}