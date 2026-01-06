internal class FileBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 4661
{
	// Fields
	private ResourceManager.ResourceManagerMediator _mediator; // 0x10

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }

	// RVA: 0x1B61AC0 Offset: 0x1B604C0 VA: 0x181B61AC0 Slot: 4
	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

	// RVA: 0x1B61A00 Offset: 0x1B60400 VA: 0x181B61A00
	private string FindResourceFile(CultureInfo culture, string fileName) { }

	// RVA: 0x1B61620 Offset: 0x1B60020 VA: 0x181B61620
	private ResourceSet CreateResourceSet(string file) { }
}
