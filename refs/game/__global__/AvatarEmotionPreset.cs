public class AvatarEmotionPreset // TypeDefIndex: 3133
{
	// Fields
	public string PresetName; // 0x10
	public Texture2D FaceTexture; // 0x18
	public Eye.EyeLidConfiguration LeftEyeRestingState; // 0x20
	public Eye.EyeLidConfiguration RightEyeRestingState; // 0x28
	[Range(-30, 30)]
	public float BrowAngleChange_L; // 0x30
	[Range(-30, 30)]
	public float BrowAngleChange_R; // 0x34
	[Range(-1, 1)]
	public float BrowHeightChange_L; // 0x38
	[Range(-1, 1)]
	public float BrowHeightChange_R; // 0x3C

	// Methods

	// RVA: 0x9AD4D0 Offset: 0x9ABED0 VA: 0x1809AD4D0
	public static AvatarEmotionPreset Lerp(AvatarEmotionPreset start, AvatarEmotionPreset end, AvatarEmotionPreset neutralPreset, float lerp) { }

	// RVA: 0x9AD870 Offset: 0x9AC270 VA: 0x1809AD870
	public void .ctor() { }
}
