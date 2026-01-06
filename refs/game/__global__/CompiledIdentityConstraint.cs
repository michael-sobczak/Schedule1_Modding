internal class CompiledIdentityConstraint // TypeDefIndex: 8245
{
	// Fields
	internal XmlQualifiedName name; // 0x10
	private CompiledIdentityConstraint.ConstraintRole role; // 0x18
	private Asttree selector; // 0x20
	private Asttree[] fields; // 0x28
	internal XmlQualifiedName refer; // 0x30
	public static readonly CompiledIdentityConstraint Empty; // 0x0

	// Properties
	public CompiledIdentityConstraint.ConstraintRole Role { get; }
	public Asttree Selector { get; }
	public Asttree[] Fields { get; }

	// Methods

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public CompiledIdentityConstraint.ConstraintRole get_Role() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Asttree get_Selector() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Asttree[] get_Fields() { }

	// RVA: 0x2562440 Offset: 0x2560E40 VA: 0x182562440
	private void .ctor() { }

	// RVA: 0x25624D0 Offset: 0x2560ED0 VA: 0x1825624D0
	public void .ctor(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr) { }

	// RVA: 0x2562360 Offset: 0x2560D60 VA: 0x182562360
	private static void .cctor() { }
}
