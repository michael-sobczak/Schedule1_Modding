public class CustomizationManager : Singleton<CustomizationManager> // TypeDefIndex: 3182
{
	// Fields
	public const string AppearancesFolderPath = "Assets/Resources/Appearances";
	[SerializeField]
	private AvatarSettings ActiveSettings; // 0x28
	public Avatar TemplateAvatar; // 0x30
	public TMP_InputField SaveInputField; // 0x38
	public TMP_InputField LoadInputField; // 0x40
	public Toggle GenerateCombinedLayerToggle; // 0x48
	public CustomizationManager.AvatarSettingsChanged OnAvatarSettingsChanged; // 0x50
	public AvatarSettings DefaultSettings; // 0x58
	private bool isEditingOriginal; // 0x60
	private string loadedSettingsAssetPath; // 0x68

	// Methods

	// RVA: 0x9B8DA0 Offset: 0x9B77A0 VA: 0x1809B8DA0 Slot: 4
	protected override void Start() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void CreateSettings(string assetName, string assetPath) { }

	// RVA: 0x9B81A0 Offset: 0x9B6BA0 VA: 0x1809B81A0
	public void CreateSettings() { }

	// RVA: 0x9B8B30 Offset: 0x9B7530 VA: 0x1809B8B30
	public void LoadSettings(AvatarSettings loadedSettings) { }

	// RVA: 0x9B8820 Offset: 0x9B7220 VA: 0x1809B8820
	public void LoadSettings(string path, bool editOriginal = False) { }

	// RVA: 0x9B7C90 Offset: 0x9B6690 VA: 0x1809B7C90
	private void ApplyDefaultSettings(AvatarSettings settings) { }

	// RVA: 0x9B8950 Offset: 0x9B7350 VA: 0x1809B8950
	public void LoadSettings() { }

	// RVA: 0x9B86A0 Offset: 0x9B70A0 VA: 0x1809B86A0
	public void GenderChanged(float genderScale) { }

	// RVA: 0x9B8E70 Offset: 0x9B7870 VA: 0x1809B8E70
	public void WeightChanged(float weightScale) { }

	// RVA: 0x9B87E0 Offset: 0x9B71E0 VA: 0x1809B87E0
	public void HeightChanged(float height) { }

	// RVA: 0x9B8D10 Offset: 0x9B7710 VA: 0x1809B8D10
	public void SkinColorChanged(Color col) { }

	// RVA: 0x9B86E0 Offset: 0x9B70E0 VA: 0x1809B86E0
	public void HairChanged(Accessory newHair) { }

	// RVA: 0x9B87A0 Offset: 0x9B71A0 VA: 0x1809B87A0
	public void HairColorChanged(Color newCol) { }

	// RVA: 0x9B82A0 Offset: 0x9B6CA0 VA: 0x1809B82A0
	public void EyeBallTintChanged(Color col) { }

	// RVA: 0x9B8E30 Offset: 0x9B7830 VA: 0x1809B8E30
	public void UpperEyeLidRestingPositionChanged(float newVal) { }

	// RVA: 0x9B8C90 Offset: 0x9B7690 VA: 0x1809B8C90
	public void LowerEyeLidRestingPositionChanged(float newVal) { }

	// RVA: 0x9B8360 Offset: 0x9B6D60 VA: 0x1809B8360
	public void EyebrowScaleChanged(float newVal) { }

	// RVA: 0x9B83A0 Offset: 0x9B6DA0 VA: 0x1809B83A0
	public void EyebrowThicknessChanged(float newVal) { }

	// RVA: 0x9B8320 Offset: 0x9B6D20 VA: 0x1809B8320
	public void EyebrowRestingHeightChanged(float newVal) { }

	// RVA: 0x9B82E0 Offset: 0x9B6CE0 VA: 0x1809B82E0
	public void EyebrowRestingAngleChanged(float newVal) { }

	// RVA: 0x9B8CD0 Offset: 0x9B76D0 VA: 0x1809B8CD0
	public void PupilDilationChanged(float dilation) { }

	// RVA: 0x9B83E0 Offset: 0x9B6DE0 VA: 0x1809B83E0
	public void FaceLayerChanged(FaceLayer layer, int index) { }

	// RVA: 0x9B8570 Offset: 0x9B6F70 VA: 0x1809B8570
	public void FaceLayerColorChanged(Color col, int index) { }

	// RVA: 0x9B7ED0 Offset: 0x9B68D0 VA: 0x1809B7ED0
	public void BodyLayerChanged(AvatarLayer layer, int index) { }

	// RVA: 0x9B8060 Offset: 0x9B6A60 VA: 0x1809B8060
	public void BodyLayerColorChanged(Color col, int index) { }

	// RVA: 0x9B78A0 Offset: 0x9B62A0 VA: 0x1809B78A0
	public void AccessoryChanged(Accessory acc, int index) { }

	// RVA: 0x9B7B60 Offset: 0x9B6560 VA: 0x1809B7B60
	public void AccessoryColorChanged(Color col, int index) { }

	// RVA: 0x9B8EB0 Offset: 0x9B78B0 VA: 0x1809B8EB0
	public void .ctor() { }
}
