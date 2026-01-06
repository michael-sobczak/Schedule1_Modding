public abstract class AnimationModifier : MonoBehaviour // TypeDefIndex: 13998
{
	// Fields
	protected Animator animator; // 0x20
	protected Baker baker; // 0x28

	// Methods

	// RVA: 0x1E92EB0 Offset: 0x1E918B0 VA: 0x181E92EB0 Slot: 4
	public virtual void OnInitiate(Baker baker, Animator animator) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public virtual void OnStartClip(AnimationClip clip) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 6
	public virtual void OnBakerUpdate(float normalizedTime) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}
