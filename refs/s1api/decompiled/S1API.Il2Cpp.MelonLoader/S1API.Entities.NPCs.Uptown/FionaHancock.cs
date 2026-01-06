using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class FionaHancock : NPC
{
	public new static string NPCId => "fiona_hancock";

	internal FionaHancock()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "fiona_hancock"))
	{
	}
}
