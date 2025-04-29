using CloudinaryDotNet;
using Microsoft.Extensions.DependencyInjection;

namespace MANAGE_SOCCER_GAME.Services
{
    internal class AppService
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static Account? CurrentUser { get; set; }

        public static void ShowError(string message) =>
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static void ShowSuccess(string message) =>
            MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static T Get<T>() where T : class =>
            ServiceProvider.GetRequiredService<T>();
    }
}
