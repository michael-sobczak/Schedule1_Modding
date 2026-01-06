public class RotationLimitSpline : RotationLimit // TypeDefIndex: 14175
{
	// Fields
	[Range(0, 180)]
	public float twistLimit; // 0x40
	[HideInInspector]
	public AnimationCurve spline; // 0x48

	// Methods

	[ContextMenu("User Manual")]
	// RVA: 0x1F2E6D0 Offset: 0x1F2D0D0 VA: 0x181F2E6D0
	private void OpenUserManual() { }

	[ContextMenu("Scrpt Reference")]
	// RVA: 0x1F2E670 Offset: 0x1F2D070 VA: 0x181F2E670
	private void OpenScriptReference() { }

	[ContextMenu("Support Group")]
	// RVA: 0x1F2E750 Offset: 0x1F2D150 VA: 0x181F2E750
	private void SupportGroup() { }

	[ContextMenu("Asset Store Thread")]
	// RVA: 0x1F2DF80 Offset: 0x1F2C980 VA: 0x181F2DF80
	private void ASThread() { }

	// RVA: 0x1F2E730 Offset: 0x1F2D130 VA: 0x181F2E730
	public void SetSpline(Keyframe[] keyframes) { }

	// RVA: 0x1F2DFE0 Offset: 0x1F2C9E0 VA: 0x181F2DFE0 Slot: 4
	protected override Quaternion LimitRotation(Quaternion rotation) { }

	// RVA: 0x1F2E090 Offset: 0x1F2CA90 VA: 0x181F2E090
	public Quaternion LimitSwing(Quaternion rotation) { }

	// RVA: 0x1F2E7B0 Offset: 0x1F2D1B0 VA: 0x181F2E7B0
	public void .ctor() { }
}
