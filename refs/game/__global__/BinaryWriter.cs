public class BinaryWriter : IDisposable // TypeDefIndex: 5101
{
	// Fields
	public static readonly BinaryWriter Null; // 0x0
	protected Stream OutStream; // 0x10
	private byte[] _buffer; // 0x18
	private Encoding _encoding; // 0x20
	private Encoder _encoder; // 0x28
	[OptionalField]
	private bool _leaveOpen; // 0x30
	private byte[] _largeByteBuffer; // 0x38
	private int _maxChars; // 0x40

	// Properties
	public virtual Stream BaseStream { get; }

	// Methods

	// RVA: 0x1C26270 Offset: 0x1C24C70 VA: 0x181C26270
	protected void .ctor() { }

	// RVA: 0x1C26570 Offset: 0x1C24F70 VA: 0x181C26570
	public void .ctor(Stream output) { }

	// RVA: 0x1C26250 Offset: 0x1C24C50 VA: 0x181C26250
	public void .ctor(Stream output, Encoding encoding) { }

	// RVA: 0x1C26380 Offset: 0x1C24D80 VA: 0x181C26380
	public void .ctor(Stream output, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x10F5FF0 Offset: 0x10F49F0 VA: 0x1810F5FF0 Slot: 5
	public virtual void Close() { }

	// RVA: 0x1C253A0 Offset: 0x1C23DA0 VA: 0x181C253A0 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x10F5FF0 Offset: 0x10F49F0 VA: 0x1810F5FF0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1C265F0 Offset: 0x1C24FF0 VA: 0x181C265F0 Slot: 7
	public virtual Stream get_BaseStream() { }

	// RVA: 0x1BF73E0 Offset: 0x1BF5DE0 VA: 0x181BF73E0 Slot: 8
	public virtual void Flush() { }

	// RVA: 0x1C25B90 Offset: 0x1C24590 VA: 0x181C25B90 Slot: 9
	public virtual void Write(bool value) { }

	// RVA: 0x1C259B0 Offset: 0x1C243B0 VA: 0x181C259B0 Slot: 10
	public virtual void Write(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1C259B0 Offset: 0x1C243B0 VA: 0x181C259B0 Slot: 11
	public virtual void Write(sbyte value) { }

	// RVA: 0x1C259E0 Offset: 0x1C243E0 VA: 0x181C259E0 Slot: 12
	public virtual void Write(byte[] buffer) { }

	// RVA: 0x1C26010 Offset: 0x1C24A10 VA: 0x181C26010 Slot: 13
	public virtual void Write(byte[] buffer, int index, int count) { }

	// RVA: 0x1C25EA0 Offset: 0x1C248A0 VA: 0x181C25EA0 Slot: 14
	public virtual void Write(char ch) { }

	// RVA: 0x1C25A70 Offset: 0x1C24470 VA: 0x181C25A70 Slot: 15
	public virtual void Write(char[] chars) { }

	// RVA: 0x1C25DA0 Offset: 0x1C247A0 VA: 0x181C25DA0 Slot: 16
	public virtual void Write(double value) { }

	// RVA: 0x1C25800 Offset: 0x1C24200 VA: 0x181C25800 Slot: 17
	public virtual void Write(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1C25D30 Offset: 0x1C24730 VA: 0x181C25D30 Slot: 18
	public virtual void Write(ushort value) { }

	// RVA: 0x1C25DF0 Offset: 0x1C247F0 VA: 0x181C25DF0 Slot: 19
	public virtual void Write(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1C26040 Offset: 0x1C24A40 VA: 0x181C26040 Slot: 20
	public virtual void Write(uint value) { }

	// RVA: 0x1C25BF0 Offset: 0x1C245F0 VA: 0x181C25BF0 Slot: 21
	public virtual void Write(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1C25870 Offset: 0x1C24270 VA: 0x181C25870 Slot: 22
	public virtual void Write(ulong value) { }

	// RVA: 0x1C25B40 Offset: 0x1C24540 VA: 0x181C25B40 Slot: 23
	public virtual void Write(float value) { }

	// RVA: 0x1C25470 Offset: 0x1C23E70 VA: 0x181C25470 Slot: 24
	public virtual void Write(string value) { }

	// RVA: 0x1C25400 Offset: 0x1C23E00 VA: 0x181C25400
	protected void Write7BitEncodedInt(int value) { }

	// RVA: 0x1C260F0 Offset: 0x1C24AF0 VA: 0x181C260F0
	private static void .cctor() { }
}
