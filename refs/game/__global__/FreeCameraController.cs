public class FreeCameraController : MonoBehaviour // TypeDefIndex: 354
{
	// Fields
	public float cameraSensitivity; // 0x20
	public float speedNormal; // 0x24
	public float speedFactorSlow; // 0x28
	public float speedFactorFast; // 0x2C
	public float speedClimb; // 0x30
	private float rotationH; // 0x34
	private float rotationV; // 0x38
	private bool m_UseMouseView; // 0x3C

	// Properties
	private bool useMouseView { get; set; }

	// Methods

	// RVA: 0x495E90 Offset: 0x494890 VA: 0x180495E90
	private bool get_useMouseView() { }

	// RVA: 0x7B24C0 Offset: 0x7B0EC0 VA: 0x1807B24C0
	private void set_useMouseView(bool value) { }

	// RVA: 0x7B1C10 Offset: 0x7B0610 VA: 0x1807B1C10
	private void Start() { }

	// RVA: 0x7B1D00 Offset: 0x7B0700 VA: 0x1807B1D00
	private void Update() { }

	// RVA: 0x7B2490 Offset: 0x7B0E90 VA: 0x1807B2490
	public void .ctor() { }
}
