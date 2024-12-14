public class Hexagono
{
    // Encapsulamos el lado como propiedad privada
    private double lado;

    // Propiedad pública para acceder al lado
    public double Lado
    {
        get { return lado; }
        set { lado = value; }
    }

    // Constructor para inicializar el lado
    public Hexagono(double lado)
    {
        this.lado = lado;
    }

    // Método para calcular el área del hexágono
    public double CalcularArea()
    {
        return (3 * Math.Sqrt(3) * Math.Pow(lado, 2)) / 2;
    }

    // Método para calcular el perímetro del hexágono
    public double CalcularPerimetro()
    {
        return 6 * lado; // Perímetro de un hexágono regular
    }
}