public class SpriteArtItem : ScriptableObject // TypeDefIndex: 408
{
	// Fields
	public Mesh mesh; // 0x18
	public Material material; // 0x20
	public int rows; // 0x28
	public int columns; // 0x2C
	public int totalFrames; // 0x30
	public int animateSpeed; // 0x34
	[Tooltip("Color that will be multiplied against the base lightning bolt text color")]
	public Color tintColor; // 0x38

	// Methods

	// RVA: 0x8D8C20 Offset: 0x8D7620 VA: 0x1808D8C20
	public void .ctor() { }
}
