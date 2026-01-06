public sealed class Animation : Behaviour, IEnumerable // TypeDefIndex: 18282
{
	// Properties
	public AnimationClip clip { get; }
	public bool isPlaying { get; }
	public AnimationState Item { get; }
	public bool animatePhysics { get; }

	// Methods

	// RVA: 0x2C76E80 Offset: 0x2C75880 VA: 0x182C76E80
	public AnimationClip get_clip() { }

	// RVA: 0x2C76E00 Offset: 0x2C75800 VA: 0x182C76E00
	public void Stop() { }

	// RVA: 0x2C76DB0 Offset: 0x2C757B0 VA: 0x182C76DB0
	public void Stop(string name) { }

	[NativeName("Stop")]
	// RVA: 0x2C76DB0 Offset: 0x2C757B0 VA: 0x182C76DB0
	private void StopNamed(string name) { }

	// RVA: 0x2C76D30 Offset: 0x2C75730 VA: 0x182C76D30
	public void Rewind() { }

	// RVA: 0x2C76CE0 Offset: 0x2C756E0 VA: 0x182C76CE0
	public void Rewind(string name) { }

	[NativeName("Rewind")]
	// RVA: 0x2C76CE0 Offset: 0x2C756E0 VA: 0x182C76CE0
	private void RewindNamed(string name) { }

	// RVA: 0x2C76D70 Offset: 0x2C75770 VA: 0x182C76D70
	public void Sample() { }

	[NativeName("IsPlaying")]
	// RVA: 0x2C76EC0 Offset: 0x2C758C0 VA: 0x182C76EC0
	public bool get_isPlaying() { }

	// RVA: 0x2C76B60 Offset: 0x2C75560 VA: 0x182C76B60
	public AnimationState get_Item(string name) { }

	[ExcludeFromDocs]
	// RVA: 0x2C76BF0 Offset: 0x2C755F0 VA: 0x182C76BF0
	public bool Play() { }

	// RVA: 0x2C76BB0 Offset: 0x2C755B0 VA: 0x182C76BB0
	public bool Play(PlayMode mode) { }

	[NativeName("Play")]
	// RVA: 0x2C76BB0 Offset: 0x2C755B0 VA: 0x182C76BB0
	private bool PlayDefaultAnimation(PlayMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x2C76C90 Offset: 0x2C75690 VA: 0x182C76C90
	public bool Play(string animation) { }

	// RVA: 0x2C76C30 Offset: 0x2C75630 VA: 0x182C76C30
	public bool Play(string animation, PlayMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x2C76910 Offset: 0x2C75310 VA: 0x182C76910
	public void CrossFade(string animation, float fadeLength) { }

	// RVA: 0x2C76970 Offset: 0x2C75370 VA: 0x182C76970
	public void CrossFade(string animation, float fadeLength, PlayMode mode) { }

	// RVA: 0x2C76830 Offset: 0x2C75230 VA: 0x182C76830
	public void AddClip(AnimationClip clip, string newName) { }

	[ExcludeFromDocs]
	// RVA: 0x2C767C0 Offset: 0x2C751C0 VA: 0x182C767C0
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame) { }

	// RVA: 0x2C768A0 Offset: 0x2C752A0 VA: 0x182C768A0
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame) { }

	// RVA: 0x2C76A70 Offset: 0x2C75470 VA: 0x182C76A70 Slot: 4
	public IEnumerator GetEnumerator() { }

	[FreeFunction("AnimationBindings::GetState", HasExplicitThis = True)]
	// RVA: 0x2C76B60 Offset: 0x2C75560 VA: 0x182C76B60
	internal AnimationState GetState(string name) { }

	[FreeFunction("AnimationBindings::GetStateAtIndex", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2C76AE0 Offset: 0x2C754E0 VA: 0x182C76AE0
	internal AnimationState GetStateAtIndex(int index) { }

	[NativeName("GetAnimationStateCount")]
	// RVA: 0x2C76B20 Offset: 0x2C75520 VA: 0x182C76B20
	internal int GetStateCount() { }

	// RVA: 0x2C769E0 Offset: 0x2C753E0 VA: 0x182C769E0
	public AnimationClip GetClip(string name) { }

	// RVA: 0x2C76E40 Offset: 0x2C75840 VA: 0x182C76E40
	public bool get_animatePhysics() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
