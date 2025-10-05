internal class Program
{
    class Empleados
    {
       private string nombre;
        private int sueldo;

        public void CargaDatos()
        {
            string respuesta;
            Console.WriteLine("Ingrese el nombre del empleado:");
            respuesta = Console.ReadLine();
            nombre = Convert.ToString(respuesta);
            Console.WriteLine("Ingrese el sueldo del empleado:");
            respuesta = Console.ReadLine();
            sueldo = Convert.ToInt32(respuesta);



        }
        public void ImprimirDatos()
        {
            Console.WriteLine("Nombre del empleado: "+nombre);
            Console.WriteLine("Sueldo del empleado: " + sueldo);
        }
        public void PagoImpuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("El empleado " + nombre + " debe pagar impuestos");
            }
            else
            {
                Console.WriteLine("El empleado " + nombre + " no debe pagar impuestos");
            }
        }

    }
    private static void Main(string[] args)
    {
        //Ejercicio1 
        /*Confeccionar una clase que represente un empleado. Definir como atributos su
  nombre y su sueldo. Confeccionar los métodos para la carga, otro para imprimir sus
  datos y por último uno que imprima un mensaje si debe pagar impuestos (si el
  sueldo supera a 3000)*/

        Empleados empleado = new Empleados();
        empleado.CargaDatos();
        empleado.ImprimirDatos();
        empleado.PagoImpuestos();
        Console.ReadKey();

    }
}