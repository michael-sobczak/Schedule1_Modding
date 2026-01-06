public class CGSpots : CGData // TypeDefIndex: 10658
{
	// Fields
	private SubArray<CGSpot> spots; // 0x20

	// Properties
	public SubArray<CGSpot> Spots { get; set; }
	[Obsolete("Use Spots instead")]
	[UsedImplicitly]
	public CGSpot[] Points { get; set; }
	public override int Count { get; }

	// Methods

	// RVA: 0x4976D0 Offset: 0x4960D0 VA: 0x1804976D0
	public SubArray<CGSpot> get_Spots() { }

	// RVA: 0x4FBC40 Offset: 0x4FA640 VA: 0x1804FBC40
	public void set_Spots(SubArray<CGSpot> value) { }

	// RVA: 0x4FBA60 Offset: 0x4FA460 VA: 0x1804FBA60
	public CGSpot[] get_Points() { }

	// RVA: 0x4FBB10 Offset: 0x4FA510 VA: 0x1804FBB10
	public void set_Points(CGSpot[] value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430 Slot: 6
	public override int get_Count() { }

	// RVA: 0x4FB740 Offset: 0x4FA140 VA: 0x1804FB740
	public void .ctor() { }

	// RVA: 0x4FB570 Offset: 0x4F9F70 VA: 0x1804FB570
	public void .ctor(CGSpot[] points) { }

	// RVA: 0x4FB840 Offset: 0x4FA240 VA: 0x1804FB840
	public void .ctor(SubArray<CGSpot> spots) { }

	// RVA: 0x4FB5F0 Offset: 0x4F9FF0 VA: 0x1804FB5F0
	public void .ctor(List<CGSpot> spots) { }

	// RVA: 0x4FB880 Offset: 0x4FA280 VA: 0x1804FB880
	public void .ctor(List<CGSpot>[] spots) { }

	// RVA: 0x4FB410 Offset: 0x4F9E10 VA: 0x1804FB410
	public void .ctor(CGSpots source) { }

	// RVA: 0x4FB320 Offset: 0x4F9D20 VA: 0x1804FB320 Slot: 5
	protected override bool Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 7
	public override T Clone<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5CAE0 Offset: 0xE5B4E0 VA: 0x180E5CAE0
	|-CGSpots.Clone<object>
	*/
}
