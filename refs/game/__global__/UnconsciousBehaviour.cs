public class UnconsciousBehaviour : Behaviour // TypeDefIndex: 1863
{
	// Fields
	public const float SnoreInterval = 6;
	public ParticleSystem Particles; // 0x168
	public bool PlaySnoreSounds; // 0x170
	private float timeOnLastSnore; // 0x174
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.UnconsciousBehaviourAssembly-CSharp.dll_Excuted; // 0x178
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.UnconsciousBehaviourAssembly-CSharp.dll_Excuted; // 0x179

	// Methods

	// RVA: 0x773EA0 Offset: 0x7728A0 VA: 0x180773EA0 Slot: 22
	public override void Activate() { }

	// RVA: 0x774180 Offset: 0x772B80 VA: 0x180774180 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x7742C0 Offset: 0x772CC0 VA: 0x1807742C0 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x73D060 Offset: 0x73BA60 VA: 0x18073D060 Slot: 21
	public override void Disable() { }

	// RVA: 0x763FC0 Offset: 0x7629C0 VA: 0x180763FC0
	public void .ctor() { }

	// RVA: 0x761DF0 Offset: 0x7607F0 VA: 0x180761DF0 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x761DD0 Offset: 0x7607D0 VA: 0x180761DD0 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
