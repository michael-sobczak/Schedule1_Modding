public abstract class MemberDescriptor // TypeDefIndex: 9788
{
	// Fields
	private string name; // 0x10
	private string displayName; // 0x18
	private int nameHash; // 0x20
	private AttributeCollection attributeCollection; // 0x28
	private Attribute[] attributes; // 0x30
	private Attribute[] originalAttributes; // 0x38
	private bool attributesFiltered; // 0x40
	private bool attributesFilled; // 0x41
	private int metadataVersion; // 0x44
	private string category; // 0x48
	private string description; // 0x50
	private object lockCookie; // 0x58

	// Properties
	protected virtual Attribute[] AttributeArray { get; set; }
	public virtual AttributeCollection Attributes { get; }
	public virtual string Name { get; }
	protected virtual int NameHashCode { get; }
	public virtual string DisplayName { get; }

	// Methods

	// RVA: 0x266B5E0 Offset: 0x2669FE0 VA: 0x18266B5E0
	protected void .ctor(string name, Attribute[] attributes) { }

	// RVA: 0x266B1C0 Offset: 0x2669BC0 VA: 0x18266B1C0
	protected void .ctor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	// RVA: 0x266B760 Offset: 0x266A160 VA: 0x18266B760 Slot: 4
	protected virtual Attribute[] get_AttributeArray() { }

	// RVA: 0x266BA00 Offset: 0x266A400 VA: 0x18266BA00 Slot: 5
	protected virtual void set_AttributeArray(Attribute[] value) { }

	// RVA: 0x266B790 Offset: 0x266A190 VA: 0x18266B790 Slot: 6
	public virtual AttributeCollection get_Attributes() { }

	// RVA: 0x266B9B0 Offset: 0x266A3B0 VA: 0x18266B9B0 Slot: 7
	public virtual string get_Name() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 8
	protected virtual int get_NameHashCode() { }

	// RVA: 0x266B870 Offset: 0x266A270 VA: 0x18266B870 Slot: 9
	public virtual string get_DisplayName() { }

	// RVA: 0x266A400 Offset: 0x2668E00 VA: 0x18266A400
	private void CheckAttributesValid() { }

	// RVA: 0x266A4C0 Offset: 0x2668EC0 VA: 0x18266A4C0 Slot: 10
	protected virtual AttributeCollection CreateAttributeCollection() { }

	// RVA: 0x266A530 Offset: 0x2668F30 VA: 0x18266A530 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x266A7E0 Offset: 0x26691E0 VA: 0x18266A7E0 Slot: 11
	protected virtual void FillAttributes(IList attributeList) { }

	// RVA: 0x266A910 Offset: 0x2669310 VA: 0x18266A910
	private void FilterAttributesIfNeeded() { }

	// RVA: 0x266AF50 Offset: 0x2669950 VA: 0x18266AF50
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType) { }

	// RVA: 0x266AE90 Offset: 0x2669890 VA: 0x18266AE90
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x266AFE0 Offset: 0x26699E0 VA: 0x18266AFE0 Slot: 12
	protected virtual object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x266B110 Offset: 0x2669B10 VA: 0x18266B110
	protected static ISite GetSite(object component) { }
}
