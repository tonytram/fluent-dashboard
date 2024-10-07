using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common.Entities;
using Domain.Enums;

namespace Domain.Entities
{
    public class Word : OwnerPropertyEntity
    {
        public required string WordText { get; set; }
        public required string VMeaning { get; set; }
        public required string EMeaning { get; set; }
        public required PartOfSpeechEnum PartOfSpeech { get; set; }
        public required string Pronunciation { get; set; }  // For phonetic transcription (e.g., /ˈwɜːd/)

        public required ICollection<ExampleSentence> ExampleSentences { get; set; }
        public required ICollection<Tag> Tags { get; set; }
        public required ICollection<WordLevel> WordLevels { get; set; }
        public ICollection<ArticleWord>? ArticleWords { get; set; }
        public ICollection<LearningProgress>? LearningProgresses { get; set; }
    }
}
