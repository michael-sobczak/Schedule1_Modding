public class PositionPredictor // TypeDefIndex: 16262
{
	// Fields
	private Vector3 m_Velocity; // 0x10
	private Vector3 m_SmoothDampVelocity; // 0x1C
	private Vector3 m_Pos; // 0x28
	private bool m_HavePos; // 0x34
	public float Smoothing; // 0x38

	// Methods

	// RVA: 0xC4ACE0 Offset: 0xC496E0 VA: 0x180C4ACE0
	public bool IsEmpty() { }

	// RVA: 0xC4ACA0 Offset: 0xC496A0 VA: 0x180C4ACA0
	public void ApplyTransformDelta(Vector3 positionDelta) { }

	// RVA: 0xC4AD80 Offset: 0xC49780 VA: 0x180C4AD80
	public void Reset() { }

	// RVA: 0xC4AA70 Offset: 0xC49470 VA: 0x180C4AA70
	public void AddPosition(Vector3 pos, float deltaTime, float lookaheadTime) { }

	// RVA: 0xC4ACF0 Offset: 0xC496F0 VA: 0x180C4ACF0
	public Vector3 PredictPositionDelta(float lookaheadTime) { }

	// RVA: 0xC4AD30 Offset: 0xC49730 VA: 0x180C4AD30
	public Vector3 PredictPosition(float lookaheadTime) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
