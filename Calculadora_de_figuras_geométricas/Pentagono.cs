public class Pentagono
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
    public Pentagono(double lado)
    {
        this.lado = lado;
    }

    // Método para calcular el área del pentágono
    public double CalcularArea()
    {
        return (5 * Math.Pow(lado, 2)) / (4 * Math.Tan(Math.PI / 5));
    }

    // Método para calcular el perímetro del pentágono
    public double CalcularPerimetro()
    {
        return 5 * lado; // Perímetro de un pentágono regular
    }
}