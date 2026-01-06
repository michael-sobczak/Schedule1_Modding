public class CausticsPass : ScriptableRenderPass // TypeDefIndex: 18810
{
	// Fields
	private const string profilerTag = "Caustics Pass";
	public Material causticsMaterial; // 0xE0
	private static Mesh mesh; // 0x0
	private float waterLevel; // 0xE8
	private const float BIAS = 0.1;

	// Methods

	// RVA: 0x1F74B70 Offset: 0x1F73570 VA: 0x181F74B70
	public void .ctor(float waterLevel) { }

	// RVA: 0x1F74360 Offset: 0x1F72D60 VA: 0x181F74360 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x1F749E0 Offset: 0x1F733E0 VA: 0x181F749E0
	private static Mesh GenerateQuad(float size) { }
}
