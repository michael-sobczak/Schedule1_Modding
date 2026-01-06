public static class InputControlExtensions // TypeDefIndex: 7352
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static TControl FindInParentChain<TControl>(InputControl control) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED28F0 Offset: 0xED12F0 VA: 0x180ED28F0
	|-InputControlExtensions.FindInParentChain<object>
	*/

	[Extension]
	// RVA: 0x279E050 Offset: 0x279CA50 VA: 0x18279E050
	public static bool IsPressed(InputControl control, float buttonPressPoint = 0) { }

	[Extension]
	// RVA: 0x279DE90 Offset: 0x279C890 VA: 0x18279DE90
	public static bool IsActuated(InputControl control, float threshold = 0) { }

	[Extension]
	// RVA: 0x279E310 Offset: 0x279CD10 VA: 0x18279E310
	public static object ReadValueAsObject(InputControl control) { }

	[Extension]
	// RVA: 0x279E470 Offset: 0x279CE70 VA: 0x18279E470
	public static void ReadValueIntoBuffer(InputControl control, void* buffer, int bufferSize) { }

	[Extension]
	// RVA: 0x279E270 Offset: 0x279CC70 VA: 0x18279E270
	public static object ReadDefaultValueAsObject(InputControl control) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static TValue ReadValueFromEvent<TValue>(InputControl<TValue> control, InputEventPtr inputEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED3210 Offset: 0xED1C10 VA: 0x180ED3210
	|-InputControlExtensions.ReadValueFromEvent<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool ReadValueFromEvent<TValue>(InputControl<TValue> control, InputEventPtr inputEvent, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED3080 Offset: 0xED1A80 VA: 0x180ED3080
	|-InputControlExtensions.ReadValueFromEvent<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: 0x279E3A0 Offset: 0x279CDA0 VA: 0x18279E3A0
	public static object ReadValueFromEventAsObject(InputControl control, InputEventPtr inputEvent) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static TValue ReadUnprocessedValueFromEvent<TValue>(InputControl<TValue> control, InputEventPtr eventPtr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED2DA0 Offset: 0xED17A0 VA: 0x180ED2DA0
	|-InputControlExtensions.ReadUnprocessedValueFromEvent<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool ReadUnprocessedValueFromEvent<TValue>(InputControl<TValue> control, InputEventPtr inputEvent, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED2EE0 Offset: 0xED18E0 VA: 0x180ED2EE0
	|-InputControlExtensions.ReadUnprocessedValueFromEvent<float>
	|
	|-RVA: 0xED2FB0 Offset: 0xED19B0 VA: 0x180ED2FB0
	|-InputControlExtensions.ReadUnprocessedValueFromEvent<Vector2>
	|
	|-RVA: 0xED2C10 Offset: 0xED1610 VA: 0x180ED2C10
	|-InputControlExtensions.ReadUnprocessedValueFromEvent<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: 0x279EB20 Offset: 0x279D520 VA: 0x18279EB20
	public static void WriteValueFromObjectIntoEvent(InputControl control, InputEventPtr eventPtr, object value) { }

	[Extension]
	// RVA: 0x279EBC0 Offset: 0x279D5C0 VA: 0x18279EBC0
	public static void WriteValueIntoState(InputControl control, void* statePtr) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void WriteValueIntoState<TValue>(InputControl control, TValue value, void* statePtr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED39E0 Offset: 0xED23E0 VA: 0x180ED39E0
	|-InputControlExtensions.WriteValueIntoState<bool>
	|
	|-RVA: 0xED44B0 Offset: 0xED2EB0 VA: 0x180ED44B0
	|-InputControlExtensions.WriteValueIntoState<uint>
	|
	|-RVA: 0xED40D0 Offset: 0xED2AD0 VA: 0x180ED40D0
	|-InputControlExtensions.WriteValueIntoState<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void WriteValueIntoState<TValue>(InputControl<TValue> control, TValue value, void* statePtr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4390 Offset: 0xED2D90 VA: 0x180ED4390
	|-InputControlExtensions.WriteValueIntoState<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void WriteValueIntoState<TValue>(InputControl<TValue> control, void* statePtr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED3FC0 Offset: 0xED29C0 VA: 0x180ED3FC0
	|-InputControlExtensions.WriteValueIntoState<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void WriteValueIntoState<TValue, TState>(InputControl<TValue> control, TValue value, ref TState state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED3C30 Offset: 0xED2630 VA: 0x180ED3C30
	|-InputControlExtensions.WriteValueIntoState<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void WriteValueIntoEvent<TValue>(InputControl control, TValue value, InputEventPtr eventPtr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED3380 Offset: 0xED1D80 VA: 0x180ED3380
	|-InputControlExtensions.WriteValueIntoEvent<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void WriteValueIntoEvent<TValue>(InputControl<TValue> control, TValue value, InputEventPtr eventPtr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED37F0 Offset: 0xED21F0 VA: 0x180ED37F0
	|-InputControlExtensions.WriteValueIntoEvent<float>
	|
	|-RVA: 0xED38E0 Offset: 0xED22E0 VA: 0x180ED38E0
	|-InputControlExtensions.WriteValueIntoEvent<Vector2>
	|
	|-RVA: 0xED3690 Offset: 0xED2090 VA: 0x180ED3690
	|-InputControlExtensions.WriteValueIntoEvent<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: 0x279D0C0 Offset: 0x279BAC0 VA: 0x18279D0C0
	public static void CopyState(InputDevice device, void* buffer, int bufferSizeInBytes) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void CopyState<TState>(InputDevice device, out TState state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED23A0 Offset: 0xED0DA0 VA: 0x180ED23A0
	|-InputControlExtensions.CopyState<MouseState>
	|
	|-RVA: 0xED1FC0 Offset: 0xED09C0 VA: 0x180ED1FC0
	|-InputControlExtensions.CopyState<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: 0x279CC20 Offset: 0x279B620 VA: 0x18279CC20
	public static bool CheckStateIsAtDefault(InputControl control) { }

	[Extension]
	// RVA: 0x279CB10 Offset: 0x279B510 VA: 0x18279CB10
	public static bool CheckStateIsAtDefault(InputControl control, void* statePtr, void* maskPtr) { }

	[Extension]
	// RVA: 0x279C880 Offset: 0x279B280 VA: 0x18279C880
	public static bool CheckStateIsAtDefaultIgnoringNoise(InputControl control) { }

	[Extension]
	// RVA: 0x279C9D0 Offset: 0x279B3D0 VA: 0x18279C9D0
	public static bool CheckStateIsAtDefaultIgnoringNoise(InputControl control, void* statePtr) { }

	[Extension]
	// RVA: 0x279CD30 Offset: 0x279B730 VA: 0x18279CD30
	public static bool CompareStateIgnoringNoise(InputControl control, void* statePtr) { }

	[Extension]
	// RVA: 0x279CF50 Offset: 0x279B950 VA: 0x18279CF50
	public static bool CompareState(InputControl control, void* firstStatePtr, void* secondStatePtr, void* maskPtr) { }

	[Extension]
	// RVA: 0x279CE50 Offset: 0x279B850 VA: 0x18279CE50
	public static bool CompareState(InputControl control, void* statePtr, void* maskPtr) { }

	[Extension]
	// RVA: 0x279DDA0 Offset: 0x279C7A0 VA: 0x18279DDA0
	public static bool HasValueChangeInState(InputControl control, void* statePtr) { }

	[Extension]
	// RVA: 0x279DC80 Offset: 0x279C680 VA: 0x18279DC80
	public static bool HasValueChangeInEvent(InputControl control, InputEventPtr eventPtr) { }

	[Extension]
	// RVA: 0x279DB70 Offset: 0x279C570 VA: 0x18279DB70
	public static void* GetStatePtrFromStateEvent(InputControl control, InputEventPtr eventPtr) { }

	[Extension]
	// RVA: 0x279D830 Offset: 0x279C230 VA: 0x18279D830
	internal static void* GetStatePtrFromStateEventUnchecked(InputControl control, InputEventPtr eventPtr, FourCC eventType) { }

	[Extension]
	// RVA: 0x279E570 Offset: 0x279CF70 VA: 0x18279E570
	public static bool ResetToDefaultStateInEvent(InputControl control, InputEventPtr eventPtr) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void QueueValueChange<TValue>(InputControl<TValue> control, TValue value, double time = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED2A00 Offset: 0xED1400 VA: 0x180ED2A00
	|-InputControlExtensions.QueueValueChange<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: 0x279C2E0 Offset: 0x279ACE0 VA: 0x18279C2E0
	public static void AccumulateValueInEvent(InputControl<float> control, void* currentStatePtr, InputEventPtr newState) { }

	[Extension]
	// RVA: 0x279C3E0 Offset: 0x279ADE0 VA: 0x18279C3E0
	internal static void AccumulateValueInEvent(InputControl<Vector2> control, void* currentStatePtr, InputEventPtr newState) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void FindControlsRecursive<TControl>(InputControl parent, IList<TControl> controls, Func<TControl, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED2680 Offset: 0xED1080 VA: 0x180ED2680
	|-InputControlExtensions.FindControlsRecursive<object>
	*/

	[Extension]
	// RVA: 0x279C4F0 Offset: 0x279AEF0 VA: 0x18279C4F0
	internal static string BuildPath(InputControl control, string deviceLayout, StringBuilder builder) { }

	[Extension]
	// RVA: 0x279D2B0 Offset: 0x279BCB0 VA: 0x18279D2B0
	public static InputControlExtensions.InputEventControlCollection EnumerateControls(InputEventPtr eventPtr, InputControlExtensions.Enumerate flags, InputDevice device, float magnitudeThreshold = 0) { }

	[Extension]
	// RVA: 0x279D260 Offset: 0x279BC60 VA: 0x18279D260
	public static InputControlExtensions.InputEventControlCollection EnumerateChangedControls(InputEventPtr eventPtr, InputDevice device, float magnitudeThreshold = 0) { }

	[Extension]
	// RVA: 0x279DC60 Offset: 0x279C660 VA: 0x18279DC60
	public static bool HasButtonPress(InputEventPtr eventPtr, float magnitude = -1, bool buttonControlsOnly = True) { }

	[Extension]
	// RVA: 0x279D600 Offset: 0x279C000 VA: 0x18279D600
	public static InputControl GetFirstButtonPressOrNull(InputEventPtr eventPtr, float magnitude = -1, bool buttonControlsOnly = True) { }

	[IteratorStateMachine(typeof(InputControlExtensions.<GetAllButtonPresses>d__43))]
	[Extension]
	// RVA: 0x279D570 Offset: 0x279BF70 VA: 0x18279D570
	public static IEnumerable<InputControl> GetAllButtonPresses(InputEventPtr eventPtr, float magnitude = -1, bool buttonControlsOnly = True) { }

	[Extension]
	// RVA: 0x279EA40 Offset: 0x279D440 VA: 0x18279EA40
	public static InputControlExtensions.ControlBuilder Setup(InputControl control) { }

	[Extension]
	// RVA: 0x279E770 Offset: 0x279D170 VA: 0x18279E770
	public static InputControlExtensions.DeviceBuilder Setup(InputDevice device, int controlCount, int usageCount, int aliasCount) { }
}
