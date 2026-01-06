internal class Charcode // TypeDefIndex: 5199
{
	// Fields
	private StandardCharCode[] codes; // 0x10
	private Hashtable reverse; // 0x18
	private int size; // 0x20
	private static Charcode ansi_generic; // 0x0

	// Properties
	public StandardCharCode Item { get; set; }
	public static Charcode AnsiGeneric { get; }
	public static Charcode AnsiSymbol { get; }

	// Methods

	// RVA: 0x21A9E10 Offset: 0x21A8810 VA: 0x1821A9E10
	private void .ctor(int size) { }

	// RVA: 0x21ACA00 Offset: 0x21AB400 VA: 0x1821ACA00
	public StandardCharCode get_Item(int c) { }

	// RVA: 0x21ACA40 Offset: 0x21AB440 VA: 0x1821ACA40
	private void set_Item(int c, StandardCharCode value) { }

	// RVA: 0x21A9EC0 Offset: 0x21A88C0 VA: 0x1821A9EC0
	public static Charcode get_AnsiGeneric() { }

	// RVA: 0x21AC170 Offset: 0x21AAB70 VA: 0x1821AC170
	public static Charcode get_AnsiSymbol() { }
}
