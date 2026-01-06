public class LegacyRVOController : RVOController // TypeDefIndex: 13349
{
	// Fields
	[Tooltip("Layer mask for the ground. The RVOController will raycast down to check for the ground to figure out where to place the agent")]
	public LayerMask mask; // 0x80
	public bool enableRotation; // 0x84
	public float rotationSpeed; // 0x88

	// Methods

	// RVA: 0xB852E0 Offset: 0xB83CE0 VA: 0x180B852E0
	public void Update() { }

	// RVA: 0xB857F0 Offset: 0xB841F0 VA: 0x180B857F0
	public void .ctor() { }
}
