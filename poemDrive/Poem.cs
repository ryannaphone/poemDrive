using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poemDrive
{
    public class Poem
    {
        public Line title;
        public Line[] lines;
        int length;
        int syllables;
        String[] rhyme;

        static int nextID = 0;

        public Poem()
        {

        }
        public Poem(Line[] lines)
        {
            this.lines = lines;
            this.title = new Line(new Word[] { new Word("Untitled"), new Word(nextID.ToString()) });
            nextID++;
        }

        public Poem(Line title, Line[] lines)
        {
            this.title = title;
            this.lines = lines;
        }

        public Poem(Line[] lines, int length, int syllables, string[] rhyme)
        {
            this.lines = lines;
            this.length = length;
            this.syllables = syllables;
            this.rhyme = rhyme;
        }
    }
}
