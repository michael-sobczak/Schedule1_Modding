public class AvatarSettings : ScriptableObject // TypeDefIndex: 3103
{
	// Fields
	public Color SkinColor; // 0x18
	public float Height; // 0x28
	public float Gender; // 0x2C
	public float Weight; // 0x30
	public string HairPath; // 0x38
	public Color HairColor; // 0x40
	public float EyebrowScale; // 0x50
	public float EyebrowThickness; // 0x54
	public float EyebrowRestingHeight; // 0x58
	public float EyebrowRestingAngle; // 0x5C
	public Color LeftEyeLidColor; // 0x60
	public Color RightEyeLidColor; // 0x70
	public Eye.EyeLidConfiguration LeftEyeRestingState; // 0x80
	public Eye.EyeLidConfiguration RightEyeRestingState; // 0x88
	public string EyeballMaterialIdentifier; // 0x90
	public Color EyeBallTint; // 0x98
	public float PupilDilation; // 0xA8
	public List<AvatarSettings.LayerSetting> FaceLayerSettings; // 0xB0
	public List<AvatarSettings.LayerSetting> BodyLayerSettings; // 0xB8
	public List<AvatarSettings.AccessorySetting> AccessorySettings; // 0xC0
	[CodegenExclude]
	public bool UseCombinedLayer; // 0xC8
	[CodegenExclude]
	public AvatarLayer CombinedLayer; // 0xD0
	[CodegenExclude]
	public Texture2D ImpostorTexture; // 0xD8

	// Properties
	public float UpperEyelidRestingPosition { get; }
	public float LowerEyelidRestingPosition { get; }
	public string FaceLayer1Path { get; }
	public Color FaceLayer1Color { get; }
	public string FaceLayer2Path { get; }
	public Color FaceLayer2Color { get; }
	public string FaceLayer3Path { get; }
	public Color FaceLayer3Color { get; }
	public string FaceLayer4Path { get; }
	public Color FaceLayer4Color { get; }
	public string FaceLayer5Path { get; }
	public Color FaceLayer5Color { get; }
	public string FaceLayer6Path { get; }
	public Color FaceLayer6Color { get; }
	public string BodyLayer1Path { get; }
	public Color BodyLayer1Color { get; }
	public string BodyLayer2Path { get; }
	public Color BodyLayer2Color { get; }
	public string BodyLayer3Path { get; }
	public Color BodyLayer3Color { get; }
	public string BodyLayer4Path { get; }
	public Color BodyLayer4Color { get; }
	public string BodyLayer5Path { get; }
	public Color BodyLayer5Color { get; }
	public string BodyLayer6Path { get; }
	public Color BodyLayer6Color { get; }
	public string Accessory1Path { get; }
	public Color Accessory1Color { get; }
	public string Accessory2Path { get; }
	public Color Accessory2Color { get; }
	public string Accessory3Path { get; }
	public Color Accessory3Color { get; }
	public string Accessory4Path { get; }
	public Color Accessory4Color { get; }
	public string Accessory5Path { get; }
	public Color Accessory5Color { get; }
	public string Accessory6Path { get; }
	public Color Accessory6Color { get; }
	public string Accessory7Path { get; }
	public Color Accessory7Color { get; }
	public string Accessory8Path { get; }
	public Color Accessory8Color { get; }
	public string Accessory9Path { get; }
	public Color Accessory9Color { get; }
	public object Item { get; }

	// Methods

	// RVA: 0x6A5300 Offset: 0x6A3D00 VA: 0x1806A5300
	public float get_UpperEyelidRestingPosition() { }

	// RVA: 0x9B5520 Offset: 0x9B3F20 VA: 0x1809B5520
	public float get_LowerEyelidRestingPosition() { }

	// RVA: 0x9B4E00 Offset: 0x9B3800 VA: 0x1809B4E00
	public string get_FaceLayer1Path() { }

	// RVA: 0x9B4D60 Offset: 0x9B3760 VA: 0x1809B4D60
	public Color get_FaceLayer1Color() { }

	// RVA: 0x9B4F20 Offset: 0x9B3920 VA: 0x1809B4F20
	public string get_FaceLayer2Path() { }

	// RVA: 0x9B4E80 Offset: 0x9B3880 VA: 0x1809B4E80
	public Color get_FaceLayer2Color() { }

	// RVA: 0x9B5040 Offset: 0x9B3A40 VA: 0x1809B5040
	public string get_FaceLayer3Path() { }

	// RVA: 0x9B4FA0 Offset: 0x9B39A0 VA: 0x1809B4FA0
	public Color get_FaceLayer3Color() { }

	// RVA: 0x9B5160 Offset: 0x9B3B60 VA: 0x1809B5160
	public string get_FaceLayer4Path() { }

	// RVA: 0x9B50C0 Offset: 0x9B3AC0 VA: 0x1809B50C0
	public Color get_FaceLayer4Color() { }

	// RVA: 0x9B5280 Offset: 0x9B3C80 VA: 0x1809B5280
	public string get_FaceLayer5Path() { }

	// RVA: 0x9B51E0 Offset: 0x9B3BE0 VA: 0x1809B51E0
	public Color get_FaceLayer5Color() { }

	// RVA: 0x9B53A0 Offset: 0x9B3DA0 VA: 0x1809B53A0
	public string get_FaceLayer6Path() { }

	// RVA: 0x9B5300 Offset: 0x9B3D00 VA: 0x1809B5300
	public Color get_FaceLayer6Color() { }

	// RVA: 0x9B4740 Offset: 0x9B3140 VA: 0x1809B4740
	public string get_BodyLayer1Path() { }

	// RVA: 0x9B46A0 Offset: 0x9B30A0 VA: 0x1809B46A0
	public Color get_BodyLayer1Color() { }

	// RVA: 0x9B4860 Offset: 0x9B3260 VA: 0x1809B4860
	public string get_BodyLayer2Path() { }

	// RVA: 0x9B47C0 Offset: 0x9B31C0 VA: 0x1809B47C0
	public Color get_BodyLayer2Color() { }

	// RVA: 0x9B4980 Offset: 0x9B3380 VA: 0x1809B4980
	public string get_BodyLayer3Path() { }

	// RVA: 0x9B48E0 Offset: 0x9B32E0 VA: 0x1809B48E0
	public Color get_BodyLayer3Color() { }

	// RVA: 0x9B4AA0 Offset: 0x9B34A0 VA: 0x1809B4AA0
	public string get_BodyLayer4Path() { }

	// RVA: 0x9B4A00 Offset: 0x9B3400 VA: 0x1809B4A00
	public Color get_BodyLayer4Color() { }

	// RVA: 0x9B4BC0 Offset: 0x9B35C0 VA: 0x1809B4BC0
	public string get_BodyLayer5Path() { }

	// RVA: 0x9B4B20 Offset: 0x9B3520 VA: 0x1809B4B20
	public Color get_BodyLayer5Color() { }

	// RVA: 0x9B4CE0 Offset: 0x9B36E0 VA: 0x1809B4CE0
	public string get_BodyLayer6Path() { }

	// RVA: 0x9B4C40 Offset: 0x9B3640 VA: 0x1809B4C40
	public Color get_BodyLayer6Color() { }

	// RVA: 0x9B3D20 Offset: 0x9B2720 VA: 0x1809B3D20
	public string get_Accessory1Path() { }

	// RVA: 0x9B3C80 Offset: 0x9B2680 VA: 0x1809B3C80
	public Color get_Accessory1Color() { }

	// RVA: 0x9B3E40 Offset: 0x9B2840 VA: 0x1809B3E40
	public string get_Accessory2Path() { }

	// RVA: 0x9B3DA0 Offset: 0x9B27A0 VA: 0x1809B3DA0
	public Color get_Accessory2Color() { }

	// RVA: 0x9B3F60 Offset: 0x9B2960 VA: 0x1809B3F60
	public string get_Accessory3Path() { }

	// RVA: 0x9B3EC0 Offset: 0x9B28C0 VA: 0x1809B3EC0
	public Color get_Accessory3Color() { }

	// RVA: 0x9B4080 Offset: 0x9B2A80 VA: 0x1809B4080
	public string get_Accessory4Path() { }

	// RVA: 0x9B3FE0 Offset: 0x9B29E0 VA: 0x1809B3FE0
	public Color get_Accessory4Color() { }

	// RVA: 0x9B41A0 Offset: 0x9B2BA0 VA: 0x1809B41A0
	public string get_Accessory5Path() { }

	// RVA: 0x9B4100 Offset: 0x9B2B00 VA: 0x1809B4100
	public Color get_Accessory5Color() { }

	// RVA: 0x9B42C0 Offset: 0x9B2CC0 VA: 0x1809B42C0
	public string get_Accessory6Path() { }

	// RVA: 0x9B4220 Offset: 0x9B2C20 VA: 0x1809B4220
	public Color get_Accessory6Color() { }

	// RVA: 0x9B43E0 Offset: 0x9B2DE0 VA: 0x1809B43E0
	public string get_Accessory7Path() { }

	// RVA: 0x9B4340 Offset: 0x9B2D40 VA: 0x1809B4340
	public Color get_Accessory7Color() { }

	// RVA: 0x9B4500 Offset: 0x9B2F00 VA: 0x1809B4500
	public string get_Accessory8Path() { }

	// RVA: 0x9B4460 Offset: 0x9B2E60 VA: 0x1809B4460
	public Color get_Accessory8Color() { }

	// RVA: 0x9B4620 Offset: 0x9B3020 VA: 0x1809B4620
	public string get_Accessory9Path() { }

	// RVA: 0x9B4580 Offset: 0x9B2F80 VA: 0x1809B4580
	public Color get_Accessory9Color() { }

	// RVA: 0x9B5420 Offset: 0x9B3E20 VA: 0x1809B5420
	public object get_Item(string propertyName) { }

	// RVA: 0x9B3B70 Offset: 0x9B2570 VA: 0x1809B3B70 Slot: 4
	public virtual string GetJson(bool prettyPrint = True) { }

	// RVA: 0x9B3B80 Offset: 0x9B2580 VA: 0x1809B3B80
	public void .ctor() { }
}
