public struct AnimatorClipInfo // TypeDefIndex: 18291
{
	// Fields
	private int m_ClipInstanceID; // 0x0
	private float m_Weight; // 0x4

	// Properties
	public AnimationClip clip { get; }
	public float weight { get; }

	// Methods

	// RVA: 0x2C76F40 Offset: 0x2C75940 VA: 0x182C76F40
	public AnimationClip get_clip() { }

	// RVA: 0x454BC0 Offset: 0x4535C0 VA: 0x180454BC0
	public float get_weight() { }

	[FreeFunction("AnimationBindings::InstanceIDToAnimationClipPPtr")]
	// RVA: 0x2C76F00 Offset: 0x2C75900 VA: 0x182C76F00
	private static AnimationClip InstanceIDToAnimationClipPPtr(int instanceID) { }
}
