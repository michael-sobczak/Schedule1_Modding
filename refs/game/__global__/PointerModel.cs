internal struct PointerModel // TypeDefIndex: 7522
{
	// Fields
	public bool changedThisFrame; // 0x0
	public PointerModel.ButtonState leftButton; // 0x8
	public PointerModel.ButtonState rightButton; // 0xA0
	public PointerModel.ButtonState middleButton; // 0x138
	public ExtendedPointerEventData eventData; // 0x1D0
	private Vector2 m_ScreenPosition; // 0x1D8
	private Vector2 m_ScrollDelta; // 0x1E0
	private Vector3 m_WorldPosition; // 0x1E8
	private Quaternion m_WorldOrientation; // 0x1F4
	private float m_Pressure; // 0x204
	private float m_AzimuthAngle; // 0x208
	private float m_AltitudeAngle; // 0x20C
	private float m_Twist; // 0x210
	private Vector2 m_Radius; // 0x214

	// Properties
	public UIPointerType pointerType { get; }
	public Vector2 screenPosition { get; set; }
	public Vector3 worldPosition { get; set; }
	public Quaternion worldOrientation { get; set; }
	public Vector2 scrollDelta { get; set; }
	public float pressure { get; set; }
	public float azimuthAngle { get; set; }
	public float altitudeAngle { get; set; }
	public float twist { get; set; }
	public Vector2 radius { get; set; }

	// Methods

	// RVA: 0x284E290 Offset: 0x284CC90 VA: 0x18284E290
	public UIPointerType get_pointerType() { }

	// RVA: 0x284E2F0 Offset: 0x284CCF0 VA: 0x18284E2F0
	public Vector2 get_screenPosition() { }

	// RVA: 0x284E400 Offset: 0x284CE00 VA: 0x18284E400
	public void set_screenPosition(Vector2 value) { }

	// RVA: 0x284E330 Offset: 0x284CD30 VA: 0x18284E330
	public Vector3 get_worldPosition() { }

	// RVA: 0x284E530 Offset: 0x284CF30 VA: 0x18284E530
	public void set_worldPosition(Vector3 value) { }

	// RVA: 0x21E0520 Offset: 0x21DEF20 VA: 0x1821E0520
	public Quaternion get_worldOrientation() { }

	// RVA: 0x284E4C0 Offset: 0x284CEC0 VA: 0x18284E4C0
	public void set_worldOrientation(Quaternion value) { }

	// RVA: 0x284E310 Offset: 0x284CD10 VA: 0x18284E310
	public Vector2 get_scrollDelta() { }

	// RVA: 0x284E450 Offset: 0x284CE50 VA: 0x18284E450
	public void set_scrollDelta(Vector2 value) { }

	// RVA: 0x284E2C0 Offset: 0x284CCC0 VA: 0x18284E2C0
	public float get_pressure() { }

	// RVA: 0x284E390 Offset: 0x284CD90 VA: 0x18284E390
	public void set_pressure(float value) { }

	// RVA: 0x284E280 Offset: 0x284CC80 VA: 0x18284E280
	public float get_azimuthAngle() { }

	// RVA: 0x284E370 Offset: 0x284CD70 VA: 0x18284E370
	public void set_azimuthAngle(float value) { }

	// RVA: 0x81F430 Offset: 0x81DE30 VA: 0x18081F430
	public float get_altitudeAngle() { }

	// RVA: 0x284E350 Offset: 0x284CD50 VA: 0x18284E350
	public void set_altitudeAngle(float value) { }

	// RVA: 0x860B60 Offset: 0x85F560 VA: 0x180860B60
	public float get_twist() { }

	// RVA: 0x284E4A0 Offset: 0x284CEA0 VA: 0x18284E4A0
	public void set_twist(float value) { }

	// RVA: 0x284E2D0 Offset: 0x284CCD0 VA: 0x18284E2D0
	public Vector2 get_radius() { }

	// RVA: 0x284E3B0 Offset: 0x284CDB0 VA: 0x18284E3B0
	public void set_radius(Vector2 value) { }

	// RVA: 0x284E140 Offset: 0x284CB40 VA: 0x18284E140
	public void .ctor(ExtendedPointerEventData eventData) { }

	// RVA: 0x284E0C0 Offset: 0x284CAC0 VA: 0x18284E0C0
	public void OnFrameFinished() { }

	// RVA: 0x284DFC0 Offset: 0x284C9C0 VA: 0x18284DFC0
	public void CopyTouchOrPenStateFrom(PointerEventData eventData) { }
}
