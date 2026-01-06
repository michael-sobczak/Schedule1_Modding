public class BipedLimbOrientations // TypeDefIndex: 14021
{
	// Fields
	public BipedLimbOrientations.LimbOrientation leftArm; // 0x10
	public BipedLimbOrientations.LimbOrientation rightArm; // 0x18
	public BipedLimbOrientations.LimbOrientation leftLeg; // 0x20
	public BipedLimbOrientations.LimbOrientation rightLeg; // 0x28

	// Properties
	public static BipedLimbOrientations UMA { get; }
	public static BipedLimbOrientations MaxBiped { get; }

	// Methods

	// RVA: 0x1CD3000 Offset: 0x1CD1A00 VA: 0x181CD3000
	public void .ctor(BipedLimbOrientations.LimbOrientation leftArm, BipedLimbOrientations.LimbOrientation rightArm, BipedLimbOrientations.LimbOrientation leftLeg, BipedLimbOrientations.LimbOrientation rightLeg) { }

	// RVA: 0x1E9AAC0 Offset: 0x1E994C0 VA: 0x181E9AAC0
	public static BipedLimbOrientations get_UMA() { }

	// RVA: 0x1E9A670 Offset: 0x1E99070 VA: 0x181E9A670
	public static BipedLimbOrientations get_MaxBiped() { }
}
