namespace CodeAcademy_Tasks.Models;

public class Celsius
{
    public double Degree { get; set; }

    public Celsius(double degree)
    {
        Degree = degree;
    }

    // Implicit operator: Celsius → Kelvin
    public static implicit operator Kelvin(Celsius celsius)
    {
        // 0°C = 273K
        return new Kelvin(celsius.Degree + 273);
    }
}
