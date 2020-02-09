namespace Fiesta.FileFormats.Quest.Actions
{
    //TODO: Figure out if this is used in QuestAction
    public enum TargetType : byte
    {
        TargetType = 0x0,
        MobGradeType = 0x1,
        MobType = 0x2,
        ChrClassType = 0x3,
        MaxActionTargetType = 0x4
    };
}