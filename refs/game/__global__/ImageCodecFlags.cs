public enum ImageCodecFlags // TypeDefIndex: 17211
{
	// Fields
	public int value__; // 0x0
	public const ImageCodecFlags Encoder = 1;
	public const ImageCodecFlags Decoder = 2;
	public const ImageCodecFlags SupportBitmap = 4;
	public const ImageCodecFlags SupportVector = 8;
	public const ImageCodecFlags SeekableEncode = 16;
	public const ImageCodecFlags BlockingDecode = 32;
	public const ImageCodecFlags Builtin = 65536;
	public const ImageCodecFlags System = 131072;
	public const ImageCodecFlags User = 262144;
}
