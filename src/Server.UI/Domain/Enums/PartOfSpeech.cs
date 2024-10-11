using System.ComponentModel;

namespace Domain.Enums
{
    public enum PartOfSpeechEnum
    {
        [Description("n.")] Noun,
        [Description("v.")] Verb,
        [Description("adj.")] Adjective,
        [Description("adv.")] Adverb,
        [Description("prop.")] Proposition,
    }
}
