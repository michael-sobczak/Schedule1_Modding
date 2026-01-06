public abstract class IntermediateLayer : MonoBehaviour // TypeDefIndex: 12727
{
	// Fields
	[CompilerGenerated]
	private TransportManager <TransportManager>k__BackingField; // 0x20

	// Properties
	public TransportManager TransportManager { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public TransportManager get_TransportManager() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_TransportManager(TransportManager value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ArraySegment<byte> HandleIncoming(ArraySegment<byte> src, bool fromServer);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ArraySegment<byte> HandleOutgoing(ArraySegment<byte> src, bool toServer);

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	internal void InitializeOnce(TransportManager manager) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}
