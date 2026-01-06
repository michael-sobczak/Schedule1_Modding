internal struct FrameTimeSample // TypeDefIndex: 13685
{
	// Fields
	internal float FramesPerSecond; // 0x0
	internal float FullFrameTime; // 0x4
	internal float MainThreadCPUFrameTime; // 0x8
	internal float MainThreadCPUPresentWaitTime; // 0xC
	internal float RenderThreadCPUFrameTime; // 0x10
	internal float GPUFrameTime; // 0x14

	// Methods

	// RVA: 0x292B550 Offset: 0x2929F50 VA: 0x18292B550
	internal void .ctor(float initValue) { }
}
