public class CinemachineTouchInputMapper : MonoBehaviour // TypeDefIndex: 16028
{
	// Fields
	[Tooltip("Sensitivity multiplier for x-axis")]
	public float TouchSensitivityX; // 0x20
	[Tooltip("Sensitivity multiplier for y-axis")]
	public float TouchSensitivityY; // 0x24
	[Tooltip("Input channel to spoof for X axis")]
	public string TouchXInputMapTo; // 0x28
	[Tooltip("Input channel to spoof for Y axis")]
	public string TouchYInputMapTo; // 0x30

	// Methods

	// RVA: 0xBF3ED0 Offset: 0xBF28D0 VA: 0x180BF3ED0
	private void Start() { }

	// RVA: 0xBF3DF0 Offset: 0xBF27F0 VA: 0x180BF3DF0
	private float GetInputAxis(string axisName) { }

	// RVA: 0xBF3F90 Offset: 0xBF2990 VA: 0x180BF3F90
	public void .ctor() { }
}
