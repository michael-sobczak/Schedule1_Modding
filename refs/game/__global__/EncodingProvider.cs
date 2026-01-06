public abstract class EncodingProvider // TypeDefIndex: 4118
{
	// Fields
	private static object s_InternalSyncObject; // 0x0
	private static EncodingProvider[] s_providers; // 0x8

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Encoding GetEncoding(string name);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Encoding GetEncoding(int codepage);

	// RVA: 0x1ABA8E0 Offset: 0x1AB92E0 VA: 0x181ABA8E0 Slot: 6
	public virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	// RVA: 0x1ABA6E0 Offset: 0x1AB90E0 VA: 0x181ABA6E0
	internal static Encoding GetEncodingFromProvider(int codepage) { }

	// RVA: 0x1ABA7E0 Offset: 0x1AB91E0 VA: 0x181ABA7E0
	internal static Encoding GetEncodingFromProvider(string encodingName) { }

	// RVA: 0x1ABA5C0 Offset: 0x1AB8FC0 VA: 0x181ABA5C0
	internal static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec) { }

	// RVA: 0x1ABAA00 Offset: 0x1AB9400 VA: 0x181ABAA00
	private static void .cctor() { }
}
