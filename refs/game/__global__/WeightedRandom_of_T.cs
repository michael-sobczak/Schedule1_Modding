public class WeightedRandom<T> // TypeDefIndex: 10451
{
	// Fields
	private readonly List<T> mData; // 0x0
	private int mCurrentPosition; // 0x0
	private T mCurrentItem; // 0x0
	[CompilerGenerated]
	private int <Seed>k__BackingField; // 0x0
	[CompilerGenerated]
	private bool <RandomizeSeed>k__BackingField; // 0x0

	// Properties
	public int Seed { get; set; }
	public bool RandomizeSeed { get; set; }
	public int Size { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_Seed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	|-WeightedRandom<int>.get_Seed
	|
	|-RVA: 0x11AE020 Offset: 0x11ACA20 VA: 0x1811AE020
	|-WeightedRandom<__Il2CppFullySharedGenericType>.get_Seed
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_Seed(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	|-WeightedRandom<int>.set_Seed
	|
	|-RVA: 0x13E6D80 Offset: 0x13E5780 VA: 0x1813E6D80
	|-WeightedRandom<__Il2CppFullySharedGenericType>.set_Seed
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public bool get_RandomizeSeed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x563D90 Offset: 0x562790 VA: 0x180563D90
	|-WeightedRandom<int>.get_RandomizeSeed
	|
	|-RVA: 0x13E6C90 Offset: 0x13E5690 VA: 0x1813E6C90
	|-WeightedRandom<__Il2CppFullySharedGenericType>.get_RandomizeSeed
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_RandomizeSeed(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x563E00 Offset: 0x562800 VA: 0x180563E00
	|-WeightedRandom<int>.set_RandomizeSeed
	|
	|-RVA: 0x13E6D10 Offset: 0x13E5710 VA: 0x1813E6D10
	|-WeightedRandom<__Il2CppFullySharedGenericType>.set_RandomizeSeed
	*/

	// RVA: -1 Offset: -1
	public int get_Size() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4AA50 Offset: 0xC49450 VA: 0x180C4AA50
	|-WeightedRandom<int>.get_Size
	|
	|-RVA: 0x13E6CC0 Offset: 0x13E56C0 VA: 0x1813E6CC0
	|-WeightedRandom<__Il2CppFullySharedGenericType>.get_Size
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int initCapacity = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C7E10 Offset: 0x13C6810 VA: 0x1813C7E10
	|-WeightedRandom<int>..ctor
	|
	|-RVA: 0x13E6B20 Offset: 0x13E5520 VA: 0x1813E6B20
	|-WeightedRandom<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int initCapacity, int seed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C7D50 Offset: 0x13C6750 VA: 0x1813C7D50
	|-WeightedRandom<int>..ctor
	|
	|-RVA: 0x13E6C30 Offset: 0x13E5630 VA: 0x1813E6C30
	|-WeightedRandom<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Add(T item, int amount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C7AC0 Offset: 0x13C64C0 VA: 0x1813C7AC0
	|-WeightedRandom<int>.Add
	|
	|-RVA: 0x13E6220 Offset: 0x13E4C20 VA: 0x1813E6220
	|-WeightedRandom<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public T Next() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C7BC0 Offset: 0x13C65C0 VA: 0x1813C7BC0
	|-WeightedRandom<int>.Next
	|
	|-RVA: 0x13E6460 Offset: 0x13E4E60 VA: 0x1813E6460
	|-WeightedRandom<__Il2CppFullySharedGenericType>.Next
	*/

	// RVA: -1 Offset: -1
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C7D30 Offset: 0x13C6730 VA: 0x1813C7D30
	|-WeightedRandom<int>.Reset
	|
	|-RVA: 0x13E6AA0 Offset: 0x13E54A0 VA: 0x1813E6AA0
	|-WeightedRandom<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C7B90 Offset: 0x13C6590 VA: 0x1813C7B90
	|-WeightedRandom<int>.Clear
	|
	|-RVA: 0x13E63C0 Offset: 0x13E4DC0 VA: 0x1813E63C0
	|-WeightedRandom<__Il2CppFullySharedGenericType>.Clear
	*/
}
