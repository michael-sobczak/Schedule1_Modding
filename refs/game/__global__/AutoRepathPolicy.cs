public class AutoRepathPolicy // TypeDefIndex: 13162
{
	// Fields
	public AutoRepathPolicy.Mode mode; // 0x10
	[FormerlySerializedAs("interval")]
	public float period; // 0x14
	public float sensitivity; // 0x18
	[FormerlySerializedAs("maximumInterval")]
	public float maximumPeriod; // 0x1C
	public bool visualizeSensitivity; // 0x20
	private Vector3 lastDestination; // 0x24
	private float lastRepathTime; // 0x30

	// Methods

	// RVA: 0xB09F10 Offset: 0xB08910 VA: 0x180B09F10 Slot: 4
	public virtual bool ShouldRecalculatePath(Vector3 position, float radius, Vector3 destination) { }

	// RVA: 0xB09F00 Offset: 0xB08900 VA: 0x180B09F00 Slot: 5
	public virtual void Reset() { }

	// RVA: 0xB09D50 Offset: 0xB08750 VA: 0x180B09D50 Slot: 6
	public virtual void DidRecalculatePath(Vector3 destination) { }

	// RVA: 0xB09D90 Offset: 0xB08790 VA: 0x180B09D90
	public void DrawGizmos(Vector3 position, float radius) { }

	// RVA: 0xB0A080 Offset: 0xB08A80 VA: 0x180B0A080
	public void .ctor() { }
}
