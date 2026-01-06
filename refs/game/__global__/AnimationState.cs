public sealed class AnimationState : TrackedReference // TypeDefIndex: 18283
{
	// Properties
	public bool enabled { set; }
	public float weight { set; }
	public float time { set; }
	public float normalizedTime { get; set; }
	public float speed { set; }
	public float length { get; }
	public int layer { set; }
	public AnimationClip clip { get; }
	public string name { get; }

	// Methods

	// RVA: 0x2C765F0 Offset: 0x2C74FF0 VA: 0x182C765F0
	public void set_enabled(bool value) { }

	// RVA: 0x2C76770 Offset: 0x2C75170 VA: 0x182C76770
	public void set_weight(float value) { }

	// RVA: 0x2C76720 Offset: 0x2C75120 VA: 0x182C76720
	public void set_time(float value) { }

	// RVA: 0x2C765B0 Offset: 0x2C74FB0 VA: 0x182C765B0
	public float get_normalizedTime() { }

	// RVA: 0x2C76680 Offset: 0x2C75080 VA: 0x182C76680
	public void set_normalizedTime(float value) { }

	// RVA: 0x2C766D0 Offset: 0x2C750D0 VA: 0x182C766D0
	public void set_speed(float value) { }

	// RVA: 0x2C76530 Offset: 0x2C74F30 VA: 0x182C76530
	public float get_length() { }

	// RVA: 0x2C76640 Offset: 0x2C75040 VA: 0x182C76640
	public void set_layer(int value) { }

	// RVA: 0x2C764F0 Offset: 0x2C74EF0 VA: 0x182C764F0
	public AnimationClip get_clip() { }

	// RVA: 0x2C76570 Offset: 0x2C74F70 VA: 0x182C76570
	public string get_name() { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }
}
