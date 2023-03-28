namespace Programando.CSharp.Demos
{
    public class Program2
    {
        static static void Main2(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            var demo = new Demo();
            var persona = new Persona()
            {
                nombre = "Ana",
                edad = 35
            };

            Console.WriteLine($"{persona.nombre} tiene {persona.edad} años.");
            demo.Transforma;
            Console.WriteLine($"{persona.nombre} tiene {persona.edad} años.");
        }

    }

    private void Inicializa(string nombre = "", string apellidos = "", int edad = 0)

    {
        this.nombre = nombre;

        this.apellidos = apellidos;

        this.edad = edad;
    }
    public class Demo
    {
        public bool Transforma
        {
            {

            }
        }
    }
    public class Persona
    {
        string nombre = "";
        int edad = 0;
    }
}