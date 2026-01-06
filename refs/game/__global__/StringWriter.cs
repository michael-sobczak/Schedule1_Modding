public class StringWriter : TextWriter // TypeDefIndex: 5103
{
	// Fields
	private static UnicodeEncoding m_encoding; // 0x0
	private StringBuilder _sb; // 0x30
	private bool _isOpen; // 0x38

	// Properties
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x1C3DBC0 Offset: 0x1C3C5C0 VA: 0x181C3DBC0
	public void .ctor() { }

	// RVA: 0x1C3DDF0 Offset: 0x1C3C7F0 VA: 0x181C3DDF0
	public void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x1C3DF10 Offset: 0x1C3C910 VA: 0x181C3DF10
	public void .ctor(StringBuilder sb) { }

	// RVA: 0x1C3DD00 Offset: 0x1C3C700 VA: 0x181C3DD00
	public void .ctor(StringBuilder sb, IFormatProvider formatProvider) { }

	// RVA: 0x1C3D610 Offset: 0x1C3C010 VA: 0x181C3D610 Slot: 8
	public override void Close() { }

	// RVA: 0x1C3D630 Offset: 0x1C3C030 VA: 0x181C3D630 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1C3E030 Offset: 0x1C3CA30 VA: 0x181C3E030 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x1C3DB90 Offset: 0x1C3C590 VA: 0x181C3DB90 Slot: 13
	public override void Write(char value) { }

	// RVA: 0x1C3D960 Offset: 0x1C3C360 VA: 0x181C3D960 Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1C3DB50 Offset: 0x1C3C550 VA: 0x181C3DB50 Slot: 16
	public override void Write(string value) { }

	[ComVisible(False)]
	// RVA: 0x1C3D7E0 Offset: 0x1C3C1E0 VA: 0x181C3D7E0 Slot: 25
	public override Task WriteAsync(char value) { }

	[ComVisible(False)]
	// RVA: 0x1C3D8A0 Offset: 0x1C3C2A0 VA: 0x181C3D8A0 Slot: 26
	public override Task WriteAsync(string value) { }

	[ComVisible(False)]
	// RVA: 0x1C3D700 Offset: 0x1C3C100 VA: 0x181C3D700 Slot: 27
	public override Task WriteAsync(char[] buffer, int index, int count) { }

	[ComVisible(False)]
	// RVA: 0x1C3D640 Offset: 0x1C3C040 VA: 0x181C3D640 Slot: 28
	public override Task FlushAsync() { }

	// RVA: 0x1C3D6D0 Offset: 0x1C3C0D0 VA: 0x181C3D6D0 Slot: 3
	public override string ToString() { }
}
