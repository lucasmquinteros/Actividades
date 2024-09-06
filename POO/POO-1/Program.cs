// Calcular el area de un rectangulo y un circulo

abstract class FormaGeometrica
{
    public abstract double CalcularArea();
}
class Rectangulo : FormaGeometrica //tengo que utilizar si o si el metodo dentro de la clase heredada
{
    public double Largo { get; set; }
    public double Ancho { get; set; }
    
    public Rectangulo(double largo, double ancho) 
    {
        this.Largo = largo;
        this.Ancho = ancho;
    }

    public override double CalcularArea() 
    {
        return Largo * Ancho;
    }
}

class Circulo : FormaGeometrica
{
    public double radio { get; set; }

    public Circulo(double radio) 
    {
        this.radio = radio;
    }

    public override double CalcularArea() 
    {
        return Math.PI * radio * radio;
    }

}



class Program 
{
    static void Main()
    {
        FormaGeometrica Circulo = new Circulo(5);

        Console.WriteLine($"Área del Circulo:  {Circulo.CalcularArea()} cm");
    }
}