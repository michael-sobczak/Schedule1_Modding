public class BakerTransform // TypeDefIndex: 14013
{
	// Fields
	public Transform transform; // 0x10
	public AnimationCurve posX; // 0x18
	public AnimationCurve posY; // 0x20
	public AnimationCurve posZ; // 0x28
	public AnimationCurve rotX; // 0x30
	public AnimationCurve rotY; // 0x38
	public AnimationCurve rotZ; // 0x40
	public AnimationCurve rotW; // 0x48
	private string relativePath; // 0x50
	private bool recordPosition; // 0x58
	private Vector3 relativePosition; // 0x5C
	private bool isRootNode; // 0x68
	private Quaternion relativeRotation; // 0x6C

	// Methods

	// RVA: 0x1E98150 Offset: 0x1E96B50 VA: 0x181E98150
	public void .ctor(Transform transform, Transform root, bool recordPosition, bool isRootNode) { }

	// RVA: 0x1E98130 Offset: 0x1E96B30 VA: 0x181E98130
	public void SetRelativeSpace(Vector3 position, Quaternion rotation) { }

	// RVA: 0x1E97B20 Offset: 0x1E96520 VA: 0x181E97B20
	public void SetCurves(ref AnimationClip clip) { }

	// RVA: 0x1E97570 Offset: 0x1E95F70 VA: 0x181E97570
	private void AddRootMotionCurves(ref AnimationClip clip) { }

	// RVA: 0x1E979C0 Offset: 0x1E963C0 VA: 0x181E979C0
	public void Reset() { }

	// RVA: 0x1E97840 Offset: 0x1E96240 VA: 0x181E97840
	public void ReduceKeyframes(float maxError) { }

	// RVA: 0x1E97E00 Offset: 0x1E96800 VA: 0x181E97E00
	public void SetKeyframes(float time) { }

	// RVA: 0x1E97350 Offset: 0x1E95D50 VA: 0x181E97350
	public void AddLoopFrame(float time) { }
}
