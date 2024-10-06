using System.Diagnostics;

namespace Open_CaptureGaming_Software.app.utils
{
    public static class RedirectHelper
    {
        public static void Redirect(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true

                };
                Process.Start(psi);
            }

        }

    }
}
