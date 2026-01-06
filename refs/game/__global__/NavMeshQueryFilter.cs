public struct NavMeshQueryFilter // TypeDefIndex: 18869
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private float[] <costs>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <areaMask>k__BackingField; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <agentTypeID>k__BackingField; // 0xC

	// Properties
	internal float[] costs { get; }
	public int areaMask { get; set; }
	public int agentTypeID { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	internal float[] get_costs() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	public int get_areaMask() { }

	[CompilerGenerated]
	// RVA: 0x4975E0 Offset: 0x495FE0 VA: 0x1804975E0
	public void set_areaMask(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4975D0 Offset: 0x495FD0 VA: 0x1804975D0
	public int get_agentTypeID() { }

	[CompilerGenerated]
	// RVA: 0x4975F0 Offset: 0x495FF0 VA: 0x1804975F0
	public void set_agentTypeID(int value) { }
}
