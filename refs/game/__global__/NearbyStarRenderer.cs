public class NearbyStarRenderer : BaseStarDataRenderer // TypeDefIndex: 400
{
	// Fields
	private const int kMaxStars = 2000;
	private const int kStarPointTextureWidth = 2048;
	private const float kStarPaddingRadiusMultipler = 2.1;

	// Methods

	// RVA: 0x8D5630 Offset: 0x8D4030 VA: 0x1808D5630
	private RenderTexture CreateRenderTexture(string name, int renderTextureSize, RenderTextureFormat format) { }

	// RVA: 0x8D56B0 Offset: 0x8D40B0 VA: 0x1808D56B0
	private Material GetNearbyStarMaterial(Vector4 randomSeed, int starCount) { }

	// RVA: 0x8D5B70 Offset: 0x8D4570 VA: 0x1808D5B70
	private void WriteDebugTexture(RenderTexture rt, string path) { }

	// RVA: 0x8D5820 Offset: 0x8D4220 VA: 0x1808D5820
	private Texture2D GetStarListTexture(string starTexKey, out int validStarPixelCount) { }

	[IteratorStateMachine(typeof(NearbyStarRenderer.<ComputeStarData>d__7))]
	// RVA: 0x8D5440 Offset: 0x8D3E40 VA: 0x1808D5440 Slot: 4
	public override IEnumerator ComputeStarData() { }

	// RVA: 0x8D54B0 Offset: 0x8D3EB0 VA: 0x1808D54B0
	private Texture2D ConvertToTexture2D(RenderTexture rt) { }

	// RVA: 0x8D5BA0 Offset: 0x8D45A0 VA: 0x1808D5BA0
	public void .ctor() { }
}
