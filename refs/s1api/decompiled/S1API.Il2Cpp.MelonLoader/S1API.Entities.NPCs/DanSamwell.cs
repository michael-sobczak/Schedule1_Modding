using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs;

public class DanSamwell : NPC
{
	public new static string NPCId => "dan_samwell";

	internal DanSamwell()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "dan_samwell"))
	{
	}
}
