public abstract class XmlMapping // TypeDefIndex: 8177
{
	// Fields
	private ObjectMap map; // 0x10
	private ArrayList relatedMaps; // 0x18
	private SerializationFormat format; // 0x20
	private SerializationSource source; // 0x28
	internal string _elementName; // 0x30
	internal string _namespace; // 0x38
	private string key; // 0x40

	// Properties
	public string ElementName { get; }
	public string Namespace { get; }
	internal ObjectMap ObjectMap { get; set; }
	internal ArrayList RelatedMaps { get; set; }
	internal SerializationFormat Format { get; set; }
	internal SerializationSource Source { get; }

	// Methods

	// RVA: 0x2544000 Offset: 0x2542A00 VA: 0x182544000
	internal void .ctor(string elementName, string ns) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_ElementName() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public string get_Namespace() { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void SetKey(string key) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal ObjectMap get_ObjectMap() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	internal void set_ObjectMap(ObjectMap value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal ArrayList get_RelatedMaps() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	internal void set_RelatedMaps(ArrayList value) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	internal SerializationFormat get_Format() { }

	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	internal void set_Format(SerializationFormat value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal SerializationSource get_Source() { }
}
