public class IKSolverLimb : IKSolverTrigonometric // TypeDefIndex: 14122
{
	// Fields
	public AvatarIKGoal goal; // 0xA8
	public IKSolverLimb.BendModifier bendModifier; // 0xAC
	[Range(0, 1)]
	public float maintainRotationWeight; // 0xB0
	[Range(0, 1)]
	public float bendModifierWeight; // 0xB4
	public Transform bendGoal; // 0xB8
	private bool maintainBendFor1Frame; // 0xC0
	private bool maintainRotationFor1Frame; // 0xC1
	private Quaternion defaultRootRotation; // 0xC4
	private Quaternion parentDefaultRotation; // 0xD4
	private Quaternion bone3RotationBeforeSolve; // 0xE4
	private Quaternion maintainRotation; // 0xF4
	private Quaternion bone3DefaultRotation; // 0x104
	private Vector3 _bendNormal; // 0x114
	private Vector3 animationNormal; // 0x120
	private IKSolverLimb.AxisDirection[] axisDirectionsLeft; // 0x130
	private IKSolverLimb.AxisDirection[] axisDirectionsRight; // 0x138

	// Properties
	private IKSolverLimb.AxisDirection[] axisDirections { get; }

	// Methods

	// RVA: 0x1EEFDF0 Offset: 0x1EEE7F0 VA: 0x181EEFDF0
	public void MaintainRotation() { }

	// RVA: 0x1EEFD50 Offset: 0x1EEE750 VA: 0x181EEFD50
	public void MaintainBend() { }

	// RVA: 0x1EEFE40 Offset: 0x1EEE840 VA: 0x181EEFE40 Slot: 12
	protected override void OnInitiateVirtual() { }

	// RVA: 0x1EF0460 Offset: 0x1EEEE60 VA: 0x181EF0460 Slot: 13
	protected override void OnUpdateVirtual() { }

	// RVA: 0x1EF0380 Offset: 0x1EEED80 VA: 0x181EF0380 Slot: 14
	protected override void OnPostSolveVirtual() { }

	// RVA: 0x1EF0960 Offset: 0x1EEF360 VA: 0x181EF0960
	public void .ctor() { }

	// RVA: 0x1EF08C0 Offset: 0x1EEF2C0 VA: 0x181EF08C0
	public void .ctor(AvatarIKGoal goal) { }

	// RVA: 0x1EF09F0 Offset: 0x1EEF3F0 VA: 0x181EF09F0
	private IKSolverLimb.AxisDirection[] get_axisDirections() { }

	// RVA: 0x1EF0570 Offset: 0x1EEEF70 VA: 0x181EF0570
	private void StoreAxisDirections(ref IKSolverLimb.AxisDirection[] axisDirections) { }

	// RVA: 0x1EEEBF0 Offset: 0x1EED5F0 VA: 0x181EEEBF0
	private Vector3 GetModifiedBendNormal() { }
}
