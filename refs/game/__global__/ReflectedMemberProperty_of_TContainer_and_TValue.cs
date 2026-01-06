public class ReflectedMemberProperty<TContainer, TValue> : Property<TContainer, TValue> // TypeDefIndex: 18360
{
	// Fields
	private readonly IMemberInfo m_Info; // 0x0
	private readonly bool m_IsStructContainerType; // 0x0
	private ReflectedMemberProperty.GetStructValueAction<TContainer, TValue> m_GetStructValueAction; // 0x0
	private ReflectedMemberProperty.SetStructValueAction<TContainer, TValue> m_SetStructValueAction; // 0x0
	private ReflectedMemberProperty.GetClassValueAction<TContainer, TValue> m_GetClassValueAction; // 0x0
	private ReflectedMemberProperty.SetClassValueAction<TContainer, TValue> m_SetClassValueAction; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly string <Name>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly bool <IsReadOnly>k__BackingField; // 0x0

	// Properties
	public override string Name { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	|-ReflectedMemberProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IMemberInfo info, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A4BB0 Offset: 0x11A35B0 VA: 0x1811A4BB0
	|-ReflectedMemberProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}
