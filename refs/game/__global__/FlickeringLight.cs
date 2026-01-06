public class FlickeringLight : MonoBehaviour // TypeDefIndex: 1264
{
	// Fields
	[Header("Intensity Settings")]
	[Tooltip("The minimum light intensity.")]
	public float minIntensity; // 0x20
	[Tooltip("The maximum light intensity.")]
	public float maxIntensity; // 0x24
	[Tooltip("Enable slight color shifts to simulate a warm flame.")]
	[Header("Color Settings")]
	public bool enableColorShift; // 0x28
	public Color minColor; // 0x2C
	public Color maxColor; // 0x3C
	[Header("Flicker Speed")]
	[Tooltip("How quickly the light flickers (lower is faster).")]
	public float flickerSpeed; // 0x4C
	private Light lightSource; // 0x50
	private float targetIntensity; // 0x58
	private Color targetColor; // 0x5C

	// Methods

	// RVA: 0x60EE60 Offset: 0x60D860 VA: 0x18060EE60
	private void Start() { }

	// RVA: 0x60EFB0 Offset: 0x60D9B0 VA: 0x18060EFB0
	private void Update() { }

	// RVA: 0x60EEC0 Offset: 0x60D8C0 VA: 0x18060EEC0
	private void UpdateTargetValues() { }

	// RVA: 0x60F1A0 Offset: 0x60DBA0 VA: 0x18060F1A0
	public void .ctor() { }
}
