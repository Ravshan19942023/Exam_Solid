using System.Net.Mail;
using Npgsql;

public class RegisterService
{
    public void RegisterUser(string username)
    {
        if (username == "admin")
            throw new InvalidOperationException();

        NpgsqlConnection connection = new NpgsqlConnection();
        connection.Open();
        NpgsqlCommand command = new NpgsqlCommand("INSERT INTO [...]"); //Insert user into database. 

        SmtpClient client = new SmtpClient("smtp.myhost.com");
        client.Send(new MailMessage());  //Send a welcome email. 
    }
}