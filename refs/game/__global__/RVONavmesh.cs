public class RVONavmesh : GraphModifier // TypeDefIndex: 13429
{
	// Fields
	public float wallHeight; // 0x40
	private readonly List<ObstacleVertex> obstacles; // 0x48
	private Simulator lastSim; // 0x50

	// Methods

	// RVA: 0x4DD630 Offset: 0x4DC030 VA: 0x1804DD630 Slot: 16
	public override void OnPostCacheLoad() { }

	// RVA: 0x4DD630 Offset: 0x4DC030 VA: 0x1804DD630 Slot: 18
	public override void OnGraphsPostUpdate() { }

	// RVA: 0xBC44A0 Offset: 0xBC2EA0 VA: 0x180BC44A0 Slot: 15
	public override void OnLatePostScan() { }

	// RVA: 0xBC4480 Offset: 0xBC2E80 VA: 0x180BC4480 Slot: 11
	protected override void OnDisable() { }

	// RVA: 0xBC4800 Offset: 0xBC3200 VA: 0x180BC4800
	public void RemoveObstacles() { }

	// RVA: 0xBC4240 Offset: 0xBC2C40 VA: 0x180BC4240
	private void AddGraphObstacles(Simulator sim, GridGraph grid) { }

	// RVA: 0xBC4160 Offset: 0xBC2B60 VA: 0x180BC4160
	private void AddGraphObstacles(Simulator simulator, INavmesh navmesh) { }

	// RVA: 0xBC49B0 Offset: 0xBC33B0 VA: 0x180BC49B0
	public void .ctor() { }
}
