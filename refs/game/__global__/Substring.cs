internal struct Substring : IComparable<Substring>, IEquatable<Substring> // TypeDefIndex: 7852
{
	// Fields
	private readonly string m_String; // 0x0
	private readonly int m_Index; // 0x8
	private readonly int m_Length; // 0xC

	// Properties
	public bool isEmpty { get; }
	public int length { get; }
	public int index { get; }
	public char Item { get; }

	// Methods

	// RVA: 0x2794A90 Offset: 0x2793490 VA: 0x182794A90
	public bool get_isEmpty() { }

	// RVA: 0x2794980 Offset: 0x2793380 VA: 0x182794980
	public void .ctor(string str) { }

	// RVA: 0x105E790 Offset: 0x105D190 VA: 0x18105E790
	public void .ctor(string str, int index, int length) { }

	// RVA: 0x27949C0 Offset: 0x27933C0 VA: 0x1827949C0
	public void .ctor(string str, int index) { }

	// RVA: 0x2794510 Offset: 0x2792F10 VA: 0x182794510 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2794700 Offset: 0x2793100 VA: 0x182794700
	public bool Equals(string other) { }

	// RVA: 0x2794670 Offset: 0x2793070 VA: 0x182794670 Slot: 5
	public bool Equals(Substring other) { }

	// RVA: 0x2794470 Offset: 0x2792E70 VA: 0x182794470
	public bool Equals(InternedString other) { }

	// RVA: 0x27943A0 Offset: 0x2792DA0 VA: 0x1827943A0 Slot: 4
	public int CompareTo(Substring other) { }

	// RVA: 0x2794420 Offset: 0x2792E20 VA: 0x182794420
	public static int Compare(Substring left, Substring right, StringComparison comparison) { }

	// RVA: 0x2794860 Offset: 0x2793260 VA: 0x182794860
	public bool StartsWith(string str) { }

	// RVA: 0x27948F0 Offset: 0x27932F0 VA: 0x1827948F0
	public string Substr(int index = 0, int length = -1) { }

	// RVA: 0x2794920 Offset: 0x2793320 VA: 0x182794920 Slot: 3
	public override string ToString() { }

	// RVA: 0x27947B0 Offset: 0x27931B0 VA: 0x1827947B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2794670 Offset: 0x2793070 VA: 0x182794670
	public static bool op_Equality(Substring a, Substring b) { }

	// RVA: 0x2794BE0 Offset: 0x27935E0 VA: 0x182794BE0
	public static bool op_Inequality(Substring a, Substring b) { }

	// RVA: 0x2794B10 Offset: 0x2793510 VA: 0x182794B10
	public static bool op_Equality(Substring a, InternedString b) { }

	// RVA: 0x2794C70 Offset: 0x2793670 VA: 0x182794C70
	public static bool op_Inequality(Substring a, InternedString b) { }

	// RVA: 0x2794AA0 Offset: 0x27934A0 VA: 0x182794AA0
	public static bool op_Equality(InternedString a, Substring b) { }

	// RVA: 0x2794CF0 Offset: 0x27936F0 VA: 0x182794CF0
	public static bool op_Inequality(InternedString a, Substring b) { }

	// RVA: 0x2794B80 Offset: 0x2793580 VA: 0x182794B80
	public static Substring op_Implicit(string s) { }

	// RVA: 0x4975D0 Offset: 0x495FD0 VA: 0x1804975D0
	public int get_length() { }

	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	public int get_index() { }

	// RVA: 0x2794A10 Offset: 0x2793410 VA: 0x182794A10
	public char get_Item(int index) { }
}
