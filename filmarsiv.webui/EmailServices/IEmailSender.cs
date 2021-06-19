using System.Threading.Tasks;

namespace filmarsiv.webui.EmailServices
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email,string subject,string htmlMessage);
    }
}