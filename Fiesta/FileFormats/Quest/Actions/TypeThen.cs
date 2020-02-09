namespace Fiesta.FileFormats.Quest.Actions
{
    public enum TypeThen : byte
    {
        None = 0x0,
        DropItem = 0x1,
        DoScenario = 0x2,
        MobRegen = 0x3,
        CallPS = 0x4
    }
}