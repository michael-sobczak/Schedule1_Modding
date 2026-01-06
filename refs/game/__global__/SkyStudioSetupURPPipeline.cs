public class SkyStudioSetupURPPipeline : MonoBehaviour // TypeDefIndex: 498
{
	// Fields
	[Tooltip("The rendering pipeline that will be assigned into the graphics settings when this scene becomes active.")]
	[HelpBox("For URP projects, Sky Studio will assign this rendering pipeline into GraphicsSettings. We have to install this pipeline so that we can embed our own custom render features, which are required for certain Sky Studio features like rain splashes to work properly. If you need to add rendering features, or customize the rendering pipeline asset please update this reference, and ensure that the 'SkyStudio-WeatherDepthForwardRenderer' is assigned to render feature index 1. Feel free to add any custom render features after index 1.", 1)]
	public RenderPipelineAsset pipelineAsset; // 0x20

	// Methods

	// RVA: 0xA90830 Offset: 0xA8F230 VA: 0x180A90830
	private void Update() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
