internal class ThreadControlQueue // TypeDefIndex: 13189
{
	// Fields
	private Path head; // 0x10
	private Path tail; // 0x18
	private readonly object lockObj; // 0x20
	private readonly int numReceivers; // 0x28
	private bool blocked; // 0x2C
	private int blockedReceivers; // 0x30
	private bool starving; // 0x34
	private bool terminate; // 0x35
	private ManualResetEvent block; // 0x38

	// Properties
	public bool IsEmpty { get; }
	public bool IsTerminating { get; }
	public bool AllReceiversBlocked { get; }

	// Methods

	// RVA: 0xB2C750 Offset: 0xB2B150 VA: 0x180B2C750
	public void .ctor(int numReceivers) { }

	// RVA: 0xB2C8B0 Offset: 0xB2B2B0 VA: 0x180B2C8B0
	public bool get_IsEmpty() { }

	// RVA: 0x660940 Offset: 0x65F340 VA: 0x180660940
	public bool get_IsTerminating() { }

	// RVA: 0xB2BB50 Offset: 0xB2A550 VA: 0x180B2BB50
	public void Block() { }

	// RVA: 0xB2C6A0 Offset: 0xB2B0A0 VA: 0x180B2C6A0
	public void Unblock() { }

	// RVA: 0xB2BBF0 Offset: 0xB2A5F0 VA: 0x180B2BBF0
	public void Lock() { }

	// RVA: 0xB2C740 Offset: 0xB2B140 VA: 0x180B2C740
	public void Unlock() { }

	// RVA: 0xB2C800 Offset: 0xB2B200 VA: 0x180B2C800
	public bool get_AllReceiversBlocked() { }

	// RVA: 0xB2C2F0 Offset: 0xB2ACF0 VA: 0x180B2C2F0
	public void PushFront(Path path) { }

	// RVA: 0xB2C450 Offset: 0xB2AE50 VA: 0x180B2C450
	public void Push(Path path) { }

	// RVA: 0xB2C5D0 Offset: 0xB2AFD0 VA: 0x180B2C5D0
	private void Starving() { }

	// RVA: 0xB2C600 Offset: 0xB2B000 VA: 0x180B2C600
	public void TerminateReceivers() { }

	// RVA: 0xB2BF40 Offset: 0xB2A940 VA: 0x180B2BF40
	public Path Pop() { }

	// RVA: 0xB2C5A0 Offset: 0xB2AFA0 VA: 0x180B2C5A0
	public void ReceiverTerminated() { }

	// RVA: 0xB2BC00 Offset: 0xB2A600 VA: 0x180B2BC00
	public Path PopNoBlock(bool blockedBefore) { }
}
