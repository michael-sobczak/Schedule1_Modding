public class Compute_DT_EventArgs // TypeDefIndex: 14852
{
	// Fields
	public Compute_DistanceTransform_EventTypes EventType; // 0x10
	public float ProgressPercentage; // 0x14
	public Color[] Colors; // 0x18

	// Methods

	// RVA: 0x2BD5BB0 Offset: 0x2BD45B0 VA: 0x182BD5BB0
	public void .ctor(Compute_DistanceTransform_EventTypes type, float progress) { }

	// RVA: 0x50D760 Offset: 0x50C160 VA: 0x18050D760
	public void .ctor(Compute_DistanceTransform_EventTypes type, Color[] colors) { }
}
