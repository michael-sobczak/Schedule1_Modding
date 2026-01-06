public sealed class NavMeshPath // TypeDefIndex: 18873
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal Vector3[] m_Corners; // 0x18

	// Properties
	public Vector3[] corners { get; }
	public NavMeshPathStatus status { get; }

	// Methods

	// RVA: 0x2C643D0 Offset: 0x2C62DD0 VA: 0x182C643D0
	public void .ctor() { }

	// RVA: 0x2C64310 Offset: 0x2C62D10 VA: 0x182C64310 Slot: 1
	protected override void Finalize() { }

	[FreeFunction("NavMeshPathScriptBindings::InitializeNavMeshPath")]
	// RVA: 0x2C643A0 Offset: 0x2C62DA0 VA: 0x182C643A0
	private static IntPtr InitializeNavMeshPath() { }

	[FreeFunction("NavMeshPathScriptBindings::DestroyNavMeshPath", IsThreadSafe = True)]
	// RVA: 0x2C642D0 Offset: 0x2C62CD0 VA: 0x182C642D0
	private static void DestroyNavMeshPath(IntPtr ptr) { }

	[FreeFunction("NavMeshPathScriptBindings::CalculateCornersInternal", HasExplicitThis = True)]
	// RVA: 0x2C641B0 Offset: 0x2C62BB0 VA: 0x182C641B0
	private Vector3[] CalculateCornersInternal() { }

	[FreeFunction("NavMeshPathScriptBindings::ClearCornersInternal", HasExplicitThis = True)]
	// RVA: 0x2C64240 Offset: 0x2C62C40 VA: 0x182C64240
	private void ClearCornersInternal() { }

	// RVA: 0x2C64280 Offset: 0x2C62C80 VA: 0x182C64280
	public void ClearCorners() { }

	// RVA: 0x2C641F0 Offset: 0x2C62BF0 VA: 0x182C641F0
	private void CalculateCorners() { }

	// RVA: 0x2C64410 Offset: 0x2C62E10 VA: 0x182C64410
	public Vector3[] get_corners() { }

	// RVA: 0x2C64470 Offset: 0x2C62E70 VA: 0x182C64470
	public NavMeshPathStatus get_status() { }
}
