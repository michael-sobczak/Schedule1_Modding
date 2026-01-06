internal enum CommandType // TypeDefIndex: 7094
{
	// Fields
	public int value__; // 0x0
	public const CommandType Draw = 0;
	public const CommandType ImmediateCull = 1;
	public const CommandType Immediate = 2;
	public const CommandType PushView = 3;
	public const CommandType PopView = 4;
	public const CommandType PushScissor = 5;
	public const CommandType PopScissor = 6;
	public const CommandType PushRenderTexture = 7;
	public const CommandType PopRenderTexture = 8;
	public const CommandType BlitToPreviousRT = 9;
	public const CommandType PushDefaultMaterial = 10;
	public const CommandType PopDefaultMaterial = 11;
}
