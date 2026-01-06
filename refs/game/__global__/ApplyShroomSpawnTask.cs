public class ApplyShroomSpawnTask : Task // TypeDefIndex: 785
{
	// Fields
	private const float DistanceBetweenMixes = 0.08;
	private const float MixRadius = 0.1;
	private const int MaskTextureSize = 128;
	private const int SmallChunkCount = 16;
	private ShroomSpawnDefinition _spawnDefinition; // 0xA0
	private MushroomBed _mushroomBed; // 0xA8
	private SpawnChunk _baseSpawnChunk; // 0xB0
	private ApplyShroomSpawnTask.EStage _currentStage; // 0xB8
	private DecalProjector _mixProjector; // 0xC0
	private Vector3 _lastMixPosition; // 0xC8
	private Texture2D _maskingTexture; // 0xD8
	private List<SpawnChunk> _mixedChunks; // 0xE0
	private bool _mixMouseUp; // 0xE8

	// Methods

	// RVA: 0x584F00 Offset: 0x583900 VA: 0x180584F00
	public void .ctor(MushroomBed mushroomBed, ShroomSpawnDefinition spawnDefinition) { }

	// RVA: 0x583FA0 Offset: 0x5829A0 VA: 0x180583FA0 Slot: 6
	public override void StopTask() { }

	// RVA: 0x584320 Offset: 0x582D20 VA: 0x180584320 Slot: 7
	public override void Success() { }

	// RVA: 0x584E60 Offset: 0x583860 VA: 0x180584E60 Slot: 9
	public override void Update() { }

	// RVA: 0x583AF0 Offset: 0x5824F0 VA: 0x180583AF0 Slot: 11
	public override void LateUpdate() { }

	// RVA: 0x584A80 Offset: 0x583480 VA: 0x180584A80
	private void UpdateInstructionText() { }

	// RVA: 0x584C60 Offset: 0x583660 VA: 0x180584C60
	private void UpdateProgression() { }

	// RVA: 0x583750 Offset: 0x582150 VA: 0x180583750
	private bool GetCursorHoverOnSoil(out Vector3 hitPoint) { }

	// RVA: 0x584550 Offset: 0x582F50 VA: 0x180584550
	private void TriggerMix(Vector3 mixPoint) { }

	// RVA: 0x583DA0 Offset: 0x5827A0 VA: 0x180583DA0
	private void PaintMask(int x, int y) { }

	// RVA: 0x583680 Offset: 0x582080 VA: 0x180583680
	private Texture2D CreateMaskTexture() { }
}
