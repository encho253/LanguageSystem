using System.Threading.Tasks;

namespace LanguageSystem.Web.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}