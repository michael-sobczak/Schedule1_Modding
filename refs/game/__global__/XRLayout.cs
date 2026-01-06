public class XRLayout // TypeDefIndex: 13493
{
	// Fields
	private readonly List<ValueTuple<Camera, XRPass>> m_ActivePasses; // 0x10

	// Methods

	// RVA: 0x29DD190 Offset: 0x29DBB90 VA: 0x1829DD190
	public void AddCamera(Camera camera, bool enableXR) { }

	// RVA: 0x29DDB50 Offset: 0x29DC550 VA: 0x1829DDB50
	public void ReconfigurePass(XRPass xrPass, Camera camera) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public List<ValueTuple<Camera, XRPass>> GetActivePasses() { }

	// RVA: 0x29DD3D0 Offset: 0x29DBDD0 VA: 0x1829DD3D0
	internal void AddPass(Camera camera, XRPass xrPass) { }

	// RVA: 0x29DD4F0 Offset: 0x29DBEF0 VA: 0x1829DD4F0
	internal void Clear() { }

	// RVA: 0x29DD620 Offset: 0x29DC020 VA: 0x1829DD620
	internal void LogDebugInfo() { }

	// RVA: 0x29DDBF0 Offset: 0x29DC5F0 VA: 0x1829DDBF0
	public void .ctor() { }
}
