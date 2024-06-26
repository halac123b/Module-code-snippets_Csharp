using System;
using NAudio.CoreAudioApi;

// Main features:
/// Direct access to Windows Core Audio APIs: control device and stream

// Note: Tuy chạy đc với .NET nhưng code này (maybe) k chạy đc bên Unity
/// Bởi này access các API low level của Windows, và Unity k cho phép
public class NAudioCoreAudioApi
{
  private void PrintSpeakerDevices()
  {
    // Multimedia Device Enumerator
    MMDeviceEnumerator enumerator = new();

    // Lọc và lấy ra list các device:
    /// DataFlow.Render: output âm thanh
    /// DeviceState.Active: trạng thái đang hoạt động
    MMDeviceCollection devices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);

    foreach (MMDevice device in devices)
    {
      Console.WriteLine($"Device: {device.FriendlyName}");
    }
  }
}