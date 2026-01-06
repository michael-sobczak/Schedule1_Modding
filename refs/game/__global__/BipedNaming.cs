public static class BipedNaming // TypeDefIndex: 14024
{
	// Fields
	public static string[] typeLeft; // 0x0
	public static string[] typeRight; // 0x8
	public static string[] typeSpine; // 0x10
	public static string[] typeHead; // 0x18
	public static string[] typeArm; // 0x20
	public static string[] typeLeg; // 0x28
	public static string[] typeTail; // 0x30
	public static string[] typeEye; // 0x38
	public static string[] typeExclude; // 0x40
	public static string[] typeExcludeSpine; // 0x48
	public static string[] typeExcludeHead; // 0x50
	public static string[] typeExcludeArm; // 0x58
	public static string[] typeExcludeLeg; // 0x60
	public static string[] typeExcludeTail; // 0x68
	public static string[] typeExcludeEye; // 0x70
	public static string[] pelvis; // 0x78
	public static string[] hand; // 0x80
	public static string[] foot; // 0x88

	// Methods

	// RVA: 0x1E9B500 Offset: 0x1E99F00 VA: 0x181E9B500
	public static Transform[] GetBonesOfType(BipedNaming.BoneType boneType, Transform[] bones) { }

	// RVA: 0x1E9B170 Offset: 0x1E99B70 VA: 0x181E9B170
	public static Transform[] GetBonesOfSide(BipedNaming.BoneSide boneSide, Transform[] bones) { }

	// RVA: 0x1E9B310 Offset: 0x1E99D10 VA: 0x181E9B310
	public static Transform[] GetBonesOfTypeAndSide(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, Transform[] bones) { }

	// RVA: 0x1E9B6A0 Offset: 0x1E9A0A0 VA: 0x181E9B6A0
	public static Transform GetFirstBoneOfTypeAndSide(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, Transform[] bones) { }

	// RVA: 0x1E9B740 Offset: 0x1E9A140 VA: 0x181E9B740
	public static Transform GetNamingMatch(Transform[] transforms, string[][] namings) { }

	// RVA: 0x1E9AF90 Offset: 0x1E99990 VA: 0x181E9AF90
	public static BipedNaming.BoneType GetBoneType(string boneName) { }

	// RVA: 0x1E9AF10 Offset: 0x1E99910 VA: 0x181E9AF10
	public static BipedNaming.BoneSide GetBoneSide(string boneName) { }

	// RVA: 0x1E9B0E0 Offset: 0x1E99AE0 VA: 0x181E9B0E0
	public static Transform GetBone(Transform[] transforms, BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide = 0, string[][] namings) { }

	// RVA: 0x1E9D880 Offset: 0x1E9C280 VA: 0x181E9D880
	private static bool isLeft(string boneName) { }

	// RVA: 0x1E9DC80 Offset: 0x1E9C680 VA: 0x181E9DC80
	private static bool isRight(string boneName) { }

	// RVA: 0x1E9DEC0 Offset: 0x1E9C8C0 VA: 0x181E9DEC0
	private static bool isSpine(string boneName) { }

	// RVA: 0x1E9D6C0 Offset: 0x1E9C0C0 VA: 0x181E9D6C0
	private static bool isHead(string boneName) { }

	// RVA: 0x1E9D340 Offset: 0x1E9BD40 VA: 0x181E9D340
	private static bool isArm(string boneName) { }

	// RVA: 0x1E9DAC0 Offset: 0x1E9C4C0 VA: 0x181E9DAC0
	private static bool isLeg(string boneName) { }

	// RVA: 0x1E9E080 Offset: 0x1E9CA80 VA: 0x181E9E080
	private static bool isTail(string boneName) { }

	// RVA: 0x1E9D500 Offset: 0x1E9BF00 VA: 0x181E9D500
	private static bool isEye(string boneName) { }

	// RVA: 0x1E9E240 Offset: 0x1E9CC40 VA: 0x181E9E240
	private static bool isTypeExclude(string boneName) { }

	// RVA: 0x1E9E4C0 Offset: 0x1E9CEC0 VA: 0x181E9E4C0
	private static bool matchesNaming(string boneName, string[] namingConvention) { }

	// RVA: 0x1E9D260 Offset: 0x1E9BC60 VA: 0x181E9D260
	private static bool excludesNaming(string boneName, string[] namingConvention) { }

	// RVA: 0x1E9E3F0 Offset: 0x1E9CDF0 VA: 0x181E9E3F0
	private static bool matchesLastLetter(string boneName, string[] namingConvention) { }

	// RVA: 0x1E9B960 Offset: 0x1E9A360 VA: 0x181E9B960
	private static bool LastLetterIs(string boneName, string letter) { }

	// RVA: 0x1E9D2E0 Offset: 0x1E9BCE0 VA: 0x181E9D2E0
	private static string firstLetter(string boneName) { }

	// RVA: 0x1E9E390 Offset: 0x1E9CD90 VA: 0x181E9E390
	private static string lastLetter(string boneName) { }

	// RVA: 0x1E9B9A0 Offset: 0x1E9A3A0 VA: 0x181E9B9A0
	private static void .cctor() { }
}
