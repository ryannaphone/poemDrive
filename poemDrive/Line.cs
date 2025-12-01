using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poemDrive
{
    public class Line
    {
        int length;
        Word[] words;
        int syllables;
        String rhyme;
        

        public Line(Word[] words)
        {
            this.length = words.Length;
            this.words = words;
            for (int i = 0; i < words.Length; i++)
            {
                this.syllables += words[i].syllables;
            }
            //this.rhyme = words[words.Length].rhyme;
        }


        public Line(int length, Word[] words, int syllables, String rhyme) { 
            this.length = length;
            this.words = words;
            this.syllables = syllables;
            this.rhyme = rhyme;
        }

        public override string ToString()
        {
            String line = "";
            line += words[0].ToString(1) + " ";
            for (int i = 1; i < words.Count(); i++)
            {
                line += words[i].ToString(1).ToLower() + " ";
            }
            line = line.Substring(0, line.Length - 1);
            line += ".";
            return line;
        }

    }
}
