public enum ParticleSystemShapeType // TypeDefIndex: 18945
{
	// Fields
	public int value__; // 0x0
	public const ParticleSystemShapeType Sphere = 0;
	[Obsolete("SphereShell is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", False)]
	public const ParticleSystemShapeType SphereShell = 1;
	public const ParticleSystemShapeType Hemisphere = 2;
	[Obsolete("HemisphereShell is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", False)]
	public const ParticleSystemShapeType HemisphereShell = 3;
	public const ParticleSystemShapeType Cone = 4;
	public const ParticleSystemShapeType Box = 5;
	public const ParticleSystemShapeType Mesh = 6;
	[Obsolete("ConeShell is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", False)]
	public const ParticleSystemShapeType ConeShell = 7;
	public const ParticleSystemShapeType ConeVolume = 8;
	[Obsolete("ConeVolumeShell is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", False)]
	public const ParticleSystemShapeType ConeVolumeShell = 9;
	public const ParticleSystemShapeType Circle = 10;
	[Obsolete("CircleEdge is deprecated and does nothing. Please use ShapeModule.radiusThickness instead, to control edge emission.", False)]
	public const ParticleSystemShapeType CircleEdge = 11;
	public const ParticleSystemShapeType SingleSidedEdge = 12;
	public const ParticleSystemShapeType MeshRenderer = 13;
	public const ParticleSystemShapeType SkinnedMeshRenderer = 14;
	public const ParticleSystemShapeType BoxShell = 15;
	public const ParticleSystemShapeType BoxEdge = 16;
	public const ParticleSystemShapeType Donut = 17;
	public const ParticleSystemShapeType Rectangle = 18;
	public const ParticleSystemShapeType Sprite = 19;
	public const ParticleSystemShapeType SpriteRenderer = 20;
}
