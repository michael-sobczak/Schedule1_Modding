public class GodRaysRenderData : ScriptableObject // TypeDefIndex: 18721
{
	// Fields
	public Material Grabpass; // 0x18
	public Material DepthGrabpass; // 0x20
	public Material ScreenSpaceGodRays; // 0x28
	public Material ApplyGodRays; // 0x30
	public Material BilateralBlur; // 0x38
	public ComputeShader TemporalReprojectionShader; // 0x40
	public bool StripUnusedShadersFromBuilds; // 0x48

	// Methods

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	public void .ctor() { }
}
