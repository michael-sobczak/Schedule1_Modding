internal class InputManager // TypeDefIndex: 7433
{
	// Fields
	private static readonly ProfilerMarker k_InputUpdateProfilerMarker; // 0x0
	private static readonly ProfilerMarker k_InputTryFindMatchingControllerMarker; // 0x8
	private static readonly ProfilerMarker k_InputAddDeviceMarker; // 0x10
	private static readonly ProfilerMarker k_InputRestoreDevicesAfterReloadMarker; // 0x18
	private static readonly ProfilerMarker k_InputRegisterCustomTypesMarker; // 0x20
	private static readonly ProfilerMarker k_InputOnBeforeUpdateMarker; // 0x28
	private static readonly ProfilerMarker k_InputOnAfterUpdateMarker; // 0x30
	private static readonly ProfilerMarker k_InputOnSettingsChangeMarker; // 0x38
	private static readonly ProfilerMarker k_InputOnDeviceSettingsChangeMarker; // 0x40
	private static readonly ProfilerMarker k_InputOnEventMarker; // 0x48
	private static readonly ProfilerMarker k_InputOnLayoutChangeMarker; // 0x50
	private static readonly ProfilerMarker k_InputOnDeviceChangeMarker; // 0x58
	private static readonly ProfilerMarker k_InputOnActionsChangeMarker; // 0x60
	internal int m_LayoutRegistrationVersion; // 0x10
	private float m_PollingFrequency; // 0x14
	internal InputControlLayout.Collection m_Layouts; // 0x18
	private TypeTable m_Processors; // 0x58
	private TypeTable m_Interactions; // 0x60
	private TypeTable m_Composites; // 0x68
	private int m_DevicesCount; // 0x70
	private InputDevice[] m_Devices; // 0x78
	private Dictionary<int, InputDevice> m_DevicesById; // 0x80
	internal int m_AvailableDeviceCount; // 0x88
	internal InputManager.AvailableDevice[] m_AvailableDevices; // 0x90
	internal int m_DisconnectedDevicesCount; // 0x98
	internal InputDevice[] m_DisconnectedDevices; // 0xA0
	internal InputUpdateType m_UpdateMask; // 0xA8
	private InputUpdateType m_CurrentUpdate; // 0xAC
	internal InputStateBuffers m_StateBuffers; // 0xB0
	private InputSettings.ScrollDeltaBehavior m_ScrollDeltaBehavior; // 0xE8
	private CallbackArray<Action<InputDevice, InputDeviceChange>> m_DeviceChangeListeners; // 0xF0
	private CallbackArray<Action<InputDevice, InputEventPtr>> m_DeviceStateChangeListeners; // 0x140
	private CallbackArray<InputDeviceFindControlLayoutDelegate> m_DeviceFindLayoutCallbacks; // 0x190
	internal CallbackArray<InputDeviceCommandDelegate> m_DeviceCommandCallbacks; // 0x1E0
	private CallbackArray<Action<string, InputControlLayoutChange>> m_LayoutChangeListeners; // 0x230
	private CallbackArray<Action<InputEventPtr, InputDevice>> m_EventListeners; // 0x280
	private CallbackArray<Action> m_BeforeUpdateListeners; // 0x2D0
	private CallbackArray<Action> m_AfterUpdateListeners; // 0x320
	private CallbackArray<Action> m_SettingsChangedListeners; // 0x370
	private CallbackArray<Action> m_ActionsChangedListeners; // 0x3C0
	private bool m_NativeBeforeUpdateHooked; // 0x410
	private bool m_HaveDevicesWithStateCallbackReceivers; // 0x411
	private bool m_HasFocus; // 0x412
	private InputEventStream m_InputEventStream; // 0x418
	private InputDeviceExecuteCommandDelegate m_DeviceFindExecuteCommandDelegate; // 0x490
	private int m_DeviceFindExecuteCommandDeviceId; // 0x498
	internal IInputRuntime m_Runtime; // 0x4A0
	internal InputMetrics m_Metrics; // 0x4A8
	internal InputSettings m_Settings; // 0x4E0
	private bool m_OptimizedControlsFeatureEnabled; // 0x4E8
	private bool m_ReadValueCachingFeatureEnabled; // 0x4E9
	private bool m_ParanoidReadValueCachingChecksEnabled; // 0x4EA
	private InputActionAsset m_Actions; // 0x4F0
	private bool m_ShouldMakeCurrentlyUpdatingDeviceCurrent; // 0x4F8
	internal InputManager.StateChangeMonitorsForDevice[] m_StateChangeMonitors; // 0x500
	private InlinedArray<InputManager.StateChangeMonitorTimeout> m_StateChangeMonitorTimeouts; // 0x508

	// Properties
	public ReadOnlyArray<InputDevice> devices { get; }
	public TypeTable processors { get; }
	public TypeTable interactions { get; }
	public TypeTable composites { get; }
	public InputMetrics metrics { get; }
	public InputSettings settings { get; set; }
	public InputActionAsset actions { get; set; }
	public InputUpdateType updateMask { get; set; }
	public InputUpdateType defaultUpdateType { get; }
	public InputSettings.ScrollDeltaBehavior scrollDeltaBehavior { get; set; }
	public float pollingFrequency { get; set; }
	public bool isProcessingEvents { get; }
	private bool gameIsPlaying { get; }
	private bool gameHasFocus { get; }
	private bool gameShouldGetInputRegardlessOfFocus { get; }
	internal bool optimizedControlsFeatureEnabled { get; set; }
	internal bool readValueCachingFeatureEnabled { get; set; }
	internal bool paranoidReadValueCachingChecksEnabled { get; set; }

	// Methods

	// RVA: 0x2816EF0 Offset: 0x28158F0 VA: 0x182816EF0
	public ReadOnlyArray<InputDevice> get_devices() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public TypeTable get_processors() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public TypeTable get_interactions() { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public TypeTable get_composites() { }

	// RVA: 0x2816FD0 Offset: 0x28159D0 VA: 0x182816FD0
	public InputMetrics get_metrics() { }

	// RVA: 0x28171B0 Offset: 0x2815BB0 VA: 0x1828171B0
	public InputSettings get_settings() { }

	// RVA: 0x2817620 Offset: 0x2816020 VA: 0x182817620
	public void set_settings(InputSettings value) { }

	// RVA: 0x2816EC0 Offset: 0x28158C0 VA: 0x182816EC0
	public InputActionAsset get_actions() { }

	// RVA: 0x28174E0 Offset: 0x2815EE0 VA: 0x1828174E0
	public void set_actions(InputActionAsset value) { }

	// RVA: 0x587050 Offset: 0x585A50 VA: 0x180587050
	public InputUpdateType get_updateMask() { }

	// RVA: 0x2817720 Offset: 0x2816120 VA: 0x182817720
	public void set_updateMask(InputUpdateType value) { }

	// RVA: 0x2816ED0 Offset: 0x28158D0 VA: 0x182816ED0
	public InputUpdateType get_defaultUpdateType() { }

	// RVA: 0x51E8D0 Offset: 0x51D2D0 VA: 0x18051E8D0
	public InputSettings.ScrollDeltaBehavior get_scrollDeltaBehavior() { }

	// RVA: 0x2817610 Offset: 0x2816010 VA: 0x182817610
	public void set_scrollDeltaBehavior(InputSettings.ScrollDeltaBehavior value) { }

	// RVA: 0x4747C0 Offset: 0x4731C0 VA: 0x1804747C0
	public float get_pollingFrequency() { }

	// RVA: 0x2817530 Offset: 0x2815F30 VA: 0x182817530
	public void set_pollingFrequency(float value) { }

	// RVA: 0x2816C80 Offset: 0x2815680 VA: 0x182816C80
	public void add_onDeviceChange(Action<InputDevice, InputDeviceChange> value) { }

	// RVA: 0x28172B0 Offset: 0x2815CB0 VA: 0x1828172B0
	public void remove_onDeviceChange(Action<InputDevice, InputDeviceChange> value) { }

	// RVA: 0x2816D20 Offset: 0x2815720 VA: 0x182816D20
	public void add_onDeviceStateChange(Action<InputDevice, InputEventPtr> value) { }

	// RVA: 0x2817350 Offset: 0x2815D50 VA: 0x182817350
	public void remove_onDeviceStateChange(Action<InputDevice, InputEventPtr> value) { }

	// RVA: 0x2816CD0 Offset: 0x28156D0 VA: 0x182816CD0
	public void add_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x2817300 Offset: 0x2815D00 VA: 0x182817300
	public void remove_onDeviceCommand(InputDeviceCommandDelegate value) { }

	// RVA: 0x2816DC0 Offset: 0x28157C0 VA: 0x182816DC0
	public void add_onFindControlLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x28173F0 Offset: 0x2815DF0 VA: 0x1828173F0
	public void remove_onFindControlLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	// RVA: 0x2816E20 Offset: 0x2815820 VA: 0x182816E20
	public void add_onLayoutChange(Action<string, InputControlLayoutChange> value) { }

	// RVA: 0x2817440 Offset: 0x2815E40 VA: 0x182817440
	public void remove_onLayoutChange(Action<string, InputControlLayoutChange> value) { }

	// RVA: 0x2816D70 Offset: 0x2815770 VA: 0x182816D70
	public void add_onEvent(Action<InputEventPtr, InputDevice> value) { }

	// RVA: 0x28173A0 Offset: 0x2815DA0 VA: 0x1828173A0
	public void remove_onEvent(Action<InputEventPtr, InputDevice> value) { }

	// RVA: 0x2816C20 Offset: 0x2815620 VA: 0x182816C20
	public void add_onBeforeUpdate(Action value) { }

	// RVA: 0x2817260 Offset: 0x2815C60 VA: 0x182817260
	public void remove_onBeforeUpdate(Action value) { }

	// RVA: 0x2816BD0 Offset: 0x28155D0 VA: 0x182816BD0
	public void add_onAfterUpdate(Action value) { }

	// RVA: 0x2817210 Offset: 0x2815C10 VA: 0x182817210
	public void remove_onAfterUpdate(Action value) { }

	// RVA: 0x2816E70 Offset: 0x2815870 VA: 0x182816E70
	public void add_onSettingsChange(Action value) { }

	// RVA: 0x2817490 Offset: 0x2815E90 VA: 0x182817490
	public void remove_onSettingsChange(Action value) { }

	// RVA: 0x2816B80 Offset: 0x2815580 VA: 0x182816B80
	public void add_onActionsChange(Action value) { }

	// RVA: 0x28171C0 Offset: 0x2815BC0 VA: 0x1828171C0
	public void remove_onActionsChange(Action value) { }

	// RVA: 0x2816FC0 Offset: 0x28159C0 VA: 0x182816FC0
	public bool get_isProcessingEvents() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	private bool get_gameIsPlaying() { }

	// RVA: 0x2816F50 Offset: 0x2815950 VA: 0x182816F50
	private bool get_gameHasFocus() { }

	// RVA: 0x2816F90 Offset: 0x2815990 VA: 0x182816F90
	private bool get_gameShouldGetInputRegardlessOfFocus() { }

	// RVA: 0x28122C0 Offset: 0x2810CC0 VA: 0x1828122C0
	public void RegisterControlLayout(string name, Type type) { }

	// RVA: 0x2812980 Offset: 0x2811380 VA: 0x182812980
	public void RegisterControlLayout(string json, string name, bool isOverride = False) { }

	// RVA: 0x2811CF0 Offset: 0x28106F0 VA: 0x182811CF0
	public void RegisterControlLayoutBuilder(Func<InputControlLayout> method, string name, string baseLayout) { }

	// RVA: 0x2810830 Offset: 0x280F230 VA: 0x182810830
	private void PerformLayoutPostRegistration(InternedString layoutName, InlinedArray<InternedString> baseLayouts, bool isReplacement, bool isKnownToBeDeviceLayout = False, bool isOverride = False) { }

	// RVA: -1 Offset: -1
	public void RegisterPrecompiledLayout<TDevice>(string metadata) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDF320 Offset: 0xEDDD20 VA: 0x180EDF320
	|-InputManager.RegisterPrecompiledLayout<object>
	*/

	// RVA: 0x2811AF0 Offset: 0x28104F0 VA: 0x182811AF0
	private void RecreateDevicesUsingLayout(InternedString layout, bool isKnownToBeDeviceLayout = False) { }

	// RVA: 0x280E390 Offset: 0x280CD90 VA: 0x18280E390
	private bool IsControlOrChildUsingLayoutRecursive(InputControl control, InternedString layout) { }

	// RVA: 0x280E4A0 Offset: 0x280CEA0 VA: 0x18280E4A0
	private bool IsControlUsingLayout(InputControl control, InternedString layout) { }

	// RVA: 0x2812130 Offset: 0x2810B30 VA: 0x182812130
	public void RegisterControlLayoutMatcher(string layoutName, InputDeviceMatcher matcher) { }

	// RVA: 0x2811F00 Offset: 0x2810900 VA: 0x182811F00
	public void RegisterControlLayoutMatcher(Type type, InputDeviceMatcher matcher) { }

	// RVA: 0x2811830 Offset: 0x2810230 VA: 0x182811830
	private void RecreateDevicesUsingLayoutWithInferiorMatch(InputDeviceMatcher deviceMatcher) { }

	// RVA: 0x2811690 Offset: 0x2810090 VA: 0x182811690
	private void RecreateDevice(InputDevice oldDevice, InternedString newLayout) { }

	// RVA: 0x2808800 Offset: 0x2807200 VA: 0x182808800
	private void AddAvailableDevicesMatchingDescription(InputDeviceMatcher matcher, InternedString layout) { }

	// RVA: 0x2813390 Offset: 0x2811D90 VA: 0x182813390
	public void RemoveControlLayout(string name) { }

	// RVA: 0x2815450 Offset: 0x2813E50 VA: 0x182815450
	public InputControlLayout TryLoadControlLayout(Type type) { }

	// RVA: 0x2815420 Offset: 0x2813E20 VA: 0x182815420
	public InputControlLayout TryLoadControlLayout(InternedString name) { }

	// RVA: 0x2814D60 Offset: 0x2813760 VA: 0x182814D60
	public InternedString TryFindMatchingControlLayout(ref InputDeviceDescription deviceDescription, int deviceId = 0) { }

	// RVA: 0x280B6C0 Offset: 0x280A0C0 VA: 0x18280B6C0
	private InternedString FindOrRegisterDeviceLayoutForType(Type type) { }

	// RVA: 0x280E5A0 Offset: 0x280CFA0 VA: 0x18280E5A0
	private bool IsDeviceLayoutMarkedAsSupportedInSettings(InternedString layoutName) { }

	[IteratorStateMachine(typeof(InputManager.<ListControlLayouts>d__97))]
	// RVA: 0x280E6F0 Offset: 0x280D0F0 VA: 0x18280E6F0
	public IEnumerable<string> ListControlLayouts(string basedOn) { }

	// RVA: -1 Offset: -1
	public int GetControls<TControl>(string path, ref InputControlList<TControl> controls) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDF1C0 Offset: 0xEDDBC0 VA: 0x180EDF1C0
	|-InputManager.GetControls<object>
	*/

	// RVA: 0x28149E0 Offset: 0x28133E0 VA: 0x1828149E0
	public void SetDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x2808EA0 Offset: 0x28078A0 VA: 0x182808EA0
	public void AddDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x2813700 Offset: 0x2812100 VA: 0x182813700
	public void RemoveDeviceUsage(InputDevice device, InternedString usage) { }

	// RVA: 0x280ECB0 Offset: 0x280D6B0 VA: 0x18280ECB0
	private void NotifyUsageChanged(InputDevice device) { }

	// RVA: 0x2809390 Offset: 0x2807D90 VA: 0x182809390
	public InputDevice AddDevice(Type type, string name) { }

	// RVA: 0x2809530 Offset: 0x2807F30 VA: 0x182809530
	public InputDevice AddDevice(string layout, string name, InternedString variants) { }

	// RVA: 0x2809F00 Offset: 0x2808900 VA: 0x182809F00
	private InputDevice AddDevice(InternedString layout, int deviceId, string deviceName, InputDeviceDescription deviceDescription, InputDevice.DeviceFlags deviceFlags = 0, InternedString variants) { }

	// RVA: 0x28096A0 Offset: 0x28080A0 VA: 0x1828096A0
	public void AddDevice(InputDevice device) { }

	// RVA: 0x280A0E0 Offset: 0x2808AE0 VA: 0x18280A0E0
	public InputDevice AddDevice(InputDeviceDescription description) { }

	// RVA: 0x2809120 Offset: 0x2807B20 VA: 0x182809120
	public InputDevice AddDevice(InputDeviceDescription description, bool throwIfNoLayoutFound, string deviceName, int deviceId = 0, InputDevice.DeviceFlags deviceFlags = 0) { }

	// RVA: 0x2809010 Offset: 0x2807A10 VA: 0x182809010
	public InputDevice AddDevice(InputDeviceDescription description, InternedString layout, string deviceName, int deviceId = 0, InputDevice.DeviceFlags deviceFlags = 0) { }

	// RVA: 0x2813870 Offset: 0x2812270 VA: 0x182813870
	public void RemoveDevice(InputDevice device, bool keepOnListOfAvailableDevices = False) { }

	// RVA: 0x280BD90 Offset: 0x280A790 VA: 0x18280BD90
	public void FlushDisconnectedDevices() { }

	// RVA: 0x2814460 Offset: 0x2812E60 VA: 0x182814460
	public void ResetDevice(InputDevice device, bool alsoResetDontResetControls = False, Nullable<bool> issueResetCommand) { }

	// RVA: 0x2815260 Offset: 0x2813C60 VA: 0x182815260
	public InputDevice TryGetDevice(string nameOrLayout) { }

	// RVA: 0x280BDE0 Offset: 0x280A7E0 VA: 0x18280BDE0
	public InputDevice GetDevice(string nameOrLayout) { }

	// RVA: 0x28153B0 Offset: 0x2813DB0 VA: 0x1828153B0
	public InputDevice TryGetDevice(Type layoutType) { }

	// RVA: 0x28151E0 Offset: 0x2813BE0 VA: 0x1828151E0
	public InputDevice TryGetDeviceById(int id) { }

	// RVA: 0x280BE80 Offset: 0x280A880 VA: 0x18280BE80
	public int GetUnsupportedDevices(List<InputDeviceDescription> descriptions) { }

	// RVA: 0x280B2A0 Offset: 0x2809CA0 VA: 0x18280B2A0
	public void EnableOrDisableDevice(InputDevice device, bool enable, InputManager.DeviceDisableScope scope = 0) { }

	// RVA: 0x28112A0 Offset: 0x280FCA0 VA: 0x1828112A0
	private void QueueEvent(InputEvent* eventPtr) { }

	// RVA: 0x2811390 Offset: 0x280FD90 VA: 0x182811390
	public void QueueEvent(InputEventPtr ptr) { }

	// RVA: -1 Offset: -1
	public void QueueEvent<TEvent>(ref TEvent inputEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDF2B0 Offset: 0xEDDCB0 VA: 0x180EDF2B0
	|-InputManager.QueueEvent<DeltaStateEvent>
	|-InputManager.QueueEvent<DeviceConfigurationEvent>
	|-InputManager.QueueEvent<StateEvent>
	|-InputManager.QueueEvent<TextEvent>
	|
	|-RVA: 0xEDF2C0 Offset: 0xEDDCC0 VA: 0x180EDF2C0
	|-InputManager.QueueEvent<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2816540 Offset: 0x2814F40 VA: 0x182816540
	public void Update() { }

	// RVA: 0x2816470 Offset: 0x2814E70 VA: 0x182816470
	public void Update(InputUpdateType updateType) { }

	// RVA: 0x280D800 Offset: 0x280C200 VA: 0x18280D800
	internal void Initialize(IInputRuntime runtime, InputSettings settings) { }

	// RVA: 0x280B170 Offset: 0x2809B70 VA: 0x18280B170
	internal void Destroy() { }

	// RVA: 0x280C060 Offset: 0x280AA60 VA: 0x18280C060
	private void InitializeActions() { }

	// RVA: 0x280C110 Offset: 0x280AB10 VA: 0x18280C110
	internal void InitializeData() { }

	// RVA: 0x2813100 Offset: 0x2811B00 VA: 0x182813100
	private void RegisterCustomTypes(Type[] types) { }

	// RVA: 0x2812EF0 Offset: 0x28118F0 VA: 0x182812EF0
	private void RegisterCustomTypes() { }

	// RVA: 0x280DF70 Offset: 0x280C970 VA: 0x18280DF70
	internal void InstallRuntime(IInputRuntime runtime) { }

	// RVA: 0x280DCD0 Offset: 0x280C6D0 VA: 0x18280DCD0
	internal void InstallGlobals() { }

	// RVA: 0x2815A50 Offset: 0x2814450 VA: 0x182815A50
	internal void UninstallGlobals() { }

	// RVA: 0x2817180 Offset: 0x2815B80 VA: 0x182817180
	internal bool get_optimizedControlsFeatureEnabled() { }

	// RVA: 0x2817510 Offset: 0x2815F10 VA: 0x182817510
	internal void set_optimizedControlsFeatureEnabled(bool value) { }

	// RVA: 0x28171A0 Offset: 0x2815BA0 VA: 0x1828171A0
	internal bool get_readValueCachingFeatureEnabled() { }

	// RVA: 0x2817600 Offset: 0x2816000 VA: 0x182817600
	internal void set_readValueCachingFeatureEnabled(bool value) { }

	// RVA: 0x2817190 Offset: 0x2815B90 VA: 0x182817190
	internal bool get_paranoidReadValueCachingChecksEnabled() { }

	// RVA: 0x2817520 Offset: 0x2815F20 VA: 0x182817520
	internal void set_paranoidReadValueCachingChecksEnabled(bool value) { }

	// RVA: 0x280E780 Offset: 0x280D180 VA: 0x18280E780
	private void MakeDeviceNameUnique(InputDevice device) { }

	// RVA: 0x28142C0 Offset: 0x2812CC0 VA: 0x1828142C0
	private static void ResetControlPathsRecursive(InputControl control) { }

	// RVA: 0x280AE00 Offset: 0x2809800 VA: 0x18280AE00
	private void AssignUniqueDeviceId(InputDevice device) { }

	// RVA: 0x2811480 Offset: 0x280FE80 VA: 0x182811480
	private void ReallocateStateBuffers() { }

	// RVA: 0x280D2F0 Offset: 0x280BCF0 VA: 0x18280D2F0
	private void InitializeDefaultState(InputDevice device) { }

	// RVA: 0x280D4D0 Offset: 0x280BED0 VA: 0x18280D4D0
	private void InitializeDeviceState(InputDevice device) { }

	// RVA: 0x280F410 Offset: 0x280DE10 VA: 0x18280F410
	private void OnNativeDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	// RVA: 0x280E950 Offset: 0x280D350 VA: 0x18280E950
	private JsonParser.JsonString MakeEscapedJsonString(string theString) { }

	// RVA: 0x28156E0 Offset: 0x28140E0 VA: 0x1828156E0
	private InputDevice TryMatchDisconnectedDevice(string deviceDescriptor) { }

	// RVA: 0x280DC10 Offset: 0x280C610 VA: 0x18280DC10
	private void InstallBeforeUpdateHookIfNecessary() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void RestoreDevicesAfterDomainReloadIfNecessary() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void WarnAboutDevicesFailingToRecreateAfterDomainReload() { }

	// RVA: 0x280EDC0 Offset: 0x280D7C0 VA: 0x18280EDC0
	private void OnBeforeUpdate(InputUpdateType updateType) { }

	// RVA: 0x280A420 Offset: 0x2808E20 VA: 0x18280A420
	internal void ApplySettings() { }

	// RVA: 0x280A3A0 Offset: 0x2808DA0 VA: 0x18280A3A0
	internal void ApplyActions() { }

	// RVA: -1 Offset: -1
	internal long ExecuteGlobalCommand<TCommand>(ref TCommand command) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDF120 Offset: 0xEDDB20 VA: 0x180EDF120
	|-InputManager.ExecuteGlobalCommand<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2808C30 Offset: 0x2807630 VA: 0x182808C30
	internal void AddAvailableDevicesThatAreNowRecognized() { }

	// RVA: 0x2814B90 Offset: 0x2813590 VA: 0x182814B90
	private bool ShouldRunDeviceInBackground(InputDevice device) { }

	// RVA: 0x280EFC0 Offset: 0x280D9C0 VA: 0x18280EFC0
	internal void OnFocusChanged(bool focus) { }

	// RVA: 0x2814BD0 Offset: 0x28135D0 VA: 0x182814BD0
	internal bool ShouldRunUpdate(InputUpdateType updateType) { }

	// RVA: 0x280F830 Offset: 0x280E230 VA: 0x18280F830
	private void OnUpdate(InputUpdateType updateType, ref InputEventBuffer eventBuffer) { }

	// RVA: 0x280AB70 Offset: 0x2809570 VA: 0x18280AB70
	private bool AreMaximumEventBytesPerUpdateExceeded(uint totalEventBytesProcessed) { }

	// RVA: 0x280EB20 Offset: 0x280D520 VA: 0x18280EB20
	private string MakeStringWithEventsProcessedByDevice() { }

	// RVA: 0x28143C0 Offset: 0x2812DC0 VA: 0x1828143C0
	private void ResetCurrentProcessedEventBytesForDevices() { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x280AFD0 Offset: 0x28099D0 VA: 0x18280AFD0
	private void CheckAllDevicesOptimizedControlsHaveValidState() { }

	// RVA: 0x280E300 Offset: 0x280CD00 VA: 0x18280E300
	private void InvokeAfterUpdateCallback(InputUpdateType updateType) { }

	// RVA: 0x280B290 Offset: 0x2809C90 VA: 0x18280B290
	internal void DontMakeCurrentlyUpdatingDeviceCurrent() { }

	// RVA: 0x2815CB0 Offset: 0x28146B0 VA: 0x182815CB0
	internal bool UpdateState(InputDevice device, InputEvent* eventPtr, InputUpdateType updateType) { }

	// RVA: 0x2815E20 Offset: 0x2814820 VA: 0x182815E20
	internal bool UpdateState(InputDevice device, InputUpdateType updateType, void* statePtr, uint stateOffsetInDevice, uint stateSize, double internalTime, InputEventPtr eventPtr) { }

	// RVA: 0x2816630 Offset: 0x2815030 VA: 0x182816630
	private void WriteStateChange(InputStateBuffers.DoubleBuffers buffers, int deviceIndex, ref InputStateBlock deviceStateBlock, uint stateOffsetInDevice, void* statePtr, uint stateSizeInBytes, bool flippedBuffers) { }

	// RVA: 0x280BCE0 Offset: 0x280A6E0 VA: 0x18280BCE0
	private bool FlipBuffersForDeviceIfNecessary(InputDevice device, InputUpdateType updateType) { }

	// RVA: 0x280A230 Offset: 0x2808C30 VA: 0x18280A230
	public void AddStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex, uint groupIndex) { }

	// RVA: 0x2814180 Offset: 0x2812B80 VA: 0x182814180
	private void RemoveStateChangeMonitors(InputDevice device) { }

	// RVA: 0x2814000 Offset: 0x2812A00 VA: 0x182814000
	public void RemoveStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex) { }

	// RVA: 0x280A140 Offset: 0x2808B40 VA: 0x18280A140
	public void AddStateChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex, int timerIndex) { }

	// RVA: 0x2813EC0 Offset: 0x28128C0 VA: 0x182813EC0
	public void RemoveStateChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex, int timerIndex) { }

	// RVA: 0x2814D10 Offset: 0x2813710 VA: 0x182814D10
	private void SortStateChangeMonitorsIfNecessary(int deviceIndex) { }

	// RVA: 0x2814BF0 Offset: 0x28135F0 VA: 0x182814BF0
	public void SignalStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor) { }

	// RVA: 0x280BBE0 Offset: 0x280A5E0 VA: 0x18280BBE0
	public void FireStateChangeNotifications() { }

	// RVA: 0x2810FA0 Offset: 0x280F9A0 VA: 0x182810FA0
	private bool ProcessStateChangeMonitors(int deviceIndex, void* newStateFromEvent, void* oldStateOfDevice, uint newStateSizeInBytes, uint newStateOffsetInBytes) { }

	// RVA: 0x280B780 Offset: 0x280A180 VA: 0x18280B780
	internal void FireStateChangeNotifications(int deviceIndex, double internalTime, InputEvent* eventPtr) { }

	// RVA: 0x2810D80 Offset: 0x280F780 VA: 0x182810D80
	private void ProcessStateChangeMonitorTimeouts() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x2816860 Offset: 0x2815260 VA: 0x182816860
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x28159E0 Offset: 0x28143E0 VA: 0x1828159E0
	private long <TryFindMatchingControlLayout>b__94_0(ref InputDeviceCommand commandRef) { }
}
