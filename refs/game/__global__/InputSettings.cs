public class InputSettings : ScriptableObject // TypeDefIndex: 7439
{
	// Fields
	[Tooltip("Determine which type of devices are used by the application. By default, this is empty meaning that all devices recognized by Unity will be used. Restricting the set of supported devices will make only those devices appear in the input system.")]
	[SerializeField]
	private string[] m_SupportedDevices; // 0x18
	[Tooltip("Determine when Unity processes events. By default, accumulated input events are flushed out before each fixed update and before each dynamic update. This setting can be used to restrict event processing to only where the application needs it.")]
	[SerializeField]
	private InputSettings.UpdateMode m_UpdateMode; // 0x20
	[SerializeField]
	private InputSettings.ScrollDeltaBehavior m_ScrollDeltaBehavior; // 0x24
	[SerializeField]
	private int m_MaxEventBytesPerUpdate; // 0x28
	[SerializeField]
	private int m_MaxQueuedEventsPerUpdate; // 0x2C
	[SerializeField]
	private bool m_CompensateForScreenOrientation; // 0x30
	[SerializeField]
	private InputSettings.BackgroundBehavior m_BackgroundBehavior; // 0x34
	[SerializeField]
	private InputSettings.EditorInputBehaviorInPlayMode m_EditorInputBehaviorInPlayMode; // 0x38
	[SerializeField]
	private InputSettings.InputActionPropertyDrawerMode m_InputActionPropertyDrawerMode; // 0x3C
	[SerializeField]
	private float m_DefaultDeadzoneMin; // 0x40
	[SerializeField]
	private float m_DefaultDeadzoneMax; // 0x44
	[Min(0.0001)]
	[SerializeField]
	private float m_DefaultButtonPressPoint; // 0x48
	[SerializeField]
	private float m_ButtonReleaseThreshold; // 0x4C
	[SerializeField]
	private float m_DefaultTapTime; // 0x50
	[SerializeField]
	private float m_DefaultSlowTapTime; // 0x54
	[SerializeField]
	private float m_DefaultHoldTime; // 0x58
	[SerializeField]
	private float m_TapRadius; // 0x5C
	[SerializeField]
	private float m_MultiTapDelayTime; // 0x60
	[SerializeField]
	private bool m_DisableRedundantEventsMerging; // 0x64
	[SerializeField]
	private bool m_ShortcutKeysConsumeInputs; // 0x65
	internal HashSet<string> m_FeatureFlags; // 0x68
	internal const int s_OldUnsupportedFixedAndDynamicUpdateSetting = 0;

	// Properties
	public InputSettings.UpdateMode updateMode { get; set; }
	public InputSettings.ScrollDeltaBehavior scrollDeltaBehavior { get; set; }
	public bool compensateForScreenOrientation { get; set; }
	[Obsolete("filterNoiseOnCurrent is deprecated, filtering of noise is always enabled now.", False)]
	public bool filterNoiseOnCurrent { get; set; }
	public float defaultDeadzoneMin { get; set; }
	public float defaultDeadzoneMax { get; set; }
	public float defaultButtonPressPoint { get; set; }
	public float buttonReleaseThreshold { get; set; }
	public float defaultTapTime { get; set; }
	public float defaultSlowTapTime { get; set; }
	public float defaultHoldTime { get; set; }
	public float tapRadius { get; set; }
	public float multiTapDelayTime { get; set; }
	public InputSettings.BackgroundBehavior backgroundBehavior { get; set; }
	public InputSettings.EditorInputBehaviorInPlayMode editorInputBehaviorInPlayMode { get; set; }
	public InputSettings.InputActionPropertyDrawerMode inputActionPropertyDrawerMode { get; set; }
	public int maxEventBytesPerUpdate { get; set; }
	public int maxQueuedEventsPerUpdate { get; set; }
	public ReadOnlyArray<string> supportedDevices { get; set; }
	public bool disableRedundantEventsMerging { get; set; }
	public bool shortcutKeysConsumeInput { get; set; }

	// Methods

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public InputSettings.UpdateMode get_updateMode() { }

	// RVA: 0x2820FE0 Offset: 0x281F9E0 VA: 0x182820FE0
	public void set_updateMode(InputSettings.UpdateMode value) { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public InputSettings.ScrollDeltaBehavior get_scrollDeltaBehavior() { }

	// RVA: 0x2820E20 Offset: 0x281F820 VA: 0x182820E20
	public void set_scrollDeltaBehavior(InputSettings.ScrollDeltaBehavior value) { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_compensateForScreenOrientation() { }

	// RVA: 0x2820CC0 Offset: 0x281F6C0 VA: 0x182820CC0
	public void set_compensateForScreenOrientation(bool value) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public bool get_filterNoiseOnCurrent() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void set_filterNoiseOnCurrent(bool value) { }

	// RVA: 0x495F60 Offset: 0x494960 VA: 0x180495F60
	public float get_defaultDeadzoneMin() { }

	// RVA: 0x2820D30 Offset: 0x281F730 VA: 0x182820D30
	public void set_defaultDeadzoneMin(float value) { }

	// RVA: 0x49D270 Offset: 0x49BC70 VA: 0x18049D270
	public float get_defaultDeadzoneMax() { }

	// RVA: 0x2820D10 Offset: 0x281F710 VA: 0x182820D10
	public void set_defaultDeadzoneMax(float value) { }

	// RVA: 0x495E80 Offset: 0x494880 VA: 0x180495E80
	public float get_defaultButtonPressPoint() { }

	// RVA: 0x2820CD0 Offset: 0x281F6D0 VA: 0x182820CD0
	public void set_defaultButtonPressPoint(float value) { }

	// RVA: 0x495F70 Offset: 0x494970 VA: 0x180495F70
	public float get_buttonReleaseThreshold() { }

	// RVA: 0x2820CA0 Offset: 0x281F6A0 VA: 0x182820CA0
	public void set_buttonReleaseThreshold(float value) { }

	// RVA: 0x4C3B50 Offset: 0x4C2550 VA: 0x1804C3B50
	public float get_defaultTapTime() { }

	// RVA: 0x2820D90 Offset: 0x281F790 VA: 0x182820D90
	public void set_defaultTapTime(float value) { }

	// RVA: 0x4B5420 Offset: 0x4B3E20 VA: 0x1804B5420
	public float get_defaultSlowTapTime() { }

	// RVA: 0x2820D70 Offset: 0x281F770 VA: 0x182820D70
	public void set_defaultSlowTapTime(float value) { }

	// RVA: 0x4B6210 Offset: 0x4B4C10 VA: 0x1804B6210
	public float get_defaultHoldTime() { }

	// RVA: 0x2820D50 Offset: 0x281F750 VA: 0x182820D50
	public void set_defaultHoldTime(float value) { }

	// RVA: 0x4B5C00 Offset: 0x4B4600 VA: 0x1804B5C00
	public float get_tapRadius() { }

	// RVA: 0x2820FC0 Offset: 0x281F9C0 VA: 0x182820FC0
	public void set_tapRadius(float value) { }

	// RVA: 0x4B5440 Offset: 0x4B3E40 VA: 0x1804B5440
	public float get_multiTapDelayTime() { }

	// RVA: 0x2820E00 Offset: 0x281F800 VA: 0x182820E00
	public void set_multiTapDelayTime(float value) { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public InputSettings.BackgroundBehavior get_backgroundBehavior() { }

	// RVA: 0x2820C90 Offset: 0x281F690 VA: 0x182820C90
	public void set_backgroundBehavior(InputSettings.BackgroundBehavior value) { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public InputSettings.EditorInputBehaviorInPlayMode get_editorInputBehaviorInPlayMode() { }

	// RVA: 0x2820DC0 Offset: 0x281F7C0 VA: 0x182820DC0
	public void set_editorInputBehaviorInPlayMode(InputSettings.EditorInputBehaviorInPlayMode value) { }

	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0
	public InputSettings.InputActionPropertyDrawerMode get_inputActionPropertyDrawerMode() { }

	// RVA: 0x2820DD0 Offset: 0x281F7D0 VA: 0x182820DD0
	public void set_inputActionPropertyDrawerMode(InputSettings.InputActionPropertyDrawerMode value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_maxEventBytesPerUpdate() { }

	// RVA: 0x2820DE0 Offset: 0x281F7E0 VA: 0x182820DE0
	public void set_maxEventBytesPerUpdate(int value) { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public int get_maxQueuedEventsPerUpdate() { }

	// RVA: 0x2820DF0 Offset: 0x281F7F0 VA: 0x182820DF0
	public void set_maxQueuedEventsPerUpdate(int value) { }

	// RVA: 0x2820C30 Offset: 0x281F630 VA: 0x182820C30
	public ReadOnlyArray<string> get_supportedDevices() { }

	// RVA: 0x2820E40 Offset: 0x281F840 VA: 0x182820E40
	public void set_supportedDevices(ReadOnlyArray<string> value) { }

	// RVA: 0x4E21A0 Offset: 0x4E0BA0 VA: 0x1804E21A0
	public bool get_disableRedundantEventsMerging() { }

	// RVA: 0x2820DB0 Offset: 0x281F7B0 VA: 0x182820DB0
	public void set_disableRedundantEventsMerging(bool value) { }

	// RVA: 0x20902A0 Offset: 0x208ECA0 VA: 0x1820902A0
	public bool get_shortcutKeysConsumeInput() { }

	// RVA: 0x2820E30 Offset: 0x281F830 VA: 0x182820E30
	public void set_shortcutKeysConsumeInput(bool value) { }

	// RVA: 0x2820A50 Offset: 0x281F450 VA: 0x182820A50
	public void SetInternalFeatureFlag(string featureName, bool enabled) { }

	// RVA: 0x2820900 Offset: 0x281F300 VA: 0x182820900
	internal bool IsFeatureEnabled(string featureName) { }

	// RVA: 0x2820980 Offset: 0x281F380 VA: 0x182820980
	internal void OnChange() { }

	// RVA: 0x28208E0 Offset: 0x281F2E0 VA: 0x1828208E0
	private static bool CompareFloats(float a, float b) { }

	// RVA: -1 Offset: -1
	private static bool CompareSets<T>(ReadOnlyArray<T> a, ReadOnlyArray<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE0290 Offset: 0xEDEC90 VA: 0x180EE0290
	|-InputSettings.CompareSets<object>
	|
	|-RVA: 0xEDFFE0 Offset: 0xEDE9E0 VA: 0x180EDFFE0
	|-InputSettings.CompareSets<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x28207F0 Offset: 0x281F1F0 VA: 0x1828207F0
	private static bool CompareFeatureFlag(InputSettings a, InputSettings b, string featureName) { }

	// RVA: 0x2820120 Offset: 0x281EB20 VA: 0x182820120
	internal static bool AreEqual(InputSettings a, InputSettings b) { }

	// RVA: 0x2820BD0 Offset: 0x281F5D0 VA: 0x182820BD0
	public void .ctor() { }
}
