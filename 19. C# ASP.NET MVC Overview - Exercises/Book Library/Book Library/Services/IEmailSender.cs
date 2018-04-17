using System;
using System.Threading.Tasks;

namespace Book_Library.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}