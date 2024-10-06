using DiscordRPC;
using Open_CaptureGaming_Software.app.utils;

namespace Open_CaptureGaming_Software.app.designs
{
    public partial class main : Form
    {

        private static readonly string github = "https://www.github.com/IdkBemja/Open-CaptureGaming-Software";
        private static readonly string discord = "";

        private VideoCaptureHandler videoCaptureHandler;
        private DiscordRichPresence discordrpc;

        public main()
        {
            InitializeComponent();
            Load += main_Load;
            Resize += main_Resize;
            FormClosed += main_closed;
        }


        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedirectHelper.Redirect(github);
        }

        private void discordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedirectHelper.Redirect(discord);
        }

        private void main_Load(object sender, EventArgs e)
        {
            // Configuración directa de la captura sin Task.Run
            int frameWidth = 1280;
            int frameHeight = 720;
            int fps = 60;

            // Inicializar directamente VideoCaptureHandler
            videoCaptureHandler = new VideoCaptureHandler(capturevideo_box, frameWidth, frameHeight, fps);

            // Inicializar Discord Rich Presence
            discordrpc = new DiscordRichPresence("1292327877882413170");
            discordrpc.SetPresence("Watching his console screen", ":D");

            // Configuraciones de la ventana
            this.Height = frameHeight;
            this.Width = frameWidth;
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana
            this.WindowState = FormWindowState.Normal; // Estado normal
            this.BringToFront(); // Traer la ventana al frente
            this.Focus(); // Enfocar la ventana
        }

        private void main_Resize(object sender, EventArgs e)
        {
            // Ajustar la resolución del video al tamaño de la ventana
            videoCaptureHandler?.UpdateResolution(this.ClientSize.Width, this.ClientSize.Height, 60);
        }

        private void main_closed(object sender, FormClosedEventArgs e)
        {
            // Liberar los recursos de VideoCaptureHandler y DiscordRPC
            videoCaptureHandler?.Release();
            discordrpc.Dispose();
            base.OnFormClosed(e);
        }
    }
}
