public struct InternedString : IEquatable<InternedString>, IComparable<InternedString> // TypeDefIndex: 7813
{
	// Fields
	private readonly string m_StringOriginalCase; // 0x0
	private readonly string m_StringLowerCase; // 0x8

	// Properties
	public int length { get; }

	// Methods

	// RVA: 0x2785260 Offset: 0x2783C60 VA: 0x182785260
	public int get_length() { }

	// RVA: 0x27851A0 Offset: 0x2783BA0 VA: 0x1827851A0
	public void .ctor(string text) { }

	// RVA: 0x2785140 Offset: 0x2783B40 VA: 0x182785140
	public bool IsEmpty() { }

	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public string ToLower() { }

	// RVA: 0x2784FC0 Offset: 0x27839C0 VA: 0x182784FC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2785100 Offset: 0x2783B00 VA: 0x182785100 Slot: 4
	public bool Equals(InternedString other) { }

	// RVA: 0x2784FA0 Offset: 0x27839A0 VA: 0x182784FA0 Slot: 5
	public int CompareTo(InternedString other) { }

	// RVA: 0x2785110 Offset: 0x2783B10 VA: 0x182785110 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2785150 Offset: 0x2783B50 VA: 0x182785150 Slot: 3
	public override string ToString() { }

	// RVA: 0x2785100 Offset: 0x2783B00 VA: 0x182785100
	public static bool op_Equality(InternedString a, InternedString b) { }

	// RVA: 0x27852E0 Offset: 0x2783CE0 VA: 0x1827852E0
	public static bool op_Inequality(InternedString a, InternedString b) { }

	// RVA: 0x2785290 Offset: 0x2783C90 VA: 0x182785290
	public static bool op_Equality(InternedString a, string b) { }

	// RVA: 0x2785310 Offset: 0x2783D10 VA: 0x182785310
	public static bool op_Inequality(InternedString a, string b) { }

	// RVA: 0x2785270 Offset: 0x2783C70 VA: 0x182785270
	public static bool op_Equality(string a, InternedString b) { }

	// RVA: 0x27852F0 Offset: 0x2783CF0 VA: 0x1827852F0
	public static bool op_Inequality(string a, InternedString b) { }

	// RVA: 0x2785330 Offset: 0x2783D30 VA: 0x182785330
	public static bool op_LessThan(InternedString left, InternedString right) { }

	// RVA: 0x27852B0 Offset: 0x2783CB0 VA: 0x1827852B0
	public static bool op_GreaterThan(InternedString left, InternedString right) { }

	// RVA: 0x2785150 Offset: 0x2783B50 VA: 0x182785150
	public static string op_Implicit(InternedString str) { }
}
