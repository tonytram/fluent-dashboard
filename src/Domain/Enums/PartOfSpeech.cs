﻿using System.ComponentModel;

namespace FluentDashboard.Domain.Enums
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
