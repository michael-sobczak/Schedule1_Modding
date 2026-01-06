internal enum LeakCategory // TypeDefIndex: 11528
{
	// Fields
	public int value__; // 0x0
	public const LeakCategory Invalid = 0;
	public const LeakCategory Malloc = 1;
	public const LeakCategory TempJob = 2;
	public const LeakCategory Persistent = 3;
	public const LeakCategory LightProbesQuery = 4;
	public const LeakCategory NativeTest = 5;
	public const LeakCategory MeshDataArray = 6;
	public const LeakCategory TransformAccessArray = 7;
	public const LeakCategory NavMeshQuery = 8;
}
