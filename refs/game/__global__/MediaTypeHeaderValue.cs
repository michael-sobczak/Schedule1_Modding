public class MediaTypeHeaderValue : ICloneable // TypeDefIndex: 17743
{
	// Fields
	internal List<NameValueHeaderValue> parameters; // 0x10
	internal string media_type; // 0x18

	// Properties
	public string CharSet { get; set; }
	public string MediaType { get; set; }
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x218CA90 Offset: 0x218B490 VA: 0x18218CA90
	public void .ctor(string mediaType) { }

	// RVA: 0x218C7C0 Offset: 0x218B1C0 VA: 0x18218C7C0
	protected void .ctor(MediaTypeHeaderValue source) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x218CC30 Offset: 0x218B630 VA: 0x18218CC30
	public string get_CharSet() { }

	// RVA: 0x218CDE0 Offset: 0x218B7E0 VA: 0x18218CDE0
	public void set_CharSet(string value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_MediaType() { }

	// RVA: 0x218CFD0 Offset: 0x218B9D0 VA: 0x18218CFD0
	public void set_MediaType(string value) { }

	// RVA: 0x218CD60 Offset: 0x218B760 VA: 0x18218CD60
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x218C260 Offset: 0x218AC60 VA: 0x18218C260 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x218C130 Offset: 0x218AB30 VA: 0x18218C130 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x218C1E0 Offset: 0x218ABE0 VA: 0x18218C1E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x218C2C0 Offset: 0x218ACC0 VA: 0x18218C2C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x218C5E0 Offset: 0x218AFE0 VA: 0x18218C5E0
	public static bool TryParse(string input, out MediaTypeHeaderValue parsedValue) { }

	// RVA: 0x218C330 Offset: 0x218AD30 VA: 0x18218C330
	internal static Nullable<Token> TryParseMediaType(Lexer lexer, out string media) { }
}
