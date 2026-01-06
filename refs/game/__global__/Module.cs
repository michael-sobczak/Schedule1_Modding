public abstract class Module : ICustomAttributeProvider, ISerializable, _Module // TypeDefIndex: 4713
{
	// Fields
	public static readonly TypeFilter FilterTypeName; // 0x0
	public static readonly TypeFilter FilterTypeNameIgnoreCase; // 0x8
	private const BindingFlags DefaultLookup = 28;

	// Properties
	public virtual Assembly Assembly { get; }
	public virtual Guid ModuleVersionId { get; }
	public virtual string ScopeName { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x1B8E1C0 Offset: 0x1B8CBC0 VA: 0x181B8E1C0 Slot: 8
	public virtual Assembly get_Assembly() { }

	// RVA: 0x1B8E1F0 Offset: 0x1B8CBF0 VA: 0x181B8E1F0 Slot: 9
	public virtual Guid get_ModuleVersionId() { }

	// RVA: 0x1B8E220 Offset: 0x1B8CC20 VA: 0x181B8E220 Slot: 10
	public virtual string get_ScopeName() { }

	// RVA: 0x1B8E0A0 Offset: 0x1B8CAA0 VA: 0x181B8E0A0 Slot: 11
	public virtual bool IsResource() { }

	// RVA: 0x1B8E070 Offset: 0x1B8CA70 VA: 0x181B8E070 Slot: 12
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1B8DFD0 Offset: 0x1B8C9D0 VA: 0x181B8DFD0 Slot: 13
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1B8DFA0 Offset: 0x1B8C9A0 VA: 0x181B8DFA0 Slot: 14
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1B8E040 Offset: 0x1B8CA40 VA: 0x181B8E040 Slot: 15
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xC82B80 Offset: 0xC81580 VA: 0x180C82B80 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B85710 Offset: 0x1B84110 VA: 0x181B85710
	public static bool op_Equality(Module left, Module right) { }

	// RVA: 0x6FDC50 Offset: 0x6FC650 VA: 0x1806FDC50 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B8DE20 Offset: 0x1B8C820 VA: 0x181B8DE20
	private static bool FilterTypeNameImpl(Type cls, object filterCriteria) { }

	// RVA: 0x1B8DC70 Offset: 0x1B8C670 VA: 0x181B8DC70
	private static bool FilterTypeNameIgnoreCaseImpl(Type cls, object filterCriteria) { }

	// RVA: 0x1B8E000 Offset: 0x1B8CA00 VA: 0x181B8E000 Slot: 16
	internal virtual Guid GetModuleVersionId() { }

	// RVA: 0x1B8E0D0 Offset: 0x1B8CAD0 VA: 0x181B8E0D0
	private static void .cctor() { }
}
