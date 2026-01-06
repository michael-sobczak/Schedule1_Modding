public sealed class SecureString : IDisposable // TypeDefIndex: 4153
{
	// Fields
	private int length; // 0x10
	private bool disposed; // 0x14
	private byte[] data; // 0x18

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x1AD7190 Offset: 0x1AD5B90 VA: 0x181AD7190
	public void .ctor() { }

	[CLSCompliant(False)]
	// RVA: 0x1AD7010 Offset: 0x1AD5A10 VA: 0x181AD7010
	public void .ctor(char* value, int length) { }

	// RVA: 0x1AD71F0 Offset: 0x1AD5BF0 VA: 0x181AD71F0
	public int get_Length() { }

	// RVA: 0x1AD6F00 Offset: 0x1AD5900 VA: 0x181AD6F00 Slot: 4
	public void Dispose() { }

	// RVA: 0x9F93E0 Offset: 0x9F7DE0 VA: 0x1809F93E0
	private void Encrypt() { }

	// RVA: 0x9F93E0 Offset: 0x9F7DE0 VA: 0x1809F93E0
	private void Decrypt() { }

	// RVA: 0x1AD6D40 Offset: 0x1AD5740 VA: 0x181AD6D40
	private void Alloc(int length, bool realloc) { }

	// RVA: 0x1AD6F60 Offset: 0x1AD5960 VA: 0x181AD6F60
	internal byte[] GetBuffer() { }
}
