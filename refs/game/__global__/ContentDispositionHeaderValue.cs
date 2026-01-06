public class ContentDispositionHeaderValue : ICloneable // TypeDefIndex: 17721
{
	// Fields
	private string dispositionType; // 0x10
	private List<NameValueHeaderValue> parameters; // 0x18

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	// RVA: 0x21811E0 Offset: 0x217FBE0 VA: 0x1821811E0
	protected void .ctor(ContentDispositionHeaderValue source) { }

	// RVA: 0x21814B0 Offset: 0x217FEB0 VA: 0x1821814B0
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x2180F00 Offset: 0x217F900 VA: 0x182180F00 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x2180DD0 Offset: 0x217F7D0 VA: 0x182180DD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2180E80 Offset: 0x217F880 VA: 0x182180E80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2180F60 Offset: 0x217F960 VA: 0x182180F60 Slot: 3
	public override string ToString() { }

	// RVA: 0x2180FC0 Offset: 0x217F9C0 VA: 0x182180FC0
	public static bool TryParse(string input, out ContentDispositionHeaderValue parsedValue) { }
}
