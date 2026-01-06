public struct NameAndParameters // TypeDefIndex: 7824
{
	// Fields
	[CompilerGenerated]
	private string <name>k__BackingField; // 0x0
	[CompilerGenerated]
	private ReadOnlyArray<NamedValue> <parameters>k__BackingField; // 0x8

	// Properties
	public string name { get; set; }
	public ReadOnlyArray<NamedValue> parameters { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public string get_name() { }

	[CompilerGenerated]
	// RVA: 0x48A530 Offset: 0x488F30 VA: 0x18048A530
	public void set_name(string value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x46EE40 Offset: 0x46D840 VA: 0x18046EE40
	public ReadOnlyArray<NamedValue> get_parameters() { }

	[CompilerGenerated]
	// RVA: 0x278EEA0 Offset: 0x278D8A0 VA: 0x18278EEA0
	public void set_parameters(ReadOnlyArray<NamedValue> value) { }

	// RVA: 0x278ECB0 Offset: 0x278D6B0 VA: 0x18278ECB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x278E360 Offset: 0x278CD60 VA: 0x18278E360
	public static IEnumerable<NameAndParameters> ParseMultiple(string text) { }

	// RVA: 0x278E5E0 Offset: 0x278CFE0 VA: 0x18278E5E0
	internal static bool ParseMultiple(string text, ref List<NameAndParameters> list) { }

	// RVA: 0x278EB90 Offset: 0x278D590 VA: 0x18278EB90
	internal static string ParseName(string text) { }

	// RVA: 0x278EC20 Offset: 0x278D620 VA: 0x18278EC20
	public static NameAndParameters Parse(string text) { }

	// RVA: 0x278E7C0 Offset: 0x278D1C0 VA: 0x18278E7C0
	private static NameAndParameters ParseNameAndParameters(string text, ref int index, bool nameOnly = False) { }
}
