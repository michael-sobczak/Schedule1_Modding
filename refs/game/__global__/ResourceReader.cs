public sealed class ResourceReader : IResourceReader, IEnumerable, IDisposable // TypeDefIndex: 4669
{
	// Fields
	private BinaryReader _store; // 0x10
	internal Dictionary<string, ResourceLocator> _resCache; // 0x18
	private long _nameSectionOffset; // 0x20
	private long _dataSectionOffset; // 0x28
	private int[] _nameHashes; // 0x30
	private int* _nameHashesPtr; // 0x38
	private int[] _namePositions; // 0x40
	private int* _namePositionsPtr; // 0x48
	private RuntimeType[] _typeTable; // 0x50
	private int[] _typeNamePositions; // 0x58
	private BinaryFormatter _objFormatter; // 0x60
	private int _numResources; // 0x68
	private UnmanagedMemoryStream _ums; // 0x70
	private int _version; // 0x78

	// Methods

	// RVA: 0x1B72B50 Offset: 0x1B71550 VA: 0x181B72B50
	internal void .ctor(Stream stream, Dictionary<string, ResourceLocator> resCache) { }

	// RVA: 0x1B6EDE0 Offset: 0x1B6D7E0 VA: 0x181B6EDE0 Slot: 4
	public void Close() { }

	// RVA: 0x1B6F530 Offset: 0x1B6DF30 VA: 0x181B6F530 Slot: 7
	public void Dispose() { }

	// RVA: 0x1B6F470 Offset: 0x1B6DE70 VA: 0x181B6F470
	private void Dispose(bool disposing) { }

	// RVA: 0x1B70A70 Offset: 0x1B6F470 VA: 0x181B70A70
	internal static int ReadUnalignedI4(int* p) { }

	// RVA: 0x1B70A90 Offset: 0x1B6F490 VA: 0x181B70A90
	private void SkipString() { }

	// RVA: 0x1B6FEC0 Offset: 0x1B6E8C0 VA: 0x181B6FEC0
	private int GetNameHash(int index) { }

	// RVA: 0x1B6FF30 Offset: 0x1B6E930 VA: 0x181B6FF30
	private int GetNamePosition(int index) { }

	// RVA: 0x1B6FE00 Offset: 0x1B6E800 VA: 0x181B6FE00 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1B6FE00 Offset: 0x1B6E800 VA: 0x181B6FE00 Slot: 5
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1B6FDA0 Offset: 0x1B6E7A0 VA: 0x181B6FDA0
	internal ResourceReader.ResourceEnumerator GetEnumeratorInternal() { }

	// RVA: 0x1B6F540 Offset: 0x1B6DF40 VA: 0x181B6F540
	internal int FindPosForResource(string name) { }

	// RVA: 0x1B6EEA0 Offset: 0x1B6D8A0 VA: 0x181B6EEA0
	private bool CompareStringEqualsName(string name) { }

	// RVA: 0x1B6E670 Offset: 0x1B6D070 VA: 0x181B6E670
	private string AllocateStringForNameIndex(int index, out int dataOffset) { }

	// RVA: 0x1B70070 Offset: 0x1B6EA70 VA: 0x181B70070
	private object GetValueForNameIndex(int index) { }

	// RVA: 0x1B705E0 Offset: 0x1B6EFE0 VA: 0x181B705E0
	internal string LoadString(int pos) { }

	// RVA: 0x1B70510 Offset: 0x1B6EF10 VA: 0x181B70510
	internal object LoadObject(int pos) { }

	// RVA: 0x1B70540 Offset: 0x1B6EF40 VA: 0x181B70540
	internal object LoadObject(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x1B70310 Offset: 0x1B6ED10 VA: 0x181B70310
	internal object LoadObjectV1(int pos) { }

	// RVA: 0x1B70B60 Offset: 0x1B6F560 VA: 0x181B70B60
	private object _LoadObjectV1(int pos) { }

	// RVA: 0x1B70410 Offset: 0x1B6EE10 VA: 0x181B70410
	internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x1B71460 Offset: 0x1B6FE60 VA: 0x181B71460
	private object _LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x1B6F290 Offset: 0x1B6DC90 VA: 0x181B6F290
	private object DeserializeObject(int typeIndex) { }

	// RVA: 0x1B708F0 Offset: 0x1B6F2F0 VA: 0x181B708F0
	private void ReadResources() { }

	// RVA: 0x1B72070 Offset: 0x1B70A70 VA: 0x181B72070
	private void _ReadResources() { }

	// RVA: 0x1B6FA10 Offset: 0x1B6E410 VA: 0x181B6FA10
	private RuntimeType FindType(int typeIndex) { }
}
