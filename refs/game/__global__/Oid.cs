public sealed class Oid // TypeDefIndex: 9606
{
	// Fields
	private string _value; // 0x10
	private string _friendlyName; // 0x18
	private OidGroup _group; // 0x20

	// Properties
	public string Value { get; set; }
	public string FriendlyName { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x262E9B0 Offset: 0x262D3B0 VA: 0x18262E9B0
	public void .ctor(string oid) { }

	// RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	public void .ctor(string value, string friendlyName) { }

	// RVA: 0x262E910 Offset: 0x262D310 VA: 0x18262E910
	public void .ctor(Oid oid) { }

	// RVA: 0x262E7A0 Offset: 0x262D1A0 VA: 0x18262E7A0
	public static Oid FromOidValue(string oidValue, OidGroup group) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Value() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Value(string value) { }

	// RVA: 0x262EA40 Offset: 0x262D440 VA: 0x18262EA40
	public string get_FriendlyName() { }

	// RVA: 0x6CAD40 Offset: 0x6C9740 VA: 0x1806CAD40
	private void .ctor(string value, string friendlyName, OidGroup group) { }
}
