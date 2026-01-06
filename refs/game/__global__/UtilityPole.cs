public class UtilityPole : MonoBehaviour // TypeDefIndex: 3320
{
	// Fields
	public const float CABLE_CULL_DISTANCE = 100;
	public const float CABLE_CULL_DISTANCE_SQR = 10000;
	public UtilityPole previousPole; // 0x20
	public UtilityPole nextPole; // 0x28
	public bool Connection1Enabled; // 0x30
	public bool Connection2Enabled; // 0x31
	public float LengthFactor; // 0x34
	[Header("References")]
	public Transform cable1Connection; // 0x38
	public Transform cable2Connection; // 0x40
	public List<Transform> cable1Segments; // 0x48
	public List<Transform> cable2Segments; // 0x50
	public Transform Cable1Container; // 0x58
	public Transform Cable2Container; // 0x60
	private Vector3 cableStart; // 0x68
	private Vector3 cableEnd; // 0x74
	private Vector3 cableMid; // 0x80

	// Methods

	// RVA: 0xA5FA40 Offset: 0xA5E440 VA: 0x180A5FA40
	private void Awake() { }

	// RVA: 0xA60610 Offset: 0xA5F010 VA: 0x180A60610
	private void Start() { }

	// RVA: 0xA60960 Offset: 0xA5F360 VA: 0x180A60960
	private void UpdateCulling() { }

	[Button]
	// RVA: 0xA60170 Offset: 0xA5EB70 VA: 0x180A60170
	public void Orient() { }

	[Button]
	// RVA: 0xA5FBC0 Offset: 0xA5E5C0 VA: 0x180A5FBC0
	public void DrawLines() { }

	// RVA: 0xA60D70 Offset: 0xA5F770 VA: 0x180A60D70
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xA60780 Offset: 0xA5F180 VA: 0x180A60780
	private void <Start>g__Register|17_0() { }
}
