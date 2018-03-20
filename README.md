# FFmpegOut for SRP

This branch is a Scriptable Render Pipeline compatible version of [FFmpegOut](https://github.com/keijiro/jp.keijiro.ffmpegout).

In SRP, `OnRenderImage()` callback is not supported. So FFmpegOut does not work.

This branch includes a custom post-processing stack v2 effect for FFmpegOut to capture frame buffer.

## How to use

Setup `CameraCapture` component by following [FFmpegOut document](https://github.com/keijiro/FFmpegOut), then add `Custom/Camera Capture` effect to your post-processing profile.

<img width="322" alt="2018-03-20 16 27 03" src="https://user-images.githubusercontent.com/1482297/37641058-9fb0c776-2c5b-11e8-9ea2-24f8991ee4c8.png">

## Known Issues

 - FXAA is not renderered. Because PPSv2 is not supported an injection point after final pass.
