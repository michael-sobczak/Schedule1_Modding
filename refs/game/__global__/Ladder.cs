public class Ladder : MonoBehaviour // TypeDefIndex: 3337
{
	// Fields
	public const float NPCClimbOffset = 0.42;
	public const float LadderMountDismountTimeMultiplier = 0.4;
	public const float LadderClimbTimeMultiplier = 0.75;
	public const float NPCClimbSoundInterval = 0.3;
	public const float PlayerClimbSoundLengthInterval = 0.8;
	[Header("References")]
	public OffMeshLink OffMeshLink; // 0x20
	public AudioSourceController ClimbSound; // 0x28
	public SewerDoorController LinkedManholeCover; // 0x30
	private BoxCollider boxCollider; // 0x38
	private float timeOnLastClimbSound; // 0x40

	// Properties
	public Transform LadderTransform { get; }
	public Vector2 LadderSize { get; }
	public Vector3 BottomCenter { get; }
	public Vector3 TopCenter { get; }

	// Methods

	// RVA: 0xA4D5C0 Offset: 0xA4BFC0 VA: 0x180A4D5C0
	public Transform get_LadderTransform() { }

	// RVA: 0xA4D4F0 Offset: 0xA4BEF0 VA: 0x180A4D4F0
	public Vector2 get_LadderSize() { }

	// RVA: 0xA4D3D0 Offset: 0xA4BDD0 VA: 0x180A4D3D0
	public Vector3 get_BottomCenter() { }

	// RVA: 0xA4D5E0 Offset: 0xA4BFE0 VA: 0x180A4D5E0
	public Vector3 get_TopCenter() { }

	// RVA: 0xA4CA70 Offset: 0xA4B470 VA: 0x180A4CA70
	private void Awake() { }

	// RVA: 0xA4CF00 Offset: 0xA4B900 VA: 0x180A4CF00
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0xA4D080 Offset: 0xA4BA80 VA: 0x180A4D080
	private void OnTriggerExit(Collider other) { }

	// RVA: 0xA4CBC0 Offset: 0xA4B5C0 VA: 0x180A4CBC0
	private void OnDrawGizmos() { }

	// RVA: 0xA4D2E0 Offset: 0xA4BCE0 VA: 0x180A4D2E0
	public Vector2 ProjectOnLadderSurface(Vector3 position) { }

	// RVA: 0xA4CAE0 Offset: 0xA4B4E0 VA: 0x180A4CAE0
	public Vector2 NormalizeProjectedPosition(Vector2 projectedPosition) { }

	// RVA: 0xA4D1F0 Offset: 0xA4BBF0 VA: 0x180A4D1F0
	public void PlayClimbSound(Vector3 position) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
