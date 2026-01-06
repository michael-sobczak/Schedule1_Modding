public class WaveParameters // TypeDefIndex: 18272
{
	// Fields
	private const string WavesKeyword = "_WAVES";
	private static int _Direction; // 0x0
	private static int _Speed; // 0x4
	private static int _WaveDistance; // 0x8
	private static int _WaveSpeed; // 0xC
	private static int _WaveHeight; // 0x10
	private static int _WaveSteepness; // 0x14
	private static int _WaveCount; // 0x18
	private static int _WaveDirection; // 0x1C
	public Vector2 animationDirection; // 0x10
	public float animationSpeed; // 0x18
	public int count; // 0x1C
	public float distance; // 0x20
	public float speed; // 0x24
	public float height; // 0x28
	public float steepness; // 0x2C
	public Vector4 direction; // 0x30

	// Methods

	// RVA: 0x1F737A0 Offset: 0x1F721A0 VA: 0x181F737A0
	public static bool WavesEnabled(Material waterMat) { }

	// RVA: 0x1F73440 Offset: 0x1F71E40 VA: 0x181F73440
	public static float GetMaxWaveHeight(Material mat) { }

	// RVA: 0x1F73620 Offset: 0x1F72020 VA: 0x181F73620
	public void Update(Material waterMat) { }

	// RVA: 0x1F734B0 Offset: 0x1F71EB0 VA: 0x181F734B0
	public void SetAsGlobal() { }

	// RVA: 0x1F732A0 Offset: 0x1F71CA0 VA: 0x181F732A0
	public void Apply(Material mat) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x1F73820 Offset: 0x1F72220 VA: 0x181F73820
	private static void .cctor() { }
}
