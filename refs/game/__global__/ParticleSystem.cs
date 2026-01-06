public sealed class ParticleSystem : Component // TypeDefIndex: 18942
{
	// Properties
	[Obsolete("startColor property is deprecated. Use main.startColor instead.", False)]
	public Color startColor { get; set; }
	public bool isPlaying { get; }
	public bool isEmitting { get; }
	public int particleCount { get; }
	public float time { get; }
	public uint randomSeed { set; }
	public bool useAutoRandomSeed { get; set; }
	public ParticleSystem.MainModule main { get; }
	public ParticleSystem.EmissionModule emission { get; }
	public ParticleSystem.ShapeModule shape { get; }
	public ParticleSystem.VelocityOverLifetimeModule velocityOverLifetime { get; }
	public ParticleSystem.CollisionModule collision { get; }
	public ParticleSystem.TriggerModule trigger { get; }
	public ParticleSystem.SubEmittersModule subEmitters { get; }

	// Methods

	[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	// RVA: 0x2D2CB10 Offset: 0x2D2B510 VA: 0x182D2CB10
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	// RVA: 0x2D2CCC0 Offset: 0x2D2B6C0 VA: 0x182D2CCC0
	public void Emit(ParticleSystem.Particle particle) { }

	// RVA: 0x2D2D140 Offset: 0x2D2BB40 VA: 0x182D2D140
	public Color get_startColor() { }

	// RVA: 0x2D2D280 Offset: 0x2D2BC80 VA: 0x182D2D280
	public void set_startColor(Color value) { }

	[NativeName("SyncJobs(false)->IsPlaying")]
	// RVA: 0x2D2D0C0 Offset: 0x2D2BAC0 VA: 0x182D2D0C0
	public bool get_isPlaying() { }

	[NativeName("SyncJobs(false)->IsEmitting")]
	// RVA: 0x2D2D080 Offset: 0x2D2BA80 VA: 0x182D2D080
	public bool get_isEmitting() { }

	[NativeName("SyncJobs(false)->GetParticleCount")]
	// RVA: 0x2D2D100 Offset: 0x2D2BB00 VA: 0x182D2D100
	public int get_particleCount() { }

	[NativeName("SyncJobs(false)->GetSecPosition")]
	// RVA: 0x2D2D1C0 Offset: 0x2D2BBC0 VA: 0x182D2D1C0
	public float get_time() { }

	[NativeName("SyncJobs(false)->SetRandomSeed")]
	// RVA: 0x2D2D240 Offset: 0x2D2BC40 VA: 0x182D2D240
	public void set_randomSeed(uint value) { }

	[NativeName("GetAutoRandomSeed")]
	// RVA: 0x2D2D200 Offset: 0x2D2BC00 VA: 0x182D2D200
	public bool get_useAutoRandomSeed() { }

	[NativeName("SyncJobs(false)->SetAutoRandomSeed")]
	// RVA: 0x2D2D360 Offset: 0x2D2BD60 VA: 0x182D2D360
	public void set_useAutoRandomSeed(bool value) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = True)]
	// RVA: 0x2D2CE00 Offset: 0x2D2B800 VA: 0x182D2CE00
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	// RVA: 0x2D2CF20 Offset: 0x2D2B920 VA: 0x182D2CF20
	public void Simulate(float t, bool withChildren, bool restart) { }

	// RVA: 0x2D2CEC0 Offset: 0x2D2B8C0 VA: 0x182D2CEC0
	public void Simulate(float t, bool withChildren) { }

	// RVA: 0x2D2CE70 Offset: 0x2D2B870 VA: 0x182D2CE70
	public void Simulate(float t) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = True)]
	// RVA: 0x2D2CD70 Offset: 0x2D2B770 VA: 0x182D2CD70
	public void Play(bool withChildren) { }

	// RVA: 0x2D2CDC0 Offset: 0x2D2B7C0 VA: 0x182D2CDC0
	public void Play() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = True)]
	// RVA: 0x2D2D020 Offset: 0x2D2BA20 VA: 0x182D2D020
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	// RVA: 0x2D2CFD0 Offset: 0x2D2B9D0 VA: 0x182D2CFD0
	public void Stop(bool withChildren) { }

	// RVA: 0x2D2CF90 Offset: 0x2D2B990 VA: 0x182D2CF90
	public void Stop() { }

	[RequiredByNativeCode]
	// RVA: 0x2D2CAD0 Offset: 0x2D2B4D0 VA: 0x182D2CAD0
	public void Emit(int count) { }

	[NativeName("SyncJobs()->Emit")]
	// RVA: 0x2D2CAD0 Offset: 0x2D2B4D0 VA: 0x182D2CAD0
	private void Emit_Internal(int count) { }

	[NativeName("SyncJobs()->EmitParticlesExternal")]
	// RVA: 0x2D2CD10 Offset: 0x2D2B710 VA: 0x182D2CD10
	public void Emit(ParticleSystem.EmitParams emitParams, int count) { }

	[NativeName("SyncJobs()->EmitParticleExternal")]
	// RVA: 0x2D2CA20 Offset: 0x2D2B420 VA: 0x182D2CA20
	private void EmitOld_Internal(ref ParticleSystem.Particle particle) { }

	// RVA: 0x1CF6580 Offset: 0x1CF4F80 VA: 0x181CF6580
	public ParticleSystem.MainModule get_main() { }

	// RVA: 0x1CF6580 Offset: 0x1CF4F80 VA: 0x181CF6580
	public ParticleSystem.EmissionModule get_emission() { }

	// RVA: 0x1CF6580 Offset: 0x1CF4F80 VA: 0x181CF6580
	public ParticleSystem.ShapeModule get_shape() { }

	// RVA: 0x1CF6580 Offset: 0x1CF4F80 VA: 0x181CF6580
	public ParticleSystem.VelocityOverLifetimeModule get_velocityOverLifetime() { }

	// RVA: 0x1CF6580 Offset: 0x1CF4F80 VA: 0x181CF6580
	public ParticleSystem.CollisionModule get_collision() { }

	// RVA: 0x1CF6580 Offset: 0x1CF4F80 VA: 0x181CF6580
	public ParticleSystem.TriggerModule get_trigger() { }

	// RVA: 0x1CF6580 Offset: 0x1CF4F80 VA: 0x181CF6580
	public ParticleSystem.SubEmittersModule get_subEmitters() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x2D2CA70 Offset: 0x2D2B470 VA: 0x182D2CA70
	private void Emit_Injected(ref ParticleSystem.EmitParams emitParams, int count) { }
}
