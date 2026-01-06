public class FlaskAnimator : MonoBehaviour // TypeDefIndex: 377
{
	// Fields
	public float speed; // 0x20
	public Vector3 initialPosition; // 0x24
	public Vector3 finalPosition; // 0x30
	public float duration; // 0x3C
	public float delay; // 0x40
	[Range(0, 1)]
	public float level; // 0x44
	[Range(0, 1)]
	public float minRange; // 0x48
	[Range(0, 1)]
	public float maxRange; // 0x4C
	[Range(0, 1)]
	public float acceleration; // 0x50
	[Range(0, 1)]
	public float rotationSpeed; // 0x54
	[Range(0, 2)]
	public float alphaDuration; // 0x58
	[Range(0, 1)]
	public float finalRefractionBlur; // 0x5C
	private LiquidVolume liquid; // 0x60
	private float direction; // 0x68

	// Methods

	// RVA: 0x8C6CC0 Offset: 0x8C56C0 VA: 0x1808C6CC0
	private void Awake() { }

	// RVA: 0x8C6D40 Offset: 0x8C5740 VA: 0x1808C6D40
	private void Update() { }

	// RVA: 0x8C7100 Offset: 0x8C5B00 VA: 0x1808C7100
	public void .ctor() { }
}
