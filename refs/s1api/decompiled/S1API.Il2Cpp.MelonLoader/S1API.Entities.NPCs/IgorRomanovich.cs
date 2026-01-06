using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs;

public class IgorRomanovich : NPC
{
	public new static string NPCId => "igor_romanovich";

	internal IgorRomanovich()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "igor_romanovich"))
	{
	}
}
