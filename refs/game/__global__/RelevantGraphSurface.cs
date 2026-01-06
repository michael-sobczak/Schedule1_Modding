public class RelevantGraphSurface : VersionedMonoBehaviour // TypeDefIndex: 13306
{
	// Fields
	private static RelevantGraphSurface root; // 0x0
	public float maxRange; // 0x28
	private RelevantGraphSurface prev; // 0x30
	private RelevantGraphSurface next; // 0x38
	private Vector3 position; // 0x40

	// Properties
	public Vector3 Position { get; }
	public RelevantGraphSurface Next { get; }
	public RelevantGraphSurface Prev { get; }
	public static RelevantGraphSurface Root { get; }

	// Methods

	// RVA: 0x79EE30 Offset: 0x79D830 VA: 0x18079EE30
	public Vector3 get_Position() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public RelevantGraphSurface get_Next() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public RelevantGraphSurface get_Prev() { }

	// RVA: 0xB76FD0 Offset: 0xB759D0 VA: 0x180B76FD0
	public static RelevantGraphSurface get_Root() { }

	// RVA: 0xB76F90 Offset: 0xB75990 VA: 0x180B76F90
	public void UpdatePosition() { }

	// RVA: 0xB76DC0 Offset: 0xB757C0 VA: 0x180B76DC0
	private void OnEnable() { }

	// RVA: 0xB76850 Offset: 0xB75250 VA: 0x180B76850
	private void OnDisable() { }

	// RVA: 0xB76EE0 Offset: 0xB758E0 VA: 0x180B76EE0
	public static void UpdateAllPositions() { }

	// RVA: 0xB76620 Offset: 0xB75020 VA: 0x180B76620
	public static void FindAllGraphSurfaces() { }

	// RVA: 0xB76BF0 Offset: 0xB755F0 VA: 0x180B76BF0
	public void OnDrawGizmos() { }

	// RVA: 0xB76A20 Offset: 0xB75420 VA: 0x180B76A20
	public void OnDrawGizmosSelected() { }

	// RVA: 0x854AA0 Offset: 0x8534A0 VA: 0x180854AA0
	public void .ctor() { }
}
