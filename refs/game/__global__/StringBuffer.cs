internal struct StringBuffer // TypeDefIndex: 11199
{
	// Fields
	private char[] _buffer; // 0x0
	private int _position; // 0x8

	// Properties
	public int Position { get; set; }
	public bool IsEmpty { get; }
	public char[] InternalBuffer { get; }

	// Methods

	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	public int get_Position() { }

	// RVA: 0x4975E0 Offset: 0x495FE0 VA: 0x1804975E0
	public void set_Position(int value) { }

	// RVA: 0xC246A0 Offset: 0xC230A0 VA: 0x180C246A0
	public bool get_IsEmpty() { }

	// RVA: 0x1D94100 Offset: 0x1D92B00 VA: 0x181D94100
	public void .ctor(IArrayPool<char> bufferPool, int initalSize) { }

	[NullableContext(1)]
	// RVA: 0x1D94140 Offset: 0x1D92B40 VA: 0x181D94140
	private void .ctor(char[] buffer) { }

	// RVA: 0x1D93E50 Offset: 0x1D92850 VA: 0x181D93E50
	public void Append(IArrayPool<char> bufferPool, char value) { }

	[NullableContext(1)]
	// RVA: 0x1D93F10 Offset: 0x1D92910 VA: 0x181D93F10
	public void Append(IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count) { }

	// RVA: 0x1D93FE0 Offset: 0x1D929E0 VA: 0x181D93FE0
	public void Clear(IArrayPool<char> bufferPool) { }

	// RVA: 0x1D94030 Offset: 0x1D92A30 VA: 0x181D94030
	private void EnsureSize(IArrayPool<char> bufferPool, int appendLength) { }

	[NullableContext(1)]
	// RVA: 0x1D940A0 Offset: 0x1D92AA0 VA: 0x181D940A0 Slot: 3
	public override string ToString() { }

	[NullableContext(1)]
	// RVA: 0x1D940D0 Offset: 0x1D92AD0 VA: 0x181D940D0
	public string ToString(int start, int length) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public char[] get_InternalBuffer() { }
}
