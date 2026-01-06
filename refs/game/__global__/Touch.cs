public struct Touch // TypeDefIndex: 19013
{
	// Fields
	private int m_FingerId; // 0x0
	private Vector2 m_Position; // 0x4
	private Vector2 m_RawPosition; // 0xC
	private Vector2 m_PositionDelta; // 0x14
	private float m_TimeDelta; // 0x1C
	private int m_TapCount; // 0x20
	private TouchPhase m_Phase; // 0x24
	private TouchType m_Type; // 0x28
	private float m_Pressure; // 0x2C
	private float m_maximumPossiblePressure; // 0x30
	private float m_Radius; // 0x34
	private float m_RadiusVariance; // 0x38
	private float m_AltitudeAngle; // 0x3C
	private float m_AzimuthAngle; // 0x40

	// Properties
	public int fingerId { get; }
	public Vector2 position { get; set; }
	public Vector2 rawPosition { get; set; }
	public Vector2 deltaPosition { get; set; }
	public float deltaTime { get; }
	public int tapCount { get; }
	public TouchPhase phase { get; }
	public float pressure { get; }
	public float maximumPossiblePressure { get; }
	public TouchType type { get; }
	public float altitudeAngle { get; }
	public float azimuthAngle { get; }
	public float radius { get; }
	public float radiusVariance { get; }

	// Methods

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50
	public int get_fingerId() { }

	// RVA: 0x2D2B1C0 Offset: 0x2D29BC0 VA: 0x182D2B1C0
	public Vector2 get_position() { }

	// RVA: 0x1CD2DE0 Offset: 0x1CD17E0 VA: 0x181CD2DE0
	public void set_position(Vector2 value) { }

	// RVA: 0x2D2B200 Offset: 0x2D29C00 VA: 0x182D2B200
	public Vector2 get_rawPosition() { }

	// RVA: 0x2D2B230 Offset: 0x2D29C30 VA: 0x182D2B230
	public void set_rawPosition(Vector2 value) { }

	// RVA: 0x1671190 Offset: 0x166FB90 VA: 0x181671190
	public Vector2 get_deltaPosition() { }

	// RVA: 0x2D2B220 Offset: 0x2D29C20 VA: 0x182D2B220
	public void set_deltaPosition(Vector2 value) { }

	// RVA: 0x2D2B190 Offset: 0x2D29B90 VA: 0x182D2B190
	public float get_deltaTime() { }

	// RVA: 0x1263FA0 Offset: 0x12629A0 VA: 0x181263FA0
	public int get_tapCount() { }

	// RVA: 0x2D2B1B0 Offset: 0x2D29BB0 VA: 0x182D2B1B0
	public TouchPhase get_phase() { }

	// RVA: 0x2D2B1E0 Offset: 0x2D29BE0 VA: 0x182D2B1E0
	public float get_pressure() { }

	// RVA: 0x2D2B1A0 Offset: 0x2D29BA0 VA: 0x182D2B1A0
	public float get_maximumPossiblePressure() { }

	// RVA: 0x1263FC0 Offset: 0x12629C0 VA: 0x181263FC0
	public TouchType get_type() { }

	// RVA: 0x2BC30D0 Offset: 0x2BC1AD0 VA: 0x182BC30D0
	public float get_altitudeAngle() { }

	// RVA: 0x2D2B180 Offset: 0x2D29B80 VA: 0x182D2B180
	public float get_azimuthAngle() { }

	// RVA: 0x2D2B1F0 Offset: 0x2D29BF0 VA: 0x182D2B1F0
	public float get_radius() { }

	// RVA: 0x2BC3240 Offset: 0x2BC1C40 VA: 0x182BC3240
	public float get_radiusVariance() { }
}
