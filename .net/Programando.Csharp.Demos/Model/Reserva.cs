namespace Programando.CSharp.Demos.Model;

/// <summary>
/// Objeto Reserva
/// </summary>

public class Reserva
{
    public string id;

    public string cliente;
    // 100: Habitación Individual   
    //200: Habitación Doble   
    //300: Junior Suite   
    //400: Suite
    public int tipo;

    public bool fumador;
}
