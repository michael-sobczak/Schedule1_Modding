public class BasicAvatarSettings : ScriptableObject // TypeDefIndex: 3176
{
	// Fields
	public const float GenderScaleMultiplier = 0.7;
	public const string MaleUnderwearPath = "Avatar/Layers/Bottom/MaleUnderwear";
	public const string FemaleUnderwearPath = "Avatar/Layers/Bottom/FemaleUnderwear";
	public int Gender; // 0x18
	public float Weight; // 0x1C
	public Color SkinColor; // 0x20
	public string HairStyle; // 0x30
	public Color HairColor; // 0x38
	public string Mouth; // 0x48
	public string FacialHair; // 0x50
	public string FacialDetails; // 0x58
	public float FacialDetailsIntensity; // 0x60
	public Color EyeballColor; // 0x64
	public float UpperEyeLidRestingPosition; // 0x74
	public float LowerEyeLidRestingPosition; // 0x78
	public float PupilDilation; // 0x7C
	public float EyebrowScale; // 0x80
	public float EyebrowThickness; // 0x84
	public float EyebrowRestingHeight; // 0x88
	public float EyebrowRestingAngle; // 0x8C
	public string Top; // 0x90
	public Color TopColor; // 0x98
	public string Bottom; // 0xA8
	public Color BottomColor; // 0xB0
	public string Shoes; // 0xC0
	public Color ShoesColor; // 0xC8
	public string Headwear; // 0xD8
	public Color HeadwearColor; // 0xE0
	public string Eyewear; // 0xF0
	public Color EyewearColor; // 0xF8
	public List<string> Tattoos; // 0x108

	// Methods

	// RVA: -1 Offset: -1
	public T SetValue<T>(string fieldName, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE58C90 Offset: 0xE57690 VA: 0x180E58C90
	|-BasicAvatarSettings.SetValue<Color>
	|
	|-RVA: 0xE58EA0 Offset: 0xE578A0 VA: 0x180E58EA0
	|-BasicAvatarSettings.SetValue<int>
	|
	|-RVA: 0xE58F40 Offset: 0xE57940 VA: 0x180E58F40
	|-BasicAvatarSettings.SetValue<object>
	|
	|-RVA: 0xE58FB0 Offset: 0xE579B0 VA: 0x180E58FB0
	|-BasicAvatarSettings.SetValue<float>
	|
	|-RVA: 0xE58D50 Offset: 0xE57750 VA: 0x180E58D50
	|-BasicAvatarSettings.SetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T GetValue<T>(string fieldName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE58750 Offset: 0xE57150 VA: 0x180E58750
	|-BasicAvatarSettings.GetValue<Color>
	|
	|-RVA: 0xE589D0 Offset: 0xE573D0 VA: 0x180E589D0
	|-BasicAvatarSettings.GetValue<int>
	|
	|-RVA: 0xE58AC0 Offset: 0xE574C0 VA: 0x180E58AC0
	|-BasicAvatarSettings.GetValue<object>
	|
	|-RVA: 0xE58BA0 Offset: 0xE575A0 VA: 0x180E58BA0
	|-BasicAvatarSettings.GetValue<float>
	|
	|-RVA: 0xE58850 Offset: 0xE57250 VA: 0x180E58850
	|-BasicAvatarSettings.GetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x9B56A0 Offset: 0x9B40A0 VA: 0x1809B56A0
	public AvatarSettings GetAvatarSettings() { }

	// RVA: 0x9B3B70 Offset: 0x9B2570 VA: 0x1809B3B70 Slot: 4
	public virtual string GetJson(bool prettyPrint = True) { }

	// RVA: 0x9B64B0 Offset: 0x9B4EB0 VA: 0x1809B64B0
	public void .ctor() { }
}
