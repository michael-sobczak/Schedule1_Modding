public class BakerMuscle // TypeDefIndex: 14012
{
	// Fields
	public AnimationCurve curve; // 0x10
	private int muscleIndex; // 0x18
	private string propertyName; // 0x20

	// Methods

	// RVA: 0x1E972A0 Offset: 0x1E95CA0 VA: 0x181E972A0
	public void .ctor(int muscleIndex) { }

	// RVA: 0x1E96650 Offset: 0x1E95050 VA: 0x181E96650
	private string MuscleNameToPropertyName(string n) { }

	// RVA: 0x1E955B0 Offset: 0x1E93FB0 VA: 0x181E955B0
	public void MultiplyLength(AnimationCurve curve, float mlp) { }

	// RVA: 0x1E970A0 Offset: 0x1E95AA0 VA: 0x181E970A0
	public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp) { }

	// RVA: 0x1E97040 Offset: 0x1E95A40 VA: 0x181E97040
	public void Reset() { }

	// RVA: 0x1E97250 Offset: 0x1E95C50 VA: 0x181E97250
	public void SetKeyframe(float time, float[] muscles) { }

	// RVA: 0x1E97290 Offset: 0x1E95C90 VA: 0x181E97290
	public void SetLoopFrame(float time) { }
}
