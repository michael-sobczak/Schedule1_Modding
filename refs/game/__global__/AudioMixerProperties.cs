internal class AudioMixerProperties : PlayableBehaviour // TypeDefIndex: 17393
{
	// Fields
	[Range(0, 1)]
	public float volume; // 0x10
	[Range(-1, 1)]
	public float stereoPan; // 0x14
	[Range(0, 1)]
	public float spatialBlend; // 0x18

	// Methods

	// RVA: 0x2C40F00 Offset: 0x2C3F900 VA: 0x182C40F00 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x2C40EF0 Offset: 0x2C3F8F0 VA: 0x182C40EF0
	public void .ctor() { }
}
