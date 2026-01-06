internal class ManifestBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 4663
{
	// Fields
	private ResourceManager.ResourceManagerMediator _mediator; // 0x10

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }

	// RVA: 0x1B647A0 Offset: 0x1B631A0 VA: 0x181B647A0 Slot: 4
	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

	// RVA: 0x1B65300 Offset: 0x1B63D00 VA: 0x181B65300
	private CultureInfo UltimateFallbackFixup(CultureInfo lookForCulture) { }

	// RVA: 0x1B64260 Offset: 0x1B62C60 VA: 0x181B64260
	internal static CultureInfo GetNeutralResourcesLanguage(Assembly a, ref UltimateResourceFallbackLocation fallbackLocation) { }

	// RVA: 0x1B635D0 Offset: 0x1B61FD0 VA: 0x181B635D0
	internal ResourceSet CreateResourceSet(Stream store, Assembly assembly) { }

	// RVA: 0x1B640D0 Offset: 0x1B62AD0 VA: 0x181B640D0
	private Stream GetManifestResourceStream(RuntimeAssembly satellite, string fileName, ref StackCrawlMark stackMark) { }

	// RVA: 0x1B631D0 Offset: 0x1B61BD0 VA: 0x181B631D0
	private Stream CaseInsensitiveManifestResourceStreamLookup(RuntimeAssembly satellite, string name) { }

	// RVA: 0x1B645E0 Offset: 0x1B62FE0 VA: 0x181B645E0
	private RuntimeAssembly GetSatelliteAssembly(CultureInfo lookForCulture, ref StackCrawlMark stackMark) { }

	// RVA: 0x1B63040 Offset: 0x1B61A40 VA: 0x181B63040
	private bool CanUseDefaultResourceClasses(string readerTypeName, string resSetTypeName) { }

	// RVA: 0x1B64570 Offset: 0x1B62F70 VA: 0x181B64570
	private string GetSatelliteAssemblyName() { }

	// RVA: 0x1B64F50 Offset: 0x1B63950 VA: 0x181B64F50
	private void HandleSatelliteMissing() { }

	// RVA: 0x1B64C40 Offset: 0x1B63640 VA: 0x181B64C40
	private void HandleResourceStreamMissing(string fileName) { }

	// RVA: 0x1B641D0 Offset: 0x1B62BD0 VA: 0x181B641D0
	private static bool GetNeutralResourcesLanguageAttribute(Assembly assembly, ref string cultureName, ref short fallbackLocation) { }
}
