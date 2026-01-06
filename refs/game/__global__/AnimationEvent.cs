public sealed class AnimationEvent // TypeDefIndex: 18284
{
	// Fields
	internal float m_Time; // 0x10
	internal string m_FunctionName; // 0x18
	internal string m_StringParameter; // 0x20
	internal Object m_ObjectReferenceParameter; // 0x28
	internal float m_FloatParameter; // 0x30
	internal int m_IntParameter; // 0x34
	internal int m_MessageOptions; // 0x38
	internal AnimationEventSource m_Source; // 0x3C
	internal AnimationState m_StateSender; // 0x40
	internal AnimatorStateInfo m_AnimatorStateInfo; // 0x48
	internal AnimatorClipInfo m_AnimatorClipInfo; // 0x6C

	// Properties
	public float time { get; }

	// Methods

	// RVA: 0x2C72BE0 Offset: 0x2C715E0 VA: 0x182C72BE0
	public void .ctor() { }

	// RVA: 0x2C72C80 Offset: 0x2C71680 VA: 0x182C72C80
	public float get_time() { }
}
