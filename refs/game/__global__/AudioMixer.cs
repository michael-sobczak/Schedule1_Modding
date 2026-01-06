public class AudioMixer : Object // TypeDefIndex: 18961
{
	// Methods

	// RVA: 0x2C7B9F0 Offset: 0x2C7A3F0 VA: 0x182C7B9F0
	internal void .ctor() { }

	// RVA: 0x2C7B750 Offset: 0x2C7A150 VA: 0x182C7B750
	internal void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach) { }

	[NativeMethod("TransitionToSnapshot")]
	// RVA: 0x2C7B6F0 Offset: 0x2C7A0F0 VA: 0x182C7B6F0
	private void TransitionToSnapshotInternal(AudioMixerSnapshot snapshot, float timeToReach) { }

	[NativeMethod]
	// RVA: 0x2C7B690 Offset: 0x2C7A090 VA: 0x182C7B690
	public bool SetFloat(string name, float value) { }
}
