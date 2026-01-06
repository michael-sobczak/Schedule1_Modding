internal class PixelPerfectCameraInternal : ISerializationCallbackReceiver // TypeDefIndex: 8720
{
	// Fields
	private IPixelPerfectCamera m_Component; // 0x10
	private PixelPerfectCamera m_SerializableComponent; // 0x18
	internal float originalOrthoSize; // 0x20
	internal bool hasPostProcessLayer; // 0x24
	internal bool cropFrameXAndY; // 0x25
	internal bool cropFrameXOrY; // 0x26
	internal bool useStretchFill; // 0x27
	internal int zoom; // 0x28
	internal bool useOffscreenRT; // 0x2C
	internal int offscreenRTWidth; // 0x30
	internal int offscreenRTHeight; // 0x34
	internal Rect pixelRect; // 0x38
	internal float orthoSize; // 0x48
	internal float unitsPerPixel; // 0x4C
	internal int cinemachineVCamZoom; // 0x50
	internal bool requiresUpscaling; // 0x54

	// Methods

	// RVA: 0x2A82550 Offset: 0x2A80F50 VA: 0x182A82550
	internal void .ctor(IPixelPerfectCamera component) { }

	// RVA: 0x2A82480 Offset: 0x2A80E80 VA: 0x182A82480 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x2A82410 Offset: 0x2A80E10 VA: 0x182A82410 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x2A81B90 Offset: 0x2A80590 VA: 0x182A81B90
	internal void CalculateCameraProperties(int screenWidth, int screenHeight) { }

	// RVA: 0x2A82040 Offset: 0x2A80A40 VA: 0x182A82040
	internal Rect CalculateFinalBlitPixelRect(int screenWidth, int screenHeight) { }

	// RVA: 0x2A82290 Offset: 0x2A80C90 VA: 0x182A82290
	internal float CorrectCinemachineOrthoSize(float targetOrthoSize) { }
}
