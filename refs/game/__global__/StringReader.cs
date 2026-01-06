public class StringReader : TextReader // TypeDefIndex: 5102
{
	// Fields
	private string _s; // 0x18
	private int _pos; // 0x20
	private int _length; // 0x24

	// Methods

	// RVA: 0x1C3D550 Offset: 0x1C3BF50 VA: 0x181C3D550
	public void .ctor(string s) { }

	// RVA: 0x1B20DF0 Offset: 0x1B1F7F0 VA: 0x181B20DF0 Slot: 7
	public override void Close() { }

	// RVA: 0x1C3CF10 Offset: 0x1C3B910 VA: 0x181C3CF10 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1C3CF60 Offset: 0x1C3B960 VA: 0x181C3CF60 Slot: 9
	public override int Peek() { }

	// RVA: 0x1C3D500 Offset: 0x1C3BF00 VA: 0x181C3D500 Slot: 10
	public override int Read() { }

	// RVA: 0x1C3D2F0 Offset: 0x1C3BCF0 VA: 0x181C3D2F0 Slot: 11
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x1C3D2A0 Offset: 0x1C3BCA0 VA: 0x181C3D2A0 Slot: 13
	public override string ReadToEnd() { }

	// RVA: 0x1C3D1A0 Offset: 0x1C3BBA0 VA: 0x181C3D1A0 Slot: 14
	public override string ReadLine() { }

	[ComVisible(False)]
	// RVA: 0x1C3CFA0 Offset: 0x1C3B9A0 VA: 0x181C3CFA0 Slot: 15
	public override Task<int> ReadAsync(char[] buffer, int index, int count) { }
}
