public sealed class ValueAnimation<T> : IValueAnimationUpdate // TypeDefIndex: 7212
{
	// Fields
	private long m_StartTimeMs; // 0x0
	private int m_DurationMs; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Func<float, float> <easingCurve>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <isRunning>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action <onAnimationCompleted>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <autoRecycle>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <recycled>k__BackingField; // 0x0
	private static ObjectPool<ValueAnimation<T>> sObjectPool; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VisualElement <owner>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<VisualElement, T> <valueUpdated>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Func<VisualElement, T> <initialValue>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Func<T, T, float, T> <interpolator>k__BackingField; // 0x0
	private T _from; // 0x0
	private bool fromValueSet; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private T <to>k__BackingField; // 0x0

	// Properties
	public int durationMs { get; set; }
	public Func<float, float> easingCurve { get; set; }
	public bool isRunning { get; set; }
	public Action onAnimationCompleted { get; set; }
	public bool autoRecycle { get; set; }
	private bool recycled { get; set; }
	private VisualElement owner { get; set; }
	public Action<VisualElement, T> valueUpdated { get; set; }
	public Func<VisualElement, T> initialValue { get; set; }
	public Func<T, T, float, T> interpolator { get; set; }
	public T from { get; set; }
	public T to { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public int get_durationMs() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EB2A0 Offset: 0x10E9CA0 VA: 0x1810EB2A0
	|-ValueAnimation<StyleValues>.get_durationMs
	|
	|-RVA: 0xFE8F90 Offset: 0xFE7990 VA: 0x180FE8F90
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_durationMs
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void set_durationMs(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F3470 Offset: 0x12F1E70 VA: 0x1812F3470
	|-ValueAnimation<StyleValues>.set_durationMs
	|
	|-RVA: 0x12F3400 Offset: 0x12F1E00 VA: 0x1812F3400
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_durationMs
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Func<float, float> get_easingCurve() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	|-ValueAnimation<StyleValues>.get_easingCurve
	|
	|-RVA: 0x129F560 Offset: 0x129DF60 VA: 0x18129F560
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_easingCurve
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_easingCurve(Func<float, float> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	|-ValueAnimation<StyleValues>.set_easingCurve
	|
	|-RVA: 0x129F780 Offset: 0x129E180 VA: 0x18129F780
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_easingCurve
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public bool get_isRunning() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	|-ValueAnimation<StyleValues>.get_isRunning
	|
	|-RVA: 0x12F31F0 Offset: 0x12F1BF0 VA: 0x1812F31F0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_isRunning
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_isRunning(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	|-ValueAnimation<StyleValues>.set_isRunning
	|
	|-RVA: 0x12F3690 Offset: 0x12F2090 VA: 0x1812F3690
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_isRunning
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Action get_onAnimationCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	|-ValueAnimation<StyleValues>.get_onAnimationCompleted
	|
	|-RVA: 0x12F3220 Offset: 0x12F1C20 VA: 0x1812F3220
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_onAnimationCompleted
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_onAnimationCompleted(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	|-ValueAnimation<StyleValues>.set_onAnimationCompleted
	|
	|-RVA: 0x12F3700 Offset: 0x12F2100 VA: 0x1812F3700
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_onAnimationCompleted
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public bool get_autoRecycle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	|-ValueAnimation<StyleValues>.get_autoRecycle
	|
	|-RVA: 0x12F2EE0 Offset: 0x12F18E0 VA: 0x1812F2EE0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_autoRecycle
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_autoRecycle(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x91C530 Offset: 0x91AF30 VA: 0x18091C530
	|-ValueAnimation<StyleValues>.set_autoRecycle
	|
	|-RVA: 0x12F3390 Offset: 0x12F1D90 VA: 0x1812F3390
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_autoRecycle
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private bool get_recycled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8D2180 Offset: 0x8D0B80 VA: 0x1808D2180
	|-ValueAnimation<StyleValues>.get_recycled
	|
	|-RVA: 0x12F3280 Offset: 0x12F1C80 VA: 0x1812F3280
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_recycled
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_recycled(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCD74A0 Offset: 0xCD5EA0 VA: 0x180CD74A0
	|-ValueAnimation<StyleValues>.set_recycled
	|
	|-RVA: 0x12F37E0 Offset: 0x12F21E0 VA: 0x1812F37E0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_recycled
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private VisualElement get_owner() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	|-ValueAnimation<StyleValues>.get_owner
	|
	|-RVA: 0x12F3250 Offset: 0x12F1C50 VA: 0x1812F3250
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_owner
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_owner(VisualElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	|-ValueAnimation<StyleValues>.set_owner
	|
	|-RVA: 0x12F3770 Offset: 0x12F2170 VA: 0x1812F3770
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_owner
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Action<VisualElement, T> get_valueUpdated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	|-ValueAnimation<StyleValues>.get_valueUpdated
	|
	|-RVA: 0x12F3360 Offset: 0x12F1D60 VA: 0x1812F3360
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_valueUpdated
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_valueUpdated(Action<VisualElement, T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	|-ValueAnimation<StyleValues>.set_valueUpdated
	|
	|-RVA: 0x12F3920 Offset: 0x12F2320 VA: 0x1812F3920
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_valueUpdated
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Func<VisualElement, T> get_initialValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	|-ValueAnimation<StyleValues>.get_initialValue
	|
	|-RVA: 0x12F3190 Offset: 0x12F1B90 VA: 0x1812F3190
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_initialValue
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_initialValue(Func<VisualElement, T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0
	|-ValueAnimation<StyleValues>.set_initialValue
	|
	|-RVA: 0x12F35B0 Offset: 0x12F1FB0 VA: 0x1812F35B0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_initialValue
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Func<T, T, float, T> get_interpolator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	|-ValueAnimation<StyleValues>.get_interpolator
	|
	|-RVA: 0x12F31C0 Offset: 0x12F1BC0 VA: 0x1812F31C0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_interpolator
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_interpolator(Func<T, T, float, T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	|-ValueAnimation<StyleValues>.set_interpolator
	|
	|-RVA: 0x12F3620 Offset: 0x12F2020 VA: 0x1812F3620
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_interpolator
	*/

	// RVA: -1 Offset: -1
	public T get_from() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F2F10 Offset: 0x12F1910 VA: 0x1812F2F10
	|-ValueAnimation<StyleValues>.get_from
	|
	|-RVA: 0x12F2F70 Offset: 0x12F1970 VA: 0x1812F2F70
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_from
	*/

	// RVA: -1 Offset: -1
	public void set_from(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F3590 Offset: 0x12F1F90 VA: 0x1812F3590
	|-ValueAnimation<StyleValues>.set_from
	|
	|-RVA: 0x12F3480 Offset: 0x12F1E80 VA: 0x1812F3480
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_from
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T get_to() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	|-ValueAnimation<StyleValues>.get_to
	|
	|-RVA: 0x12F32B0 Offset: 0x12F1CB0 VA: 0x1812F32B0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_to
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_to(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F3910 Offset: 0x12F2310 VA: 0x1812F3910
	|-ValueAnimation<StyleValues>.set_to
	|
	|-RVA: 0x12F3850 Offset: 0x12F2250 VA: 0x1812F3850
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_to
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F2EA0 Offset: 0x12F18A0 VA: 0x1812F2EA0
	|-ValueAnimation<StyleValues>..ctor
	|
	|-RVA: 0x12F2E10 Offset: 0x12F1810 VA: 0x1812F2E10
	|-ValueAnimation<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F1EC0 Offset: 0x12F08C0 VA: 0x1812F1EC0
	|-ValueAnimation<StyleValues>.Start
	|
	|-RVA: 0x12F1F90 Offset: 0x12F0990 VA: 0x1812F1F90
	|-ValueAnimation<__Il2CppFullySharedGenericType>.Start
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Stop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F21C0 Offset: 0x12F0BC0 VA: 0x1812F21C0
	|-ValueAnimation<StyleValues>.Stop
	|
	|-RVA: 0x12F20B0 Offset: 0x12F0AB0 VA: 0x1812F20B0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.Stop
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void Recycle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F15E0 Offset: 0x12EFFE0 VA: 0x1812F15E0
	|-ValueAnimation<StyleValues>.Recycle
	|
	|-RVA: 0x12F1730 Offset: 0x12F0130 VA: 0x1812F1730
	|-ValueAnimation<__Il2CppFullySharedGenericType>.Recycle
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(long currentTimeMs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F2720 Offset: 0x12F1120 VA: 0x1812F2720
	|-ValueAnimation<StyleValues>.UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick
	|
	|-RVA: 0x12F2360 Offset: 0x12F0D60 VA: 0x1812F2360
	|-ValueAnimation<__Il2CppFullySharedGenericType>.UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick
	*/

	// RVA: -1 Offset: -1
	private void SetDefaultValues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F1CA0 Offset: 0x12F06A0 VA: 0x1812F1CA0
	|-ValueAnimation<StyleValues>.SetDefaultValues
	|
	|-RVA: 0x12F1930 Offset: 0x12F0330 VA: 0x1812F1930
	|-ValueAnimation<__Il2CppFullySharedGenericType>.SetDefaultValues
	*/

	// RVA: -1 Offset: -1
	private void Unregister() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F28B0 Offset: 0x12F12B0 VA: 0x1812F28B0
	|-ValueAnimation<StyleValues>.Unregister
	|
	|-RVA: 0x12F28D0 Offset: 0x12F12D0 VA: 0x1812F28D0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.Unregister
	*/

	// RVA: -1 Offset: -1
	private void Register() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F18A0 Offset: 0x12F02A0 VA: 0x1812F18A0
	|-ValueAnimation<StyleValues>.Register
	|
	|-RVA: 0x12F18C0 Offset: 0x12F02C0 VA: 0x1812F18C0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.Register
	*/

	// RVA: -1 Offset: -1
	internal void SetOwner(VisualElement e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F1DA0 Offset: 0x12F07A0 VA: 0x1812F1DA0
	|-ValueAnimation<StyleValues>.SetOwner
	|
	|-RVA: 0x12F1E10 Offset: 0x12F0810 VA: 0x1812F1E10
	|-ValueAnimation<__Il2CppFullySharedGenericType>.SetOwner
	*/

	// RVA: -1 Offset: -1
	private void CheckNotRecycled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F1180 Offset: 0x12EFB80 VA: 0x1812F1180
	|-ValueAnimation<StyleValues>.CheckNotRecycled
	|
	|-RVA: 0x12F1100 Offset: 0x12EFB00 VA: 0x1812F1100
	|-ValueAnimation<__Il2CppFullySharedGenericType>.CheckNotRecycled
	*/

	// RVA: -1 Offset: -1
	public static ValueAnimation<T> Create(VisualElement e, Func<T, T, float, T> interpolator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F11E0 Offset: 0x12EFBE0 VA: 0x1812F11E0
	|-ValueAnimation<StyleValues>.Create
	|
	|-RVA: 0x12F1370 Offset: 0x12EFD70 VA: 0x1812F1370
	|-ValueAnimation<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1
	public ValueAnimation<T> KeepAlive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F15D0 Offset: 0x12EFFD0 VA: 0x1812F15D0
	|-ValueAnimation<StyleValues>.KeepAlive
	|
	|-RVA: 0x12F15A0 Offset: 0x12EFFA0 VA: 0x1812F15A0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.KeepAlive
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F2940 Offset: 0x12F1340 VA: 0x1812F2940
	|-ValueAnimation<StyleValues>..cctor
	|
	|-RVA: 0x12F2B80 Offset: 0x12F1580 VA: 0x1812F2B80
	|-ValueAnimation<__Il2CppFullySharedGenericType>..cctor
	*/
}
