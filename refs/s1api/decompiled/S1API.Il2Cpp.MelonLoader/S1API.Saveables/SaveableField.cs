using System;

namespace S1API.Saveables;

[AttributeUsage(AttributeTargets.Field)]
public class SaveableField : Attribute
{
	internal string SaveName { get; }

	public SaveableField(string saveName)
	{
		SaveName = saveName;
	}
}
