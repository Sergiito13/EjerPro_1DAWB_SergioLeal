namespace tiendaonline
{
    internal class Cliente
    {
        // ATRIBUTOS
        private string Nombre { get; set; }
        private string Email { get; set; }

        // CONSTRUCTORES
        public Cliente()
        {

        }
        public Cliente(string Nombre, string Email)
        {
            SetNombre(Nombre);
            SetEmail(Email);
        }
        // GETTERS Y SETTERS
        public string GetNombre()
        {
            return this.Nombre;
        }
        public string GetEmail()
        {
            return this.Email;
        }
        //---------------------------
        public void SetNombre(string nombre)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                this.Nombre = nombre;
            }
            else
            {
                this.Nombre = "";
            }
        }

        public void SetEmail(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                this.Email = email;
            }
            else
            {
                this.Email = "";
            }
        }

        // METODOS
        public override string ToString()
        {
            string linea = "Clientes:\n";
            linea += $"Nombre: {this.Nombre}\n";
            linea += $"email: {this.Email}\n";

            return linea;
        }
    }
}
