using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class KyleCooley : NPC
{
	public new static string NPCId => "kyle_cooley";

	internal KyleCooley()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "kyle_cooley"))
	{
	}
}
