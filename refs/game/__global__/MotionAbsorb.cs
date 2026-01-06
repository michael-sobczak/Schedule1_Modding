public class MotionAbsorb : OffsetModifier // TypeDefIndex: 14263
{
	// Fields
	[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
	public MotionAbsorb.Mode mode; // 0x38
	[Tooltip("Array containing the absorbers")]
	public MotionAbsorb.Absorber[] absorbers; // 0x40
	[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
	public AnimationCurve falloff; // 0x48
	[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
	public float falloffSpeed; // 0x50
	private float timer; // 0x54
	private float w; // 0x58
	private MotionAbsorb.Mode initialMode; // 0x5C

	// Methods

	// RVA: 0x1F46200 Offset: 0x1F44C00 VA: 0x181F46200 Slot: 5
	protected override void Start() { }

	// RVA: 0x1F45C90 Offset: 0x1F44690 VA: 0x181F45C90
	private void OnCollisionEnter(Collision c) { }

	// RVA: 0x1F45FA0 Offset: 0x1F449A0 VA: 0x181F45FA0 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x1F45B20 Offset: 0x1F44520 VA: 0x181F45B20
	private void AfterIK() { }

	// RVA: 0x1F45E50 Offset: 0x1F44850 VA: 0x181F45E50 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x1F46320 Offset: 0x1F44D20 VA: 0x181F46320
	public void .ctor() { }
}
