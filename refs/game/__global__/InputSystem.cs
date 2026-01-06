public static class InputSystem // TypeDefIndex: 7341
{
	// Fields
	internal const string kAssemblyVersion = "1.14.1";
	internal const string kDocUrl = "https://docs.unity3d.com/Packages/com.unity.inputsystem@1.14";
	private static readonly ProfilerMarker k_InputResetMarker; // 0x0
	internal const float scrollWheelDeltaPerTick = 1;
	internal static InputManager s_Manager; // 0x8
	internal static InputRemoting s_Remote; // 0x10

	// Properties
	public static ReadOnlyArray<InputDevice> devices { get; }
	public static ReadOnlyArray<InputDevice> disconnectedDevices { get; }
	public static float pollingFrequency { get; set; }
	internal static bool isProcessingEvents { get; }
	public static InputEventListener onEvent { get; set; }
	public static IObservable<InputControl> onAnyButtonPress { get; }
	public static InputSettings settings { get; set; }
	public static InputActionAsset actions { get; set; }
	public static InputRemoting remoting { get; }
	public static Version version { get; }
	public static bool runInBackground { get; set; }
	public static InputMetrics metrics { get; }

	// Methods

	// RVA: 0x27AADE0 Offset: 0x27A97E0 VA: 0x1827AADE0
	public static void add_onLayoutChange(Action<string, InputControlLayoutChange> value) { }

	// RVA: 0x27ABD30 Offset: 0x27AA730 VA: 0x1827ABD30
	public static void remove_onLayoutChange(Action<string, InputControlLayoutChange> value) { }

	// RVA: 0x27A9130 Offset: 0x27A7B30 VA: 0x1827A9130
	public static void RegisterLayout(Type type, string name, Nullable<InputDeviceMatcher> matches) { }

	// RVA: -1 Offset: -1
	public static void RegisterLayout<T>(string name, Nullable<InputDeviceMatcher> matches) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE36E0 Offset: 0xEE20E0 VA: 0x180EE36E0
	|-InputSystem.RegisterLayout<object>
	*/

	// RVA: 0x27A92E0 Offset: 0x27A7CE0 VA: 0x1827A92E0
	public static void RegisterLayout(string json, string name, Nullable<InputDeviceMatcher> matches) { }

	// RVA: 0x27A90A0 Offset: 0x27A7AA0 VA: 0x1827A90A0
	public static void RegisterLayoutOverride(string json, string name) { }

	// RVA: 0x27A9020 Offset: 0x27A7A20 VA: 0x1827A9020
	public static void RegisterLayoutMatcher(string layoutName, InputDeviceMatcher matcher) { }

	// RVA: -1 Offset: -1
	public static void RegisterLayoutMatcher<TDevice>(InputDeviceMatcher matcher) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE3620 Offset: 0xEE2020 VA: 0x180EE3620
	|-InputSystem.RegisterLayoutMatcher<object>
	*/

	// RVA: 0x27A8E60 Offset: 0x27A7860 VA: 0x1827A8E60
	public static void RegisterLayoutBuilder(Func<InputControlLayout> buildMethod, string name, string baseLayout, Nullable<InputDeviceMatcher> matches) { }

	// RVA: -1 Offset: -1
	public static void RegisterPrecompiledLayout<TDevice>(string metadata) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE3790 Offset: 0xEE2190 VA: 0x180EE3790
	|-InputSystem.RegisterPrecompiledLayout<object>
	*/

	// RVA: 0x27A99A0 Offset: 0x27A83A0 VA: 0x1827A99A0
	public static void RemoveLayout(string name) { }

	// RVA: 0x27A9F90 Offset: 0x27A8990 VA: 0x1827A9F90
	public static string TryFindMatchingLayout(InputDeviceDescription deviceDescription) { }

	// RVA: 0x27A8350 Offset: 0x27A6D50 VA: 0x1827A8350
	public static IEnumerable<string> ListLayouts() { }

	// RVA: 0x27A8280 Offset: 0x27A6C80 VA: 0x1827A8280
	public static IEnumerable<string> ListLayoutsBasedOn(string baseLayout) { }

	// RVA: 0x27A8430 Offset: 0x27A6E30 VA: 0x1827A8430
	public static InputControlLayout LoadLayout(string name) { }

	// RVA: -1 Offset: -1
	public static InputControlLayout LoadLayout<TControl>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE2720 Offset: 0xEE1120 VA: 0x180EE2720
	|-InputSystem.LoadLayout<object>
	*/

	// RVA: 0x27A7990 Offset: 0x27A6390 VA: 0x1827A7990
	public static string GetNameOfBaseLayout(string layoutName) { }

	// RVA: 0x27A7EC0 Offset: 0x27A68C0 VA: 0x1827A7EC0
	public static bool IsFirstLayoutBasedOnSecond(string firstLayoutName, string secondLayoutName) { }

	// RVA: 0x27A93E0 Offset: 0x27A7DE0 VA: 0x1827A93E0
	public static void RegisterProcessor(Type type, string name) { }

	// RVA: -1 Offset: -1
	public static void RegisterProcessor<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE3810 Offset: 0xEE2210 VA: 0x180EE3810
	|-InputSystem.RegisterProcessor<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x27AA1C0 Offset: 0x27A8BC0 VA: 0x1827AA1C0
	public static Type TryGetProcessor(string name) { }

	// RVA: 0x27A83C0 Offset: 0x27A6DC0 VA: 0x1827A83C0
	public static IEnumerable<string> ListProcessors() { }

	// RVA: 0x27AAFC0 Offset: 0x27A99C0 VA: 0x1827AAFC0
	public static ReadOnlyArray<InputDevice> get_devices() { }

	// RVA: 0x27AB040 Offset: 0x27A9A40 VA: 0x1827AB040
	public static ReadOnlyArray<InputDevice> get_disconnectedDevices() { }

	// RVA: 0x27AAA10 Offset: 0x27A9410 VA: 0x1827AAA10
	public static void add_onDeviceChange(Action<InputDevice, InputDeviceChange> value) { }

	// RVA: 0x27AB960 Offset: 0x27AA360 VA: 0x1827AB960
	public static void remove_onDeviceChange(Action<InputDevice, InputDeviceChange> value) { }

	// RVA: 0x27AAB70 Offset: 0x27A9570 VA: 0x1827AAB70
	public static void add_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x27ABAC0 Offset: 0x27AA4C0 VA: 0x1827ABAC0
	public static void remove_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x27AACD0 Offset: 0x27A96D0 VA: 0x1827AACD0
	public static void add_onFindLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x27ABC20 Offset: 0x27AA620 VA: 0x1827ABC20
	public static void remove_onFindLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x27AB400 Offset: 0x27A9E00 VA: 0x1827AB400
	public static float get_pollingFrequency() { }

	// RVA: 0x27AC010 Offset: 0x27AAA10 VA: 0x1827AC010
	public static void set_pollingFrequency(float value) { }

	// RVA: 0x27A6E70 Offset: 0x27A5870 VA: 0x1827A6E70
	public static InputDevice AddDevice(string layout, string name, string variants) { }

	// RVA: -1 Offset: -1
	public static TDevice AddDevice<TDevice>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE1E90 Offset: 0xEE0890 VA: 0x180EE1E90
	|-InputSystem.AddDevice<object>
	*/

	// RVA: 0x27A6FA0 Offset: 0x27A59A0 VA: 0x1827A6FA0
	public static InputDevice AddDevice(InputDeviceDescription description) { }

	// RVA: 0x27A6DB0 Offset: 0x27A57B0 VA: 0x1827A6DB0
	public static void AddDevice(InputDevice device) { }

	// RVA: 0x27A9930 Offset: 0x27A8330 VA: 0x1827A9930
	public static void RemoveDevice(InputDevice device) { }

	// RVA: 0x27A75F0 Offset: 0x27A5FF0 VA: 0x1827A75F0
	public static void FlushDisconnectedDevices() { }

	// RVA: 0x27A7920 Offset: 0x27A6320 VA: 0x1827A7920
	public static InputDevice GetDevice(string nameOrLayout) { }

	// RVA: -1 Offset: -1
	public static TDevice GetDevice<TDevice>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE25B0 Offset: 0xEE0FB0 VA: 0x180EE25B0
	|-InputSystem.GetDevice<object>
	*/

	// RVA: 0x27A76C0 Offset: 0x27A60C0 VA: 0x1827A76C0
	public static InputDevice GetDevice(Type type) { }

	// RVA: -1 Offset: -1
	public static TDevice GetDevice<TDevice>(InternedString usage) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE2330 Offset: 0xEE0D30 VA: 0x180EE2330
	|-InputSystem.GetDevice<object>
	*/

	// RVA: -1 Offset: -1
	public static TDevice GetDevice<TDevice>(string usage) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE2690 Offset: 0xEE1090 VA: 0x180EE2690
	|-InputSystem.GetDevice<object>
	*/

	// RVA: 0x27A7650 Offset: 0x27A6050 VA: 0x1827A7650
	public static InputDevice GetDeviceById(int deviceId) { }

	// RVA: 0x27A7AC0 Offset: 0x27A64C0 VA: 0x1827A7AC0
	public static List<InputDeviceDescription> GetUnsupportedDevices() { }

	// RVA: 0x27A7B90 Offset: 0x27A6590 VA: 0x1827A7B90
	public static int GetUnsupportedDevices(List<InputDeviceDescription> descriptions) { }

	// RVA: 0x27A7370 Offset: 0x27A5D70 VA: 0x1827A7370
	public static void EnableDevice(InputDevice device) { }

	// RVA: 0x27A71E0 Offset: 0x27A5BE0 VA: 0x1827A71E0
	public static void DisableDevice(InputDevice device, bool keepSendingEvents = False) { }

	// RVA: 0x27AA350 Offset: 0x27A8D50 VA: 0x1827AA350
	public static bool TrySyncDevice(InputDevice device) { }

	// RVA: 0x27A9A10 Offset: 0x27A8410 VA: 0x1827A9A10
	public static void ResetDevice(InputDevice device, bool alsoResetDontResetControls = False) { }

	[Obsolete("Use 'ResetDevice' instead.", False)]
	// RVA: 0x27AA290 Offset: 0x27A8C90 VA: 0x1827AA290
	public static bool TryResetDevice(InputDevice device) { }

	// RVA: 0x27A8530 Offset: 0x27A6F30 VA: 0x1827A8530
	public static void PauseHaptics() { }

	// RVA: 0x27A9BD0 Offset: 0x27A85D0 VA: 0x1827A9BD0
	public static void ResumeHaptics() { }

	// RVA: 0x27A9A90 Offset: 0x27A8490 VA: 0x1827A9A90
	public static void ResetHaptics() { }

	// RVA: 0x27A9E20 Offset: 0x27A8820 VA: 0x1827A9E20
	public static void SetDeviceUsage(InputDevice device, string usage) { }

	// RVA: 0x27A9F00 Offset: 0x27A8900 VA: 0x1827A9F00
	public static void SetDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x27A6D00 Offset: 0x27A5700 VA: 0x1827A6D00
	public static void AddDeviceUsage(InputDevice device, string usage) { }

	// RVA: 0x27A6C70 Offset: 0x27A5670 VA: 0x1827A6C70
	public static void AddDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x27A9880 Offset: 0x27A8280 VA: 0x1827A9880
	public static void RemoveDeviceUsage(InputDevice device, string usage) { }

	// RVA: 0x27A97F0 Offset: 0x27A81F0 VA: 0x1827A97F0
	public static void RemoveDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x27A73F0 Offset: 0x27A5DF0 VA: 0x1827A73F0
	public static InputControl FindControl(string path) { }

	// RVA: 0x27A7570 Offset: 0x27A5F70 VA: 0x1827A7570
	public static InputControlList<InputControl> FindControls(string path) { }

	// RVA: -1 Offset: -1
	public static InputControlList<TControl> FindControls<TControl>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE21C0 Offset: 0xEE0BC0 VA: 0x180EE21C0
	|-InputSystem.FindControls<object>
	*/

	// RVA: -1 Offset: -1
	public static int FindControls<TControl>(string path, ref InputControlList<TControl> controls) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE2090 Offset: 0xEE0A90 VA: 0x180EE2090
	|-InputSystem.FindControls<object>
	*/

	// RVA: 0x27AB0E0 Offset: 0x27A9AE0 VA: 0x1827AB0E0
	internal static bool get_isProcessingEvents() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public static InputEventListener get_onEvent() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void set_onEvent(InputEventListener value) { }

	// RVA: 0x27AB1D0 Offset: 0x27A9BD0 VA: 0x1827AB1D0
	public static IObservable<InputControl> get_onAnyButtonPress() { }

	// RVA: 0x27A8870 Offset: 0x27A7270 VA: 0x1827A8870
	public static void QueueEvent(InputEventPtr eventPtr) { }

	// RVA: -1 Offset: -1
	public static void QueueEvent<TEvent>(ref TEvent inputEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE2E00 Offset: 0xEE1800 VA: 0x180EE2E00
	|-InputSystem.QueueEvent<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void QueueStateEvent<TState>(InputDevice device, TState state, double time = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE3280 Offset: 0xEE1C80 VA: 0x180EE3280
	|-InputSystem.QueueStateEvent<TouchState>
	|
	|-RVA: 0xEE2E90 Offset: 0xEE1890 VA: 0x180EE2E90
	|-InputSystem.QueueStateEvent<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void QueueDeltaStateEvent<TDelta>(InputControl control, TDelta delta, double time = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE27D0 Offset: 0xEE11D0 VA: 0x180EE27D0
	|-InputSystem.QueueDeltaStateEvent<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x27A86B0 Offset: 0x27A70B0 VA: 0x1827A86B0
	public static void QueueConfigChangeEvent(InputDevice device, double time = -1) { }

	// RVA: 0x27A8960 Offset: 0x27A7360 VA: 0x1827A8960
	public static void QueueTextEvent(InputDevice device, char character, double time = -1) { }

	// RVA: 0x27AA5F0 Offset: 0x27A8FF0 VA: 0x1827AA5F0
	public static void Update() { }

	// RVA: 0x27AA480 Offset: 0x27A8E80 VA: 0x1827AA480
	internal static void Update(InputUpdateType updateType) { }

	// RVA: 0x27AA900 Offset: 0x27A9300 VA: 0x1827AA900
	public static void add_onBeforeUpdate(Action value) { }

	// RVA: 0x27AB850 Offset: 0x27AA250 VA: 0x1827AB850
	public static void remove_onBeforeUpdate(Action value) { }

	// RVA: 0x27AA7F0 Offset: 0x27A91F0 VA: 0x1827AA7F0
	public static void add_onAfterUpdate(Action value) { }

	// RVA: 0x27AB740 Offset: 0x27AA140 VA: 0x1827AB740
	public static void remove_onAfterUpdate(Action value) { }

	// RVA: 0x27AB540 Offset: 0x27A9F40 VA: 0x1827AB540
	public static InputSettings get_settings() { }

	// RVA: 0x27AC1A0 Offset: 0x27AABA0 VA: 0x1827AC1A0
	public static void set_settings(InputSettings value) { }

	// RVA: 0x27AAEF0 Offset: 0x27A98F0 VA: 0x1827AAEF0
	public static void add_onSettingsChange(Action value) { }

	// RVA: 0x27ABE40 Offset: 0x27AA840 VA: 0x1827ABE40
	public static void remove_onSettingsChange(Action value) { }

	// RVA: 0x27A7270 Offset: 0x27A5C70 VA: 0x1827A7270
	private static void EnableActions() { }

	// RVA: 0x27A70B0 Offset: 0x27A5AB0 VA: 0x1827A70B0
	private static void DisableActions(bool triggerSetupChanged = False) { }

	// RVA: 0x27AAF60 Offset: 0x27A9960 VA: 0x1827AAF60
	public static InputActionAsset get_actions() { }

	// RVA: 0x27ABEB0 Offset: 0x27AA8B0 VA: 0x1827ABEB0
	public static void set_actions(InputActionAsset value) { }

	// RVA: 0x27AA780 Offset: 0x27A9180 VA: 0x1827AA780
	public static void add_onActionsChange(Action value) { }

	// RVA: 0x27AB6D0 Offset: 0x27AA0D0 VA: 0x1827AB6D0
	public static void remove_onActionsChange(Action value) { }

	// RVA: 0x27AA6C0 Offset: 0x27A90C0 VA: 0x1827AA6C0
	public static void add_onActionChange(Action<object, InputActionChange> value) { }

	// RVA: 0x27AB610 Offset: 0x27AA010 VA: 0x1827AB610
	public static void remove_onActionChange(Action<object, InputActionChange> value) { }

	// RVA: 0x27A8CD0 Offset: 0x27A76D0 VA: 0x1827A8CD0
	public static void RegisterInteraction(Type type, string name) { }

	// RVA: -1 Offset: -1
	public static void RegisterInteraction<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE3580 Offset: 0xEE1F80 VA: 0x180EE3580
	|-InputSystem.RegisterInteraction<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x27AA0F0 Offset: 0x27A8AF0 VA: 0x1827AA0F0
	public static Type TryGetInteraction(string name) { }

	// RVA: 0x27A8210 Offset: 0x27A6C10 VA: 0x1827A8210
	public static IEnumerable<string> ListInteractions() { }

	// RVA: 0x27A8B40 Offset: 0x27A7540 VA: 0x1827A8B40
	public static void RegisterBindingComposite(Type type, string name) { }

	// RVA: -1 Offset: -1
	public static void RegisterBindingComposite<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE34E0 Offset: 0xEE1EE0 VA: 0x180EE34E0
	|-InputSystem.RegisterBindingComposite<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x27AA020 Offset: 0x27A8A20 VA: 0x1827AA020
	public static Type TryGetBindingComposite(string name) { }

	// RVA: 0x27A71A0 Offset: 0x27A5BA0 VA: 0x1827A71A0
	public static void DisableAllEnabledActions() { }

	// RVA: 0x27A8110 Offset: 0x27A6B10 VA: 0x1827A8110
	public static List<InputAction> ListEnabledActions() { }

	// RVA: 0x27A8070 Offset: 0x27A6A70 VA: 0x1827A8070
	public static int ListEnabledActions(List<InputAction> actions) { }

	// RVA: 0x27AB460 Offset: 0x27A9E60 VA: 0x1827AB460
	public static InputRemoting get_remoting() { }

	// RVA: 0x27AB5B0 Offset: 0x27A9FB0 VA: 0x1827AB5B0
	public static Version get_version() { }

	// RVA: 0x27AB4B0 Offset: 0x27A9EB0 VA: 0x1827AB4B0
	public static bool get_runInBackground() { }

	// RVA: 0x27AC090 Offset: 0x27AAA90 VA: 0x1827AC090
	public static void set_runInBackground(bool value) { }

	// RVA: 0x27AB140 Offset: 0x27A9B40 VA: 0x1827AB140
	public static InputMetrics get_metrics() { }

	// RVA: 0x27AA650 Offset: 0x27A9050 VA: 0x1827AA650
	private static void .cctor() { }

	[RuntimeInitializeOnLoadMethod(4)]
	// RVA: 0x27A9DB0 Offset: 0x27A87B0 VA: 0x1827A9DB0
	private static void RunInitializeInPlayer() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void EnsureInitialized() { }

	// RVA: 0x27A7C00 Offset: 0x27A6600 VA: 0x1827A7C00
	private static void InitializeInPlayer(IInputRuntime runtime, InputSettings settings) { }

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x27A9D10 Offset: 0x27A8710 VA: 0x1827A9D10
	private static void RunInitialUpdate() { }

	// RVA: 0x27A8670 Offset: 0x27A7070 VA: 0x1827A8670
	private static void PerformDefaultPluginInitialization() { }
}
