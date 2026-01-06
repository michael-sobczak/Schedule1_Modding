public abstract class DebugDisplaySettings<T> : IDebugDisplaySettings, IDebugDisplaySettingsQuery // TypeDefIndex: 13609
{
	// Fields
	protected readonly HashSet<IDebugDisplaySettingsData> m_Settings; // 0x0
	private static readonly Lazy<T> s_Instance; // 0x0

	// Properties
	public static T Instance { get; }
	public virtual bool AreAnySettingsActive { get; }
	public virtual bool IsPostProcessingAllowed { get; }
	public virtual bool IsLightingActive { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E49E0 Offset: 0x14E33E0 VA: 0x1814E49E0
	|-DebugDisplaySettings<object>.get_Instance
	|
	|-RVA: 0x12D6880 Offset: 0x12D5280 VA: 0x1812D6880
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>.get_Instance
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public virtual bool get_AreAnySettingsActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E48B0 Offset: 0x14E32B0 VA: 0x1814E48B0
	|-DebugDisplaySettings<object>.get_AreAnySettingsActive
	|
	|-RVA: 0x14E4780 Offset: 0x14E3180 VA: 0x1814E4780
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>.get_AreAnySettingsActive
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public virtual bool get_IsPostProcessingAllowed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E4FF0 Offset: 0x14E39F0 VA: 0x1814E4FF0
	|-DebugDisplaySettings<object>.get_IsPostProcessingAllowed
	|
	|-RVA: 0x14E4E30 Offset: 0x14E3830 VA: 0x1814E4E30
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>.get_IsPostProcessingAllowed
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual bool get_IsLightingActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E4C70 Offset: 0x14E3670 VA: 0x1814E4C70
	|-DebugDisplaySettings<object>.get_IsLightingActive
	|
	|-RVA: 0x14E4AB0 Offset: 0x14E34B0 VA: 0x1814E4AB0
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>.get_IsLightingActive
	*/

	// RVA: -1 Offset: -1
	protected TData Add<TData>(TData newData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC5CC0 Offset: 0xDC46C0 VA: 0x180DC5CC0
	|-DebugDisplaySettings<object>.Add<object>
	|
	|-RVA: 0xDC5B80 Offset: 0xDC4580 VA: 0x180DC5B80
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>.Add<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void ForEach(Action<IDebugDisplaySettingsData> onExecute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E3C80 Offset: 0x14E2680 VA: 0x1814E3C80
	|-DebugDisplaySettings<object>.ForEach
	|
	|-RVA: 0x14E3DA0 Offset: 0x14E27A0 VA: 0x1814E3DA0
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>.ForEach
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E3EC0 Offset: 0x14E28C0 VA: 0x1814E3EC0
	|-DebugDisplaySettings<object>.Reset
	|
	|-RVA: 0x14E3F10 Offset: 0x14E2910 VA: 0x1814E3F10
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual bool TryGetScreenClearColor(ref Color color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E40B0 Offset: 0x14E2AB0 VA: 0x1814E40B0
	|-DebugDisplaySettings<object>.TryGetScreenClearColor
	|
	|-RVA: 0x14E3F60 Offset: 0x14E2960 VA: 0x1814E3F60
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>.TryGetScreenClearColor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E4700 Offset: 0x14E3100 VA: 0x1814E4700
	|-DebugDisplaySettings<object>..ctor
	|
	|-RVA: 0x14E4680 Offset: 0x14E3080 VA: 0x1814E4680
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E4460 Offset: 0x14E2E60 VA: 0x1814E4460
	|-DebugDisplaySettings<object>..cctor
	|
	|-RVA: 0x14E4200 Offset: 0x14E2C00 VA: 0x1814E4200
	|-DebugDisplaySettings<__Il2CppFullySharedGenericType>..cctor
	*/
}
