internal struct ValueStringBuilder // TypeDefIndex: 18606
{
	// Fields
	private char[] _arrayToReturnToPool; // 0x0
	private Span<char> _chars; // 0x8
	private int _pos; // 0x18

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x1AE1C90 Offset: 0x1AE0690 VA: 0x181AE1C90
	public void .ctor(Span<char> initialBuffer) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_Length() { }

	// RVA: 0x21A8B90 Offset: 0x21A7590 VA: 0x1821A8B90 Slot: 3
	public override string ToString() { }

	// RVA: 0x21A8C70 Offset: 0x21A7670 VA: 0x1821A8C70
	public bool TryCopyTo(Span<char> destination, out int charsWritten) { }

	// RVA: 0x21A89B0 Offset: 0x21A73B0 VA: 0x1821A89B0
	public void Insert(int index, char value, int count) { }

	// RVA: 0x21A86B0 Offset: 0x21A70B0 VA: 0x1821A86B0
	public void Append(char c) { }

	// RVA: 0x21A8520 Offset: 0x21A6F20 VA: 0x1821A8520
	public void Append(string s) { }

	// RVA: 0x21A8210 Offset: 0x21A6C10 VA: 0x1821A8210
	private void AppendSlow(string s) { }

	// RVA: 0x21A8440 Offset: 0x21A6E40 VA: 0x1821A8440
	public void Append(char c, int count) { }

	// RVA: 0x21A85D0 Offset: 0x21A6FD0 VA: 0x1821A85D0
	public void Append(char* value, int length) { }

	// RVA: 0x21A8360 Offset: 0x21A6D60 VA: 0x1821A8360
	public Span<char> AppendSpan(int length) { }

	// RVA: 0x21A87C0 Offset: 0x21A71C0 VA: 0x1821A87C0
	private void GrowAndAppend(char c) { }

	// RVA: 0x21A8800 Offset: 0x21A7200 VA: 0x1821A8800
	private void Grow(int requiredAdditionalCapacity) { }

	// RVA: 0x21A8720 Offset: 0x21A7120 VA: 0x1821A8720
	public void Dispose() { }
}
