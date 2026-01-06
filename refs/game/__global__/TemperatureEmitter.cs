public class TemperatureEmitter : MonoBehaviour // TypeDefIndex: 670
{
	// Fields
	public const int DefaultAmbientTemperature = 20;
	public const int MinTemperature = 0;
	public const int MaxTemperature = 40;
	[CompilerGenerated]
	[SerializeField]
	private float <Temperature>k__BackingField; // 0x20
	[SerializeField]
	[CompilerGenerated]
	private float <Range>k__BackingField; // 0x24
	public Action OnEmitterChanged; // 0x28

	// Properties
	public float Temperature { get; set; }
	public float Range { get; set; }
	public Vector3 EmissionPoint { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4975C0 Offset: 0x495FC0 VA: 0x1804975C0
	public float get_Temperature() { }

	[CompilerGenerated]
	// RVA: 0x49CD70 Offset: 0x49B770 VA: 0x18049CD70
	private void set_Temperature(float value) { }

	[CompilerGenerated]
	// RVA: 0x494450 Offset: 0x492E50 VA: 0x180494450
	public float get_Range() { }

	[CompilerGenerated]
	// RVA: 0x4944A0 Offset: 0x492EA0 VA: 0x1804944A0
	private void set_Range(float value) { }

	// RVA: 0x7262C0 Offset: 0x724CC0 VA: 0x1807262C0
	public Vector3 get_EmissionPoint() { }

	// RVA: 0xAC9270 Offset: 0xAC7C70 VA: 0x180AC9270
	public void SetPosition(Vector3 position) { }

	// RVA: 0xAC9320 Offset: 0xAC7D20 VA: 0x180AC9320
	public void SetTemperature(float temperature) { }

	// RVA: 0xAC92E0 Offset: 0xAC7CE0 VA: 0x180AC92E0
	public void SetRange(float range) { }

	// RVA: 0x9977E0 Offset: 0x9961E0 VA: 0x1809977E0
	public void NotifyChanged() { }

	// RVA: 0xAC9360 Offset: 0xAC7D60 VA: 0x180AC9360
	public void .ctor() { }
}
