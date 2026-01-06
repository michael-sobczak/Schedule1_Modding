public sealed class InputLanguage // TypeDefIndex: 5413
{
	// Fields
	private static InputLanguageCollection all; // 0x0
	private IntPtr handle; // 0x10
	private CultureInfo culture; // 0x18
	private string layout_name; // 0x20
	private static InputLanguage current_input; // 0x8

	// Properties
	public static InputLanguage CurrentInputLanguage { get; }
	public static InputLanguageCollection InstalledInputLanguages { get; }

	// Methods

	[MonoInternalNote("Pull Microsofts InputLanguages and enter them here")]
	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x6245E0 Offset: 0x622FE0 VA: 0x1806245E0
	internal void .ctor(IntPtr handle, CultureInfo culture, string layout_name) { }

	// RVA: 0x2349DD0 Offset: 0x23487D0 VA: 0x182349DD0
	public static InputLanguage get_CurrentInputLanguage() { }

	// RVA: 0x2349E80 Offset: 0x2348880 VA: 0x182349E80
	public static InputLanguageCollection get_InstalledInputLanguages() { }

	// RVA: 0x2349AD0 Offset: 0x23484D0 VA: 0x182349AD0
	public static InputLanguage FromCulture(CultureInfo culture) { }

	// RVA: 0x23499D0 Offset: 0x23483D0 VA: 0x1823499D0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830 Slot: 2
	public override int GetHashCode() { }
}
