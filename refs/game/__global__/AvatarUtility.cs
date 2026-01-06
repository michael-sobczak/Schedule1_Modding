public class AvatarUtility // TypeDefIndex: 14009
{
	// Methods

	// RVA: 0x1E938F0 Offset: 0x1E922F0 VA: 0x181E938F0
	public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal) { }

	// RVA: 0x1E92F00 Offset: 0x1E91900 VA: 0x181E92F00
	public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ) { }

	// RVA: 0x1E93E60 Offset: 0x1E92860 VA: 0x181E93E60
	public static TQ WorldSpaceIKGoalToBone(TQ goalTQ, Avatar avatar, AvatarIKGoal avatarIKGoal) { }

	// RVA: 0x1E93B80 Offset: 0x1E92580 VA: 0x181E93B80
	public static TQ GetWorldSpaceIKGoal(BakerHumanoidQT ikQT, BakerHumanoidQT rootQT, float time, float humanScale) { }

	// RVA: 0x1E93E20 Offset: 0x1E92820 VA: 0x181E93E20
	public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
