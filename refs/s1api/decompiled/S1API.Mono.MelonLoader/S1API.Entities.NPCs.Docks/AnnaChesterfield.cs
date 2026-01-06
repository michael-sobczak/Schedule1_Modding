using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Docks;

public class AnnaChesterfield : NPC
{
	public new static string NPCId => "anna_chesterfield";

	internal AnnaChesterfield()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "anna_chesterfield"))
	{
	}
}
