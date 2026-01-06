public sealed class KeySizes // TypeDefIndex: 4187
{
	// Fields
	private int m_minSize; // 0x10
	private int m_maxSize; // 0x14
	private int m_skipSize; // 0x18

	// Properties
	public int MinSize { get; }
	public int MaxSize { get; }
	public int SkipSize { get; }

	// Methods

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_MinSize() { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public int get_MaxSize() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_SkipSize() { }

	// RVA: 0x5BD610 Offset: 0x5BC010 VA: 0x1805BD610
	public void .ctor(int minSize, int maxSize, int skipSize) { }

	// RVA: 0x1AE7090 Offset: 0x1AE5A90 VA: 0x181AE7090
	internal bool IsLegal(int keySize) { }

	// RVA: 0x1AE7000 Offset: 0x1AE5A00 VA: 0x181AE7000
	internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size) { }
}
