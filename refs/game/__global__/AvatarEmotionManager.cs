public class AvatarEmotionManager : MonoBehaviour // TypeDefIndex: 3132
{
	// Fields
	public const float MAX_UPDATE_DISTANCE = 30;
	[CompilerGenerated]
	private string <CurrentEmotion>k__BackingField; // 0x20
	[CompilerGenerated]
	private AvatarEmotionPreset <CurrentEmotionPreset>k__BackingField; // 0x28
	[Header("Settings")]
	public List<AvatarEmotionPreset> EmotionPresetList; // 0x30
	[Header("References")]
	public Avatar Avatar; // 0x38
	public EyeController EyeController; // 0x40
	public EyebrowController EyebrowController; // 0x48
	private EmotionOverride activeEmotionOverride; // 0x50
	private List<EmotionOverride> overrideStack; // 0x58
	private AvatarEmotionPreset neutralPreset; // 0x60
	private Coroutine emotionLerpRoutine; // 0x68
	private Dictionary<string, Coroutine> emotionRemovalRoutines; // 0x70
	private int tempIndex; // 0x78

	// Properties
	public string CurrentEmotion { get; set; }
	public AvatarEmotionPreset CurrentEmotionPreset { get; set; }
	public bool IsSwitchingEmotion { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_CurrentEmotion() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_CurrentEmotion(string value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public AvatarEmotionPreset get_CurrentEmotionPreset() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	protected void set_CurrentEmotionPreset(AvatarEmotionPreset value) { }

	// RVA: 0x9AD4C0 Offset: 0x9ABEC0 VA: 0x1809AD4C0
	public bool get_IsSwitchingEmotion() { }

	// RVA: 0x9ACD30 Offset: 0x9AB730 VA: 0x1809ACD30
	private void Start() { }

	// RVA: 0x9ACEF0 Offset: 0x9AB8F0 VA: 0x1809ACEF0
	public void UpdateEmotion() { }

	// RVA: 0x9AC3F0 Offset: 0x9AADF0 VA: 0x1809AC3F0
	public void ConfigureNeutralFace(Texture2D faceTex, float restingBrowHeight, float restingBrowAngle, Eye.EyeLidConfiguration leftEyelidConfig, Eye.EyeLidConfiguration rightEyelidConfig) { }

	// RVA: 0x9ABEF0 Offset: 0x9AA8F0 VA: 0x1809ABEF0 Slot: 4
	public virtual void AddEmotionOverride(string emotionName, string overrideLabel, float duration = 0, int priority = 0) { }

	// RVA: 0x9ACA50 Offset: 0x9AB450 VA: 0x1809ACA50
	public void RemoveEmotionOverride(string label) { }

	// RVA: 0x9AC220 Offset: 0x9AAC20 VA: 0x1809AC220
	public void ClearOverrides() { }

	// RVA: 0x9AC300 Offset: 0x9AAD00 VA: 0x1809AC300
	private void ClearRemovalRoutine(string label) { }

	// RVA: 0x9AC740 Offset: 0x9AB140 VA: 0x1809AC740
	public EmotionOverride GetHighestPriorityOverride() { }

	// RVA: 0x9AC8B0 Offset: 0x9AB2B0 VA: 0x1809AC8B0
	private void LerpEmotion(AvatarEmotionPreset preset, float animationTime = 0.2) { }

	// RVA: 0x9ACB70 Offset: 0x9AB570 VA: 0x1809ACB70
	private void SetEmotion(AvatarEmotionPreset preset) { }

	// RVA: 0x9AC890 Offset: 0x9AB290 VA: 0x1809AC890
	public bool HasEmotion(string emotion) { }

	// RVA: 0x9AC660 Offset: 0x9AB060 VA: 0x1809AC660
	public AvatarEmotionPreset GetEmotion(string emotion) { }

	// RVA: 0x9AD390 Offset: 0x9ABD90 VA: 0x1809AD390
	public void .ctor() { }
}
