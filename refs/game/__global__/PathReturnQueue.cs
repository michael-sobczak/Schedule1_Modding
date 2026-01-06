internal class PathReturnQueue // TypeDefIndex: 13187
{
	// Fields
	private Queue<Path> pathReturnQueue; // 0x10
	private object pathsClaimedSilentlyBy; // 0x18

	// Methods

	// RVA: 0xB28470 Offset: 0xB26E70 VA: 0x180B28470
	public void .ctor(object pathsClaimedSilentlyBy) { }

	// RVA: 0xB28000 Offset: 0xB26A00 VA: 0x180B28000
	public void Enqueue(Path path) { }

	// RVA: 0xB280D0 Offset: 0xB26AD0 VA: 0x180B280D0
	public void ReturnPaths(bool timeSlice) { }
}
