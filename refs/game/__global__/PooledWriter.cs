public sealed class PooledWriter : Writer, IDisposable // TypeDefIndex: 12512
{
	// Methods

	// RVA: 0xD167F0 Offset: 0xD151F0 VA: 0x180D167F0
	public void Store() { }

	// RVA: 0xD167A0 Offset: 0xD151A0 VA: 0x180D167A0
	public void StoreLength() { }

	[Obsolete("Use Store().")]
	// RVA: 0xD167F0 Offset: 0xD151F0 VA: 0x180D167F0 Slot: 4
	public void Dispose() { }

	[Obsolete("Use StoreLength().")]
	// RVA: 0xD167A0 Offset: 0xD151A0 VA: 0x180D167A0
	public void DisposeLength() { }

	// RVA: 0xD16840 Offset: 0xD15240 VA: 0x180D16840
	public void .ctor() { }
}
