public class SkyProfile : ScriptableObject // TypeDefIndex: 463
{
	// Fields
	public const string DefaultShaderName = "Funly/Sky Studio/Skybox/3D Standard";
	public const string DefaultLegacyShaderName = "Funly/Sky Studio/Skybox/3D Standard - Global Keywords";
	[SerializeField]
	private Material m_SkyboxMaterial; // 0x18
	[SerializeField]
	private string m_ShaderName; // 0x20
	public IProfileDefinition profileDefinition; // 0x28
	public List<string> timelineManagedKeys; // 0x30
	public KeyframeGroupDictionary keyframeGroups; // 0x38
	public BoolDictionary featureStatus; // 0x40
	public LightningArtSet lightningArtSet; // 0x48
	public RainSplashArtSet rainSplashArtSet; // 0x50
	public Texture2D starLayer1DataTexture; // 0x58
	public Texture2D starLayer2DataTexture; // 0x60
	public Texture2D starLayer3DataTexture; // 0x68
	[SerializeField]
	private int m_ProfileVersion; // 0x70
	private Dictionary<string, ProfileGroupDefinition> m_KeyToGroupInfo; // 0x78

	// Properties
	public Material skyboxMaterial { get; set; }
	public string shaderName { get; }
	public ProfileGroupSection[] groupDefinitions { get; }
	public ProfileFeatureSection[] featureDefinitions { get; }

	// Methods

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Material get_skyboxMaterial() { }

	// RVA: 0x9E77F0 Offset: 0x9E61F0 VA: 0x1809E77F0
	public void set_skyboxMaterial(Material value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_shaderName() { }

	// RVA: 0x9E7720 Offset: 0x9E6120 VA: 0x1809E7720
	public ProfileGroupSection[] get_groupDefinitions() { }

	// RVA: 0x9E76D0 Offset: 0x9E60D0 VA: 0x1809E76D0
	public ProfileFeatureSection[] get_featureDefinitions() { }

	// RVA: 0x9E6000 Offset: 0x9E4A00 VA: 0x1809E6000
	public float GetNumberPropertyValue(string propertyKey) { }

	// RVA: 0x9E6010 Offset: 0x9E4A10 VA: 0x1809E6010
	public float GetNumberPropertyValue(string propertyKey, float timeOfDay) { }

	// RVA: 0x9E58B0 Offset: 0x9E42B0 VA: 0x1809E58B0
	public Color GetColorPropertyValue(string propertyKey) { }

	// RVA: 0x9E58E0 Offset: 0x9E42E0 VA: 0x1809E58E0
	public Color GetColorPropertyValue(string propertyKey, float timeOfDay) { }

	// RVA: 0x9E64B0 Offset: 0x9E4EB0 VA: 0x1809E64B0
	public Texture GetTexturePropertyValue(string propertyKey) { }

	// RVA: 0x9E62F0 Offset: 0x9E4CF0 VA: 0x1809E62F0
	public Texture GetTexturePropertyValue(string propertyKey, float timeOfDay) { }

	// RVA: 0x9E6210 Offset: 0x9E4C10 VA: 0x1809E6210
	public SpherePoint GetSpherePointPropertyValue(string propertyKey) { }

	// RVA: 0x9E6220 Offset: 0x9E4C20 VA: 0x1809E6220
	public SpherePoint GetSpherePointPropertyValue(string propertyKey, float timeOfDay) { }

	// RVA: 0x9E58A0 Offset: 0x9E42A0 VA: 0x1809E58A0
	public bool GetBoolPropertyValue(string propertyKey) { }

	// RVA: 0x9E57D0 Offset: 0x9E41D0 VA: 0x1809E57D0
	public bool GetBoolPropertyValue(string propertyKey, float timeOfDay) { }

	// RVA: 0x9E7590 Offset: 0x9E5F90 VA: 0x1809E7590
	public void .ctor() { }

	// RVA: 0x9E6E00 Offset: 0x9E5800 VA: 0x1809E6E00
	private void OnEnable() { }

	// RVA: 0x9E6FE0 Offset: 0x9E59E0 VA: 0x1809E6FE0
	private void ReloadFullProfile() { }

	// RVA: 0x9E6F50 Offset: 0x9E5950 VA: 0x1809E6F50
	private void ReloadDefinitions() { }

	// RVA: 0x9E6190 Offset: 0x9E4B90 VA: 0x1809E6190
	private IProfileDefinition GetShaderInfoForMaterial(string shaderName) { }

	// RVA: 0x9E6C20 Offset: 0x9E5620 VA: 0x1809E6C20
	public void MergeProfileWithDefinitions() { }

	// RVA: 0x9E67B0 Offset: 0x9E51B0 VA: 0x1809E67B0
	public void MergeGroupsWithDefinitions() { }

	// RVA: 0x9E64C0 Offset: 0x9E4EC0 VA: 0x1809E64C0
	public Dictionary<string, ProfileGroupDefinition> GroupDefinitionDictionary() { }

	// RVA: 0x9E60E0 Offset: 0x9E4AE0 VA: 0x1809E60E0
	public ProfileGroupSection[] ProfileDefinitionTable() { }

	// RVA: 0x9E5280 Offset: 0x9E3C80 VA: 0x1809E5280
	private void AddNumericGroup(string propKey, string groupName, float min, float max, float value) { }

	// RVA: 0x9E5130 Offset: 0x9E3B30 VA: 0x1809E5130
	private void AddColorGroup(string propKey, string groupName, Color color) { }

	// RVA: 0x9E55C0 Offset: 0x9E3FC0 VA: 0x1809E55C0
	private void AddTextureGroup(string propKey, string groupName, Texture2D texture) { }

	// RVA: 0x9E53F0 Offset: 0x9E3DF0 VA: 0x1809E53F0
	private void AddSpherePointGroup(string propKey, string groupName, SpherePoint point) { }

	// RVA: 0x9E4FF0 Offset: 0x9E39F0 VA: 0x1809E4FF0
	private void AddBooleanGroup(string propKey, string groupName, bool value) { }

	// RVA: -1 Offset: -1
	public T GetGroup<T>(string propertyKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF4EB10 Offset: 0xF4D510 VA: 0x180F4EB10
	|-SkyProfile.GetGroup<object>
	*/

	// RVA: 0x9E5FE0 Offset: 0x9E49E0 VA: 0x1809E5FE0
	public IKeyframeGroup GetGroup(string propertyKey) { }

	// RVA: 0x9E5DB0 Offset: 0x9E47B0 VA: 0x1809E5DB0
	public IKeyframeGroup GetGroupWithId(string groupId) { }

	// RVA: 0x9E60E0 Offset: 0x9E4AE0 VA: 0x1809E60E0
	public ProfileGroupSection[] GetProfileDefinitions() { }

	// RVA: 0x9E60F0 Offset: 0x9E4AF0 VA: 0x1809E60F0
	public ProfileGroupSection GetSectionInfo(string sectionKey) { }

	// RVA: 0x9E6750 Offset: 0x9E5150 VA: 0x1809E6750
	public bool IsManagedByTimeline(string propertyKey) { }

	// RVA: 0x9E7280 Offset: 0x9E5C80 VA: 0x1809E7280
	public void ValidateTimelineGroupKeys() { }

	// RVA: 0x9E5A40 Offset: 0x9E4440 VA: 0x1809E5A40
	public List<ProfileGroupDefinition> GetGroupDefinitionsManagedByTimeline() { }

	// RVA: 0x9E5C30 Offset: 0x9E4630 VA: 0x1809E5C30
	public List<ProfileGroupDefinition> GetGroupDefinitionsNotManagedByTimeline() { }

	// RVA: 0x9E59C0 Offset: 0x9E43C0 VA: 0x1809E59C0
	public ProfileGroupDefinition GetGroupDefinitionForKey(string propertyKey) { }

	// RVA: 0x9E6E10 Offset: 0x9E5810 VA: 0x1809E6E10
	public void RebuildKeyToGroupInfoMapping() { }

	// RVA: 0x9E7210 Offset: 0x9E5C10 VA: 0x1809E7210
	public void TrimGroupToSingleKeyframe(string propertyKey) { }

	// RVA: 0x9E5710 Offset: 0x9E4110 VA: 0x1809E5710
	public bool CanGroupBeOnTimeline(ProfileGroupDefinition definition) { }

	// RVA: 0x9E6C40 Offset: 0x9E5640 VA: 0x1809E6C40
	protected void MergeShaderKeywordsWithDefinitions() { }

	// RVA: 0x9E65F0 Offset: 0x9E4FF0 VA: 0x1809E65F0
	public bool IsFeatureEnabled(string featureKey, bool recursive = True) { }

	// RVA: 0x9E7150 Offset: 0x9E5B50 VA: 0x1809E7150
	public void SetFeatureEnabled(string featureKey, bool value) { }
}
