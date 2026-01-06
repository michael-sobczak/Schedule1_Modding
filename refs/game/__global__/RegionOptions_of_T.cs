public struct RegionOptions<T> // TypeDefIndex: 10441
{
	// Fields
	public string LabelFrom; // 0x0
	public string LabelTo; // 0x0
	public string OptionalTooltip; // 0x0
	public DTValueClamping ClampFrom; // 0x0
	public DTValueClamping ClampTo; // 0x0
	public T FromMin; // 0x0
	public T FromMax; // 0x0
	public T ToMin; // 0x0
	public T ToMax; // 0x0

	// Properties
	public static RegionOptions<T> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static RegionOptions<T> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A5C80 Offset: 0x11A4680 VA: 0x1811A5C80
	|-RegionOptions<int>.get_Default
	|
	|-RVA: 0x11A5900 Offset: 0x11A4300 VA: 0x1811A5900
	|-RegionOptions<float>.get_Default
	|
	|-RVA: 0x11A59B0 Offset: 0x11A43B0 VA: 0x1811A59B0
	|-RegionOptions<__Il2CppFullySharedGenericType>.get_Default
	*/

	// RVA: -1 Offset: -1
	public static RegionOptions<T> MinMax(T min, T max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11A5850 Offset: 0x11A4250 VA: 0x1811A5850
	|-RegionOptions<int>.MinMax
	|
	|-RVA: 0x11A5790 Offset: 0x11A4190 VA: 0x1811A5790
	|-RegionOptions<float>.MinMax
	|
	|-RVA: 0x11A5280 Offset: 0x11A3C80 VA: 0x1811A5280
	|-RegionOptions<__Il2CppFullySharedGenericType>.MinMax
	*/
}
