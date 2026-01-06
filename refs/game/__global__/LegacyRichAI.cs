public class LegacyRichAI : RichAI // TypeDefIndex: 13348
{
	// Fields
	public bool preciseSlowdown; // 0x190
	public bool raycastingForGroundPlacement; // 0x191
	private Vector3 velocity; // 0x194
	private Vector3 lastTargetPoint; // 0x1A0
	private Vector3 currentTargetDirection; // 0x1AC
	private static float deltaTime; // 0x0

	// Methods

	// RVA: 0xB85830 Offset: 0xB84230 VA: 0x180B85830 Slot: 7
	protected override void Awake() { }

	// RVA: 0xB85FA0 Offset: 0xB849A0 VA: 0x180B85FA0 Slot: 27
	protected override void Update() { }

	// RVA: 0xB859A0 Offset: 0xB843A0 VA: 0x180B859A0
	private Vector3 RaycastPosition(Vector3 position, float lasty) { }

	// RVA: 0xB85C00 Offset: 0xB84600 VA: 0x180B85C00
	private bool RotateTowards(Vector3 trotdir) { }

	// RVA: 0xB87570 Offset: 0xB85F70 VA: 0x180B87570
	public void .ctor() { }
}
