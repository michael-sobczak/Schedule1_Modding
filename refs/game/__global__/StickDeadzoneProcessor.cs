public class StickDeadzoneProcessor : InputProcessor<Vector2> // TypeDefIndex: 7735
{
	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Properties
	private float minOrDefault { get; }
	private float maxOrDefault { get; }

	// Methods

	// RVA: 0x2880640 Offset: 0x287F040 VA: 0x182880640
	private float get_minOrDefault() { }

	// RVA: 0x28805D0 Offset: 0x287EFD0 VA: 0x1828805D0
	private float get_maxOrDefault() { }

	// RVA: 0x28802A0 Offset: 0x287ECA0 VA: 0x1828802A0 Slot: 7
	public override Vector2 Process(Vector2 value, InputControl control) { }

	// RVA: 0x2880150 Offset: 0x287EB50 VA: 0x182880150
	private float GetDeadZoneAdjustedValue(float value) { }

	// RVA: 0x2880450 Offset: 0x287EE50 VA: 0x182880450 Slot: 3
	public override string ToString() { }

	// RVA: 0x2880590 Offset: 0x287EF90 VA: 0x182880590
	public void .ctor() { }
}
