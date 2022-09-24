using MailAPI.Models;

namespace MailAPI.Abstracts
{
    public interface IMailService
    {
        Task SenEmailAsync(MailRequest mailRequest);
    }
}
