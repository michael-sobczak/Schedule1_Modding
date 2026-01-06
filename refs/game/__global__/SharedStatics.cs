internal sealed class SharedStatics // TypeDefIndex: 3823
{
	// Fields
	private static readonly SharedStatics _sharedStatics; // 0x0
	private Tokenizer.StringMaker _maker; // 0x10

	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void .ctor() { }

	// RVA: 0x1CC8960 Offset: 0x1CC7360 VA: 0x181CC8960
	public static Tokenizer.StringMaker GetSharedStringMaker() { }

	// RVA: 0x1CC8AE0 Offset: 0x1CC74E0 VA: 0x181CC8AE0
	public static void ReleaseSharedStringMaker(ref Tokenizer.StringMaker maker) { }

	// RVA: 0x1CC8BF0 Offset: 0x1CC75F0 VA: 0x181CC8BF0
	private static void .cctor() { }
}
