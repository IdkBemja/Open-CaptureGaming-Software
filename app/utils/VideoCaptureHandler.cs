using OpenCvSharp.Extensions;
using OpenCvSharp;

namespace Open_CaptureGaming_Software.app.utils
{
    public class VideoCaptureHandler
    {
        private VideoCapture capture;
        private Mat frame;
        private PictureBox videobox;
        private Bitmap image;

        public VideoCaptureHandler(PictureBox videobox, int frameWidth, int frameHeight, int fps)
        {
            this.videobox = videobox;
            Task.Run(() => InitializeCapture(frameWidth, frameHeight, fps));
        }

        private void InitializeCapture(int frameWidth, int frameHeight, int fps)
        {
            capture = new VideoCapture(0); // 0 es el primer dispositivo de captura
            SetCaptureProperties(frameWidth, frameHeight, fps);
            frame = new Mat();
            Application.Idle += ProcessFrame;
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            capture.Read(frame);
            if (!frame.Empty())
            {
                image = BitmapConverter.ToBitmap(frame);
                videobox.Invoke((MethodInvoker)(() => videobox.Image = image));
            }
        }

        public void UpdateResolution(int frameWidth, int frameHeight, int fps)
        {
            Task.Run(() =>
            {
                // Asegúrate de que 'capture' no sea null
                if (capture == null)
                {
                    MessageBox.Show("El dispositivo de captura no está inicializado.");
                    return;
                }

                capture.Set(VideoCaptureProperties.FrameWidth, frameWidth);
                capture.Set(VideoCaptureProperties.FrameHeight, frameHeight);
                capture.Set(VideoCaptureProperties.Fps, fps);
            });
        }

        private void SetCaptureProperties(int frameWidth, int frameHeight, int fps)
        {
            capture.Set(VideoCaptureProperties.FrameWidth, frameWidth);
            capture.Set(VideoCaptureProperties.FrameHeight, frameHeight);
            capture.Set(VideoCaptureProperties.Fps, fps);
        }

        public void Release()
        {
            Application.Idle -= ProcessFrame;
            capture.Release();
            frame.Dispose();
        }
    }
}