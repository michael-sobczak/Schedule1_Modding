internal class PathPatternIterator // TypeDefIndex: 10357
{
	// Fields
	private float[] pattern; // 0x10
	private int currentSegment; // 0x18
	private bool solid; // 0x1C
	private float segmentLength; // 0x20
	private float patternLength; // 0x24
	private float patternOffset; // 0x28

	// Properties
	public float SegmentLength { get; }
	public bool IsSolid { get; }

	// Methods

	// RVA: 0x497460 Offset: 0x495E60 VA: 0x180497460
	public void .ctor(float[] pattern, float patternOffset = 0) { }

	// RVA: 0x497270 Offset: 0x495C70 VA: 0x180497270
	public void Advance() { }

	// RVA: 0x4972D0 Offset: 0x495CD0 VA: 0x1804972D0
	public bool IsSolidAt(float unitsFromPathStart) { }

	// RVA: 0x497300 Offset: 0x495D00 VA: 0x180497300
	public bool IsSolidAt(float unitsFromPathStart, out int patternSegmentIndex, out float patternSegmentLength) { }

	// RVA: 0x4975C0 Offset: 0x495FC0 VA: 0x1804975C0
	public float get_SegmentLength() { }

	// RVA: 0x4975B0 Offset: 0x495FB0 VA: 0x1804975B0
	public bool get_IsSolid() { }
}
