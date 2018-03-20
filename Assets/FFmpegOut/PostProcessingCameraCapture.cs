using System;
using UnityEngine.Rendering.PostProcessing;

namespace FFmpegOut
{
    [Serializable]
    [PostProcess(typeof(PostProcessingCameraCaptureRenderer), PostProcessEvent.AfterStack, "Custom/Camera Capture", false)]
    public class PostProcessingCameraCapture : PostProcessEffectSettings
    {
    }

    public class PostProcessingCameraCaptureRenderer : PostProcessEffectRenderer<PostProcessingCameraCapture>
    {
        public override void Render(PostProcessRenderContext ctx)
        {
            var capture = ctx.camera.GetComponent<CameraCapture>();
            if (capture != null)
            {
                capture.Render(ctx);
            }
        }
    }
}