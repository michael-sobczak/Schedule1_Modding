using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class GregFliggle : NPC
{
	public new static string NPCId => "greg_fliggle";

	internal GregFliggle()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "greg_fliggle"))
	{
	}
}
