public sealed class DitheringComponent : PostProcessingComponentRenderTexture<DitheringModel> // TypeDefIndex: 128
{
	// Fields
	private Texture2D[] noiseTextures; // 0x20
	private int textureIndex; // 0x28
	private const int k_TextureCount = 64;

	// Properties
	public override bool active { get; }

	// Methods

	// RVA: 0x571B40 Offset: 0x570540 VA: 0x180571B40 Slot: 5
	public override bool get_active() { }

	// RVA: 0x5717F0 Offset: 0x5701F0 VA: 0x1805717F0 Slot: 7
	public override void OnDisable() { }

	// RVA: 0x5716F0 Offset: 0x5700F0 VA: 0x1805716F0
	private void LoadNoiseTextures() { }

	// RVA: 0x571810 Offset: 0x570210 VA: 0x180571810 Slot: 10
	public override void Prepare(Material uberMaterial) { }

	// RVA: 0x571B00 Offset: 0x570500 VA: 0x180571B00
	public void .ctor() { }
}
