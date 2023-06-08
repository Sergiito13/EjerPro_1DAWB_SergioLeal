namespace examentienda
{
    internal class Juego
    {
        // ATRIBUTOS
        private string nombre { get; set; }
        private decimal precio { get; set; }
        private int code { get; set; }

        // CONSTRUCTORES
        public Juego()
        {

        }

        public Juego(string nombre, decimal precio, int code)
        {
            SetNombre(nombre);
            SetPrecio(precio);
            SetCode(code);
        }
        // GETTERS Y SETTERS
        public string GetNombre()
        {
            return nombre;
        }
        public decimal GetPrecio()
        {
            return precio;
        }
        public int GetCode()
        {
            return code;
        }
        public void SetNombre(string nombre)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                this.nombre = nombre;
            }
            else
            {
                this.nombre = "Algo ha salido mal";
            }
        }
        public void SetPrecio(decimal precio)
        {
            if (precio > 0)
            {
                this.precio = precio;
            }
            else
            {
                this.precio = 0;
            }
        }
        public void SetCode(int codigo)
        {
            if (codigo >= 100 && codigo <= 999)
            {
                this.code = codigo;
            }
            else
            {
                this.code = 0;
            }
        }
        // TO STRING
        public override string ToString()
        {
            return $"Nombre: {this.nombre} - Precio: {this.precio} - Codigo Usuario: {this.code}";
        }
        // METODOS
        public static int PedirCodigoUsu()
        {
            int codigo = 0;
            bool correcto = false;

            Console.WriteLine("Dime tu código usuario");
            while (!(int.TryParse(Console.ReadLine(), out codigo) && (codigo >= 100) && (codigo <= 999)))
            {
                Console.WriteLine("Error! El código introducido no es válido");
            }
            return codigo;
        }
        public void CambiarCodigo0()
        {
            code = 0;
        }


    }
}
