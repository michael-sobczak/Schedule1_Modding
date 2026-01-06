public class DelegateProperty<TContainer, TValue> : Property<TContainer, TValue> // TypeDefIndex: 18349
{
	// Fields
	private readonly PropertyGetter<TContainer, TValue> m_Getter; // 0x0
	private readonly PropertySetter<TContainer, TValue> m_Setter; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly string <Name>k__BackingField; // 0x0

	// Properties
	public override string Name { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	|-DelegateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string name, PropertyGetter<TContainer, TValue> getter, PropertySetter<TContainer, TValue> setter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E7620 Offset: 0x14E6020 VA: 0x1814E7620
	|-DelegateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}
