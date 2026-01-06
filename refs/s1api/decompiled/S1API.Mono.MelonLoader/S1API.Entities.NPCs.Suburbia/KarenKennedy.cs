using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class KarenKennedy : NPC
{
	public new static string NPCId => "karen_kennedy";

	internal KarenKennedy()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "karen_kennedy"))
	{
	}
}
