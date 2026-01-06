public sealed class TlsException : Exception // TypeDefIndex: 17543
{
	// Fields
	private Alert alert; // 0x90

	// Methods

	// RVA: 0x1A80C10 Offset: 0x1A7F610 VA: 0x181A80C10
	public void .ctor(Alert alert) { }

	// RVA: 0x1A80A50 Offset: 0x1A7F450 VA: 0x181A80A50
	public void .ctor(Alert alert, string message) { }

	// RVA: 0x1A80B50 Offset: 0x1A7F550 VA: 0x181A80B50
	public void .ctor(AlertDescription description) { }

	// RVA: 0x1A80AD0 Offset: 0x1A7F4D0 VA: 0x181A80AD0
	public void .ctor(AlertDescription description, string message) { }
}
