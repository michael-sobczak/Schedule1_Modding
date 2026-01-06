public class CinemachineFixedSignal : SignalSourceAsset // TypeDefIndex: 16202
{
	// Fields
	[Tooltip("The raw signal shape along the X axis")]
	public AnimationCurve m_XCurve; // 0x18
	[Tooltip("The raw signal shape along the Y axis")]
	public AnimationCurve m_YCurve; // 0x20
	[Tooltip("The raw signal shape along the Z axis")]
	public AnimationCurve m_ZCurve; // 0x28

	// Properties
	public override float SignalDuration { get; }

	// Methods

	// RVA: 0xC29110 Offset: 0xC27B10 VA: 0x180C29110 Slot: 6
	public override float get_SignalDuration() { }

	// RVA: 0xC28EC0 Offset: 0xC278C0 VA: 0x180C28EC0
	private float AxisDuration(AnimationCurve axis) { }

	// RVA: 0xC28FF0 Offset: 0xC279F0 VA: 0x180C28FF0 Slot: 7
	public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }

	// RVA: 0xC28FA0 Offset: 0xC279A0 VA: 0x180C28FA0
	private float AxisValue(AnimationCurve axis, float time) { }

	// RVA: 0xBF3DE0 Offset: 0xBF27E0 VA: 0x180BF3DE0
	public void .ctor() { }
}
