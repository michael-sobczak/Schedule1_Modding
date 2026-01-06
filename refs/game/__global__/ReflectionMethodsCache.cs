internal class ReflectionMethodsCache // TypeDefIndex: 16493
{
	// Fields
	public ReflectionMethodsCache.Raycast3DCallback raycast3D; // 0x10
	public ReflectionMethodsCache.RaycastAllCallback raycast3DAll; // 0x18
	public ReflectionMethodsCache.GetRaycastNonAllocCallback getRaycastNonAlloc; // 0x20
	public ReflectionMethodsCache.Raycast2DCallback raycast2D; // 0x28
	public ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll; // 0x30
	public ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc; // 0x38
	private static ReflectionMethodsCache s_ReflectionMethodsCache; // 0x0

	// Properties
	public static ReflectionMethodsCache Singleton { get; }

	// Methods

	// RVA: 0x2F31A60 Offset: 0x2F30460 VA: 0x182F31A60
	public void .ctor() { }

	// RVA: 0x2F32A20 Offset: 0x2F31420 VA: 0x182F32A20
	public static ReflectionMethodsCache get_Singleton() { }
}
