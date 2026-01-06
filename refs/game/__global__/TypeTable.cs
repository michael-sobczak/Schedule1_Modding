internal struct TypeTable // TypeDefIndex: 7855
{
	// Fields
	public Dictionary<InternedString, Type> table; // 0x0

	// Properties
	public IEnumerable<string> names { get; }
	public IEnumerable<InternedString> internedNames { get; }

	// Methods

	// RVA: 0x27960B0 Offset: 0x2794AB0 VA: 0x1827960B0
	public IEnumerable<string> get_names() { }

	// RVA: 0x2796060 Offset: 0x2794A60 VA: 0x182796060
	public IEnumerable<InternedString> get_internedNames() { }

	// RVA: 0x2795EE0 Offset: 0x27948E0 VA: 0x182795EE0
	public void Initialize() { }

	// RVA: 0x2795CC0 Offset: 0x27946C0 VA: 0x182795CC0
	public InternedString FindNameForType(Type type) { }

	// RVA: 0x2795B40 Offset: 0x2794540 VA: 0x182795B40
	public void AddTypeRegistration(string name, Type type) { }

	// RVA: 0x2795F50 Offset: 0x2794950 VA: 0x182795F50
	public Type LookupTypeRegistration(string name) { }
}
