public abstract class TransitionEventBase<T> : EventBase<T> // TypeDefIndex: 6653
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly StylePropertyNameCollection <stylePropertyNames>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private double <elapsedTime>k__BackingField; // 0x0

	// Properties
	public StylePropertyNameCollection stylePropertyNames { get; }
	protected double elapsedTime { set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 15
	public StylePropertyNameCollection get_stylePropertyNames() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	|-TransitionEventBase<object>.get_stylePropertyNames
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void set_elapsedTime(double value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1277B60 Offset: 0x1276560 VA: 0x181277B60
	|-TransitionEventBase<object>.set_elapsedTime
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1277A10 Offset: 0x1276410 VA: 0x181277A10
	|-TransitionEventBase<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12778E0 Offset: 0x12762E0 VA: 0x1812778E0
	|-TransitionEventBase<object>.Init
	*/

	// RVA: -1 Offset: -1
	private void LocalInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1277980 Offset: 0x1276380 VA: 0x181277980
	|-TransitionEventBase<object>.LocalInit
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled(StylePropertyName stylePropertyName, double elapsedTime) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1277760 Offset: 0x1276160 VA: 0x181277760
	|-TransitionEventBase<object>.GetPooled
	*/
}
