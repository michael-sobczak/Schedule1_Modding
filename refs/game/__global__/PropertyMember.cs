internal struct PropertyMember : IMemberInfo // TypeDefIndex: 18355
{
	// Fields
	internal readonly PropertyInfo m_PropertyInfo; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly string <Name>k__BackingField; // 0x8

	// Properties
	public string Name { get; }
	public bool IsReadOnly { get; }
	public Type ValueType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0 Slot: 4
	public string get_Name() { }

	// RVA: 0x2D3E950 Offset: 0x2D3D350 VA: 0x182D3E950 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x2D3E980 Offset: 0x2D3D380 VA: 0x182D3E980 Slot: 6
	public Type get_ValueType() { }

	// RVA: 0x2D3DF50 Offset: 0x2D3C950 VA: 0x182D3DF50
	public void .ctor(PropertyInfo propertyInfo) { }

	// RVA: 0x2D3DF40 Offset: 0x2D3C940 VA: 0x182D3DF40 Slot: 7
	public IEnumerable<Attribute> GetCustomAttributes() { }
}
