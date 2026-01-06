public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo // TypeDefIndex: 4715
{
	// Fields
	protected ParameterAttributes AttrsImpl; // 0x10
	protected Type ClassImpl; // 0x18
	protected object DefaultValueImpl; // 0x20
	protected MemberInfo MemberImpl; // 0x28
	protected string NameImpl; // 0x30
	protected int PositionImpl; // 0x38
	private const int MetadataToken_ParamDef = 134217728;

	// Properties
	public virtual ParameterAttributes Attributes { get; }
	public virtual MemberInfo Member { get; }
	public virtual string Name { get; }
	public virtual Type ParameterType { get; }
	public virtual int Position { get; }
	public bool IsIn { get; }
	public bool IsOptional { get; }
	public bool IsOut { get; }
	public virtual object DefaultValue { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220 Slot: 8
	public virtual ParameterAttributes get_Attributes() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 9
	public virtual MemberInfo get_Member() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0 Slot: 10
	public virtual string get_Name() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0 Slot: 11
	public virtual Type get_ParameterType() { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50 Slot: 12
	public virtual int get_Position() { }

	// RVA: 0x1B8EA70 Offset: 0x1B8D470 VA: 0x181B8EA70
	public bool get_IsIn() { }

	// RVA: 0x1B8EA90 Offset: 0x1B8D490 VA: 0x181B8EA90
	public bool get_IsOptional() { }

	// RVA: 0x1B8EAC0 Offset: 0x1B8D4C0 VA: 0x181B8EAC0
	public bool get_IsOut() { }

	// RVA: 0x1B8EA40 Offset: 0x1B8D440 VA: 0x181B8EA40 Slot: 13
	public virtual object get_DefaultValue() { }

	// RVA: 0x1B8E910 Offset: 0x1B8D310 VA: 0x181B8E910 Slot: 14
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1B8E460 Offset: 0x1B8CE60 VA: 0x181B8E460 Slot: 15
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1B8E490 Offset: 0x1B8CE90 VA: 0x181B8E490 Slot: 16
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1B8E550 Offset: 0x1B8CF50 VA: 0x181B8E550 Slot: 7
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x1B8E9B0 Offset: 0x1B8D3B0 VA: 0x181B8E9B0 Slot: 3
	public override string ToString() { }
}
