internal class XIMCallback // TypeDefIndex: 5805
{
	// Fields
	public IntPtr client_data; // 0x10
	public XIMProc callback; // 0x18
	private GCHandle gch; // 0x20

	// Methods

	// RVA: 0x227E840 Offset: 0x227D240 VA: 0x18227E840
	public void .ctor(IntPtr clientData, XIMProc proc) { }

	// RVA: 0x227E7E0 Offset: 0x227D1E0 VA: 0x18227E7E0 Slot: 1
	protected override void Finalize() { }
}
