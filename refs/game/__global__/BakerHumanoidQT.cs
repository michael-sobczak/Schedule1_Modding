public class BakerHumanoidQT // TypeDefIndex: 14011
{
	// Fields
	private Transform transform; // 0x10
	private string Qx; // 0x18
	private string Qy; // 0x20
	private string Qz; // 0x28
	private string Qw; // 0x30
	private string Tx; // 0x38
	private string Ty; // 0x40
	private string Tz; // 0x48
	public AnimationCurve rotX; // 0x50
	public AnimationCurve rotY; // 0x58
	public AnimationCurve rotZ; // 0x60
	public AnimationCurve rotW; // 0x68
	public AnimationCurve posX; // 0x70
	public AnimationCurve posY; // 0x78
	public AnimationCurve posZ; // 0x80
	private AvatarIKGoal goal; // 0x88
	private Quaternion lastQ; // 0x8C
	private bool lastQSet; // 0x9C

	// Methods

	// RVA: 0x1E96320 Offset: 0x1E94D20 VA: 0x181E96320
	public void .ctor(string name) { }

	// RVA: 0x1E964A0 Offset: 0x1E94EA0 VA: 0x181E964A0
	public void .ctor(Transform transform, AvatarIKGoal goal, string name) { }

	// RVA: 0x1E95010 Offset: 0x1E93A10 VA: 0x181E95010
	public Quaternion EvaluateRotation(float time) { }

	// RVA: 0x1E94F70 Offset: 0x1E93970 VA: 0x181E94F70
	public Vector3 EvaluatePosition(float time) { }

	// RVA: 0x1E950E0 Offset: 0x1E93AE0 VA: 0x181E950E0
	public TQ Evaluate(float time) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void GetCurvesFromClip(AnimationClip clip, Animator animator) { }

	// RVA: 0x1E95660 Offset: 0x1E94060 VA: 0x181E95660
	public void Reset() { }

	// RVA: 0x1E95CA0 Offset: 0x1E946A0 VA: 0x181E95CA0
	public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation) { }

	// RVA: 0x1E96190 Offset: 0x1E94B90 VA: 0x181E96190
	public void SetKeyframes(float time, Vector3 pos, Quaternion rot) { }

	// RVA: 0x1E95310 Offset: 0x1E93D10 VA: 0x181E95310
	public void MoveLastKeyframes(float time) { }

	// RVA: 0x1E96290 Offset: 0x1E94C90 VA: 0x181E96290
	public void SetLoopFrame(float time) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void SetRootLoopFrame(float time) { }

	// RVA: 0x1E95290 Offset: 0x1E93C90 VA: 0x181E95290
	private void MoveLastKeyframe(float time, AnimationCurve curve) { }

	// RVA: 0x1E955B0 Offset: 0x1E93FB0 VA: 0x181E955B0
	public void MultiplyLength(AnimationCurve curve, float mlp) { }

	// RVA: 0x1E95800 Offset: 0x1E94200 VA: 0x181E95800
	public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp) { }
}
