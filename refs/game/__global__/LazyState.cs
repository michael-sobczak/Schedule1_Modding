internal enum LazyState // TypeDefIndex: 3679
{
	// Fields
	public int value__; // 0x0
	public const LazyState NoneViaConstructor = 0;
	public const LazyState NoneViaFactory = 1;
	public const LazyState NoneException = 2;
	public const LazyState PublicationOnlyViaConstructor = 3;
	public const LazyState PublicationOnlyViaFactory = 4;
	public const LazyState PublicationOnlyWait = 5;
	public const LazyState PublicationOnlyException = 6;
	public const LazyState ExecutionAndPublicationViaConstructor = 7;
	public const LazyState ExecutionAndPublicationViaFactory = 8;
	public const LazyState ExecutionAndPublicationException = 9;
}
