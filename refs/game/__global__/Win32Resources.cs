internal class Win32Resources : IDisposable // TypeDefIndex: 17347
{
	// Fields
	private SafeModuleHandle _moduleHandle; // 0x10
	private const int _bufferSize = 500;

	// Methods

	// RVA: 0x1E1CC00 Offset: 0x1E1B600 VA: 0x181E1CC00
	public void .ctor(string module) { }

	// RVA: 0x1E1CAF0 Offset: 0x1E1B4F0 VA: 0x181E1CAF0
	public string LoadString(uint id) { }

	// RVA: 0x1E1C910 Offset: 0x1E1B310 VA: 0x181E1C910
	public string FormatString(uint id, string[] args) { }

	// RVA: 0x1E1C8E0 Offset: 0x1E1B2E0 VA: 0x181E1C8E0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1E1C7F0 Offset: 0x1E1B1F0 VA: 0x181E1C7F0
	private void CheckDisposed() { }

	// RVA: 0x1E1C870 Offset: 0x1E1B270 VA: 0x181E1C870 Slot: 4
	public void Dispose() { }
}
