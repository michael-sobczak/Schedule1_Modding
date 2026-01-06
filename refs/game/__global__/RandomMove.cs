public class RandomMove : MonoBehaviour // TypeDefIndex: 381
{
	// Fields
	[Range(-10, 10)]
	public float right; // 0x20
	[Range(-10, 10)]
	public float left; // 0x24
	[Range(-10, 10)]
	public float back; // 0x28
	[Range(-10, 10)]
	public float front; // 0x2C
	[Range(0, 0.2)]
	public float speed; // 0x30
	[Range(0, 2)]
	public float rotationSpeed; // 0x34
	[Range(0.1, 2)]
	public float randomSpeed; // 0x38
	public bool automatic; // 0x3C
	private Vector3 velocity; // 0x40
	private int flaskType; // 0x4C

	// Methods

	// RVA: 0x8D6EC0 Offset: 0x8D58C0 VA: 0x1808D6EC0
	private void Update() { }

	// RVA: 0x8D7850 Offset: 0x8D6250 VA: 0x1808D7850
	public void .ctor() { }
}
