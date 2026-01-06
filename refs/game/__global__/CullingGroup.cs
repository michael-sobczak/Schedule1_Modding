public class CullingGroup : IDisposable // TypeDefIndex: 11609
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private CullingGroup.StateChanged m_OnStateChanged; // 0x18

	// Properties
	public Camera targetCamera { set; }

	// Methods

	// RVA: 0x2C85080 Offset: 0x2C83A80 VA: 0x182C85080
	public void .ctor() { }

	// RVA: 0x2C84C40 Offset: 0x2C83640 VA: 0x182C84C40 Slot: 1
	protected override void Finalize() { }

	[FreeFunction("CullingGroup_Bindings::Dispose", HasExplicitThis = True)]
	// RVA: 0x2C84BC0 Offset: 0x2C835C0 VA: 0x182C84BC0
	private void DisposeInternal() { }

	// RVA: 0x2C84C00 Offset: 0x2C83600 VA: 0x182C84C00 Slot: 4
	public void Dispose() { }

	// RVA: 0x2C850E0 Offset: 0x2C83AE0 VA: 0x182C850E0
	public void set_targetCamera(Camera value) { }

	// RVA: 0x2C84F40 Offset: 0x2C83940 VA: 0x182C84F40
	public void SetBoundingSpheres(BoundingSphere[] array) { }

	// RVA: 0x2C84F00 Offset: 0x2C83900 VA: 0x182C84F00
	public void SetBoundingSphereCount(int count) { }

	// RVA: 0x2C84DC0 Offset: 0x2C837C0 VA: 0x182C84DC0
	public int QueryIndices(bool visible, int[] result, int firstIndex) { }

	[FreeFunction("CullingGroup_Bindings::QueryIndices", HasExplicitThis = True)]
	[NativeThrows]
	// RVA: 0x2C84D50 Offset: 0x2C83750 VA: 0x182C84D50
	private int QueryIndices(bool visible, int distanceIndex, CullingQueryOptions options, int[] result, int firstIndex) { }

	[FreeFunction("CullingGroup_Bindings::SetBoundingDistances", HasExplicitThis = True)]
	// RVA: 0x2C84EB0 Offset: 0x2C838B0 VA: 0x182C84EB0
	public void SetBoundingDistances(float[] distances) { }

	[FreeFunction("CullingGroup_Bindings::SetDistanceReferencePoint", HasExplicitThis = True)]
	// RVA: 0x2C84FE0 Offset: 0x2C839E0 VA: 0x182C84FE0
	private void SetDistanceReferencePoint_InternalVector3(Vector3 point) { }

	// RVA: 0x2C85030 Offset: 0x2C83A30 VA: 0x182C85030
	public void SetDistanceReferencePoint(Vector3 point) { }

	[RequiredByNativeCode]
	// RVA: 0x2C84E40 Offset: 0x2C83840 VA: 0x182C84E40
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }

	[FreeFunction("CullingGroup_Bindings::Init")]
	// RVA: 0x2C84D10 Offset: 0x2C83710 VA: 0x182C84D10
	private static IntPtr Init(object scripting) { }

	[FreeFunction("CullingGroup_Bindings::FinalizerFailure", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x2C84CD0 Offset: 0x2C836D0 VA: 0x182C84CD0
	private void FinalizerFailure() { }

	// RVA: 0x2C84F90 Offset: 0x2C83990 VA: 0x182C84F90
	private void SetDistanceReferencePoint_InternalVector3_Injected(ref Vector3 point) { }
}
