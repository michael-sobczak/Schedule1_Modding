public class Animator : Behaviour // TypeDefIndex: 18294
{
	// Properties
	public bool isHuman { get; }
	public bool hasRootMotion { get; }
	public float humanScale { get; }
	public Vector3 deltaPosition { get; }
	public Quaternion deltaRotation { get; }
	public bool applyRootMotion { get; set; }
	public AnimatorUpdateMode updateMode { get; set; }
	public int layerCount { get; }
	public AnimatorControllerParameter[] parameters { get; }
	public Vector3 pivotPosition { get; }
	public float speed { get; set; }
	public AnimatorCullingMode cullingMode { set; }
	public RuntimeAnimatorController runtimeAnimatorController { get; set; }
	public bool hasBoundPlayables { get; }
	public Avatar avatar { get; }
	public bool logWarnings { get; }
	public bool keepAnimatorStateOnDisable { set; }

	// Methods

	[NativeMethod("IsHuman")]
	// RVA: 0x2C79090 Offset: 0x2C77A90 VA: 0x182C79090
	public bool get_isHuman() { }

	[NativeMethod("HasRootMotion")]
	// RVA: 0x2C79010 Offset: 0x2C77A10 VA: 0x182C79010
	public bool get_hasRootMotion() { }

	// RVA: 0x2C79050 Offset: 0x2C77A50 VA: 0x182C79050
	public float get_humanScale() { }

	// RVA: 0x2C77FF0 Offset: 0x2C769F0 VA: 0x182C77FF0
	public float GetFloat(string name) { }

	// RVA: 0x2C77FB0 Offset: 0x2C769B0 VA: 0x182C77FB0
	public float GetFloat(int id) { }

	// RVA: 0x2C78620 Offset: 0x2C77020 VA: 0x182C78620
	public void SetFloat(string name, float value) { }

	// RVA: 0x2C785D0 Offset: 0x2C76FD0 VA: 0x182C785D0
	public void SetFloat(int id, float value) { }

	// RVA: 0x2C77E20 Offset: 0x2C76820 VA: 0x182C77E20
	public bool GetBool(int id) { }

	// RVA: 0x2C78570 Offset: 0x2C76F70 VA: 0x182C78570
	public void SetBool(string name, bool value) { }

	// RVA: 0x2C78510 Offset: 0x2C76F10 VA: 0x182C78510
	public void SetBool(int id, bool value) { }

	// RVA: 0x2C78040 Offset: 0x2C76A40 VA: 0x182C78040
	public int GetInteger(int id) { }

	// RVA: 0x2C78A00 Offset: 0x2C77400 VA: 0x182C78A00
	public void SetInteger(int id, int value) { }

	// RVA: 0x2C78D30 Offset: 0x2C77730 VA: 0x182C78D30
	public void SetTrigger(string name) { }

	// RVA: 0x2C78CF0 Offset: 0x2C776F0 VA: 0x182C78CF0
	public void SetTrigger(int id) { }

	// RVA: 0x2C784C0 Offset: 0x2C76EC0 VA: 0x182C784C0
	public void ResetTrigger(string name) { }

	// RVA: 0x2C78480 Offset: 0x2C76E80 VA: 0x182C78480
	public void ResetTrigger(int id) { }

	// RVA: 0x2C782E0 Offset: 0x2C76CE0 VA: 0x182C782E0
	public bool IsParameterControlledByCurve(string name) { }

	// RVA: 0x2C78EE0 Offset: 0x2C778E0 VA: 0x182C78EE0
	public Vector3 get_deltaPosition() { }

	// RVA: 0x2C78F80 Offset: 0x2C77980 VA: 0x182C78F80
	public Quaternion get_deltaRotation() { }

	// RVA: 0x2C78E10 Offset: 0x2C77810 VA: 0x182C78E10
	public bool get_applyRootMotion() { }

	// RVA: 0x2C792F0 Offset: 0x2C77CF0 VA: 0x182C792F0
	public void set_applyRootMotion(bool value) { }

	// RVA: 0x2C792B0 Offset: 0x2C77CB0 VA: 0x182C792B0
	public AnimatorUpdateMode get_updateMode() { }

	// RVA: 0x2C79470 Offset: 0x2C77E70 VA: 0x182C79470
	public void set_updateMode(AnimatorUpdateMode value) { }

	// RVA: 0x2C788C0 Offset: 0x2C772C0 VA: 0x182C788C0
	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x2C786D0 Offset: 0x2C770D0 VA: 0x182C786D0
	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x2C78990 Offset: 0x2C77390 VA: 0x182C78990
	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x2C78770 Offset: 0x2C77170 VA: 0x182C78770
	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x2C78860 Offset: 0x2C77260 VA: 0x182C78860
	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x2C787C0 Offset: 0x2C771C0 VA: 0x182C787C0
	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	// RVA: 0x2C78930 Offset: 0x2C77330 VA: 0x182C78930
	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x2C78810 Offset: 0x2C77210 VA: 0x182C78810
	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	// RVA: 0x2C78B40 Offset: 0x2C77540 VA: 0x182C78B40
	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	[NativeMethod("SetLookAtPosition")]
	// RVA: 0x2C78AF0 Offset: 0x2C774F0 VA: 0x182C78AF0
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	// RVA: 0x2C78C80 Offset: 0x2C77680 VA: 0x182C78C80
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x2C78C10 Offset: 0x2C77610 VA: 0x182C78C10
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[NativeMethod("SetLookAtWeight")]
	// RVA: 0x2C78BA0 Offset: 0x2C775A0 VA: 0x182C78BA0
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x2C790D0 Offset: 0x2C77AD0 VA: 0x182C790D0
	public int get_layerCount() { }

	// RVA: 0x2C78080 Offset: 0x2C76A80 VA: 0x182C78080
	public float GetLayerWeight(int layerIndex) { }

	// RVA: 0x2C78A50 Offset: 0x2C77450 VA: 0x182C78A50
	public void SetLayerWeight(int layerIndex, float weight) { }

	// RVA: 0x2C77990 Offset: 0x2C76390 VA: 0x182C77990
	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	// RVA: 0x2C77F10 Offset: 0x2C76910 VA: 0x182C77F10
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x2C78170 Offset: 0x2C76B70 VA: 0x182C78170
	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x2C779F0 Offset: 0x2C763F0 VA: 0x182C779F0
	private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info) { }

	// RVA: 0x2C77A40 Offset: 0x2C76440 VA: 0x182C77A40
	public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) { }

	// RVA: 0x2C77E60 Offset: 0x2C76860 VA: 0x182C77E60
	public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) { }

	[FreeFunction(Name = "AnimatorBindings::GetAnimatorClipInfoInternal", HasExplicitThis = True)]
	// RVA: 0x2C77920 Offset: 0x2C76320 VA: 0x182C77920
	private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips) { }

	// RVA: 0x2C780C0 Offset: 0x2C76AC0 VA: 0x182C780C0
	public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) { }

	// RVA: 0x2C782A0 Offset: 0x2C76CA0 VA: 0x182C782A0
	public bool IsInTransition(int layerIndex) { }

	[FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = True)]
	// RVA: 0x2C79150 Offset: 0x2C77B50 VA: 0x182C79150
	public AnimatorControllerParameter[] get_parameters() { }

	// RVA: 0x2C791E0 Offset: 0x2C77BE0 VA: 0x182C791E0
	public Vector3 get_pivotPosition() { }

	// RVA: 0x2C79270 Offset: 0x2C77C70 VA: 0x182C79270
	public float get_speed() { }

	// RVA: 0x2C79420 Offset: 0x2C77E20 VA: 0x182C79420
	public void set_speed(float value) { }

	[FreeFunction(Name = "AnimatorBindings::CrossFadeInFixedTime", HasExplicitThis = True)]
	// RVA: 0x2C77600 Offset: 0x2C76000 VA: 0x182C77600
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x2C77700 Offset: 0x2C76100 VA: 0x182C77700
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x2C77660 Offset: 0x2C76060 VA: 0x182C77660
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x2C777F0 Offset: 0x2C761F0 VA: 0x182C777F0
	public void CrossFade(string stateName, float normalizedTransitionDuration) { }

	// RVA: 0x2C77890 Offset: 0x2C76290 VA: 0x182C77890
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[FreeFunction(Name = "AnimatorBindings::CrossFade", HasExplicitThis = True)]
	// RVA: 0x2C77790 Offset: 0x2C76190 VA: 0x182C77790
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[FreeFunction(Name = "AnimatorBindings::PlayInFixedTime", HasExplicitThis = True)]
	// RVA: 0x2C78330 Offset: 0x2C76D30 VA: 0x182C78330
	public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime) { }

	// RVA: 0x2C783F0 Offset: 0x2C76DF0 VA: 0x182C783F0
	public void Play(string stateName, int layer, float normalizedTime) { }

	[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = True)]
	// RVA: 0x2C78390 Offset: 0x2C76D90 VA: 0x182C78390
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	// RVA: 0x2C77B00 Offset: 0x2C76500 VA: 0x182C77B00
	public Transform GetBoneTransform(HumanBodyBones humanBoneId) { }

	[NativeMethod("GetBoneTransform")]
	// RVA: 0x2C77AC0 Offset: 0x2C764C0 VA: 0x182C77AC0
	internal Transform GetBoneTransformInternal(int humanBoneId) { }

	// RVA: 0x2C79340 Offset: 0x2C77D40 VA: 0x182C79340
	public void set_cullingMode(AnimatorCullingMode value) { }

	// RVA: 0x2C79230 Offset: 0x2C77C30 VA: 0x182C79230
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x2C793D0 Offset: 0x2C77DD0 VA: 0x182C793D0
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	[NativeMethod("HasBoundPlayables")]
	// RVA: 0x2C78FD0 Offset: 0x2C779D0 VA: 0x182C78FD0
	public bool get_hasBoundPlayables() { }

	// RVA: 0x2C78210 Offset: 0x2C76C10 VA: 0x182C78210
	public bool HasState(int layerIndex, int stateID) { }

	[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = True)]
	// RVA: 0x2C78D80 Offset: 0x2C77780 VA: 0x182C78D80
	public static int StringToHash(string name) { }

	// RVA: 0x2C78E50 Offset: 0x2C77850 VA: 0x182C78E50
	public Avatar get_avatar() { }

	// RVA: 0x2C77550 Offset: 0x2C75F50 VA: 0x182C77550
	private void CheckIfInIKPass() { }

	// RVA: 0x2C78260 Offset: 0x2C76C60 VA: 0x182C78260
	private bool IsInIKPass() { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatString", HasExplicitThis = True)]
	// RVA: 0x2C78620 Offset: 0x2C77020 VA: 0x182C78620
	private void SetFloatString(string name, float value) { }

	[FreeFunction(Name = "AnimatorBindings::SetFloatID", HasExplicitThis = True)]
	// RVA: 0x2C785D0 Offset: 0x2C76FD0 VA: 0x182C785D0
	private void SetFloatID(int id, float value) { }

	[FreeFunction(Name = "AnimatorBindings::GetFloatString", HasExplicitThis = True)]
	// RVA: 0x2C77FF0 Offset: 0x2C769F0 VA: 0x182C77FF0
	private float GetFloatString(string name) { }

	[FreeFunction(Name = "AnimatorBindings::GetFloatID", HasExplicitThis = True)]
	// RVA: 0x2C77FB0 Offset: 0x2C769B0 VA: 0x182C77FB0
	private float GetFloatID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::SetBoolString", HasExplicitThis = True)]
	// RVA: 0x2C78570 Offset: 0x2C76F70 VA: 0x182C78570
	private void SetBoolString(string name, bool value) { }

	[FreeFunction(Name = "AnimatorBindings::SetBoolID", HasExplicitThis = True)]
	// RVA: 0x2C78510 Offset: 0x2C76F10 VA: 0x182C78510
	private void SetBoolID(int id, bool value) { }

	[FreeFunction(Name = "AnimatorBindings::GetBoolID", HasExplicitThis = True)]
	// RVA: 0x2C77E20 Offset: 0x2C76820 VA: 0x182C77E20
	private bool GetBoolID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::SetIntegerID", HasExplicitThis = True)]
	// RVA: 0x2C78A00 Offset: 0x2C77400 VA: 0x182C78A00
	private void SetIntegerID(int id, int value) { }

	[FreeFunction(Name = "AnimatorBindings::GetIntegerID", HasExplicitThis = True)]
	// RVA: 0x2C78040 Offset: 0x2C76A40 VA: 0x182C78040
	private int GetIntegerID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = True)]
	// RVA: 0x2C78D30 Offset: 0x2C77730 VA: 0x182C78D30
	private void SetTriggerString(string name) { }

	[FreeFunction(Name = "AnimatorBindings::SetTriggerID", HasExplicitThis = True)]
	// RVA: 0x2C78CF0 Offset: 0x2C776F0 VA: 0x182C78CF0
	private void SetTriggerID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = True)]
	// RVA: 0x2C784C0 Offset: 0x2C76EC0 VA: 0x182C784C0
	private void ResetTriggerString(string name) { }

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerID", HasExplicitThis = True)]
	// RVA: 0x2C78480 Offset: 0x2C76E80 VA: 0x182C78480
	private void ResetTriggerID(int id) { }

	[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveString", HasExplicitThis = True)]
	// RVA: 0x2C782E0 Offset: 0x2C76CE0 VA: 0x182C782E0
	private bool IsParameterControlledByCurveString(string name) { }

	[NativeMethod("UpdateWithDelta")]
	// RVA: 0x2C78DC0 Offset: 0x2C777C0 VA: 0x182C78DC0
	public void Update(float deltaTime) { }

	// RVA: 0x2C79110 Offset: 0x2C77B10 VA: 0x182C79110
	public bool get_logWarnings() { }

	// RVA: 0x2C79380 Offset: 0x2C77D80 VA: 0x182C79380
	public void set_keepAnimatorStateOnDisable(bool value) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x2C78E90 Offset: 0x2C77890 VA: 0x182C78E90
	private void get_deltaPosition_Injected(out Vector3 ret) { }

	// RVA: 0x2C78F30 Offset: 0x2C77930 VA: 0x182C78F30
	private void get_deltaRotation_Injected(out Quaternion ret) { }

	// RVA: 0x2C78680 Offset: 0x2C77080 VA: 0x182C78680
	private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) { }

	// RVA: 0x2C78720 Offset: 0x2C77120 VA: 0x182C78720
	private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) { }

	// RVA: 0x2C78AA0 Offset: 0x2C774A0 VA: 0x182C78AA0
	private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) { }

	// RVA: 0x2C79190 Offset: 0x2C77B90 VA: 0x182C79190
	private void get_pivotPosition_Injected(out Vector3 ret) { }
}
