using System;
using System.Collections.Generic;
using NAudio.Wave;

// Main features:
/// Record, play audio
/// Manage audio device
public class NAudioWave
{
  private int _numberDevices;
  private List<string> _audioDevices = new();

  private List<string> GetListDevice()
  {
    // WaveOut: class tương tác với sound output
    // Get số device có thể output đc sound
    _numberDevices = WaveOut.DeviceCount;

    for (int i = 0; i < _numberDevices; i++)
    {
      // Get thông số của từng device dựa vào index trong list
      WaveOutCapabilities capabilities = WaveOut.GetCapabilities(i);
      // Get tên device từ WaveOutCapabilities
      /// Warning: tên này chỉ tối đa 32 kí tự, nếu dài hơn sẽ bị cắt bớt
      Console.WriteLine($"Device {i}: {capabilities.ProductName}");
      _audioDevices.Add(capabilities.ProductName);
    }

    return _audioDevices;
  }
}