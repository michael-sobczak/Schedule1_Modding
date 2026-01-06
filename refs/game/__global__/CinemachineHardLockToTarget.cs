public class CinemachineHardLockToTarget : CinemachineComponentBase // TypeDefIndex: 16105
{
	// Fields
	[Tooltip("How much time it takes for the position to catch up to the target's position")]
	public float m_Damping; // 0x28
	private Vector3 m_PreviousTargetPosition; // 0x2C

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }

	// Methods

	// RVA: 0xBFD550 Offset: 0xBFBF50 VA: 0x180BFD550 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0xBFD3F0 Offset: 0xBFBDF0 VA: 0x180BFD3F0 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x44B2F0 Offset: 0x449CF0 VA: 0x18044B2F0
	public void .ctor() { }
}
