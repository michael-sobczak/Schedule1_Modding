public class DistanceCondition : ObserverCondition // TypeDefIndex: 12656
{
	// Fields
	[Tooltip("Maximum distance a client must be within this object to see it.")]
	[SerializeField]
	private float _maximumDistance; // 0x28
	[Tooltip("Additional percent of distance client must be until this object is hidden. For example, if distance was 100f and percent was 0.5f the client must be 150f units away before this object is hidden again. This can be useful for keeping objects from regularly appearing and disappearing.")]
	[Range(0, 1)]
	[SerializeField]
	private float _hideDistancePercent; // 0x2C
	[Obsolete("UpdateFrequency is no longer used.")]
	[HideInInspector]
	public float UpdateFrequency; // 0x30
	private Dictionary<NetworkConnection, float> _timedUpdates; // 0x38

	// Properties
	public float MaximumDistance { get; set; }

	// Methods

	// RVA: 0x5260F0 Offset: 0x524AF0 VA: 0x1805260F0
	public float get_MaximumDistance() { }

	// RVA: 0x54B820 Offset: 0x54A220 VA: 0x18054B820
	public void set_MaximumDistance(float value) { }

	// RVA: 0x54B820 Offset: 0x54A220 VA: 0x18054B820
	public void ConditionConstructor(float maximumDistance) { }

	// RVA: 0xD27980 Offset: 0xD26380 VA: 0x180D27980 Slot: 6
	public override bool ConditionMet(NetworkConnection connection, bool currentlyAdded, out bool notProcessed) { }

	// RVA: 0xD27BD0 Offset: 0xD265D0 VA: 0x180D27BD0 Slot: 8
	public override ObserverConditionType GetConditionType() { }

	// RVA: 0xD27930 Offset: 0xD26330 VA: 0x180D27930 Slot: 9
	public override ObserverCondition Clone() { }

	// RVA: 0xD27BE0 Offset: 0xD265E0 VA: 0x180D27BE0
	public void .ctor() { }
}
