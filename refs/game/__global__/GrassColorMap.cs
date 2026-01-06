public class GrassColorMap : ScriptableObject // TypeDefIndex: 18846
{
	// Fields
	public int resolution; // 0x18
	public Bounds bounds; // 0x1C
	public Vector4 uv; // 0x34
	public Texture2D texture; // 0x48
	public Texture2D customTex; // 0x50
	[Tooltip("When enabled, a custom color map texture can be used")]
	public bool overrideTexture; // 0x58
	public bool hasScalemap; // 0x59
	public static GrassColorMap Active; // 0x0
	private static readonly int _ColorMap; // 0x8
	private static readonly int _ColorMapUV; // 0xC
	private static readonly int _ColorMapParams; // 0x10

	// Methods

	// RVA: 0x1F60BE0 Offset: 0x1F5F5E0 VA: 0x181F60BE0
	public void SetActive() { }

	// RVA: 0x1F60AB0 Offset: 0x1F5F4B0 VA: 0x181F60AB0
	public static void DisableGlobally() { }

	// RVA: 0x1F60E80 Offset: 0x1F5F880 VA: 0x181F60E80
	public void .ctor() { }

	// RVA: 0x1F60DD0 Offset: 0x1F5F7D0 VA: 0x181F60DD0
	private static void .cctor() { }
}
