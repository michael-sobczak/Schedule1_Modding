public class LightGenerator : MonoBehaviour // TypeDefIndex: 355
{
	// Fields
	[SerializeField]
	[Range(1, 100)]
	private int CountX; // 0x20
	[SerializeField]
	[Range(1, 100)]
	private int CountY; // 0x24
	[SerializeField]
	private float OffsetUnits; // 0x28
	[SerializeField]
	private float PositionY; // 0x2C
	[SerializeField]
	private bool NoiseEnabled; // 0x30
	[SerializeField]
	private bool AddLight; // 0x31

	// Methods

	// RVA: 0x7B2ED0 Offset: 0x7B18D0 VA: 0x1807B2ED0
	public void Generate() { }

	// RVA: 0x7B36F0 Offset: 0x7B20F0 VA: 0x1807B36F0
	public void .ctor() { }
}
