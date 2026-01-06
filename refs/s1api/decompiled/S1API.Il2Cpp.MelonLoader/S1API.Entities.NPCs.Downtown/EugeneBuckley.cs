using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class EugeneBuckley : NPC
{
	public new static string NPCId => "eugene_buckley";

	internal EugeneBuckley()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "eugene_buckley"))
	{
	}
}
