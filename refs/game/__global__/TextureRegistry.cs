internal class TextureRegistry // TypeDefIndex: 6758
{
	// Fields
	private List<TextureRegistry.TextureInfo> m_Textures; // 0x10
	private Dictionary<Texture, TextureId> m_TextureToId; // 0x18
	private Stack<TextureId> m_FreeIds; // 0x20
	internal const int maxTextures = 2048;
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly TextureRegistry <instance>k__BackingField; // 0x0

	// Properties
	public static TextureRegistry instance { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2EE26B0 Offset: 0x2EE10B0 VA: 0x182EE26B0
	public static TextureRegistry get_instance() { }

	// RVA: 0x2EE1D70 Offset: 0x2EE0770 VA: 0x182EE1D70
	public Texture GetTexture(TextureId id) { }

	// RVA: 0x2EE19D0 Offset: 0x2EE03D0 VA: 0x182EE19D0
	public TextureId AllocAndAcquireDynamic() { }

	// RVA: 0x2EE21C0 Offset: 0x2EE0BC0 VA: 0x182EE21C0
	public void UpdateDynamic(TextureId id, Texture texture) { }

	// RVA: 0x2EE19E0 Offset: 0x2EE03E0 VA: 0x182EE19E0
	private TextureId AllocAndAcquire(Texture texture, bool dynamic) { }

	// RVA: 0x2EE1830 Offset: 0x2EE0230 VA: 0x182EE1830
	public TextureId Acquire(Texture tex) { }

	// RVA: 0x2EE1F20 Offset: 0x2EE0920 VA: 0x182EE1F20
	public void Release(TextureId id) { }

	// RVA: 0x2EE25A0 Offset: 0x2EE0FA0 VA: 0x182EE25A0
	public void .ctor() { }

	// RVA: 0x2EE2440 Offset: 0x2EE0E40 VA: 0x182EE2440
	private static void .cctor() { }
}
