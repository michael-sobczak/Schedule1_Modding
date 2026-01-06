public class RemotingSurrogateSelector : ISurrogateSelector // TypeDefIndex: 4402
{
	// Fields
	private static Type s_cachedTypeObjRef; // 0x0
	private static ObjRefSurrogate _objRefSurrogate; // 0x8
	private static RemotingSurrogate _objRemotingSurrogate; // 0x10
	private ISurrogateSelector _next; // 0x10

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x1B3F210 Offset: 0x1B3DC10 VA: 0x181B3F210 Slot: 5
	public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout) { }

	// RVA: 0x1B3F3B0 Offset: 0x1B3DDB0 VA: 0x181B3F3B0
	private static void .cctor() { }
}
