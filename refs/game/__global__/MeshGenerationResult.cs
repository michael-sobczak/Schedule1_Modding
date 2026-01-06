public struct MeshGenerationResult : IEquatable<MeshGenerationResult> // TypeDefIndex: 18925
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly MeshId <MeshId>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Mesh <Mesh>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly MeshCollider <MeshCollider>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly MeshGenerationStatus <Status>k__BackingField; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly MeshVertexAttributes <Attributes>k__BackingField; // 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ulong <Timestamp>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Vector3 <Position>k__BackingField; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Quaternion <Rotation>k__BackingField; // 0x3C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Vector3 <Scale>k__BackingField; // 0x4C

	// Properties
	public MeshId MeshId { get; }
	public Mesh Mesh { get; }
	public MeshCollider MeshCollider { get; }
	public MeshGenerationStatus Status { get; }
	public MeshVertexAttributes Attributes { get; }
	public Vector3 Position { get; }
	public Quaternion Rotation { get; }
	public Vector3 Scale { get; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4944C0 Offset: 0x492EC0 VA: 0x1804944C0
	public MeshId get_MeshId() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Mesh get_Mesh() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public MeshCollider get_MeshCollider() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public MeshGenerationStatus get_Status() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public MeshVertexAttributes get_Attributes() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4D6350 Offset: 0x4D4D50 VA: 0x1804D6350
	public Vector3 get_Position() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x2D9F950 Offset: 0x2D9E350 VA: 0x182D9F950
	public Quaternion get_Rotation() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4D6260 Offset: 0x4D4C60 VA: 0x1804D6260
	public Vector3 get_Scale() { }

	// RVA: 0x2F601D0 Offset: 0x2F5EBD0 VA: 0x182F601D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F602B0 Offset: 0x2F5ECB0 VA: 0x182F602B0 Slot: 4
	public bool Equals(MeshGenerationResult other) { }

	// RVA: 0x2F604C0 Offset: 0x2F5EEC0 VA: 0x182F604C0 Slot: 2
	public override int GetHashCode() { }
}
