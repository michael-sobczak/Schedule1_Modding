using System;

namespace S1API.Quests.Identifiers;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public sealed class QuestNameAttribute : Attribute
{
	public string Name { get; }

	public QuestNameAttribute(string name)
	{
		Name = name;
	}
}
