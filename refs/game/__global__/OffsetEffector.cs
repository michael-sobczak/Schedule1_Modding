public class OffsetEffector : OffsetModifier // TypeDefIndex: 14266
{
	// Fields
	[Tooltip("Optional. Assign the bone Transform that is closest to this OffsetEffector to be able to call OffsetEffector.Anchor() in LateUpdate to match its position and rotation to animation.")]
	public Transform anchor; // 0x38
	public OffsetEffector.EffectorLink[] effectorLinks; // 0x40
	private Vector3 posRelToAnchor; // 0x48
	private Quaternion rotRelToAnchor; // 0x54

	// Methods

	// RVA: 0x1F467F0 Offset: 0x1F451F0 VA: 0x181F467F0 Slot: 5
	protected override void Start() { }

	// RVA: 0x1F465A0 Offset: 0x1F44FA0 VA: 0x181F465A0 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x1F46330 Offset: 0x1F44D30 VA: 0x181F46330
	public void Anchor() { }

	// RVA: 0x1F46BF0 Offset: 0x1F455F0 VA: 0x181F46BF0
	public void .ctor() { }
}
