public interface ITextEdition // TypeDefIndex: 6920
{
	// Properties
	internal abstract bool multiline { get; set; }
	public abstract bool isReadOnly { get; set; }
	public abstract int maxLength { get; set; }
	public abstract bool isDelayed { get; set; }
	internal abstract Func<char, bool> AcceptCharacter { get; set; }
	internal abstract Action<bool> UpdateScrollOffset { get; set; }
	internal abstract Action UpdateValueFromText { get; set; }
	internal abstract Action UpdateTextFromValue { get; set; }
	internal abstract Action MoveFocusToCompositeRoot { get; set; }
	public abstract char maskChar { set; }
	public abstract bool isPassword { get; set; }
	public virtual bool autoCorrection { get; set; }
	public virtual bool hideMobileInput { get; set; }
	public virtual TouchScreenKeyboardType keyboardType { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	internal abstract bool get_multiline();

	// RVA: -1 Offset: -1 Slot: 1
	internal abstract void set_multiline(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_isReadOnly();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_isReadOnly(bool value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_maxLength();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_maxLength(int value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_isDelayed();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_isDelayed(bool value);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void SaveValueAndText();

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void RestoreValueAndText();

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract Func<char, bool> get_AcceptCharacter();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract void set_AcceptCharacter(Func<char, bool> value);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract Action<bool> get_UpdateScrollOffset();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void set_UpdateScrollOffset(Action<bool> value);

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract Action get_UpdateValueFromText();

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract void set_UpdateValueFromText(Action value);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract Action get_UpdateTextFromValue();

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract void set_UpdateTextFromValue(Action value);

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract Action get_MoveFocusToCompositeRoot();

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract void set_MoveFocusToCompositeRoot(Action value);

	// RVA: -1 Offset: -1 Slot: 20
	internal abstract void UpdateText(string value);

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract string CullString(string s);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void set_maskChar(char value);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract bool get_isPassword();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void set_isPassword(bool value);

	// RVA: 0x2DDE040 Offset: 0x2DDCA40 VA: 0x182DDE040 Slot: 25
	public virtual bool get_autoCorrection() { }

	// RVA: 0x2DDE250 Offset: 0x2DDCC50 VA: 0x182DDE250 Slot: 26
	public virtual void set_autoCorrection(bool value) { }

	// RVA: 0x2DDE0F0 Offset: 0x2DDCAF0 VA: 0x182DDE0F0 Slot: 27
	public virtual bool get_hideMobileInput() { }

	// RVA: 0x2DDE300 Offset: 0x2DDCD00 VA: 0x182DDE300 Slot: 28
	public virtual void set_hideMobileInput(bool value) { }

	// RVA: 0x2DDE1A0 Offset: 0x2DDCBA0 VA: 0x182DDE1A0 Slot: 29
	public virtual TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x2DDE3B0 Offset: 0x2DDCDB0 VA: 0x182DDE3B0 Slot: 30
	public virtual void set_keyboardType(TouchScreenKeyboardType value) { }
}
