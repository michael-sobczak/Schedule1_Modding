public class LightningArtItem : SpriteArtItem // TypeDefIndex: 404
{
	// Fields
	[Tooltip("Adjust how the lightning bolt is positioned inside the spawn area container.")]
	public LightningArtItem.Alignment alignment; // 0x48
	[Tooltip("Thunder sound clip to play when this lighting bolt is rendered.")]
	public AudioClip thunderSound; // 0x50
	[Tooltip("Probability adjustment for this specific lightning bolt. This value is multiplied against the global lightning probability.")]
	[Range(0, 1)]
	public float strikeProbability; // 0x58
	[Tooltip("Size of the lighting bolt.")]
	[Range(0, 60)]
	public float size; // 0x5C
	[Range(0, 1)]
	[Tooltip("The blending weight of the additive lighting bolt effect")]
	public float intensity; // 0x60

	// Methods

	// RVA: 0x8C7450 Offset: 0x8C5E50 VA: 0x1808C7450
	public void .ctor() { }
}
