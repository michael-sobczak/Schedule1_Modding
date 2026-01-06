public sealed class PropertySheet // TypeDefIndex: 17068
{
	// Fields
	[CompilerGenerated]
	private MaterialPropertyBlock <properties>k__BackingField; // 0x10
	[CompilerGenerated]
	private Material <material>k__BackingField; // 0x18

	// Properties
	public MaterialPropertyBlock properties { get; set; }
	internal Material material { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public MaterialPropertyBlock get_properties() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_properties(MaterialPropertyBlock value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal Material get_material() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_material(Material value) { }

	// RVA: 0x29BB490 Offset: 0x29B9E90 VA: 0x1829BB490
	internal void .ctor(Material material) { }

	// RVA: 0x29BB3B0 Offset: 0x29B9DB0 VA: 0x1829BB3B0
	public void ClearKeywords() { }

	// RVA: 0x29BB400 Offset: 0x29B9E00 VA: 0x1829BB400
	public void EnableKeyword(string keyword) { }

	// RVA: 0x29BB3E0 Offset: 0x29B9DE0 VA: 0x1829BB3E0
	public void DisableKeyword(string keyword) { }

	// RVA: 0x29BB420 Offset: 0x29B9E20 VA: 0x1829BB420
	internal void Release() { }
}
