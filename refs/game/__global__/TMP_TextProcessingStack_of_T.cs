public struct TMP_TextProcessingStack<T> // TypeDefIndex: 15003
{
	// Fields
	public T[] itemStack; // 0x0
	public int index; // 0x0
	private T m_DefaultItem; // 0x0
	private int m_Capacity; // 0x0
	private int m_RolloverSize; // 0x0
	private int m_Count; // 0x0
	private const int k_DefaultCapacity = 4;

	// Properties
	public int Count { get; }
	public T current { get; }
	public int rolloverSize { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120F150 Offset: 0x120DB50 VA: 0x18120F150
	|-TMP_TextProcessingStack<Color32>..ctor
	|-TMP_TextProcessingStack<int>..ctor
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x120F4B0 Offset: 0x120DEB0 VA: 0x18120F4B0
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x120F9A0 Offset: 0x120E3A0 VA: 0x18120F9A0
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x120FD10 Offset: 0x120E710 VA: 0x18120FD10
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x120F500 Offset: 0x120DF00 VA: 0x18120F500
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x120FA00 Offset: 0x120E400 VA: 0x18120FA00
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120F050 Offset: 0x120DA50 VA: 0x18120F050
	|-TMP_TextProcessingStack<Color32>..ctor
	|-TMP_TextProcessingStack<int>..ctor
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x120F920 Offset: 0x120E320 VA: 0x18120F920
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x120EFC0 Offset: 0x120D9C0 VA: 0x18120EFC0
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x120F190 Offset: 0x120DB90 VA: 0x18120F190
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x120F0C0 Offset: 0x120DAC0 VA: 0x18120F0C0
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x120F690 Offset: 0x120E090 VA: 0x18120F690
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, int rolloverSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120EF40 Offset: 0x120D940 VA: 0x18120EF40
	|-TMP_TextProcessingStack<Color32>..ctor
	|-TMP_TextProcessingStack<int>..ctor
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x120F560 Offset: 0x120DF60 VA: 0x18120F560
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x120F5F0 Offset: 0x120DFF0 VA: 0x18120F5F0
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x120EEB0 Offset: 0x120D8B0 VA: 0x18120EEB0
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x120FC70 Offset: 0x120E670 VA: 0x18120FC70
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x120F210 Offset: 0x120DC10 VA: 0x18120F210
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	|-TMP_TextProcessingStack<Color32>.get_Count
	|-TMP_TextProcessingStack<int>.get_Count
	|-TMP_TextProcessingStack<Int32Enum>.get_Count
	|-TMP_TextProcessingStack<float>.get_Count
	|
	|-RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	|-TMP_TextProcessingStack<HighlightState>.get_Count
	|
	|-RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	|-TMP_TextProcessingStack<MaterialReference>.get_Count
	|
	|-RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	|-TMP_TextProcessingStack<object>.get_Count
	|
	|-RVA: 0x120FD60 Offset: 0x120E760 VA: 0x18120FD60
	|-TMP_TextProcessingStack<WordWrapState>.get_Count
	|
	|-RVA: 0x120FD70 Offset: 0x120E770 VA: 0x18120FD70
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120AD30 Offset: 0x1209730 VA: 0x18120AD30
	|-TMP_TextProcessingStack<Color32>.get_current
	|-TMP_TextProcessingStack<int>.get_current
	|-TMP_TextProcessingStack<Int32Enum>.get_current
	|
	|-RVA: 0x120ACC0 Offset: 0x12096C0 VA: 0x18120ACC0
	|-TMP_TextProcessingStack<HighlightState>.get_current
	|
	|-RVA: 0x120ABD0 Offset: 0x12095D0 VA: 0x18120ABD0
	|-TMP_TextProcessingStack<MaterialReference>.get_current
	|
	|-RVA: 0x120AC70 Offset: 0x1209670 VA: 0x18120AC70
	|-TMP_TextProcessingStack<object>.get_current
	|
	|-RVA: 0x120AF40 Offset: 0x1209940 VA: 0x18120AF40
	|-TMP_TextProcessingStack<float>.get_current
	|
	|-RVA: 0x120AF90 Offset: 0x1209990 VA: 0x18120AF90
	|-TMP_TextProcessingStack<WordWrapState>.get_current
	|
	|-RVA: 0x120AD80 Offset: 0x1209780 VA: 0x18120AD80
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.get_current
	*/

	// RVA: -1 Offset: -1
	public int get_rolloverSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	|-TMP_TextProcessingStack<Color32>.get_rolloverSize
	|-TMP_TextProcessingStack<int>.get_rolloverSize
	|-TMP_TextProcessingStack<Int32Enum>.get_rolloverSize
	|-TMP_TextProcessingStack<float>.get_rolloverSize
	|
	|-RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	|-TMP_TextProcessingStack<HighlightState>.get_rolloverSize
	|
	|-RVA: 0x4D60C0 Offset: 0x4D4AC0 VA: 0x1804D60C0
	|-TMP_TextProcessingStack<MaterialReference>.get_rolloverSize
	|
	|-RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	|-TMP_TextProcessingStack<object>.get_rolloverSize
	|
	|-RVA: 0x120FE10 Offset: 0x120E810 VA: 0x18120FE10
	|-TMP_TextProcessingStack<WordWrapState>.get_rolloverSize
	|
	|-RVA: 0x120FDC0 Offset: 0x120E7C0 VA: 0x18120FDC0
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.get_rolloverSize
	*/

	// RVA: -1 Offset: -1
	public void set_rolloverSize(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x65C890 Offset: 0x65B290 VA: 0x18065C890
	|-TMP_TextProcessingStack<Color32>.set_rolloverSize
	|-TMP_TextProcessingStack<int>.set_rolloverSize
	|-TMP_TextProcessingStack<Int32Enum>.set_rolloverSize
	|-TMP_TextProcessingStack<float>.set_rolloverSize
	|
	|-RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	|-TMP_TextProcessingStack<HighlightState>.set_rolloverSize
	|
	|-RVA: 0x4E27E0 Offset: 0x4E11E0 VA: 0x1804E27E0
	|-TMP_TextProcessingStack<MaterialReference>.set_rolloverSize
	|
	|-RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80
	|-TMP_TextProcessingStack<object>.set_rolloverSize
	|
	|-RVA: 0x120FE20 Offset: 0x120E820 VA: 0x18120FE20
	|-TMP_TextProcessingStack<WordWrapState>.set_rolloverSize
	|
	|-RVA: 0x120FE30 Offset: 0x120E830 VA: 0x18120FE30
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.set_rolloverSize
	*/

	// RVA: -1 Offset: -1
	internal static void SetDefault(TMP_TextProcessingStack<T>[] stack, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120E030 Offset: 0x120CA30 VA: 0x18120E030
	|-TMP_TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0x120E4C0 Offset: 0x120CEC0 VA: 0x18120E4C0
	|-TMP_TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x120DAA0 Offset: 0x120C4A0 VA: 0x18120DAA0
	|-TMP_TextProcessingStack<int>.SetDefault
	|-TMP_TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0x120E870 Offset: 0x120D270 VA: 0x18120E870
	|-TMP_TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x120EC30 Offset: 0x120D630 VA: 0x18120EC30
	|-TMP_TextProcessingStack<object>.SetDefault
	|
	|-RVA: 0x120E2C0 Offset: 0x120CCC0 VA: 0x18120E2C0
	|-TMP_TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x120E5F0 Offset: 0x120CFF0 VA: 0x18120E5F0
	|-TMP_TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x120E9D0 Offset: 0x120D3D0 VA: 0x18120E9D0
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120AAB0 Offset: 0x12094B0 VA: 0x18120AAB0
	|-TMP_TextProcessingStack<Color32>.Clear
	|-TMP_TextProcessingStack<int>.Clear
	|-TMP_TextProcessingStack<Int32Enum>.Clear
	|-TMP_TextProcessingStack<float>.Clear
	|
	|-RVA: 0x120ABC0 Offset: 0x12095C0 VA: 0x18120ABC0
	|-TMP_TextProcessingStack<HighlightState>.Clear
	|
	|-RVA: 0x120ABB0 Offset: 0x12095B0 VA: 0x18120ABB0
	|-TMP_TextProcessingStack<MaterialReference>.Clear
	|
	|-RVA: 0x120AAA0 Offset: 0x12094A0 VA: 0x18120AAA0
	|-TMP_TextProcessingStack<object>.Clear
	|
	|-RVA: 0x120ABA0 Offset: 0x12095A0 VA: 0x18120ABA0
	|-TMP_TextProcessingStack<WordWrapState>.Clear
	|
	|-RVA: 0x120AAC0 Offset: 0x12094C0 VA: 0x18120AAC0
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void SetDefault(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120E210 Offset: 0x120CC10 VA: 0x18120E210
	|-TMP_TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0x120E150 Offset: 0x120CB50 VA: 0x18120E150
	|-TMP_TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x120DBC0 Offset: 0x120C5C0 VA: 0x18120DBC0
	|-TMP_TextProcessingStack<int>.SetDefault
	|-TMP_TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0x120E3E0 Offset: 0x120CDE0 VA: 0x18120E3E0
	|-TMP_TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x120E7B0 Offset: 0x120D1B0 VA: 0x18120E7B0
	|-TMP_TextProcessingStack<object>.SetDefault
	|
	|-RVA: 0x120EB80 Offset: 0x120D580 VA: 0x18120EB80
	|-TMP_TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x120ED60 Offset: 0x120D760 VA: 0x18120ED60
	|-TMP_TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x120DC70 Offset: 0x120C670 VA: 0x18120DC70
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120A880 Offset: 0x1209280 VA: 0x18120A880
	|-TMP_TextProcessingStack<Color32>.Add
	|-TMP_TextProcessingStack<int>.Add
	|-TMP_TextProcessingStack<Int32Enum>.Add
	|
	|-RVA: 0x120A8C0 Offset: 0x12092C0 VA: 0x18120A8C0
	|-TMP_TextProcessingStack<HighlightState>.Add
	|
	|-RVA: 0x120A950 Offset: 0x1209350 VA: 0x18120A950
	|-TMP_TextProcessingStack<MaterialReference>.Add
	|
	|-RVA: 0x120A560 Offset: 0x1208F60 VA: 0x18120A560
	|-TMP_TextProcessingStack<object>.Add
	|
	|-RVA: 0x120A910 Offset: 0x1209310 VA: 0x18120A910
	|-TMP_TextProcessingStack<float>.Add
	|
	|-RVA: 0x120A9D0 Offset: 0x12093D0 VA: 0x18120A9D0
	|-TMP_TextProcessingStack<WordWrapState>.Add
	|
	|-RVA: 0x120A5B0 Offset: 0x1208FB0 VA: 0x18120A5B0
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public T Remove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120D3F0 Offset: 0x120BDF0 VA: 0x18120D3F0
	|-TMP_TextProcessingStack<Color32>.Remove
	|-TMP_TextProcessingStack<int>.Remove
	|-TMP_TextProcessingStack<Int32Enum>.Remove
	|
	|-RVA: 0x120D540 Offset: 0x120BF40 VA: 0x18120D540
	|-TMP_TextProcessingStack<HighlightState>.Remove
	|
	|-RVA: 0x120D970 Offset: 0x120C370 VA: 0x18120D970
	|-TMP_TextProcessingStack<MaterialReference>.Remove
	|
	|-RVA: 0x120DA30 Offset: 0x120C430 VA: 0x18120DA30
	|-TMP_TextProcessingStack<object>.Remove
	|
	|-RVA: 0x120D4D0 Offset: 0x120BED0 VA: 0x18120D4D0
	|-TMP_TextProcessingStack<float>.Remove
	|
	|-RVA: 0x120D460 Offset: 0x120BE60 VA: 0x18120D460
	|-TMP_TextProcessingStack<WordWrapState>.Remove
	|
	|-RVA: 0x120D5D0 Offset: 0x120BFD0 VA: 0x18120D5D0
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120C850 Offset: 0x120B250 VA: 0x18120C850
	|-TMP_TextProcessingStack<Color32>.Push
	|
	|-RVA: 0x120C780 Offset: 0x120B180 VA: 0x18120C780
	|-TMP_TextProcessingStack<HighlightState>.Push
	|
	|-RVA: 0x120CB60 Offset: 0x120B560 VA: 0x18120CB60
	|-TMP_TextProcessingStack<int>.Push
	|-TMP_TextProcessingStack<Int32Enum>.Push
	|
	|-RVA: 0x120C680 Offset: 0x120B080 VA: 0x18120C680
	|-TMP_TextProcessingStack<MaterialReference>.Push
	|
	|-RVA: 0x120C910 Offset: 0x120B310 VA: 0x18120C910
	|-TMP_TextProcessingStack<object>.Push
	|
	|-RVA: 0x120D320 Offset: 0x120BD20 VA: 0x18120D320
	|-TMP_TextProcessingStack<float>.Push
	|
	|-RVA: 0x120C9F0 Offset: 0x120B3F0 VA: 0x18120C9F0
	|-TMP_TextProcessingStack<WordWrapState>.Push
	|
	|-RVA: 0x120CC20 Offset: 0x120B620 VA: 0x18120CC20
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120B4A0 Offset: 0x1209EA0 VA: 0x18120B4A0
	|-TMP_TextProcessingStack<Color32>.Pop
	|
	|-RVA: 0x120B530 Offset: 0x1209F30 VA: 0x18120B530
	|-TMP_TextProcessingStack<HighlightState>.Pop
	|
	|-RVA: 0x120B410 Offset: 0x1209E10 VA: 0x18120B410
	|-TMP_TextProcessingStack<int>.Pop
	|-TMP_TextProcessingStack<Int32Enum>.Pop
	|
	|-RVA: 0x120B600 Offset: 0x120A000 VA: 0x18120B600
	|-TMP_TextProcessingStack<MaterialReference>.Pop
	|
	|-RVA: 0x120C1C0 Offset: 0x120ABC0 VA: 0x18120C1C0
	|-TMP_TextProcessingStack<object>.Pop
	|
	|-RVA: 0x120C120 Offset: 0x120AB20 VA: 0x18120C120
	|-TMP_TextProcessingStack<float>.Pop
	|
	|-RVA: 0x120B750 Offset: 0x120A150 VA: 0x18120B750
	|-TMP_TextProcessingStack<WordWrapState>.Pop
	|
	|-RVA: 0x120B9C0 Offset: 0x120A3C0 VA: 0x18120B9C0
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120B1E0 Offset: 0x1209BE0 VA: 0x18120B1E0
	|-TMP_TextProcessingStack<Color32>.Peek
	|-TMP_TextProcessingStack<int>.Peek
	|-TMP_TextProcessingStack<Int32Enum>.Peek
	|
	|-RVA: 0x120B0B0 Offset: 0x1209AB0 VA: 0x18120B0B0
	|-TMP_TextProcessingStack<HighlightState>.Peek
	|
	|-RVA: 0x120B150 Offset: 0x1209B50 VA: 0x18120B150
	|-TMP_TextProcessingStack<MaterialReference>.Peek
	|
	|-RVA: 0x120B110 Offset: 0x1209B10 VA: 0x18120B110
	|-TMP_TextProcessingStack<object>.Peek
	|
	|-RVA: 0x120B220 Offset: 0x1209C20 VA: 0x18120B220
	|-TMP_TextProcessingStack<float>.Peek
	|
	|-RVA: 0x120AFE0 Offset: 0x12099E0 VA: 0x18120AFE0
	|-TMP_TextProcessingStack<WordWrapState>.Peek
	|
	|-RVA: 0x120B260 Offset: 0x1209C60 VA: 0x18120B260
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Peek
	*/

	// RVA: -1 Offset: -1
	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120AD30 Offset: 0x1209730 VA: 0x18120AD30
	|-TMP_TextProcessingStack<Color32>.CurrentItem
	|-TMP_TextProcessingStack<int>.CurrentItem
	|-TMP_TextProcessingStack<Int32Enum>.CurrentItem
	|
	|-RVA: 0x120ACC0 Offset: 0x12096C0 VA: 0x18120ACC0
	|-TMP_TextProcessingStack<HighlightState>.CurrentItem
	|
	|-RVA: 0x120ABD0 Offset: 0x12095D0 VA: 0x18120ABD0
	|-TMP_TextProcessingStack<MaterialReference>.CurrentItem
	|
	|-RVA: 0x120AC70 Offset: 0x1209670 VA: 0x18120AC70
	|-TMP_TextProcessingStack<object>.CurrentItem
	|
	|-RVA: 0x120AF40 Offset: 0x1209940 VA: 0x18120AF40
	|-TMP_TextProcessingStack<float>.CurrentItem
	|
	|-RVA: 0x120AF90 Offset: 0x1209990 VA: 0x18120AF90
	|-TMP_TextProcessingStack<WordWrapState>.CurrentItem
	|
	|-RVA: 0x120AD80 Offset: 0x1209780 VA: 0x18120AD80
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.CurrentItem
	*/

	// RVA: -1 Offset: -1
	public T PreviousItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120C2E0 Offset: 0x120ACE0 VA: 0x18120C2E0
	|-TMP_TextProcessingStack<Color32>.PreviousItem
	|-TMP_TextProcessingStack<int>.PreviousItem
	|-TMP_TextProcessingStack<Int32Enum>.PreviousItem
	|
	|-RVA: 0x120C270 Offset: 0x120AC70 VA: 0x18120C270
	|-TMP_TextProcessingStack<HighlightState>.PreviousItem
	|
	|-RVA: 0x120C590 Offset: 0x120AF90 VA: 0x18120C590
	|-TMP_TextProcessingStack<MaterialReference>.PreviousItem
	|
	|-RVA: 0x120C630 Offset: 0x120B030 VA: 0x18120C630
	|-TMP_TextProcessingStack<object>.PreviousItem
	|
	|-RVA: 0x120C4F0 Offset: 0x120AEF0 VA: 0x18120C4F0
	|-TMP_TextProcessingStack<float>.PreviousItem
	|
	|-RVA: 0x120C540 Offset: 0x120AF40 VA: 0x18120C540
	|-TMP_TextProcessingStack<WordWrapState>.PreviousItem
	|
	|-RVA: 0x120C330 Offset: 0x120AD30 VA: 0x18120C330
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.PreviousItem
	*/
}
