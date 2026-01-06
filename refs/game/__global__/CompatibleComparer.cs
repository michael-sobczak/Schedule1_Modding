internal class CompatibleComparer : IEqualityComparer // TypeDefIndex: 9869
{
	// Fields
	private IComparer _comparer; // 0x10
	private static IComparer defaultComparer; // 0x0
	private IHashCodeProvider _hcp; // 0x18
	private static IHashCodeProvider defaultHashProvider; // 0x8

	// Properties
	public IComparer Comparer { get; }
	public IHashCodeProvider HashCodeProvider { get; }
	public static IComparer DefaultComparer { get; }
	public static IHashCodeProvider DefaultHashCodeProvider { get; }

	// Methods

	// RVA: 0x5CC320 Offset: 0x5CAD20 VA: 0x1805CC320
	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0x269C130 Offset: 0x269AB30 VA: 0x18269C130 Slot: 4
	public bool Equals(object a, object b) { }

	// RVA: 0x269C240 Offset: 0x269AC40 VA: 0x18269C240 Slot: 5
	public int GetHashCode(object obj) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public IComparer get_Comparer() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x269C310 Offset: 0x269AD10 VA: 0x18269C310
	public static IComparer get_DefaultComparer() { }

	// RVA: 0x269C400 Offset: 0x269AE00 VA: 0x18269C400
	public static IHashCodeProvider get_DefaultHashCodeProvider() { }
}
