internal abstract class AsyncReadOrWriteRequest : AsyncProtocolRequest // TypeDefIndex: 9391
{
	// Fields
	[CompilerGenerated]
	private readonly BufferOffsetSize <UserBuffer>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <CurrentSize>k__BackingField; // 0x40

	// Properties
	protected BufferOffsetSize UserBuffer { get; }
	protected int CurrentSize { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	protected BufferOffsetSize get_UserBuffer() { }

	[CompilerGenerated]
	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	protected int get_CurrentSize() { }

	[CompilerGenerated]
	// RVA: 0x4E28B0 Offset: 0x4E12B0 VA: 0x1804E28B0
	protected void set_CurrentSize(int value) { }

	// RVA: 0x200E6C0 Offset: 0x200D0C0 VA: 0x18200E6C0
	public void .ctor(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	// RVA: 0x200E650 Offset: 0x200D050 VA: 0x18200E650 Slot: 3
	public override string ToString() { }
}
