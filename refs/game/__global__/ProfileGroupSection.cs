public class ProfileGroupSection // TypeDefIndex: 449
{
	// Fields
	public string sectionTitle; // 0x10
	public string sectionIcon; // 0x18
	public string sectionKey; // 0x20
	public string dependsOnFeature; // 0x28
	public bool dependsOnValue; // 0x30
	public ProfileGroupDefinition[] groups; // 0x38

	// Methods

	// RVA: 0x9E0B80 Offset: 0x9DF580 VA: 0x1809E0B80
	public void .ctor(string sectionTitle, string sectionKey, string sectionIcon, string dependsOnFeature, bool dependsOnValue, ProfileGroupDefinition[] groups) { }
}
