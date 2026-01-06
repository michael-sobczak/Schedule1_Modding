public class Claim // TypeDefIndex: 4264
{
	// Fields
	private string m_issuer; // 0x10
	private string m_originalIssuer; // 0x18
	private string m_type; // 0x20
	private string m_value; // 0x28
	private string m_valueType; // 0x30
	private byte[] m_userSerializationData; // 0x38
	private Dictionary<string, string> m_properties; // 0x40
	private object m_propertyLock; // 0x48
	private ClaimsIdentity m_subject; // 0x50

	// Properties
	public IDictionary<string, string> Properties { get; }
	public ClaimsIdentity Subject { get; set; }
	public string Type { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1B04420 Offset: 0x1B02E20 VA: 0x181B04420
	public void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject) { }

	// RVA: 0x1B047E0 Offset: 0x1B031E0 VA: 0x181B047E0
	internal void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue) { }

	// RVA: 0x1B04470 Offset: 0x1B02E70 VA: 0x181B04470
	protected void .ctor(Claim other, ClaimsIdentity subject) { }

	[OnDeserialized]
	// RVA: 0x1B04340 Offset: 0x1B02D40 VA: 0x181B04340
	private void OnDeserializedMethod(StreamingContext context) { }

	// RVA: 0x1B04AA0 Offset: 0x1B034A0 VA: 0x181B04AA0
	public IDictionary<string, string> get_Properties() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public ClaimsIdentity get_Subject() { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	internal void set_Subject(ClaimsIdentity value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Type() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Value() { }

	// RVA: 0x1B042D0 Offset: 0x1B02CD0 VA: 0x181B042D0 Slot: 4
	public virtual Claim Clone(ClaimsIdentity identity) { }

	// RVA: 0x1B043A0 Offset: 0x1B02DA0 VA: 0x181B043A0 Slot: 3
	public override string ToString() { }
}
