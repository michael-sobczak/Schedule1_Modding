public abstract class StringComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 3725
{
	// Fields
	private static readonly CultureAwareComparer s_invariantCulture; // 0x0
	private static readonly CultureAwareComparer s_invariantCultureIgnoreCase; // 0x8
	private static readonly OrdinalCaseSensitiveComparer s_ordinal; // 0x10
	private static readonly OrdinalIgnoreCaseComparer s_ordinalIgnoreCase; // 0x18

	// Properties
	public static StringComparer InvariantCultureIgnoreCase { get; }
	public static StringComparer CurrentCultureIgnoreCase { get; }
	public static StringComparer Ordinal { get; }
	public static StringComparer OrdinalIgnoreCase { get; }

	// Methods

	// RVA: 0x1C88E10 Offset: 0x1C87810 VA: 0x181C88E10
	public static StringComparer get_InvariantCultureIgnoreCase() { }

	// RVA: 0x1C88D80 Offset: 0x1C87780 VA: 0x181C88D80
	public static StringComparer get_CurrentCultureIgnoreCase() { }

	// RVA: 0x1C88EB0 Offset: 0x1C878B0 VA: 0x181C88EB0
	public static StringComparer get_Ordinal() { }

	// RVA: 0x1C88E60 Offset: 0x1C87860 VA: 0x181C88E60
	public static StringComparer get_OrdinalIgnoreCase() { }

	// RVA: 0x1C888E0 Offset: 0x1C872E0 VA: 0x181C888E0
	public static StringComparer Create(CultureInfo culture, bool ignoreCase) { }

	// RVA: 0x1C88770 Offset: 0x1C87170 VA: 0x181C88770 Slot: 4
	public int Compare(object x, object y) { }

	// RVA: 0x1C889A0 Offset: 0x1C873A0 VA: 0x181C889A0 Slot: 5
	public bool Equals(object x, object y) { }

	// RVA: 0x1C88A80 Offset: 0x1C87480 VA: 0x181C88A80 Slot: 6
	public int GetHashCode(object obj) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int Compare(string x, string y);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool Equals(string x, string y);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int GetHashCode(string obj);

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x1C88B60 Offset: 0x1C87560 VA: 0x181C88B60
	private static void .cctor() { }
}
