public struct AxisState // TypeDefIndex: 16124
{
	// Fields
	[NoSaveDuringPlay]
	[Tooltip("The current value of the axis.")]
	public float Value; // 0x0
	[Tooltip("How to interpret the Max Speed setting: in units/second, or as a direct input value multiplier")]
	public AxisState.SpeedMode m_SpeedMode; // 0x4
	[Tooltip("The maximum speed of this axis in units/second, or the input value multiplier, depending on the Speed Mode")]
	public float m_MaxSpeed; // 0x8
	[Tooltip("The amount of time in seconds it takes to accelerate to MaxSpeed with the supplied Axis at its maximum value")]
	public float m_AccelTime; // 0xC
	[Tooltip("The amount of time in seconds it takes to decelerate the axis to zero if the supplied axis is in a neutral position")]
	public float m_DecelTime; // 0x10
	[FormerlySerializedAs("m_AxisName")]
	[Tooltip("The name of this axis as specified in Unity Input manager. Setting to an empty string will disable the automatic updating of this axis")]
	public string m_InputAxisName; // 0x18
	[NoSaveDuringPlay]
	[Tooltip("The value of the input axis.  A value of 0 means no input.  You can drive this directly from a custom input system, or you can set the Axis Name and have the value driven by the internal Input Manager")]
	public float m_InputAxisValue; // 0x20
	[Tooltip("If checked, then the raw value of the input axis will be inverted before it is used")]
	[FormerlySerializedAs("m_InvertAxis")]
	public bool m_InvertInput; // 0x24
	[Tooltip("The minimum value for the axis")]
	public float m_MinValue; // 0x28
	[Tooltip("The maximum value for the axis")]
	public float m_MaxValue; // 0x2C
	[Tooltip("If checked, then the axis will wrap around at the min/max values, forming a loop")]
	public bool m_Wrap; // 0x30
	[Tooltip("Automatic recentering to at-rest position")]
	public AxisState.Recentering m_Recentering; // 0x34
	private float m_CurrentSpeed; // 0x54
	private float m_LastUpdateTime; // 0x58
	private int m_LastUpdateFrame; // 0x5C
	private const float Epsilon = 0.0001;
	private AxisState.IInputAxisProvider m_InputAxisProvider; // 0x60
	private int m_InputAxisIndex; // 0x68
	[CompilerGenerated]
	private bool <ValueRangeLocked>k__BackingField; // 0x6C
	[CompilerGenerated]
	private bool <HasRecentering>k__BackingField; // 0x6D

	// Properties
	public bool HasInputProvider { get; }
	public bool ValueRangeLocked { get; set; }
	public bool HasRecentering { get; set; }

	// Methods

	// RVA: 0xC0DBB0 Offset: 0xC0C5B0 VA: 0x180C0DBB0
	public void .ctor(float minValue, float maxValue, bool wrap, bool rangeLocked, float maxSpeed, float accelTime, float decelTime, string name, bool invert) { }

	// RVA: 0xC0DB50 Offset: 0xC0C550 VA: 0x180C0DB50
	public void Validate() { }

	// RVA: 0xC0D670 Offset: 0xC0C070 VA: 0x180C0D670
	public void Reset() { }

	// RVA: 0xC0D680 Offset: 0xC0C080 VA: 0x180C0D680
	public void SetInputAxisProvider(int axis, AxisState.IInputAxisProvider provider) { }

	// RVA: 0xC0DCA0 Offset: 0xC0C6A0 VA: 0x180C0DCA0
	public bool get_HasInputProvider() { }

	// RVA: 0xC0D6A0 Offset: 0xC0C0A0 VA: 0x180C0D6A0
	public bool Update(float deltaTime) { }

	// RVA: 0xC0D310 Offset: 0xC0BD10 VA: 0x180C0D310
	private float ClampValue(float v) { }

	// RVA: 0xC0D430 Offset: 0xC0BE30 VA: 0x180C0D430
	private bool MaxSpeedUpdate(float input, float deltaTime) { }

	// RVA: 0xC0D380 Offset: 0xC0BD80 VA: 0x180C0D380
	private float GetMaxSpeed() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x614490 Offset: 0x612E90 VA: 0x180614490
	public bool get_ValueRangeLocked() { }

	[CompilerGenerated]
	// RVA: 0x614530 Offset: 0x612F30 VA: 0x180614530
	public void set_ValueRangeLocked(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0xC0DCB0 Offset: 0xC0C6B0 VA: 0x180C0DCB0
	public bool get_HasRecentering() { }

	[CompilerGenerated]
	// RVA: 0xC0DCC0 Offset: 0xC0C6C0 VA: 0x180C0DCC0
	public void set_HasRecentering(bool value) { }
}
