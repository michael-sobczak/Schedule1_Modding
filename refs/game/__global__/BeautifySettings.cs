public class BeautifySettings : MonoBehaviour // TypeDefIndex: 9307
{
	// Fields
	[Header("Scene Settings")]
	public Transform sun; // 0x20
	public Transform depthOfFieldTarget; // 0x28
	public OnBeforeFocusEvent OnBeforeFocus; // 0x30
	public static float depthOfFieldCurrentFocalPointDistance; // 0x0
	public static int bloomExcludeMask; // 0x4
	public static int anamorphicFlaresExcludeMask; // 0x8
	public static bool dofTransparentSupport; // 0xC
	public static int dofTransparentLayerMask; // 0x10
	public static bool dofTransparentDoubleSided; // 0x14
	public static bool dofAlphaTestSupport; // 0x15
	public static int dofAlphaTestLayerMask; // 0x18
	public static bool dofAlphaTestDoubleSided; // 0x1C
	private static BeautifySettings _instance; // 0x20
	private static Volume _beautifyVolume; // 0x28
	private static Beautify _beautify; // 0x30

	// Properties
	public static BeautifySettings instance { get; }
	public static Beautify sharedSettings { get; }
	public static Beautify settings { get; }

	// Methods

	// RVA: 0x2AC47A0 Offset: 0x2AC31A0 VA: 0x182AC47A0
	public static void UnloadBeautify() { }

	// RVA: 0x2AC4860 Offset: 0x2AC3260 VA: 0x182AC4860
	public static BeautifySettings get_instance() { }

	// RVA: 0x2AC4640 Offset: 0x2AC3040 VA: 0x182AC4640
	private static Volume FindBeautifyVolume() { }

	// RVA: 0x2AC4C80 Offset: 0x2AC3680 VA: 0x182AC4C80
	public static Beautify get_sharedSettings() { }

	// RVA: 0x2AC4AE0 Offset: 0x2AC34E0 VA: 0x182AC4AE0
	public static Beautify get_settings() { }

	// RVA: 0x2AC44E0 Offset: 0x2AC2EE0 VA: 0x182AC44E0
	public static void Blink(float duration, float maxValue = 1) { }

	[IteratorStateMachine(typeof(BeautifySettings.<DoBlink>d__24))]
	// RVA: 0x2AC45D0 Offset: 0x2AC2FD0 VA: 0x182AC45D0
	private IEnumerator DoBlink(float duration, float maxValue) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void OnEnable() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
