public class NodeLink : GraphModifier // TypeDefIndex: 13178
{
	// Fields
	public static List<NodeLink> validNodeLinks; // 0x0
	public Vector3 midPosition; // 0x40
	public Transform end; // 0x50
	public float costFactor; // 0x58
	public bool oneWay; // 0x5C
	public bool deleteConnection; // 0x5D

	// Properties
	public Transform Start { get; }
	public Vector2 Start2D { get; }
	public Transform End { get; }
	public Vector2 End2D { get; }

	// Methods

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0
	public Transform get_Start() { }

	// RVA: 0x6CA140 Offset: 0x6C8B40 VA: 0x1806CA140
	public Vector2 get_Start2D() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public Transform get_End() { }

	// RVA: 0xB25560 Offset: 0xB23F60 VA: 0x180B25560
	public Vector2 get_End2D() { }

	// RVA: 0xB24910 Offset: 0xB23310 VA: 0x180B24910 Slot: 7
	protected override void Awake() { }

	// RVA: 0xB252A0 Offset: 0xB23CA0 VA: 0x180B252A0 Slot: 13
	public override void OnPostScan() { }

	// RVA: 0xB1DDB0 Offset: 0xB1C7B0 VA: 0x180B1DDB0
	public void InternalOnPostScan() { }

	// RVA: 0xB25130 Offset: 0xB23B30 VA: 0x180B25130 Slot: 18
	public override void OnGraphsPostUpdate() { }

	// RVA: 0xB244E0 Offset: 0xB22EE0 VA: 0x180B244E0 Slot: 19
	public virtual void Apply() { }

	// RVA: 0xB24C90 Offset: 0xB23690 VA: 0x180B24C90
	public Vector3 GetClosestPoint(Vector3 point) { }

	// RVA: 0xB24B10 Offset: 0xB23510 VA: 0x180B24B10
	public static List<NodeLink> GetClosestLinks(Vector3 point) { }

	// RVA: 0xB24F90 Offset: 0xB23990 VA: 0x180B24F90
	public void OnDrawGizmos() { }

	// RVA: 0xB254D0 Offset: 0xB23ED0 VA: 0x180B254D0
	public void .ctor() { }

	// RVA: 0xB25440 Offset: 0xB23E40 VA: 0x180B25440
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0xB25420 Offset: 0xB23E20 VA: 0x180B25420
	private bool <OnPostScan>b__15_0(bool force) { }

	[CompilerGenerated]
	// RVA: 0xB25420 Offset: 0xB23E20 VA: 0x180B25420
	private bool <OnGraphsPostUpdate>b__17_0(bool force) { }
}
