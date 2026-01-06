public class BinaryReader : IDisposable // TypeDefIndex: 5100
{
	// Fields
	private Stream m_stream; // 0x10
	private byte[] m_buffer; // 0x18
	private Decoder m_decoder; // 0x20
	private byte[] m_charBytes; // 0x28
	private char[] m_singleChar; // 0x30
	private char[] m_charBuffer; // 0x38
	private int m_maxCharsSize; // 0x40
	private bool m_2BytesPerChar; // 0x44
	private bool m_isMemoryStream; // 0x45
	private bool m_leaveOpen; // 0x46

	// Properties
	public virtual Stream BaseStream { get; }

	// Methods

	// RVA: 0x1C25300 Offset: 0x1C23D00 VA: 0x181C25300
	public void .ctor(Stream input) { }

	// RVA: 0x1C25380 Offset: 0x1C23D80 VA: 0x181C25380
	public void .ctor(Stream input, Encoding encoding) { }

	// RVA: 0x1C25030 Offset: 0x1C23A30 VA: 0x181C25030
	public void .ctor(Stream input, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 5
	public virtual Stream get_BaseStream() { }

	// RVA: 0x95E000 Offset: 0x95CA00 VA: 0x18095E000 Slot: 6
	public virtual void Close() { }

	// RVA: 0x1C237A0 Offset: 0x1C221A0 VA: 0x181C237A0 Slot: 7
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x95E000 Offset: 0x95CA00 VA: 0x18095E000 Slot: 4
	public void Dispose() { }

	// RVA: 0x1C24010 Offset: 0x1C22A10 VA: 0x181C24010 Slot: 8
	public virtual int PeekChar() { }

	// RVA: 0x1C24E20 Offset: 0x1C23820 VA: 0x181C24E20 Slot: 9
	public virtual int Read() { }

	// RVA: 0x1C24180 Offset: 0x1C22B80 VA: 0x181C24180 Slot: 10
	public virtual bool ReadBoolean() { }

	// RVA: 0x1C241D0 Offset: 0x1C22BD0 VA: 0x181C241D0 Slot: 11
	public virtual byte ReadByte() { }

	[CLSCompliant(False)]
	// RVA: 0x1C249A0 Offset: 0x1C233A0 VA: 0x181C249A0 Slot: 12
	public virtual sbyte ReadSByte() { }

	// RVA: 0x1C243C0 Offset: 0x1C22DC0 VA: 0x181C243C0 Slot: 13
	public virtual char ReadChar() { }

	// RVA: 0x1C246F0 Offset: 0x1C230F0 VA: 0x181C246F0 Slot: 14
	public virtual short ReadInt16() { }

	[CLSCompliant(False)]
	// RVA: 0x1C246F0 Offset: 0x1C230F0 VA: 0x181C246F0 Slot: 15
	public virtual ushort ReadUInt16() { }

	// RVA: 0x1C24750 Offset: 0x1C23150 VA: 0x181C24750 Slot: 16
	public virtual int ReadInt32() { }

	[CLSCompliant(False)]
	// RVA: 0x1C24DA0 Offset: 0x1C237A0 VA: 0x181C24DA0 Slot: 17
	public virtual uint ReadUInt32() { }

	// RVA: 0x1C24880 Offset: 0x1C23280 VA: 0x181C24880 Slot: 18
	public virtual long ReadInt64() { }

	[CLSCompliant(False)]
	// RVA: 0x1C24880 Offset: 0x1C23280 VA: 0x181C24880 Slot: 19
	public virtual ulong ReadUInt64() { }

	// RVA: 0x1C249F0 Offset: 0x1C233F0 VA: 0x181C249F0 Slot: 20
	public virtual float ReadSingle() { }

	// RVA: 0x1C246B0 Offset: 0x1C230B0 VA: 0x181C246B0 Slot: 21
	public virtual double ReadDouble() { }

	// RVA: 0x1C24570 Offset: 0x1C22F70 VA: 0x181C24570 Slot: 22
	public virtual Decimal ReadDecimal() { }

	// RVA: 0x1C24A30 Offset: 0x1C23430 VA: 0x181C24A30 Slot: 23
	public virtual string ReadString() { }

	// RVA: 0x1C239D0 Offset: 0x1C223D0 VA: 0x181C239D0
	private int InternalReadChars(char[] buffer, int index, int count) { }

	// RVA: 0x1C23D60 Offset: 0x1C22760 VA: 0x181C23D60
	private int InternalReadOneChar() { }

	// RVA: 0x1C243F0 Offset: 0x1C22DF0 VA: 0x181C243F0 Slot: 24
	public virtual char[] ReadChars(int count) { }

	// RVA: 0x1C24E40 Offset: 0x1C23840 VA: 0x181C24E40 Slot: 25
	public virtual int Read(byte[] buffer, int index, int count) { }

	// RVA: 0x1C24210 Offset: 0x1C22C10 VA: 0x181C24210 Slot: 26
	public virtual byte[] ReadBytes(int count) { }

	// RVA: 0x1C23860 Offset: 0x1C22260 VA: 0x181C23860 Slot: 27
	protected virtual void FillBuffer(int numBytes) { }

	// RVA: 0x1C240D0 Offset: 0x1C22AD0 VA: 0x181C240D0
	protected internal int Read7BitEncodedInt() { }
}
