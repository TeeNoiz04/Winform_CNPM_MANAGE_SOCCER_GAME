using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;

namespace MANAGE_SOCCER_GAME.Services
{
    internal class AppService
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static Guid TournamentId { get; set; } = Guid.Parse("C9E0BB16-D5C1-400B-834F-3C3789D3836C");

        public static void ShowError(string message) =>
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static void ShowSuccess(string message) =>
            MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static T Get<T>() where T : class =>
            ServiceProvider.GetRequiredService<T>();

        public static bool IsEmptyInput(params Control[] controls)
        {
            foreach (var ctrl in controls)
            {
                if (ctrl is Guna2TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    ShowError($"Vui lòng nhập: {textBox.Tag ?? textBox.Name}");
                    return true;
                }
            }

            return false;
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) return false;

            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^0\d{9}$");
        }

        public static bool IsValidText(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;

            return System.Text.RegularExpressions.Regex.IsMatch(name, @"^[\p{L} ]{2,50}$");
        }
       
    }
}
