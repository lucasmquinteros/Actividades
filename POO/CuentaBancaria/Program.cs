class CuentaBancaria
{
    private string _titular;
    private decimal _saldo;

    public CuentaBancaria(string titular, decimal saldoInicial)
    {
        _titular = titular;
        _saldo = saldoInicial;
    }

    public string Titular
    { 
        get { return _titular; }
        set { _titular = value; }
    }
    public decimal Saldo
    { 
        get { return _saldo; }
        private set { _saldo = value; } 
    }
    public void Depositar(decimal cantidad)
    {
        if (cantidad > 0)
        {
            Saldo += cantidad;
            Console.WriteLine($"Depositaste {cantidad}. Saldo actual: {Saldo}");
        }
        else
        {
            Console.WriteLine("Depositar una cantidad mayor a 0");
        }
    }
    public void Retirar(decimal cantidad)
    {
        if (cantidad > 0 && cantidad <= Saldo)
        {
        Saldo -= cantidad;
            Console.WriteLine($"Retiraste: {cantidad}; Saldo Actual: {Saldo}");
        }
        else
        {
            Console.WriteLine($"Ingrese un valor valido");
        }
    }
}


class Program
{
    static void Main()
    {
        CuentaBancaria cuenta = new CuentaBancaria("Ana", 5000);
        cuenta.Depositar(200);
        cuenta.Retirar(150);

        Console.WriteLine($"Saldo final: {cuenta.Saldo}");
    }
}