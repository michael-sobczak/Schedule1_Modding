public class SceneLookupData : IEquatable<SceneLookupData> // TypeDefIndex: 12777
{
	// Fields
	public int Handle; // 0x10
	public string Name; // 0x18
	private const string INVALID_SCENE = "One or more scene information entries contain invalid data and have been skipped.";

	// Properties
	public string NameOnly { get; }
	public bool IsValid { get; }

	// Methods

	// RVA: 0xD83570 Offset: 0xD81F70 VA: 0x180D83570
	public string get_NameOnly() { }

	// RVA: 0xD83510 Offset: 0xD81F10 VA: 0x180D83510
	public bool get_IsValid() { }

	// RVA: 0xD834B0 Offset: 0xD81EB0 VA: 0x180D834B0
	public void .ctor() { }

	// RVA: 0xD83330 Offset: 0xD81D30 VA: 0x180D83330
	public void .ctor(Scene scene) { }

	// RVA: 0xD832C0 Offset: 0xD81CC0 VA: 0x180D832C0
	public void .ctor(string name) { }

	// RVA: 0xD833C0 Offset: 0xD81DC0 VA: 0x180D833C0
	public void .ctor(int handle) { }

	// RVA: 0xD83430 Offset: 0xD81E30 VA: 0x180D83430
	public void .ctor(int handle, string name) { }

	// RVA: 0xD83680 Offset: 0xD82080 VA: 0x180D83680
	public static bool op_Equality(SceneLookupData sldA, SceneLookupData sldB) { }

	// RVA: 0xD83700 Offset: 0xD82100 VA: 0x180D83700
	public static bool op_Inequality(SceneLookupData sldA, SceneLookupData sldB) { }

	// RVA: 0xD82950 Offset: 0xD81350 VA: 0x180D82950 Slot: 4
	public bool Equals(SceneLookupData sld) { }

	// RVA: 0xD829A0 Offset: 0xD813A0 VA: 0x180D829A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC82B80 Offset: 0xC81580 VA: 0x180C82B80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xD82D80 Offset: 0xD81780 VA: 0x180D82D80 Slot: 3
	public override string ToString() { }

	// RVA: 0xD82780 Offset: 0xD81180 VA: 0x180D82780
	public static SceneLookupData CreateData(Scene scene) { }

	// RVA: 0xD82600 Offset: 0xD81000 VA: 0x180D82600
	public static SceneLookupData CreateData(string name) { }

	// RVA: 0xD826A0 Offset: 0xD810A0 VA: 0x180D826A0
	public static SceneLookupData CreateData(int handle) { }

	// RVA: 0xD82730 Offset: 0xD81130 VA: 0x180D82730
	public static SceneLookupData[] CreateData(List<Scene> scenes) { }

	// RVA: 0xD825B0 Offset: 0xD80FB0 VA: 0x180D825B0
	public static SceneLookupData[] CreateData(List<string> names) { }

	// RVA: 0xD82560 Offset: 0xD80F60 VA: 0x180D82560
	public static SceneLookupData[] CreateData(List<int> handles) { }

	// RVA: 0xD823E0 Offset: 0xD80DE0 VA: 0x180D823E0
	public static SceneLookupData[] CreateData(Scene[] scenes) { }

	// RVA: 0xD82250 Offset: 0xD80C50 VA: 0x180D82250
	public static SceneLookupData[] CreateData(string[] names) { }

	// RVA: 0xD82E00 Offset: 0xD81800 VA: 0x180D82E00
	public static SceneLookupData[] ValidateData(SceneLookupData data) { }

	// RVA: 0xD82EB0 Offset: 0xD818B0 VA: 0x180D82EB0
	public static SceneLookupData[] ValidateData(SceneLookupData[] datas) { }

	// RVA: 0xD827E0 Offset: 0xD811E0 VA: 0x180D827E0
	public static SceneLookupData[] CreateData(int[] handles) { }

	// RVA: 0xD82CF0 Offset: 0xD816F0 VA: 0x180D82CF0
	private static string RemoveUnityExtension(string text) { }

	// RVA: 0xD82B30 Offset: 0xD81530 VA: 0x180D82B30
	public Scene GetScene(out bool foundByHandle, bool warnIfDuplicates = True) { }
}
