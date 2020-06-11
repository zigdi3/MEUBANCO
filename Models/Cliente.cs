using System;

namespace MEUBANCO.Models
{
    public class Cliente
    {
        public Cliente()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id  { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Pass { get; set; }
    public double Saldo { get; set; }
    }
}