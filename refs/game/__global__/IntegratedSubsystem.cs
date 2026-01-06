public class IntegratedSubsystem : ISubsystem // TypeDefIndex: 19134
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal ISubsystemDescriptor m_SubsystemDescriptor; // 0x18

	// Properties
	public bool running { get; }
	internal bool valid { get; }

	// Methods

	// RVA: 0x2D43A00 Offset: 0x2D42400 VA: 0x182D43A00
	internal void SetHandle(IntegratedSubsystem subsystem) { }

	// RVA: 0x2D43A50 Offset: 0x2D42450 VA: 0x182D43A50 Slot: 4
	public bool get_running() { }

	// RVA: 0x2D43AB0 Offset: 0x2D424B0 VA: 0x182D43AB0
	internal bool get_valid() { }

	// RVA: 0x2D439C0 Offset: 0x2D423C0 VA: 0x182D439C0
	internal bool IsRunning() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
