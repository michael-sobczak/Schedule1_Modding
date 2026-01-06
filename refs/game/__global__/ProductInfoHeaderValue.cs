public class ProductInfoHeaderValue : ICloneable // TypeDefIndex: 17760
{
	// Fields
	[CompilerGenerated]
	private string <Comment>k__BackingField; // 0x10
	[CompilerGenerated]
	private ProductHeaderValue <Product>k__BackingField; // 0x18

	// Properties
	public string Comment { get; set; }
	public ProductHeaderValue Product { get; set; }

	// Methods

	// RVA: 0x2191330 Offset: 0x218FD30 VA: 0x182191330
	public void .ctor(ProductHeaderValue product) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Comment() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_Comment(string value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public ProductHeaderValue get_Product() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_Product(ProductHeaderValue value) { }

	// RVA: 0x1BBF180 Offset: 0x1BBDB80 VA: 0x181BBF180 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x2190D40 Offset: 0x218F740 VA: 0x182190D40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2190DF0 Offset: 0x218F7F0 VA: 0x182190DF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2191150 Offset: 0x218FB50 VA: 0x182191150
	internal static bool TryParse(string input, int minimalCount, out List<ProductInfoHeaderValue> result) { }

	// RVA: 0x2190E60 Offset: 0x218F860 VA: 0x182190E60
	private static bool TryParseElement(Lexer lexer, out ProductInfoHeaderValue parsedValue) { }

	// RVA: 0x2190E30 Offset: 0x218F830 VA: 0x182190E30 Slot: 3
	public override string ToString() { }
}
