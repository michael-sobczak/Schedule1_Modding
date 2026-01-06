public class SkinnedMeshRenderer : Renderer // TypeDefIndex: 11715
{
	// Properties
	public bool updateWhenOffscreen { set; }
	public Transform[] bones { get; set; }
	[NativeProperty("Mesh")]
	public Mesh sharedMesh { get; }

	// Methods

	// RVA: 0x2CA0800 Offset: 0x2C9F200 VA: 0x182CA0800
	public void set_updateWhenOffscreen(bool value) { }

	// RVA: 0x2CA0730 Offset: 0x2C9F130 VA: 0x182CA0730
	public Transform[] get_bones() { }

	// RVA: 0x2CA07B0 Offset: 0x2C9F1B0 VA: 0x182CA07B0
	public void set_bones(Transform[] value) { }

	// RVA: 0x2CA0770 Offset: 0x2C9F170 VA: 0x182CA0770
	public Mesh get_sharedMesh() { }

	// RVA: 0x2CA06E0 Offset: 0x2C9F0E0 VA: 0x182CA06E0
	public void SetBlendShapeWeight(int index, float value) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
