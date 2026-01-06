public enum ZipProgressEventType // TypeDefIndex: 16580
{
	// Fields
	public int value__; // 0x0
	public const ZipProgressEventType Adding_Started = 0;
	public const ZipProgressEventType Adding_AfterAddEntry = 1;
	public const ZipProgressEventType Adding_Completed = 2;
	public const ZipProgressEventType Reading_Started = 3;
	public const ZipProgressEventType Reading_BeforeReadEntry = 4;
	public const ZipProgressEventType Reading_AfterReadEntry = 5;
	public const ZipProgressEventType Reading_Completed = 6;
	public const ZipProgressEventType Reading_ArchiveBytesRead = 7;
	public const ZipProgressEventType Saving_Started = 8;
	public const ZipProgressEventType Saving_BeforeWriteEntry = 9;
	public const ZipProgressEventType Saving_AfterWriteEntry = 10;
	public const ZipProgressEventType Saving_Completed = 11;
	public const ZipProgressEventType Saving_AfterSaveTempArchive = 12;
	public const ZipProgressEventType Saving_BeforeRenameTempArchive = 13;
	public const ZipProgressEventType Saving_AfterRenameTempArchive = 14;
	public const ZipProgressEventType Saving_AfterCompileSelfExtractor = 15;
	public const ZipProgressEventType Saving_EntryBytesRead = 16;
	public const ZipProgressEventType Extracting_BeforeExtractEntry = 17;
	public const ZipProgressEventType Extracting_AfterExtractEntry = 18;
	public const ZipProgressEventType Extracting_ExtractEntryWouldOverwrite = 19;
	public const ZipProgressEventType Extracting_EntryBytesWritten = 20;
	public const ZipProgressEventType Extracting_BeforeExtractAll = 21;
	public const ZipProgressEventType Extracting_AfterExtractAll = 22;
	public const ZipProgressEventType Error_Saving = 23;
}
