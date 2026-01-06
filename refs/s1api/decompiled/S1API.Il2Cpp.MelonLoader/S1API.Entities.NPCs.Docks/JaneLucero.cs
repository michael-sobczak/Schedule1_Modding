using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class JaneLucero : NPC
{
	public new static string NPCId => "jane_lucero";

	internal JaneLucero()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "jane_lucero"))
	{
	}
}
