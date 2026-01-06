public class LightAnchor : MonoBehaviour // TypeDefIndex: 13491
{
	// Fields
	private const float k_ArcRadius = 5;
	private const float k_AxisLength = 10;
	internal const float k_MaxDistance = 10000;
	[SerializeField]
	[Min(0)]
	private float m_Distance; // 0x20
	[SerializeField]
	private LightAnchor.UpDirection m_FrameSpace; // 0x24
	[SerializeField]
	private Transform m_AnchorPositionOverride; // 0x28
	[SerializeField]
	private Vector3 m_AnchorPositionOffset; // 0x30
	[SerializeField]
	private float m_Yaw; // 0x3C
	[SerializeField]
	private float m_Pitch; // 0x40
	[SerializeField]
	private float m_Roll; // 0x44

	// Properties
	public float yaw { get; set; }
	public float pitch { get; set; }
	public float roll { get; set; }
	public float distance { get; set; }
	public LightAnchor.UpDirection frameSpace { get; set; }
	public Vector3 anchorPosition { get; }
	public Transform anchorPositionOverride { get; set; }
	public Vector3 anchorPositionOffset { get; set; }

	// Methods

	// RVA: 0x4E2CC0 Offset: 0x4E16C0 VA: 0x1804E2CC0
	public float get_yaw() { }

	// RVA: 0x29C9BC0 Offset: 0x29C85C0 VA: 0x1829C9BC0
	public void set_yaw(float value) { }

	// RVA: 0x495F60 Offset: 0x494960 VA: 0x180495F60
	public float get_pitch() { }

	// RVA: 0x29C9B20 Offset: 0x29C8520 VA: 0x1829C9B20
	public void set_pitch(float value) { }

	// RVA: 0x49D270 Offset: 0x49BC70 VA: 0x18049D270
	public float get_roll() { }

	// RVA: 0x29C9B70 Offset: 0x29C8570 VA: 0x1829C9B70
	public void set_roll(float value) { }

	// RVA: 0x4975C0 Offset: 0x495FC0 VA: 0x1804975C0
	public float get_distance() { }

	// RVA: 0x29C9AF0 Offset: 0x29C84F0 VA: 0x1829C9AF0
	public void set_distance(float value) { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public LightAnchor.UpDirection get_frameSpace() { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_frameSpace(LightAnchor.UpDirection value) { }

	// RVA: 0x29C9940 Offset: 0x29C8340 VA: 0x1829C9940
	public Vector3 get_anchorPosition() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Transform get_anchorPositionOverride() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_anchorPositionOverride(Transform value) { }

	// RVA: 0x4D6350 Offset: 0x4D4D50 VA: 0x1804D6350
	public Vector3 get_anchorPositionOffset() { }

	// RVA: 0x4D6610 Offset: 0x4D5010 VA: 0x1804D6610
	public void set_anchorPositionOffset(Vector3 value) { }

	// RVA: 0x29C8800 Offset: 0x29C7200 VA: 0x1829C8800
	public static float NormalizeAngleDegree(float angle) { }

	// RVA: 0x29C8940 Offset: 0x29C7340 VA: 0x1829C8940
	public void SynchronizeOnTransform(Camera camera) { }

	// RVA: 0x29C9150 Offset: 0x29C7B50 VA: 0x1829C9150
	public void UpdateTransform(Camera camera, Vector3 anchor) { }

	// RVA: 0x29C7EA0 Offset: 0x29C68A0 VA: 0x1829C7EA0
	private LightAnchor.Axes GetWorldSpaceAxes(Camera camera, Vector3 anchor) { }

	// RVA: 0x29C9760 Offset: 0x29C8160 VA: 0x1829C9760
	private void Update() { }

	// RVA: 0x29C8850 Offset: 0x29C7250 VA: 0x1829C8850
	private void OnDrawGizmosSelected() { }

	// RVA: 0x29C9240 Offset: 0x29C7C40 VA: 0x1829C9240
	private void UpdateTransform(Vector3 up, Vector3 right, Vector3 forward, Vector3 anchor) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
