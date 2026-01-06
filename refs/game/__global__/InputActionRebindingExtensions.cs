public static class InputActionRebindingExtensions // TypeDefIndex: 7291
{
	// Fields
	private static InputActionRebindingExtensions.DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper; // 0x0

	// Methods

	[Extension]
	// RVA: 0x2755350 Offset: 0x2753D50 VA: 0x182755350
	public static Nullable<PrimitiveValue> GetParameterValue(InputAction action, string name, InputBinding bindingMask) { }

	[Extension]
	// RVA: 0x27555C0 Offset: 0x2753FC0 VA: 0x1827555C0
	private static Nullable<PrimitiveValue> GetParameterValue(InputAction action, InputActionRebindingExtensions.ParameterOverride parameterOverride) { }

	[Extension]
	// RVA: 0x27559E0 Offset: 0x27543E0 VA: 0x1827559E0
	public static Nullable<PrimitiveValue> GetParameterValue(InputAction action, string name, int bindingIndex) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static Nullable<TValue> GetParameterValue<TObject, TValue>(InputAction action, Expression<Func<TObject, TValue>> expr, InputBinding bindingMask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xECBE90 Offset: 0xECA890 VA: 0x180ECBE90
	|-InputActionRebindingExtensions.GetParameterValue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void ApplyParameterOverride<TObject, TValue>(InputAction action, Expression<Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xECB580 Offset: 0xEC9F80 VA: 0x180ECB580
	|-InputActionRebindingExtensions.ApplyParameterOverride<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void ApplyParameterOverride<TObject, TValue>(InputActionMap actionMap, Expression<Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xECB330 Offset: 0xEC9D30 VA: 0x180ECB330
	|-InputActionRebindingExtensions.ApplyParameterOverride<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void ApplyParameterOverride<TObject, TValue>(InputActionAsset asset, Expression<Func<TObject, TValue>> expr, TValue value, InputBinding bindingMask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xECB0A0 Offset: 0xEC9AA0 VA: 0x180ECB0A0
	|-InputActionRebindingExtensions.ApplyParameterOverride<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private static InputActionRebindingExtensions.ParameterOverride ExtractParameterOverride<TObject, TValue>(Expression<Func<TObject, TValue>> expr, InputBinding bindingMask, PrimitiveValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xECB860 Offset: 0xECA260 VA: 0x180ECB860
	|-InputActionRebindingExtensions.ExtractParameterOverride<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x2753240 Offset: 0x2751C40 VA: 0x182753240
	public static void ApplyParameterOverride(InputActionMap actionMap, string name, PrimitiveValue value, InputBinding bindingMask) { }

	[Extension]
	// RVA: 0x27537C0 Offset: 0x27521C0 VA: 0x1827537C0
	public static void ApplyParameterOverride(InputActionAsset asset, string name, PrimitiveValue value, InputBinding bindingMask) { }

	[Extension]
	// RVA: 0x2752F60 Offset: 0x2751960 VA: 0x182752F60
	public static void ApplyParameterOverride(InputAction action, string name, PrimitiveValue value, InputBinding bindingMask) { }

	[Extension]
	// RVA: 0x27534F0 Offset: 0x2751EF0 VA: 0x1827534F0
	public static void ApplyParameterOverride(InputAction action, string name, PrimitiveValue value, int bindingIndex) { }

	// RVA: 0x2752450 Offset: 0x2750E50 VA: 0x182752450
	private static void ApplyParameterOverride(InputActionState state, int mapIndex, ref InputActionRebindingExtensions.ParameterOverride[] parameterOverrides, ref int parameterOverridesCount, InputActionRebindingExtensions.ParameterOverride parameterOverride) { }

	[Extension]
	// RVA: 0x2754D40 Offset: 0x2753740 VA: 0x182754D40
	public static int GetBindingIndex(InputAction action, InputBinding bindingMask) { }

	[Extension]
	// RVA: 0x27551A0 Offset: 0x2753BA0 VA: 0x1827551A0
	public static int GetBindingIndex(InputActionMap actionMap, InputBinding bindingMask) { }

	[Extension]
	// RVA: 0x2754F40 Offset: 0x2753940 VA: 0x182754F40
	public static int GetBindingIndex(InputAction action, string group, string path) { }

	[Extension]
	// RVA: 0x27548A0 Offset: 0x27532A0 VA: 0x1827548A0
	public static Nullable<InputBinding> GetBindingForControl(InputAction action, InputControl control) { }

	[Extension]
	// RVA: 0x2754B30 Offset: 0x2753530 VA: 0x182754B30
	public static int GetBindingIndexForControl(InputAction action, InputControl control) { }

	[Extension]
	// RVA: 0x2754340 Offset: 0x2752D40 VA: 0x182754340
	public static string GetBindingDisplayString(InputAction action, InputBinding.DisplayStringOptions options = 0, string group) { }

	[Extension]
	// RVA: 0x27545A0 Offset: 0x2752FA0 VA: 0x1827545A0
	public static string GetBindingDisplayString(InputAction action, InputBinding bindingMask, InputBinding.DisplayStringOptions options = 0) { }

	[Extension]
	// RVA: 0x2753BF0 Offset: 0x27525F0 VA: 0x182753BF0
	public static string GetBindingDisplayString(InputAction action, int bindingIndex, InputBinding.DisplayStringOptions options = 0) { }

	[Extension]
	// RVA: 0x2753C80 Offset: 0x2752680 VA: 0x182753C80
	public static string GetBindingDisplayString(InputAction action, int bindingIndex, out string deviceLayoutName, out string controlPath, InputBinding.DisplayStringOptions options = 0) { }

	[Extension]
	// RVA: 0x2751480 Offset: 0x274FE80 VA: 0x182751480
	public static void ApplyBindingOverride(InputAction action, string newPath, string group, string path) { }

	[Extension]
	// RVA: 0x2751770 Offset: 0x2750170 VA: 0x182751770
	public static void ApplyBindingOverride(InputAction action, InputBinding bindingOverride) { }

	[Extension]
	// RVA: 0x2751920 Offset: 0x2750320 VA: 0x182751920
	public static void ApplyBindingOverride(InputAction action, int bindingIndex, InputBinding bindingOverride) { }

	[Extension]
	// RVA: 0x27515A0 Offset: 0x274FFA0 VA: 0x1827515A0
	public static void ApplyBindingOverride(InputAction action, int bindingIndex, string path) { }

	[Extension]
	// RVA: 0x2751A10 Offset: 0x2750410 VA: 0x182751A10
	public static int ApplyBindingOverride(InputActionMap actionMap, InputBinding bindingOverride) { }

	[Extension]
	// RVA: 0x2751C00 Offset: 0x2750600 VA: 0x182751C00
	public static void ApplyBindingOverride(InputActionMap actionMap, int bindingIndex, InputBinding bindingOverride) { }

	[Extension]
	// RVA: 0x2756F90 Offset: 0x2755990 VA: 0x182756F90
	public static void RemoveBindingOverride(InputAction action, int bindingIndex) { }

	[Extension]
	// RVA: 0x2756E90 Offset: 0x2755890 VA: 0x182756E90
	public static void RemoveBindingOverride(InputAction action, InputBinding bindingMask) { }

	[Extension]
	// RVA: 0x27570C0 Offset: 0x2755AC0 VA: 0x1827570C0
	private static void RemoveBindingOverride(InputActionMap actionMap, InputBinding bindingMask) { }

	[Extension]
	// RVA: 0x27569A0 Offset: 0x27553A0 VA: 0x1827569A0
	public static void RemoveAllBindingOverrides(IInputActionCollection2 actions) { }

	[Extension]
	// RVA: 0x2756CB0 Offset: 0x27556B0 VA: 0x182756CB0
	public static void RemoveAllBindingOverrides(InputAction action) { }

	[Extension]
	// RVA: 0x27521A0 Offset: 0x2750BA0 VA: 0x1827521A0
	public static void ApplyBindingOverrides(InputActionMap actionMap, IEnumerable<InputBinding> overrides) { }

	[Extension]
	// RVA: 0x27571C0 Offset: 0x2755BC0 VA: 0x1827571C0
	public static void RemoveBindingOverrides(InputActionMap actionMap, IEnumerable<InputBinding> overrides) { }

	[Extension]
	// RVA: 0x2751F80 Offset: 0x2750980 VA: 0x182751F80
	public static int ApplyBindingOverridesOnMatchingControls(InputAction action, InputControl control) { }

	[Extension]
	// RVA: 0x2751E00 Offset: 0x2750800 VA: 0x182751E00
	public static int ApplyBindingOverridesOnMatchingControls(InputActionMap actionMap, InputControl control) { }

	[Extension]
	// RVA: 0x2757500 Offset: 0x2755F00 VA: 0x182757500
	public static string SaveBindingOverridesAsJson(IInputActionCollection2 actions) { }

	[Extension]
	// RVA: 0x2757870 Offset: 0x2756270 VA: 0x182757870
	public static string SaveBindingOverridesAsJson(InputAction action) { }

	[Extension]
	// RVA: 0x2751220 Offset: 0x274FC20 VA: 0x182751220
	private static void AddBindingOverrideJsonTo(IInputActionCollection2 actions, InputBinding binding, List<InputActionMap.BindingOverrideJson> list, InputAction action) { }

	[Extension]
	// RVA: 0x27561B0 Offset: 0x2754BB0 VA: 0x1827561B0
	public static void LoadBindingOverridesFromJson(IInputActionCollection2 actions, string json, bool removeExisting = True) { }

	[Extension]
	// RVA: 0x27562D0 Offset: 0x2754CD0 VA: 0x1827562D0
	public static void LoadBindingOverridesFromJson(InputAction action, string json, bool removeExisting = True) { }

	[Extension]
	// RVA: 0x2755CC0 Offset: 0x27546C0 VA: 0x182755CC0
	private static void LoadBindingOverridesFromJsonInternal(IInputActionCollection2 actions, string json) { }

	[Extension]
	// RVA: 0x27563F0 Offset: 0x2754DF0 VA: 0x1827563F0
	public static InputActionRebindingExtensions.RebindingOperation PerformInteractiveRebinding(InputAction action, int bindingIndex = -1) { }

	// RVA: 0x2753B20 Offset: 0x2752520 VA: 0x182753B20
	internal static InputActionRebindingExtensions.DeferBindingResolutionWrapper DeferBindingResolution() { }
}
