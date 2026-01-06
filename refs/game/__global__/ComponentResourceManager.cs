public class ComponentResourceManager : ResourceManager // TypeDefIndex: 9695
{
	// Fields
	private Hashtable _resourceSets; // 0x88
	private CultureInfo _neutralResourcesCulture; // 0x90

	// Properties
	private CultureInfo NeutralResourcesCulture { get; }

	// Methods

	// RVA: 0x2644E10 Offset: 0x2643810 VA: 0x182644E10
	public void .ctor(Type t) { }

	// RVA: 0x2644E70 Offset: 0x2643870 VA: 0x182644E70
	private CultureInfo get_NeutralResourcesCulture() { }

	// RVA: 0x26448F0 Offset: 0x26432F0 VA: 0x1826448F0
	public void ApplyResources(object value, string objectName) { }

	// RVA: 0x2643F70 Offset: 0x2642970 VA: 0x182643F70 Slot: 11
	public virtual void ApplyResources(object value, string objectName, CultureInfo culture) { }

	// RVA: 0x2644920 Offset: 0x2643320 VA: 0x182644920
	private SortedList<string, object> FillResources(CultureInfo culture, out ResourceSet resourceSet) { }
}
