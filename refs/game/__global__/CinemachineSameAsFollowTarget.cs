public class CinemachineSameAsFollowTarget : CinemachineComponentBase // TypeDefIndex: 16114
{
	// Fields
	[Tooltip("How much time it takes for the aim to catch up to the target's rotation")]
	[FormerlySerializedAs("m_AngularDamping")]
	public float m_Damping; // 0x28
	private Quaternion m_PreviousReferenceOrientation; // 0x2C

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }

	// Methods

	// RVA: 0xC01400 Offset: 0xBFFE00 VA: 0x180C01400 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0xC01240 Offset: 0xBFFC40 VA: 0x180C01240 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0xC013B0 Offset: 0xBFFDB0 VA: 0x180C013B0
	public void .ctor() { }
}
