internal abstract class UIInteropWrapper<T> : IUIInteropWrapper // TypeDefIndex: 18006
{
	// Fields
	protected readonly T InternalTarget; // 0x0

	// Properties
	public static Type TargetType { get; }
	public Component Target { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static Type get_TargetType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C80D0 Offset: 0x12C6AD0 VA: 0x1812C80D0
	|-UIInteropWrapper<object>.get_TargetType
	*/

	// RVA: -1 Offset: -1
	public static T GetTarget(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12C8080 Offset: 0x12C6A80 VA: 0x1812C8080
	|-UIInteropWrapper<object>.GetTarget
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public Component get_Target() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	|-UIInteropWrapper<object>.get_Target
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(T internalTarget) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	|-UIInteropWrapper<object>..ctor
	*/
}
