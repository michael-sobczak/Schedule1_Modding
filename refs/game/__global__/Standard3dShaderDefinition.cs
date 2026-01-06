public class Standard3dShaderDefinition : BaseShaderDefinition // TypeDefIndex: 462
{
	// Fields
	public const float MaxStarSize = 0.2;
	public const float MaxStarDensity = 1;
	public const float MinEdgeFeathering = 0.0001;
	public const float MinStarFadeBegin = -0.999;
	public const float MaxSpriteItems = 100000;
	public const float MinRotationSpeed = -10;
	public const float MaxRotationSpeed = 10;
	public const float MaxCloudRotationSpeed = 0.5;
	public const float MaxHDRValue = 25;

	// Methods

	// RVA: 0x9F19B0 Offset: 0x9F03B0 VA: 0x1809F19B0
	public void .ctor() { }

	// RVA: 0x9EF620 Offset: 0x9EE020 VA: 0x1809EF620 Slot: 8
	protected override ProfileFeatureSection[] ProfileFeatureSection() { }

	// RVA: 0x9E7F60 Offset: 0x9E6960 VA: 0x1809E7F60 Slot: 9
	protected override ProfileGroupSection[] ProfileDefinitionTable() { }
}
