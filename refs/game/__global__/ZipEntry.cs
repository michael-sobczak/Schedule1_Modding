public class ZipEntry // TypeDefIndex: 16616
{
	// Fields
	private short _VersionMadeBy; // 0x10
	private short _InternalFileAttrs; // 0x12
	private int _ExternalFileAttrs; // 0x14
	private short _filenameLength; // 0x18
	private short _extraFieldLength; // 0x1A
	private short _commentLength; // 0x1C
	private Stream _inputDecryptorStream; // 0x20
	private int _readExtraDepth; // 0x28
	private object _outputLock; // 0x30
	private ZipCrypto _zipCrypto_forExtract; // 0x38
	private ZipCrypto _zipCrypto_forWrite; // 0x40
	internal DateTime _LastModified; // 0x48
	private DateTime _Mtime; // 0x50
	private DateTime _Atime; // 0x58
	private DateTime _Ctime; // 0x60
	private bool _ntfsTimesAreSet; // 0x68
	private bool _emitNtfsTimes; // 0x69
	private bool _emitUnixTimes; // 0x6A
	private bool _TrimVolumeFromFullyQualifiedPaths; // 0x6B
	internal string _LocalFileName; // 0x70
	private string _FileNameInArchive; // 0x78
	internal short _VersionNeeded; // 0x80
	internal short _BitField; // 0x82
	internal short _CompressionMethod; // 0x84
	private short _CompressionMethod_FromZipFile; // 0x86
	private CompressionLevel _CompressionLevel; // 0x88
	internal string _Comment; // 0x90
	private bool _IsDirectory; // 0x98
	private byte[] _CommentBytes; // 0xA0
	internal long _CompressedSize; // 0xA8
	internal long _CompressedFileDataSize; // 0xB0
	internal long _UncompressedSize; // 0xB8
	internal int _TimeBlob; // 0xC0
	private bool _crcCalculated; // 0xC4
	internal int _Crc32; // 0xC8
	internal byte[] _Extra; // 0xD0
	private bool _metadataChanged; // 0xD8
	private bool _restreamRequiredOnSave; // 0xD9
	private bool _sourceIsEncrypted; // 0xDA
	private bool _skippedDuringSave; // 0xDB
	private uint _diskNumber; // 0xDC
	private static Encoding ibm437; // 0x0
	private Encoding _actualEncoding; // 0xE0
	internal ZipContainer _container; // 0xE8
	private long __FileDataPosition; // 0xF0
	private byte[] _EntryHeader; // 0xF8
	internal long _RelativeOffsetOfLocalHeader; // 0x100
	private long _future_ROLH; // 0x108
	private long _TotalEntrySize; // 0x110
	private int _LengthOfHeader; // 0x118
	private int _LengthOfTrailer; // 0x11C
	internal bool _InputUsesZip64; // 0x120
	private uint _UnsupportedAlgorithmId; // 0x124
	internal string _Password; // 0x128
	internal ZipEntrySource _Source; // 0x130
	internal EncryptionAlgorithm _Encryption; // 0x134
	internal EncryptionAlgorithm _Encryption_FromZipFile; // 0x138
	internal byte[] _WeakEncryptionHeader; // 0x140
	internal Stream _archiveStream; // 0x148
	private Stream _sourceStream; // 0x150
	private Nullable<long> _sourceStreamOriginalPosition; // 0x158
	private bool _sourceWasJitProvided; // 0x168
	private bool _ioOperationCanceled; // 0x169
	private bool _presumeZip64; // 0x16A
	private Nullable<bool> _entryRequiresZip64; // 0x16B
	private Nullable<bool> _OutputUsesZip64; // 0x16D
	private bool _IsText; // 0x16F
	private ZipEntryTimestamp _timestamp; // 0x170
	private static DateTime _unixEpoch; // 0x8
	private static DateTime _win32Epoch; // 0x10
	private static DateTime _zeroHour; // 0x18
	private WriteDelegate _WriteDelegate; // 0x178
	private OpenDelegate _OpenDelegate; // 0x180
	private CloseDelegate _CloseDelegate; // 0x188
	[CompilerGenerated]
	private ExtractExistingFileAction <ExtractExistingFile>k__BackingField; // 0x190
	[CompilerGenerated]
	private ZipErrorAction <ZipErrorAction>k__BackingField; // 0x194
	[CompilerGenerated]
	private SetCompressionCallback <SetCompression>k__BackingField; // 0x198
	[CompilerGenerated]
	private Encoding <ProvisionalAlternateEncoding>k__BackingField; // 0x1A0
	[CompilerGenerated]
	private Encoding <AlternateEncoding>k__BackingField; // 0x1A8
	[CompilerGenerated]
	private ZipOption <AlternateEncodingUsage>k__BackingField; // 0x1B0

	// Properties
	internal bool AttributesIndicateDirectory { get; }
	public string Info { get; }
	private string UnsupportedAlgorithm { get; }
	private string UnsupportedCompressionMethod { get; }
	public DateTime LastModified { get; set; }
	private int BufferSize { get; }
	public DateTime ModifiedTime { get; set; }
	public DateTime AccessedTime { get; set; }
	public DateTime CreationTime { get; set; }
	public bool EmitTimesInWindowsFormatWhenSaving { get; set; }
	public bool EmitTimesInUnixFormatWhenSaving { get; set; }
	public ZipEntryTimestamp Timestamp { get; }
	public FileAttributes Attributes { get; set; }
	internal string LocalFileName { get; }
	public string FileName { get; set; }
	public Stream InputStream { get; set; }
	public bool InputStreamWasJitProvided { get; }
	public ZipEntrySource Source { get; }
	public short VersionNeeded { get; }
	public string Comment { get; set; }
	public Nullable<bool> RequiresZip64 { get; }
	public Nullable<bool> OutputUsedZip64 { get; }
	public short BitField { get; }
	public CompressionMethod CompressionMethod { get; set; }
	public CompressionLevel CompressionLevel { get; set; }
	public long CompressedSize { get; }
	public long UncompressedSize { get; }
	public double CompressionRatio { get; }
	public int Crc { get; }
	public bool IsDirectory { get; }
	public bool UsesEncryption { get; }
	public EncryptionAlgorithm Encryption { get; set; }
	private string Password { get; set; }
	internal bool IsChanged { get; }
	public ExtractExistingFileAction ExtractExistingFile { get; set; }
	public ZipErrorAction ZipErrorAction { get; set; }
	public bool IncludedInMostRecentSave { get; }
	public SetCompressionCallback SetCompression { get; set; }
	[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete.  It will be removed in a future version of the library. Your applications should  use AlternateEncoding and AlternateEncodingUsage instead.")]
	public bool UseUnicodeAsNecessary { get; set; }
	[Obsolete("This property is obsolete since v1.9.1.6. Use AlternateEncoding and AlternateEncodingUsage instead.", True)]
	public Encoding ProvisionalAlternateEncoding { get; set; }
	public Encoding AlternateEncoding { get; set; }
	public ZipOption AlternateEncodingUsage { get; set; }
	public bool IsText { get; set; }
	internal Stream ArchiveStream { get; }
	internal long FileDataPosition { get; }
	private int LengthOfHeader { get; }

	// Methods

	// RVA: 0x1E43460 Offset: 0x1E41E60 VA: 0x181E43460
	public void .ctor() { }

	// RVA: 0x1E43330 Offset: 0x1E41D30 VA: 0x181E43330
	private static void .cctor() { }

	// RVA: 0x1E435D0 Offset: 0x1E41FD0 VA: 0x181E435D0
	internal bool get_AttributesIndicateDirectory() { }

	// RVA: 0x1E40010 Offset: 0x1E3EA10 VA: 0x181E40010
	internal void ResetDirEntry() { }

	// RVA: 0x1E436C0 Offset: 0x1E420C0 VA: 0x181E436C0
	public string get_Info() { }

	// RVA: 0x1E3E5B0 Offset: 0x1E3CFB0 VA: 0x181E3E5B0
	internal static ZipEntry ReadDirEntry(ZipFile zf, Dictionary<string, object> previouslySeen) { }

	// RVA: 0x1E3C2A0 Offset: 0x1E3ACA0 VA: 0x181E3C2A0
	internal static bool IsNotValidZipDirEntrySig(int signature) { }

	// RVA: 0x1E3A960 Offset: 0x1E39360 VA: 0x181E3A960
	public void Extract() { }

	// RVA: 0x1E3A9F0 Offset: 0x1E393F0 VA: 0x181E3A9F0
	public void Extract(ExtractExistingFileAction extractExistingFile) { }

	// RVA: 0x1E3A9D0 Offset: 0x1E393D0 VA: 0x181E3A9D0
	public void Extract(Stream stream) { }

	// RVA: 0x1E3A9B0 Offset: 0x1E393B0 VA: 0x181E3A9B0
	public void Extract(string baseDirectory) { }

	// RVA: 0x1E3A930 Offset: 0x1E39330 VA: 0x181E3A930
	public void Extract(string baseDirectory, ExtractExistingFileAction extractExistingFile) { }

	// RVA: 0x1E3A8D0 Offset: 0x1E392D0 VA: 0x181E3A8D0
	public void ExtractWithPassword(string password) { }

	// RVA: 0x1E3A800 Offset: 0x1E39200 VA: 0x181E3A800
	public void ExtractWithPassword(string baseDirectory, string password) { }

	// RVA: 0x1E3A840 Offset: 0x1E39240 VA: 0x181E3A840
	public void ExtractWithPassword(ExtractExistingFileAction extractExistingFile, string password) { }

	// RVA: 0x1E3A820 Offset: 0x1E39220 VA: 0x181E3A820
	public void ExtractWithPassword(string baseDirectory, ExtractExistingFileAction extractExistingFile, string password) { }

	// RVA: 0x1E3A8B0 Offset: 0x1E392B0 VA: 0x181E3A8B0
	public void ExtractWithPassword(Stream stream, string password) { }

	// RVA: 0x1E3CCF0 Offset: 0x1E3B6F0 VA: 0x181E3CCF0
	public CrcCalculatorStream OpenReader() { }

	// RVA: 0x1E3CD90 Offset: 0x1E3B790 VA: 0x181E3CD90
	public CrcCalculatorStream OpenReader(string password) { }

	// RVA: 0x1E3C100 Offset: 0x1E3AB00 VA: 0x181E3C100
	internal CrcCalculatorStream InternalOpenReader(string password) { }

	// RVA: 0x1E3CC10 Offset: 0x1E3B610 VA: 0x181E3CC10
	private void OnExtractProgress(long bytesWritten, long totalBytesToWrite) { }

	// RVA: 0x1E3CB70 Offset: 0x1E3B570 VA: 0x181E3CB70
	private void OnBeforeExtract(string path) { }

	// RVA: 0x1E3CB20 Offset: 0x1E3B520 VA: 0x181E3CB20
	private void OnAfterExtract(string path) { }

	// RVA: 0x1E3CBD0 Offset: 0x1E3B5D0 VA: 0x181E3CBD0
	private void OnExtractExisting(string path) { }

	// RVA: 0x1E40000 Offset: 0x1E3EA00 VA: 0x181E40000
	private static void ReallyDelete(string fileName) { }

	// RVA: 0x1E42690 Offset: 0x1E41090 VA: 0x181E42690
	private void WriteStatus(string format, object[] args) { }

	// RVA: 0x1E3B7B0 Offset: 0x1E3A1B0 VA: 0x181E3B7B0
	private void InternalExtract(string baseDir, Stream outstream, string password) { }

	// RVA: 0x1E41160 Offset: 0x1E3FB60 VA: 0x181E41160
	internal void VerifyCrcAfterExtract(int actualCrc32) { }

	// RVA: 0x1E388F0 Offset: 0x1E372F0 VA: 0x181E388F0
	private int CheckExtractExistingFile(string baseDir, string targetFileName) { }

	// RVA: 0x1E42DE0 Offset: 0x1E417E0 VA: 0x181E42DE0
	private void _CheckRead(int nbytes) { }

	// RVA: 0x1E3A4C0 Offset: 0x1E38EC0 VA: 0x181E3A4C0
	private int ExtractOne(Stream output) { }

	// RVA: 0x1E3B360 Offset: 0x1E39D60 VA: 0x181E3B360
	internal Stream GetExtractDecompressor(Stream input2) { }

	// RVA: 0x1E3B400 Offset: 0x1E39E00 VA: 0x181E3B400
	internal Stream GetExtractDecryptor(Stream input) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal void _SetTimes(string fileOrDirectory, bool isFile) { }

	// RVA: 0x1E43DF0 Offset: 0x1E427F0 VA: 0x181E43DF0
	private string get_UnsupportedAlgorithm() { }

	// RVA: 0x1E44010 Offset: 0x1E42A10 VA: 0x181E44010
	private string get_UnsupportedCompressionMethod() { }

	// RVA: 0x1E40D80 Offset: 0x1E3F780 VA: 0x181E40D80
	internal void ValidateEncryption() { }

	// RVA: 0x1E40CA0 Offset: 0x1E3F6A0 VA: 0x181E40CA0
	private void ValidateCompression() { }

	// RVA: 0x1E40A20 Offset: 0x1E3F420 VA: 0x181E40A20
	private void SetupCryptoForExtract(string password) { }

	// RVA: 0x1E40EC0 Offset: 0x1E3F8C0 VA: 0x181E40EC0
	private bool ValidateOutput(string basedir, Stream outstream, out string outFileName) { }

	// RVA: 0x1E3F2F0 Offset: 0x1E3DCF0 VA: 0x181E3F2F0
	private void ReadExtraField() { }

	// RVA: 0x1E3F4D0 Offset: 0x1E3DED0 VA: 0x181E3F4D0
	private static bool ReadHeader(ZipEntry ze, Encoding defaultEncoding) { }

	// RVA: 0x1E3FF20 Offset: 0x1E3E920 VA: 0x181E3FF20
	internal static int ReadWeakEncryptionHeader(Stream s, byte[] buffer) { }

	// RVA: 0x1E3C290 Offset: 0x1E3AC90 VA: 0x181E3C290
	private static bool IsNotValidSig(int signature) { }

	// RVA: 0x1E3F050 Offset: 0x1E3DA50 VA: 0x181E3F050
	internal static ZipEntry ReadEntry(ZipContainer zc, bool first) { }

	// RVA: 0x1E3B500 Offset: 0x1E39F00 VA: 0x181E3B500
	internal static void HandlePK00Prefix(Stream s) { }

	// RVA: 0x1E3B5D0 Offset: 0x1E39FD0 VA: 0x181E3B5D0
	private static void HandleUnexpectedDataDescriptor(ZipEntry entry) { }

	// RVA: 0x1E3AC50 Offset: 0x1E39650 VA: 0x181E3AC50
	internal static int FindExtraFieldSegment(byte[] extra, int offx, ushort targetHeaderId) { }

	// RVA: 0x1E3E320 Offset: 0x1E3CD20 VA: 0x181E3E320
	internal int ProcessExtraField(Stream s, short extraFieldLength) { }

	// RVA: 0x1E3DED0 Offset: 0x1E3C8D0 VA: 0x181E3DED0
	private int ProcessExtraFieldPkwareStrongEncryption(byte[] Buffer, int j) { }

	// RVA: 0x1E3E240 Offset: 0x1E3CC40 VA: 0x181E3E240
	private int ProcessExtraFieldZip64(byte[] buffer, int j, short dataSize, long posn) { }

	// RVA: 0x1E3DD10 Offset: 0x1E3C710 VA: 0x181E3DD10
	private int ProcessExtraFieldInfoZipTimes(byte[] buffer, int j, short dataSize, long posn) { }

	// RVA: 0x1E3DF40 Offset: 0x1E3C940 VA: 0x181E3DF40
	private int ProcessExtraFieldUnixTimes(byte[] buffer, int j, short dataSize, long posn) { }

	// RVA: 0x1E3E020 Offset: 0x1E3CA20 VA: 0x181E3E020
	private int ProcessExtraFieldWindowsTimes(byte[] buffer, int j, short dataSize, long posn) { }

	// RVA: 0x1E412E0 Offset: 0x1E3FCE0 VA: 0x181E412E0
	internal void WriteCentralDirectoryEntry(Stream s) { }

	// RVA: 0x1E38BE0 Offset: 0x1E375E0 VA: 0x181E38BE0
	private byte[] ConstructExtraField(bool forCentralDirectory) { }

	// RVA: 0x1E3C920 Offset: 0x1E3B320 VA: 0x181E3C920
	private string NormalizeFileName() { }

	// RVA: 0x1E3AEA0 Offset: 0x1E398A0 VA: 0x181E3AEA0
	private byte[] GetEncodedFileNameBytes() { }

	// RVA: 0x1E41240 Offset: 0x1E3FC40 VA: 0x181E41240
	private bool WantReadAgain() { }

	// RVA: 0x1E3C6C0 Offset: 0x1E3B0C0 VA: 0x181E3C6C0
	private void MaybeUnsetCompressionMethodForWriting(int cycle) { }

	// RVA: 0x1E41A50 Offset: 0x1E40450 VA: 0x181E41A50
	internal void WriteHeader(Stream s, int cycle) { }

	// RVA: 0x1E3AA50 Offset: 0x1E39450 VA: 0x181E3AA50
	private int FigureCrc32() { }

	// RVA: 0x1E3DB10 Offset: 0x1E3C510 VA: 0x181E3DB10
	private void PrepSourceStream() { }

	// RVA: 0x1E393A0 Offset: 0x1E37DA0 VA: 0x181E393A0
	internal void CopyMetaData(ZipEntry source) { }

	// RVA: 0x1E3CC60 Offset: 0x1E3B660 VA: 0x181E3CC60
	private void OnWriteBlock(long bytesXferred, long totalBytesToXfer) { }

	// RVA: 0x1E42E70 Offset: 0x1E41870 VA: 0x181E42E70
	private void _WriteEntryData(Stream s) { }

	// RVA: 0x1E406A0 Offset: 0x1E3F0A0 VA: 0x181E406A0
	private long SetInputAndFigureFileLength(ref Stream input) { }

	// RVA: 0x1E3AD20 Offset: 0x1E39720 VA: 0x181E3AD20
	internal void FinishOutputStream(Stream s, CountingStream entryCounter, Stream encryptor, Stream compressor, CrcCalculatorStream output) { }

	// RVA: 0x1E3CE10 Offset: 0x1E3B810 VA: 0x181E3CE10
	internal void PostProcessOutput(Stream s) { }

	// RVA: 0x1E408B0 Offset: 0x1E3F2B0 VA: 0x181E408B0
	private void SetZip64Flags() { }

	// RVA: 0x1E3D9E0 Offset: 0x1E3C3E0 VA: 0x181E3D9E0
	internal void PrepOutputStream(Stream s, long streamLength, out CountingStream outputCounter, out Stream encryptor, out Stream compressor, out CrcCalculatorStream output) { }

	// RVA: 0x1E3C330 Offset: 0x1E3AD30 VA: 0x181E3C330
	private Stream MaybeApplyCompression(Stream s, long streamLength) { }

	// RVA: 0x1E3C630 Offset: 0x1E3B030 VA: 0x181E3C630
	private Stream MaybeApplyEncryption(Stream s) { }

	// RVA: 0x1E3CCB0 Offset: 0x1E3B6B0 VA: 0x181E3CCB0
	private void OnZipErrorWhileSaving(Exception e) { }

	// RVA: 0x1E42720 Offset: 0x1E41120 VA: 0x181E42720
	internal void Write(Stream s) { }

	// RVA: 0x1E40B20 Offset: 0x1E3F520 VA: 0x181E40B20
	internal void StoreRelativeOffset() { }

	// RVA: 0x1E3CAF0 Offset: 0x1E3B4F0 VA: 0x181E3CAF0
	internal void NotifySaveComplete() { }

	// RVA: 0x1E423E0 Offset: 0x1E40DE0 VA: 0x181E423E0
	internal void WriteSecurityMetadata(Stream outstream) { }

	// RVA: 0x1E39460 Offset: 0x1E37E60 VA: 0x181E39460
	private void CopyThroughOneEntry(Stream outStream) { }

	// RVA: 0x1E39890 Offset: 0x1E38290 VA: 0x181E39890
	private void CopyThroughWithRecompute(Stream outstream) { }

	// RVA: 0x1E396B0 Offset: 0x1E380B0 VA: 0x181E396B0
	private void CopyThroughWithNoChange(Stream outstream) { }

	[Conditional("Trace")]
	// RVA: 0x1E40B70 Offset: 0x1E3F570 VA: 0x181E40B70
	private void TraceWriteLine(string format, object[] varParams) { }

	// RVA: 0x1E43D30 Offset: 0x1E42730 VA: 0x181E43D30
	public DateTime get_LastModified() { }

	// RVA: 0x1E44780 Offset: 0x1E43180 VA: 0x181E44780
	public void set_LastModified(DateTime value) { }

	// RVA: 0x1E435F0 Offset: 0x1E41FF0 VA: 0x181E435F0
	private int get_BufferSize() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public DateTime get_ModifiedTime() { }

	// RVA: 0x1E448A0 Offset: 0x1E432A0 VA: 0x181E448A0
	public void set_ModifiedTime(DateTime value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public DateTime get_AccessedTime() { }

	// RVA: 0x1E44230 Offset: 0x1E42C30 VA: 0x181E44230
	public void set_AccessedTime(DateTime value) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public DateTime get_CreationTime() { }

	// RVA: 0x1E44410 Offset: 0x1E42E10 VA: 0x181E44410
	public void set_CreationTime(DateTime value) { }

	// RVA: 0x1E40030 Offset: 0x1E3EA30 VA: 0x181E40030
	public void SetEntryTimes(DateTime created, DateTime accessed, DateTime modified) { }

	// RVA: 0xCE3D90 Offset: 0xCE2790 VA: 0x180CE3D90
	public bool get_EmitTimesInWindowsFormatWhenSaving() { }

	// RVA: 0x1E44440 Offset: 0x1E42E40 VA: 0x181E44440
	public void set_EmitTimesInWindowsFormatWhenSaving(bool value) { }

	// RVA: 0xCE3DD0 Offset: 0xCE27D0 VA: 0x180CE3DD0
	public bool get_EmitTimesInUnixFormatWhenSaving() { }

	// RVA: 0x1E44430 Offset: 0x1E42E30 VA: 0x181E44430
	public void set_EmitTimesInUnixFormatWhenSaving(bool value) { }

	// RVA: 0x74C8E0 Offset: 0x74B2E0 VA: 0x18074C8E0
	public ZipEntryTimestamp get_Timestamp() { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public FileAttributes get_Attributes() { }

	// RVA: 0x1E44270 Offset: 0x1E42C70 VA: 0x181E44270
	public void set_Attributes(FileAttributes value) { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	internal string get_LocalFileName() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public string get_FileName() { }

	// RVA: 0x1E44500 Offset: 0x1E42F00 VA: 0x181E44500
	public void set_FileName(string value) { }

	// RVA: 0x618010 Offset: 0x616A10 VA: 0x180618010
	public Stream get_InputStream() { }

	// RVA: 0x1E446F0 Offset: 0x1E430F0 VA: 0x181E446F0
	public void set_InputStream(Stream value) { }

	// RVA: 0x617FF0 Offset: 0x6169F0 VA: 0x180617FF0
	public bool get_InputStreamWasJitProvided() { }

	// RVA: 0x523410 Offset: 0x521E10 VA: 0x180523410
	public ZipEntrySource get_Source() { }

	// RVA: 0x1D32B50 Offset: 0x1D31550 VA: 0x181D32B50
	public short get_VersionNeeded() { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public string get_Comment() { }

	// RVA: 0x1E44290 Offset: 0x1E42C90 VA: 0x181E44290
	public void set_Comment(string value) { }

	// RVA: 0x1E43DD0 Offset: 0x1E427D0 VA: 0x181E43DD0
	public Nullable<bool> get_RequiresZip64() { }

	// RVA: 0x1E43DC0 Offset: 0x1E427C0 VA: 0x181E43DC0
	public Nullable<bool> get_OutputUsedZip64() { }

	// RVA: 0x1DA37A0 Offset: 0x1DA21A0 VA: 0x181DA37A0
	public short get_BitField() { }

	// RVA: 0x1E43620 Offset: 0x1E42020 VA: 0x181E43620
	public CompressionMethod get_CompressionMethod() { }

	// RVA: 0x1E44340 Offset: 0x1E42D40 VA: 0x181E44340
	public void set_CompressionMethod(CompressionMethod value) { }

	// RVA: 0x1063C60 Offset: 0x1062660 VA: 0x181063C60
	public CompressionLevel get_CompressionLevel() { }

	// RVA: 0x1E442C0 Offset: 0x1E42CC0 VA: 0x181E442C0
	public void set_CompressionLevel(CompressionLevel value) { }

	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	public long get_CompressedSize() { }

	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160
	public long get_UncompressedSize() { }

	// RVA: 0x1E43630 Offset: 0x1E42030 VA: 0x181E43630
	public double get_CompressionRatio() { }

	// RVA: 0x4F2350 Offset: 0x4F0D50 VA: 0x1804F2350
	public int get_Crc() { }

	// RVA: 0x614460 Offset: 0x612E60 VA: 0x180614460
	public bool get_IsDirectory() { }

	// RVA: 0x1E44210 Offset: 0x1E42C10 VA: 0x181E44210
	public bool get_UsesEncryption() { }

	// RVA: 0x512ED0 Offset: 0x5118D0 VA: 0x180512ED0
	public EncryptionAlgorithm get_Encryption() { }

	// RVA: 0x1E44450 Offset: 0x1E42E50 VA: 0x181E44450
	public void set_Encryption(EncryptionAlgorithm value) { }

	// RVA: 0x1E448D0 Offset: 0x1E432D0 VA: 0x181E448D0
	public void set_Password(string value) { }

	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	private string get_Password() { }

	// RVA: 0x1E43D00 Offset: 0x1E42700 VA: 0x181E43D00
	internal bool get_IsChanged() { }

	[CompilerGenerated]
	// RVA: 0xB3D920 Offset: 0xB3C320 VA: 0x180B3D920
	public ExtractExistingFileAction get_ExtractExistingFile() { }

	[CompilerGenerated]
	// RVA: 0x1E444F0 Offset: 0x1E42EF0 VA: 0x181E444F0
	public void set_ExtractExistingFile(ExtractExistingFileAction value) { }

	[CompilerGenerated]
	// RVA: 0x1E44220 Offset: 0x1E42C20 VA: 0x181E44220
	public ZipErrorAction get_ZipErrorAction() { }

	[CompilerGenerated]
	// RVA: 0x1E44A40 Offset: 0x1E43440 VA: 0x181E44A40
	public void set_ZipErrorAction(ZipErrorAction value) { }

	// RVA: 0x1E436B0 Offset: 0x1E420B0 VA: 0x181E436B0
	public bool get_IncludedInMostRecentSave() { }

	[CompilerGenerated]
	// RVA: 0x1E43DE0 Offset: 0x1E427E0 VA: 0x181E43DE0
	public SetCompressionCallback get_SetCompression() { }

	[CompilerGenerated]
	// RVA: 0x1E44940 Offset: 0x1E43340 VA: 0x181E44940
	public void set_SetCompression(SetCompressionCallback value) { }

	// RVA: 0x1E441A0 Offset: 0x1E42BA0 VA: 0x181E441A0
	public bool get_UseUnicodeAsNecessary() { }

	// RVA: 0x1E44960 Offset: 0x1E43360 VA: 0x181E44960
	public void set_UseUnicodeAsNecessary(bool value) { }

	[CompilerGenerated]
	// RVA: 0x74CCB0 Offset: 0x74B6B0 VA: 0x18074CCB0
	public Encoding get_ProvisionalAlternateEncoding() { }

	[CompilerGenerated]
	// RVA: 0x76A800 Offset: 0x769200 VA: 0x18076A800
	public void set_ProvisionalAlternateEncoding(Encoding value) { }

	[CompilerGenerated]
	// RVA: 0x76A7D0 Offset: 0x7691D0 VA: 0x18076A7D0
	public Encoding get_AlternateEncoding() { }

	[CompilerGenerated]
	// RVA: 0x76A7E0 Offset: 0x7691E0 VA: 0x18076A7E0
	public void set_AlternateEncoding(Encoding value) { }

	[CompilerGenerated]
	// RVA: 0x1E43520 Offset: 0x1E41F20 VA: 0x181E43520
	public ZipOption get_AlternateEncodingUsage() { }

	[CompilerGenerated]
	// RVA: 0x1E44260 Offset: 0x1E42C60 VA: 0x181E44260
	public void set_AlternateEncodingUsage(ZipOption value) { }

	// RVA: 0x1E3C860 Offset: 0x1E3B260 VA: 0x181E3C860
	internal static string NameInArchive(string filename, string directoryPathInArchive) { }

	// RVA: 0x1E39FB0 Offset: 0x1E389B0 VA: 0x181E39FB0
	internal static ZipEntry CreateFromNothing(string nameInArchive) { }

	// RVA: 0x1E39F40 Offset: 0x1E38940 VA: 0x181E39F40
	internal static ZipEntry CreateFromFile(string filename, string nameInArchive) { }

	// RVA: 0x1E39E00 Offset: 0x1E38800 VA: 0x181E39E00
	internal static ZipEntry CreateForStream(string entryName, Stream s) { }

	// RVA: 0x1E39E70 Offset: 0x1E38870 VA: 0x181E39E70
	internal static ZipEntry CreateForWriter(string entryName, WriteDelegate d) { }

	// RVA: 0x1E39D80 Offset: 0x1E38780 VA: 0x181E39D80
	internal static ZipEntry CreateForJitStreamProvider(string nameInArchive, OpenDelegate opener, CloseDelegate closer) { }

	// RVA: 0x1E39EE0 Offset: 0x1E388E0 VA: 0x181E39EE0
	internal static ZipEntry CreateForZipOutputStream(string nameInArchive) { }

	// RVA: 0x1E3A010 Offset: 0x1E38A10 VA: 0x181E3A010
	private static ZipEntry Create(string nameInArchive, ZipEntrySource source, object arg1, object arg2) { }

	// RVA: 0x1E3C2B0 Offset: 0x1E3ACB0 VA: 0x181E3C2B0
	internal void MarkAsDirectory() { }

	// RVA: 0x1E43D20 Offset: 0x1E42720 VA: 0x181E43D20
	public bool get_IsText() { }

	// RVA: 0x1E44770 Offset: 0x1E43170 VA: 0x181E44770
	public void set_IsText(bool value) { }

	// RVA: 0x1E40B30 Offset: 0x1E3F530 VA: 0x181E40B30 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E43530 Offset: 0x1E41F30 VA: 0x181E43530
	internal Stream get_ArchiveStream() { }

	// RVA: 0x1E40380 Offset: 0x1E3ED80 VA: 0x181E40380
	private void SetFdpLoh() { }

	// RVA: 0x1E3B490 Offset: 0x1E39E90 VA: 0x181E3B490
	internal static int GetLengthOfCryptoHeaderBytes(EncryptionAlgorithm a) { }

	// RVA: 0x1E43670 Offset: 0x1E42070 VA: 0x181E43670
	internal long get_FileDataPosition() { }

	// RVA: 0x1E43D80 Offset: 0x1E42780 VA: 0x181E43D80
	private int get_LengthOfHeader() { }
}
