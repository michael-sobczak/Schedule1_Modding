public class RichPath // TypeDefIndex: 13104
{
	// Fields
	private int currentPart; // 0x10
	private readonly List<RichPathPart> parts; // 0x18
	public Seeker seeker; // 0x20
	public ITransform transform; // 0x28
	[CompilerGenerated]
	private Vector3 <Endpoint>k__BackingField; // 0x30

	// Properties
	public Vector3 Endpoint { get; set; }
	public bool CompletedAllParts { get; }
	public bool IsLastPart { get; }

	// Methods

	// RVA: 0xAFE3C0 Offset: 0xAFCDC0 VA: 0x180AFE3C0
	public void .ctor() { }

	// RVA: 0xAFD600 Offset: 0xAFC000 VA: 0x180AFD600
	public void Clear() { }

	// RVA: 0xAFD960 Offset: 0xAFC360 VA: 0x180AFD960
	public void Initialize(Seeker seeker, Path path, bool mergePartEndpoints, bool simplificationMode) { }

	[CompilerGenerated]
	// RVA: 0x4D6350 Offset: 0x4D4D50 VA: 0x1804D6350
	public Vector3 get_Endpoint() { }

	[CompilerGenerated]
	// RVA: 0x4D6610 Offset: 0x4D5010 VA: 0x1804D6610
	private void set_Endpoint(Vector3 value) { }

	// RVA: 0xAFE450 Offset: 0xAFCE50 VA: 0x180AFE450
	public bool get_CompletedAllParts() { }

	// RVA: 0xAFE4A0 Offset: 0xAFCEA0 VA: 0x180AFE4A0
	public bool get_IsLastPart() { }

	// RVA: 0xAFE370 Offset: 0xAFCD70 VA: 0x180AFE370
	public void NextPart() { }

	// RVA: 0xAFD680 Offset: 0xAFC080 VA: 0x180AFD680
	public RichPathPart GetCurrentPart() { }

	// RVA: 0xAFD710 Offset: 0xAFC110 VA: 0x180AFD710
	public void GetRemainingPath(List<Vector3> buffer, Vector3 currentPosition, out bool requiresRepath) { }
}
