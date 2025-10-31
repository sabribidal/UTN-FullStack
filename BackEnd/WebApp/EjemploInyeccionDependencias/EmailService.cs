namespace WebApp.EjemploInyeccionDep
{
    public class EmailService : IEmailService
    {
        public void Enviar(string email, string mensaje)
        {
            Console.WriteLine($"Mail para {email} con el mensaje: {mensaje}");
        }

        public bool ValidarEmail(string email)
        {
            return email.Contains("@");
        }
    }
}