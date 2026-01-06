public abstract class MessageBase // TypeDefIndex: 17523
{
	// Fields
	private static byte[] header; // 0x0
	private int _type; // 0x10
	private NtlmFlags _flags; // 0x14

	// Properties
	public NtlmFlags Flags { get; set; }
	public int Type { get; }

	// Methods

	// RVA: 0x445F80 Offset: 0x444980 VA: 0x180445F80
	protected void .ctor(int messageType) { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public NtlmFlags get_Flags() { }

	// RVA: 0x65C890 Offset: 0x65B290 VA: 0x18065C890
	public void set_Flags(NtlmFlags value) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_Type() { }

	// RVA: 0x1A79B60 Offset: 0x1A78560 VA: 0x181A79B60
	protected byte[] PrepareMessage(int messageSize) { }

	// RVA: 0x1A798E0 Offset: 0x1A782E0 VA: 0x181A798E0 Slot: 4
	protected virtual void Decode(byte[] message) { }

	// RVA: 0x1A797D0 Offset: 0x1A781D0 VA: 0x181A797D0
	protected bool CheckHeader(byte[] message) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract byte[] GetBytes();

	// RVA: 0x1A79C50 Offset: 0x1A78650 VA: 0x181A79C50
	private static void .cctor() { }
}
