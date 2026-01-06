internal abstract class PlatformMimeIconHandler // TypeDefIndex: 5512
{
	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract MimeExtensionHandlerStatus Start();

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 5
	public virtual object AddAndGetIconIndex(string filename, string mime_type) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	public virtual object AddAndGetIconIndex(string mime_type) { }
}
