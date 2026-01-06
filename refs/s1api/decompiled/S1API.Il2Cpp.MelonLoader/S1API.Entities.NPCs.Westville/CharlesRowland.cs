using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Westville;

public class CharlesRowland : NPC
{
	public new static string NPCId => "charles_rowland";

	internal CharlesRowland()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "charles_rowland"))
	{
	}
}
