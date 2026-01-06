internal class AnimateEventArgs : EventArgs // TypeDefIndex: 17157
{
	// Fields
	private int frameCount; // 0x10
	private int activeFrame; // 0x14
	private Thread thread; // 0x18

	// Properties
	public Thread RunThread { get; set; }

	// Methods

	// RVA: 0x214F250 Offset: 0x214DC50 VA: 0x18214F250
	public void .ctor(Image image) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Thread get_RunThread() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_RunThread(Thread value) { }

	// RVA: 0x214F230 Offset: 0x214DC30 VA: 0x18214F230
	public int GetNextFrame() { }
}
