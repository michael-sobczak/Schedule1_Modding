public sealed class RuntimeWrappedException : Exception // TypeDefIndex: 4609
{
	// Fields
	private object _wrappedException; // 0x90

	// Properties
	public object WrappedException { get; }

	// Methods

	// RVA: 0x1B749B0 Offset: 0x1B733B0 VA: 0x181B749B0
	public void .ctor(object thrownObject) { }

	// RVA: 0x1B748B0 Offset: 0x1B732B0 VA: 0x181B748B0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B747B0 Offset: 0x1B731B0 VA: 0x181B747B0 Slot: 14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public object get_WrappedException() { }

	// RVA: 0x1B74880 Offset: 0x1B73280 VA: 0x181B74880
	internal void .ctor() { }
}
