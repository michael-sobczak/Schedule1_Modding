internal struct TextProcessingStack<T> // TypeDefIndex: 16755
{
	// Fields
	public T[] itemStack; // 0x0
	public int index; // 0x0
	private T m_DefaultItem; // 0x0
	private int m_Capacity; // 0x0
	private int m_RolloverSize; // 0x0
	private int m_Count; // 0x0

	// Properties
	public int Count { get; }
	public T current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120F150 Offset: 0x120DB50 VA: 0x18120F150
	|-TextProcessingStack<Color32>..ctor
	|-TextProcessingStack<int>..ctor
	|-TextProcessingStack<Int32Enum>..ctor
	|-TextProcessingStack<float>..ctor
	|
	|-RVA: 0x120F4B0 Offset: 0x120DEB0 VA: 0x18120F4B0
	|-TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x120F9A0 Offset: 0x120E3A0 VA: 0x18120F9A0
	|-TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x120FD10 Offset: 0x120E710 VA: 0x18120FD10
	|-TextProcessingStack<object>..ctor
	|
	|-RVA: 0x1263E90 Offset: 0x1262890 VA: 0x181263E90
	|-TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x120FA00 Offset: 0x120E400 VA: 0x18120FA00
	|-TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120F050 Offset: 0x120DA50 VA: 0x18120F050
	|-TextProcessingStack<Color32>..ctor
	|-TextProcessingStack<int>..ctor
	|-TextProcessingStack<Int32Enum>..ctor
	|-TextProcessingStack<float>..ctor
	|
	|-RVA: 0x120F920 Offset: 0x120E320 VA: 0x18120F920
	|-TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x120EFC0 Offset: 0x120D9C0 VA: 0x18120EFC0
	|-TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x120F190 Offset: 0x120DB90 VA: 0x18120F190
	|-TextProcessingStack<object>..ctor
	|
	|-RVA: 0x1263E00 Offset: 0x1262800 VA: 0x181263E00
	|-TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x120F690 Offset: 0x120E090 VA: 0x18120F690
	|-TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, int rolloverSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120EF40 Offset: 0x120D940 VA: 0x18120EF40
	|-TextProcessingStack<Color32>..ctor
	|-TextProcessingStack<int>..ctor
	|-TextProcessingStack<Int32Enum>..ctor
	|-TextProcessingStack<float>..ctor
	|
	|-RVA: 0x120F560 Offset: 0x120DF60 VA: 0x18120F560
	|-TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x120F5F0 Offset: 0x120DFF0 VA: 0x18120F5F0
	|-TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x120EEB0 Offset: 0x120D8B0 VA: 0x18120EEB0
	|-TextProcessingStack<object>..ctor
	|
	|-RVA: 0x1263EF0 Offset: 0x12628F0 VA: 0x181263EF0
	|-TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x120F210 Offset: 0x120DC10 VA: 0x18120F210
	|-TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EB2A0 Offset: 0x10E9CA0 VA: 0x1810EB2A0
	|-TextProcessingStack<Color32>.get_Count
	|-TextProcessingStack<int>.get_Count
	|-TextProcessingStack<Int32Enum>.get_Count
	|-TextProcessingStack<float>.get_Count
	|
	|-RVA: 0x1263FC0 Offset: 0x12629C0 VA: 0x181263FC0
	|-TextProcessingStack<HighlightState>.get_Count
	|
	|-RVA: 0x1263FB0 Offset: 0x12629B0 VA: 0x181263FB0
	|-TextProcessingStack<MaterialReference>.get_Count
	|
	|-RVA: 0x1263FA0 Offset: 0x12629A0 VA: 0x181263FA0
	|-TextProcessingStack<object>.get_Count
	|
	|-RVA: 0x1263F90 Offset: 0x1262990 VA: 0x181263F90
	|-TextProcessingStack<WordWrapState>.get_Count
	|
	|-RVA: 0x120FD70 Offset: 0x120E770 VA: 0x18120FD70
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120AD30 Offset: 0x1209730 VA: 0x18120AD30
	|-TextProcessingStack<Color32>.get_current
	|-TextProcessingStack<int>.get_current
	|-TextProcessingStack<Int32Enum>.get_current
	|
	|-RVA: 0x1261820 Offset: 0x1260220 VA: 0x181261820
	|-TextProcessingStack<HighlightState>.get_current
	|
	|-RVA: 0x1261610 Offset: 0x1260010 VA: 0x181261610
	|-TextProcessingStack<MaterialReference>.get_current
	|
	|-RVA: 0x120AC70 Offset: 0x1209670 VA: 0x18120AC70
	|-TextProcessingStack<object>.get_current
	|
	|-RVA: 0x120AF40 Offset: 0x1209940 VA: 0x18120AF40
	|-TextProcessingStack<float>.get_current
	|
	|-RVA: 0x12616C0 Offset: 0x12600C0 VA: 0x1812616C0
	|-TextProcessingStack<WordWrapState>.get_current
	|
	|-RVA: 0x1261400 Offset: 0x125FE00 VA: 0x181261400
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.get_current
	*/

	// RVA: -1 Offset: -1
	internal static void SetDefault(TextProcessingStack<T>[] stack, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120E030 Offset: 0x120CA30 VA: 0x18120E030
	|-TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0x120E4C0 Offset: 0x120CEC0 VA: 0x18120E4C0
	|-TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x120DAA0 Offset: 0x120C4A0 VA: 0x18120DAA0
	|-TextProcessingStack<int>.SetDefault
	|-TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0x120E870 Offset: 0x120D270 VA: 0x18120E870
	|-TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x120EC30 Offset: 0x120D630 VA: 0x18120EC30
	|-TextProcessingStack<object>.SetDefault
	|
	|-RVA: 0x120E2C0 Offset: 0x120CCC0 VA: 0x18120E2C0
	|-TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x1263C50 Offset: 0x1262650 VA: 0x181263C50
	|-TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x120E9D0 Offset: 0x120D3D0 VA: 0x18120E9D0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120AAB0 Offset: 0x12094B0 VA: 0x18120AAB0
	|-TextProcessingStack<Color32>.Clear
	|-TextProcessingStack<int>.Clear
	|-TextProcessingStack<Int32Enum>.Clear
	|-TextProcessingStack<float>.Clear
	|
	|-RVA: 0x120ABC0 Offset: 0x12095C0 VA: 0x18120ABC0
	|-TextProcessingStack<HighlightState>.Clear
	|
	|-RVA: 0x120ABB0 Offset: 0x12095B0 VA: 0x18120ABB0
	|-TextProcessingStack<MaterialReference>.Clear
	|
	|-RVA: 0x120AAA0 Offset: 0x12094A0 VA: 0x18120AAA0
	|-TextProcessingStack<object>.Clear
	|
	|-RVA: 0x12613F0 Offset: 0x125FDF0 VA: 0x1812613F0
	|-TextProcessingStack<WordWrapState>.Clear
	|
	|-RVA: 0x120AAC0 Offset: 0x12094C0 VA: 0x18120AAC0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void SetDefault(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120E210 Offset: 0x120CC10 VA: 0x18120E210
	|-TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0x120E150 Offset: 0x120CB50 VA: 0x18120E150
	|-TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x120DBC0 Offset: 0x120C5C0 VA: 0x18120DBC0
	|-TextProcessingStack<int>.SetDefault
	|-TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0x120E3E0 Offset: 0x120CDE0 VA: 0x18120E3E0
	|-TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x120E7B0 Offset: 0x120D1B0 VA: 0x18120E7B0
	|-TextProcessingStack<object>.SetDefault
	|
	|-RVA: 0x120EB80 Offset: 0x120D580 VA: 0x18120EB80
	|-TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x1263B10 Offset: 0x1262510 VA: 0x181263B10
	|-TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x120DC70 Offset: 0x120C670 VA: 0x18120DC70
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120A880 Offset: 0x1209280 VA: 0x18120A880
	|-TextProcessingStack<Color32>.Add
	|-TextProcessingStack<int>.Add
	|-TextProcessingStack<Int32Enum>.Add
	|
	|-RVA: 0x120A8C0 Offset: 0x12092C0 VA: 0x18120A8C0
	|-TextProcessingStack<HighlightState>.Add
	|
	|-RVA: 0x120A950 Offset: 0x1209350 VA: 0x18120A950
	|-TextProcessingStack<MaterialReference>.Add
	|
	|-RVA: 0x120A560 Offset: 0x1208F60 VA: 0x18120A560
	|-TextProcessingStack<object>.Add
	|
	|-RVA: 0x120A910 Offset: 0x1209310 VA: 0x18120A910
	|-TextProcessingStack<float>.Add
	|
	|-RVA: 0x1261330 Offset: 0x125FD30 VA: 0x181261330
	|-TextProcessingStack<WordWrapState>.Add
	|
	|-RVA: 0x120A5B0 Offset: 0x1208FB0 VA: 0x18120A5B0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public T Remove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120D3F0 Offset: 0x120BDF0 VA: 0x18120D3F0
	|-TextProcessingStack<Color32>.Remove
	|-TextProcessingStack<int>.Remove
	|-TextProcessingStack<Int32Enum>.Remove
	|
	|-RVA: 0x1263A80 Offset: 0x1262480 VA: 0x181263A80
	|-TextProcessingStack<HighlightState>.Remove
	|
	|-RVA: 0x1263440 Offset: 0x1261E40 VA: 0x181263440
	|-TextProcessingStack<MaterialReference>.Remove
	|
	|-RVA: 0x120DA30 Offset: 0x120C430 VA: 0x18120DA30
	|-TextProcessingStack<object>.Remove
	|
	|-RVA: 0x120D4D0 Offset: 0x120BED0 VA: 0x18120D4D0
	|-TextProcessingStack<float>.Remove
	|
	|-RVA: 0x1263510 Offset: 0x1261F10 VA: 0x181263510
	|-TextProcessingStack<WordWrapState>.Remove
	|
	|-RVA: 0x1263690 Offset: 0x1262090 VA: 0x181263690
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1262A60 Offset: 0x1261460 VA: 0x181262A60
	|-TextProcessingStack<Color32>.Push
	|
	|-RVA: 0x120C780 Offset: 0x120B180 VA: 0x18120C780
	|-TextProcessingStack<HighlightState>.Push
	|
	|-RVA: 0x120CB60 Offset: 0x120B560 VA: 0x18120CB60
	|-TextProcessingStack<int>.Push
	|-TextProcessingStack<Int32Enum>.Push
	|
	|-RVA: 0x120C680 Offset: 0x120B080 VA: 0x18120C680
	|-TextProcessingStack<MaterialReference>.Push
	|
	|-RVA: 0x120C910 Offset: 0x120B310 VA: 0x18120C910
	|-TextProcessingStack<object>.Push
	|
	|-RVA: 0x1262B20 Offset: 0x1261520 VA: 0x181262B20
	|-TextProcessingStack<float>.Push
	|
	|-RVA: 0x1262BF0 Offset: 0x12615F0 VA: 0x181262BF0
	|-TextProcessingStack<WordWrapState>.Push
	|
	|-RVA: 0x1262D50 Offset: 0x1261750 VA: 0x181262D50
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120B4A0 Offset: 0x1209EA0 VA: 0x18120B4A0
	|-TextProcessingStack<Color32>.Pop
	|
	|-RVA: 0x1261CF0 Offset: 0x12606F0 VA: 0x181261CF0
	|-TextProcessingStack<HighlightState>.Pop
	|
	|-RVA: 0x120B410 Offset: 0x1209E10 VA: 0x18120B410
	|-TextProcessingStack<int>.Pop
	|-TextProcessingStack<Int32Enum>.Pop
	|
	|-RVA: 0x1262900 Offset: 0x1261300 VA: 0x181262900
	|-TextProcessingStack<MaterialReference>.Pop
	|
	|-RVA: 0x1262580 Offset: 0x1260F80 VA: 0x181262580
	|-TextProcessingStack<object>.Pop
	|
	|-RVA: 0x12624E0 Offset: 0x1260EE0 VA: 0x1812624E0
	|-TextProcessingStack<float>.Pop
	|
	|-RVA: 0x1262630 Offset: 0x1261030 VA: 0x181262630
	|-TextProcessingStack<WordWrapState>.Pop
	|
	|-RVA: 0x1261DC0 Offset: 0x12607C0 VA: 0x181261DC0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120B1E0 Offset: 0x1209BE0 VA: 0x18120B1E0
	|-TextProcessingStack<Color32>.Peek
	|-TextProcessingStack<int>.Peek
	|-TextProcessingStack<Int32Enum>.Peek
	|
	|-RVA: 0x12618A0 Offset: 0x12602A0 VA: 0x1812618A0
	|-TextProcessingStack<HighlightState>.Peek
	|
	|-RVA: 0x1261C50 Offset: 0x1260650 VA: 0x181261C50
	|-TextProcessingStack<MaterialReference>.Peek
	|
	|-RVA: 0x120B110 Offset: 0x1209B10 VA: 0x18120B110
	|-TextProcessingStack<object>.Peek
	|
	|-RVA: 0x120B220 Offset: 0x1209C20 VA: 0x18120B220
	|-TextProcessingStack<float>.Peek
	|
	|-RVA: 0x1261910 Offset: 0x1260310 VA: 0x181261910
	|-TextProcessingStack<WordWrapState>.Peek
	|
	|-RVA: 0x1261A50 Offset: 0x1260450 VA: 0x181261A50
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Peek
	*/

	// RVA: -1 Offset: -1
	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120AD30 Offset: 0x1209730 VA: 0x18120AD30
	|-TextProcessingStack<Color32>.CurrentItem
	|-TextProcessingStack<int>.CurrentItem
	|-TextProcessingStack<Int32Enum>.CurrentItem
	|
	|-RVA: 0x1261820 Offset: 0x1260220 VA: 0x181261820
	|-TextProcessingStack<HighlightState>.CurrentItem
	|
	|-RVA: 0x1261610 Offset: 0x1260010 VA: 0x181261610
	|-TextProcessingStack<MaterialReference>.CurrentItem
	|
	|-RVA: 0x120AC70 Offset: 0x1209670 VA: 0x18120AC70
	|-TextProcessingStack<object>.CurrentItem
	|
	|-RVA: 0x120AF40 Offset: 0x1209940 VA: 0x18120AF40
	|-TextProcessingStack<float>.CurrentItem
	|
	|-RVA: 0x12616C0 Offset: 0x12600C0 VA: 0x1812616C0
	|-TextProcessingStack<WordWrapState>.CurrentItem
	|
	|-RVA: 0x1261400 Offset: 0x125FE00 VA: 0x181261400
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.CurrentItem
	*/
}
