internal class CameraRaycastHelper // TypeDefIndex: 19017
{
	// Methods

	[FreeFunction("CameraScripting::RaycastTry")]
	// RVA: 0x2D28C30 Offset: 0x2D27630 VA: 0x182D28C30
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	[FreeFunction("CameraScripting::RaycastTry2D")]
	// RVA: 0x2D28B50 Offset: 0x2D27550 VA: 0x182D28B50
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x2D28BC0 Offset: 0x2D275C0 VA: 0x182D28BC0
	private static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

	// RVA: 0x2D28AE0 Offset: 0x2D274E0 VA: 0x182D28AE0
	private static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }
}
