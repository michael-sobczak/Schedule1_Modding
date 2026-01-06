public struct CinemachineInputAxisDriver // TypeDefIndex: 16146
{
	// Fields
	[Tooltip("Multiply the input by this amount prior to processing.  Controls the input power.")]
	public float multiplier; // 0x0
	[Tooltip("The amount of time in seconds it takes to accelerate to a higher speed")]
	public float accelTime; // 0x4
	[Tooltip("The amount of time in seconds it takes to decelerate to a lower speed")]
	public float decelTime; // 0x8
	[Tooltip("The name of this axis as specified in Unity Input manager. Setting to an empty string will disable the automatic updating of this axis")]
	public string name; // 0x10
	[Tooltip("The value of the input axis.  A value of 0 means no input.  You can drive this directly from a custom input system, or you can set the Axis Name and have the value driven by the internal Input Manager")]
	[NoSaveDuringPlay]
	public float inputValue; // 0x18
	private float mCurrentSpeed; // 0x1C
	private const float Epsilon = 0.0001;

	// Methods

	// RVA: 0xC1A3D0 Offset: 0xC18DD0 VA: 0x180C1A3D0
	public void Validate() { }

	// RVA: 0xC1A090 Offset: 0xC18A90 VA: 0x180C1A090
	public bool Update(float deltaTime, ref AxisBase axis) { }

	// RVA: 0xC1A020 Offset: 0xC18A20 VA: 0x180C1A020
	public bool Update(float deltaTime, ref AxisState axis) { }

	// RVA: 0xC19FB0 Offset: 0xC189B0 VA: 0x180C19FB0
	private float ClampValue(ref AxisBase axis, float v) { }
}
