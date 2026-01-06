internal class DiskCache : IDiskCache // TypeDefIndex: 17946
{
	// Fields
	internal const string k_FileHeaderString = "UGSEventCache";
	internal const int k_CacheFileVersionOne = 1;
	internal const int k_CacheFileVersionTwo = 2;
	private readonly string k_CacheFilePath; // 0x10
	private readonly IFileSystemCalls k_SystemCalls; // 0x18
	private readonly long k_CacheFileMaximumSize; // 0x20

	// Methods

	// RVA: 0x2B8FD60 Offset: 0x2B8E760 VA: 0x182B8FD60
	internal void .ctor(IFileSystemCalls systemCalls) { }

	// RVA: 0x25639B0 Offset: 0x25623B0 VA: 0x1825639B0
	internal void .ctor(string cacheFilePath, IFileSystemCalls systemCalls, long maximumFileSize) { }

	// RVA: 0x2B8F8E0 Offset: 0x2B8E2E0 VA: 0x182B8F8E0 Slot: 5
	public void Write(List<EventSummary> eventSummaries, Stream payload) { }

	// RVA: 0x2B8EF90 Offset: 0x2B8D990 VA: 0x182B8EF90 Slot: 4
	public void Clear() { }

	// RVA: 0x2B8F4D0 Offset: 0x2B8DED0 VA: 0x182B8F4D0 Slot: 6
	public bool Read(List<EventSummary> eventSummaries, Stream buffer) { }

	// RVA: 0x2B8F030 Offset: 0x2B8DA30 VA: 0x182B8F030
	private void ReadVersionOneCacheFile(in List<EventSummary> eventEndIndices, BinaryReader reader, in Stream buffer) { }

	// RVA: 0x2B8F270 Offset: 0x2B8DC70 VA: 0x182B8F270
	private void ReadVersionTwoCacheFile(in List<EventSummary> eventSummaries, BinaryReader reader, in Stream buffer) { }
}
