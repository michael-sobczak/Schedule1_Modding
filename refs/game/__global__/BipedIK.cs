public class BipedIK : SolverManager // TypeDefIndex: 14048
{
	// Fields
	public BipedReferences references; // 0x40
	public BipedIKSolvers solvers; // 0x48

	// Methods

	[ContextMenu("User Manual")]
	// RVA: 0x1E99E10 Offset: 0x1E98810 VA: 0x181E99E10
	private void OpenUserManual() { }

	[ContextMenu("Scrpt Reference")]
	// RVA: 0x1E99DB0 Offset: 0x1E987B0 VA: 0x181E99DB0
	private void OpenScriptReference() { }

	[ContextMenu("Support Group")]
	// RVA: 0x1E9A360 Offset: 0x1E98D60 VA: 0x181E9A360
	private void SupportGroup() { }

	[ContextMenu("Asset Store Thread")]
	// RVA: 0x1E99550 Offset: 0x1E97F50 VA: 0x181E99550
	private void ASThread() { }

	// RVA: 0x1E99770 Offset: 0x1E98170 VA: 0x181E99770
	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	// RVA: 0x1E99880 Offset: 0x1E98280 VA: 0x181E99880
	public float GetIKRotationWeight(AvatarIKGoal goal) { }

	// RVA: 0x1E99E70 Offset: 0x1E98870 VA: 0x181E99E70
	public void SetIKPositionWeight(AvatarIKGoal goal, float weight) { }

	// RVA: 0x1E99F70 Offset: 0x1E98970 VA: 0x181E99F70
	public void SetIKRotationWeight(AvatarIKGoal goal, float weight) { }

	// RVA: 0x1E99EF0 Offset: 0x1E988F0 VA: 0x181E99EF0
	public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition) { }

	// RVA: 0x1E99FF0 Offset: 0x1E989F0 VA: 0x181E99FF0
	public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation) { }

	// RVA: 0x1E997E0 Offset: 0x1E981E0 VA: 0x181E997E0
	public Vector3 GetIKPosition(AvatarIKGoal goal) { }

	// RVA: 0x1E998F0 Offset: 0x1E982F0 VA: 0x181E998F0
	public Quaternion GetIKRotation(AvatarIKGoal goal) { }

	// RVA: 0x1E9A090 Offset: 0x1E98A90 VA: 0x181E9A090
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes) { }

	// RVA: 0x1E9A060 Offset: 0x1E98A60 VA: 0x181E9A060
	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	// RVA: 0x1E9A0D0 Offset: 0x1E98AD0 VA: 0x181E9A0D0
	public void SetSpinePosition(Vector3 spinePosition) { }

	// RVA: 0x1E9A100 Offset: 0x1E98B00 VA: 0x181E9A100
	public void SetSpineWeight(float weight) { }

	// RVA: 0x1E99700 Offset: 0x1E98100 VA: 0x181E99700
	public IKSolverLimb GetGoalIK(AvatarIKGoal goal) { }

	// RVA: 0x1C842D0 Offset: 0x1C82CD0 VA: 0x181C842D0
	public void InitiateBipedIK() { }

	// RVA: 0x618750 Offset: 0x617150 VA: 0x180618750
	public void UpdateBipedIK() { }

	// RVA: 0x1E9A130 Offset: 0x1E98B30 VA: 0x181E9A130
	public void SetToDefaults() { }

	// RVA: 0x1E995B0 Offset: 0x1E97FB0 VA: 0x181E995B0 Slot: 6
	protected override void FixTransforms() { }

	// RVA: 0x1E99970 Offset: 0x1E98370 VA: 0x181E99970 Slot: 4
	protected override void InitiateSolver() { }

	// RVA: 0x1E9A3C0 Offset: 0x1E98DC0 VA: 0x181E9A3C0 Slot: 5
	protected override void UpdateSolver() { }

	// RVA: 0x1E99D80 Offset: 0x1E98780 VA: 0x181E99D80
	public void LogWarning(string message) { }

	// RVA: 0x1E9A5D0 Offset: 0x1E98FD0 VA: 0x181E9A5D0
	public void .ctor() { }
}
