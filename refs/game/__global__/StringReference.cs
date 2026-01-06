internal struct StringReference // TypeDefIndex: 11200
{
	// Fields
	private readonly char[] _chars; // 0x0
	private readonly int _startIndex; // 0x8
	private readonly int _length; // 0xC

	// Properties
	public char Item { get; }
	public char[] Chars { get; }
	public int StartIndex { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x1D94350 Offset: 0x1D92D50 VA: 0x181D94350
	public char get_Item(int i) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public char[] get_Chars() { }

	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	public int get_StartIndex() { }

	// RVA: 0x4975D0 Offset: 0x495FD0 VA: 0x1804975D0
	public int get_Length() { }

	// RVA: 0x105E790 Offset: 0x105D190 VA: 0x18105E790
	public void .ctor(char[] chars, int startIndex, int length) { }

	// RVA: 0x1D94320 Offset: 0x1D92D20 VA: 0x181D94320 Slot: 3
	public override string ToString() { }
}
