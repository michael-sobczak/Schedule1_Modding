internal class ReflectionObject // TypeDefIndex: 11192
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private readonly ObjectConstructor<object> <Creator>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly IDictionary<string, ReflectionMember> <Members>k__BackingField; // 0x18

	// Properties
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> Creator { get; }
	public IDictionary<string, ReflectionMember> Members { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public ObjectConstructor<object> get_Creator() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public IDictionary<string, ReflectionMember> get_Members() { }

	// RVA: 0x1D6DD30 Offset: 0x1D6C730 VA: 0x181D6DD30
	private void .ctor(ObjectConstructor<object> creator) { }

	// RVA: 0x1D6DC00 Offset: 0x1D6C600 VA: 0x181D6DC00
	public object GetValue(object target, string member) { }

	// RVA: 0x1D6DC90 Offset: 0x1D6C690 VA: 0x181D6DC90
	public void SetValue(object target, string member, object value) { }

	// RVA: 0x1D6DBA0 Offset: 0x1D6C5A0 VA: 0x181D6DBA0
	public Type GetType(string member) { }

	// RVA: 0x1D6D260 Offset: 0x1D6BC60 VA: 0x181D6D260
	public static ReflectionObject Create(Type t, string[] memberNames) { }

	// RVA: 0x1D6D270 Offset: 0x1D6BC70 VA: 0x181D6D270
	public static ReflectionObject Create(Type t, MethodBase creator, string[] memberNames) { }
}
