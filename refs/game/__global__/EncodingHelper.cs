internal static class EncodingHelper // TypeDefIndex: 4144
{
	// Fields
	private static Encoding utf8EncodingWithoutMarkers; // 0x0
	private static readonly object lockobj; // 0x8
	private static Assembly i18nAssembly; // 0x10
	private static bool i18nDisabled; // 0x18

	// Properties
	internal static Encoding UTF8Unmarked { get; }

	// Methods

	// RVA: 0x1ACDFE0 Offset: 0x1ACC9E0 VA: 0x181ACDFE0
	internal static Encoding get_UTF8Unmarked() { }

	// RVA: 0x1ACD9D0 Offset: 0x1ACC3D0 VA: 0x181ACD9D0
	internal static string InternalCodePage(ref int code_page) { }

	// RVA: 0x1ACD8C0 Offset: 0x1ACC2C0 VA: 0x181ACD8C0
	internal static Encoding GetDefaultEncoding() { }

	// RVA: 0x1ACD9E0 Offset: 0x1ACC3E0 VA: 0x181ACD9E0
	internal static object InvokeI18N(string name, object[] args) { }

	// RVA: 0x1ACDF60 Offset: 0x1ACC960 VA: 0x181ACDF60
	private static void .cctor() { }
}
