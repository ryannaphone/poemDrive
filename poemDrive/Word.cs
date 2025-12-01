using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poemDrive
{
    public class Word
    {
       public String text;
       public int length;
       public int syllables;
       public String rhyme;
       public String tone;

        public Word(string text) : this(text, text.Length, -1, "orange", "")
        {
            
        }

        public Word(string text, int syllables, string rhyme) : this(text, text.Length, syllables, rhyme, "")
        {

        }

        public Word(string text, int length, int syllables, string rhyme, string tone)
        {
            this.text = text;
            this.length = length;
            this.syllables = syllables;
            this.rhyme = rhyme;
            this.tone = tone;
        }

        public string ToString(int mode)
        {
            switch (mode)
            {
                case 0:
                    return this.text + ", type : " + this.GetType().ToString();
                case 1:
                    return this.text;
                case 2:
                    return this.text + " (" + this.GetType().ToString().Substring(this.GetType().ToString().IndexOf(".") + 1, 1) + ")";
                default:
                    return this.text;


            }

        }
    }

    public class Noun : Word
    {
        public String type;
        public Boolean plural;

        public Noun(string text) : base(text)
        {

        }

        public Noun(string text, int length, int syllables,  String rhyme, String tone, String type) : base(text, length, syllables, rhyme, tone )
        {
            this.type = type;
        }
    }

    public class Adjective : Word
    {
        public String type;

        public Adjective(string text) : base(text)
        {

        }

        public Adjective(string text, int length, int syllables, String rhyme, String tone, String type) : base(text, length, syllables, rhyme, tone)
        {
            this.type = type;
        }
    }

    public class Verb : Word
    {
        public String tense;

        public Verb(String text) : base(text)
        {

        }

        public Verb(string text, int length, int syllables, String rhyme, String tone, String tense) : base(text, length, syllables, rhyme, tone)
        {
            this.tense = tense;
        }
    }

    public class Conjunction : Word
    {

        public Conjunction(String text) : base(text) 
        {

        }
        public Conjunction(string text, int length, int syllables, string rhyme, string tone) : base(text, length, syllables, rhyme, tone)
        {
        }
    }

    public class Pronoun : Noun
    {
        public Pronoun(string text, int length, int syllables, string rhyme, string tone, string type) : base(text, length, syllables, rhyme, tone, type)
        {
        }
    }

    public class Interjection : Word
    {
        public Interjection(string text, int length, int syllables, string rhyme, string tone) : base(text, length, syllables, rhyme, tone)
        {
        }
    }

    public class Adverb : Word
    {
        public Adverb(String text) : base(text)
        {

        }
        public Adverb(string text, int length, int syllables, string rhyme, string tone) : base(text, length, syllables, rhyme, tone)
        {
        }
    }

    public class Preposition : Word
    {
        public Preposition(String text) : base(text)
        {

        }

        public Preposition(string text, int length, int syllables, string rhyme, string tone) : base(text, length, syllables, rhyme, tone)
        {
        }
    }

    public class Article : Word
    {
        public Article(String text) : base(text)
        {

        }
        public Article(string text, int length, int syllables, string rhyme, string tone) : base(text, length, syllables, rhyme, tone)
        {
        }
    }

    public class QuestionWord : Word
    {
        public QuestionWord(String text) : base(text)
        {

        }
    }

    


}
