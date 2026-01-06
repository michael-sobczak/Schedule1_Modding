public class CausticsFeature : ScriptableRendererFeature // TypeDefIndex: 18809
{
	// Fields
	public CausticsFeature.CausticsSettings settings; // 0x20
	private CausticsPass causticsPass; // 0x28
	[HideInInspector]
	[SerializeField]
	private Shader causticsShader; // 0x30
	private Material causticsMaterial; // 0x38
	private static readonly int SrcBlend; // 0x0
	private static readonly int DstBlend; // 0x4
	private static readonly int causticsTextureID; // 0x8
	private static readonly int causticsStrengthID; // 0xC
	private static readonly int causticsScaleID; // 0x10
	private static readonly int causticsSpeedID; // 0x14
	private static readonly int causticsSplitID; // 0x18
	private static readonly int shadowMaskID; // 0x1C
	private static readonly int causticsFadeID; // 0x20
	private static readonly int waterLevelID; // 0x24
	private static readonly int causticsStartID; // 0x28
	private static readonly int causticsEndID; // 0x2C

	// Methods

	// RVA: 0x1F739D0 Offset: 0x1F723D0 VA: 0x181F739D0 Slot: 5
	public override void Create() { }

	// RVA: 0x1F739A0 Offset: 0x1F723A0 VA: 0x181F739A0 Slot: 7
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	// RVA: 0x1F742B0 Offset: 0x1F72CB0 VA: 0x181F742B0
	public void .ctor() { }

	// RVA: 0x1F74080 Offset: 0x1F72A80 VA: 0x181F74080
	private static void .cctor() { }
}
