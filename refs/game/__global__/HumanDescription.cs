public struct HumanDescription // TypeDefIndex: 18303
{
	// Fields
	[NativeName("m_Human")]
	public HumanBone[] human; // 0x0
	[NativeName("m_Skeleton")]
	public SkeletonBone[] skeleton; // 0x8
	internal float m_ArmTwist; // 0x10
	internal float m_ForeArmTwist; // 0x14
	internal float m_UpperLegTwist; // 0x18
	internal float m_LegTwist; // 0x1C
	internal float m_ArmStretch; // 0x20
	internal float m_LegStretch; // 0x24
	internal float m_FeetSpacing; // 0x28
	internal float m_GlobalScale; // 0x2C
	internal string m_RootMotionBoneName; // 0x30
	internal bool m_HasTranslationDoF; // 0x38
	internal bool m_HasExtraRoot; // 0x39
	internal bool m_SkeletonHasParents; // 0x3A
}
