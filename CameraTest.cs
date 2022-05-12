using System;
using System.Threading;
using System.Threading.Tasks;
using MMALSharp;
using MMALSharp.Common;
using MMALSharp.Handlers;

namespace CatToyTestApp
{
    public class CameraTest
    {
        MMALCamera cam = MMALCamera.Instance;

        public async Task TakePicture()
        {
            using (var imgCaptureHandler = new ImageStreamCaptureHandler("/home/pi/images/", "jpg"))
            {
                await cam.TakePicture(imgCaptureHandler, MMALEncoding.JPEG, MMALEncoding.I420);
            }

     
            cam.Cleanup();
        }

        public async Task TakeVideo()
        {
            using (var vidCaptureHandler = new VideoStreamCaptureHandler("/home/pi/videos/", "avi"))
            {
                var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

                await cam.TakeVideo(vidCaptureHandler, cts.Token);
            }

           
            cam.Cleanup();
        }
    }
}
