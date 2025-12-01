namespace poemDrive
{
    public partial class Form1 : Form
    {
        static int maxLines = 5;
        static int maxWords = 6;

        List<Poem> poems = new List<Poem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public List<Word> genWords()
        {
            Word[] nouns = genNouns();
            Word[] verbs = genVerbs();
            Word[] adjectives = genAdjectives();
            Word[] adverbs = genAdverbs();
            Word[] prepositions = genPrepositions();
            Word[] conjunctions = genConjunctions();
            Word[] articles = genArticles();
            Word[] questionWords = genQuestionWords();

            List<Word> w = new List<Word>();

            foreach (Noun n in nouns)
            {
                w.Add(n);
            }

            foreach (Verb v in verbs)
            {
                w.Add(v);
            }

            foreach (Adjective a in adjectives)
            {
                w.Add(a);
            }

            foreach (Adverb a in adverbs)
            {
                w.Add(a);
            }

            foreach (Preposition p in prepositions)
            {
                w.Add(p);
            }

            foreach (Conjunction c in conjunctions)
            {
                w.Add(c);
            }

            foreach (Article a in articles)
            {
                w.Add(a);
            }

            foreach (QuestionWord q in questionWords)
            {
                w.Add(q);
            }


            return w;

        }

        public QuestionWord[] genQuestionWords()
        {
            QuestionWord[] q = new QuestionWord[6];

            q[0] = new QuestionWord("Why");
            q[1] = new QuestionWord("What");
            q[2] = new QuestionWord("Who");
            q[3] = new QuestionWord("When");
            q[4] = new QuestionWord("Whom");
            q[5] = new QuestionWord("How");


            return q;

        }

        public Article[] genArticles()
        {
            Article[] a = new Article[3];

            a[0] = new Article("A");
            a[1] = new Article("The");
            a[2] = new Article("An");

            return a;
        }


        public Adjective[] genAdjectives()
        {
            Adjective[] a = new Adjective[35];

            a[0] = new Adjective("Sad");
            a[1] = new Adjective("Fast");
            a[2] = new Adjective("Happy");
            a[3] = new Adjective("Double");
            a[4] = new Adjective("Quick");
            a[5] = new Adjective("Slow");
            a[6] = new Adjective("Bald");
            a[7] = new Adjective("Clean");
            a[8] = new Adjective("Dazzling");
            a[9] = new Adjective("Drab");
            a[10] = new Adjective("Elegant");
            a[11] = new Adjective("Fancy");
            a[12] = new Adjective("Blue");
            a[13] = new Adjective("Gray");
            a[14] = new Adjective("Green");
            a[15] = new Adjective("Purple");
            a[16] = new Adjective("Famous");
            a[17] = new Adjective("Powerful");
            a[18] = new Adjective("Mushy");
            a[19] = new Adjective("Odd");
            a[20] = new Adjective("Strange");
            a[21] = new Adjective("Normal");
            a[22] = new Adjective("Large");
            a[23] = new Adjective("Small");
            a[24] = new Adjective("Unusual");
            a[25] = new Adjective("Angry");
            a[26] = new Adjective("Corrupt");
            a[27] = new Adjective("True");
            a[28] = new Adjective("False");
            a[29] = new Adjective("Rounded");
            a[30] = new Adjective("Animated");
            a[31] = new Adjective("Moving");
            a[32] = new Adjective("Static");
            a[33] = new Adjective("Nice");
            a[34] = new Adjective("Mean");


            return a;
        }

        public Noun[] genNouns()
        {
            Noun[] n = new Noun[100];

            // Original nouns (0–34)
            n[0] = new Noun("Doom");
            n[1] = new Noun("Boom");
            n[2] = new Noun("Emotion");
            n[3] = new Noun("Land");
            n[4] = new Noun("Chunk");
            n[5] = new Noun("Chocolate");
            n[6] = new Noun("Cookie");
            n[7] = new Noun("Chicken");
            n[8] = new Noun("Nation");
            n[9] = new Noun("Costco");
            n[10] = new Noun("Guys");
            n[11] = new Noun("America");
            n[12] = new Noun("Flag");
            n[13] = new Noun("Statue");
            n[14] = new Noun("School");
            n[15] = new Noun("Teacher");
            n[16] = new Noun("President");
            n[17] = new Noun("Leader");
            n[18] = new Noun("Dog");
            n[19] = new Noun("Cat");
            n[20] = new Noun("Friend");
            n[21] = new Noun("Community");
            n[22] = new Noun("Neighborhood");
            n[23] = new Noun("Lemon");
            n[24] = new Noun("Cake");
            n[25] = new Noun("Adventure");
            n[26] = new Noun("Time");
            n[27] = new Noun("Clock");
            n[28] = new Noun("Years");
            n[29] = new Noun("Days");
            n[30] = new Noun("Computer");
            n[31] = new Noun("Mind");
            n[32] = new Noun("Heart");
            n[33] = new Noun("Spirit");
            n[34] = new Noun("Nouns");

            // Added previously (35–49)
            n[35] = new Noun("Dream");
            n[36] = new Noun("Memory");
            n[37] = new Noun("Storm");
            n[38] = new Noun("Mountain");
            n[39] = new Noun("River");
            n[40] = new Noun("Noise");
            n[41] = new Noun("Shadow");
            n[42] = new Noun("Light");
            n[43] = new Noun("Sound");
            n[44] = new Noun("Energy");
            n[45] = new Noun("Story");
            n[46] = new Noun("Galaxy");
            n[47] = new Noun("Robot");
            n[48] = new Noun("Village");
            n[49] = new Noun("Hero");

            // New nouns (50–99) — fitting your tone/theme
            n[50] = new Noun("Chaos");
            n[51] = new Noun("Order");
            n[52] = new Noun("Portal");
            n[53] = new Noun("Island");
            n[54] = new Noun("Town");
            n[55] = new Noun("Forest");
            n[56] = new Noun("Bridge");
            n[57] = new Noun("Stone");
            n[58] = new Noun("Flower");
            n[59] = new Noun("Tree");

            n[60] = new Noun("Wind");
            n[61] = new Noun("Fire");
            n[62] = new Noun("Water");
            n[63] = new Noun("Earth");
            n[64] = new Noun("Sky");

            n[65] = new Noun("Monster");
            n[66] = new Noun("Creature");
            n[67] = new Noun("Citizen");
            n[68] = new Noun("Family");
            n[69] = new Noun("Foe");

            n[70] = new Noun("Treasure");
            n[71] = new Noun("Candy");
            n[72] = new Noun("Sandwich");
            n[73] = new Noun("Banana");
            n[74] = new Noun("Soda");

            n[75] = new Noun("Room");
            n[76] = new Noun("Door");
            n[77] = new Noun("Window");
            n[78] = new Noun("Table");
            n[79] = new Noun("Chair");

            n[80] = new Noun("Guitar");
            n[81] = new Noun("Ball");
            n[82] = new Noun("Phone");
            n[83] = new Noun("Car");
            n[84] = new Noun("Train");

            n[85] = new Noun("Universe");
            n[86] = new Noun("Planet");
            n[87] = new Noun("Star");
            n[88] = new Noun("Comet");
            n[89] = new Noun("Meteor");

            n[90] = new Noun("Honor");
            n[91] = new Noun("Courage");
            n[92] = new Noun("Truth");
            n[93] = new Noun("Wisdom");
            n[94] = new Noun("Hope");

            n[95] = new Noun("Mystery");
            n[96] = new Noun("Puzzle");
            n[97] = new Noun("Signal");
            n[98] = new Noun("Artifact");
            n[99] = new Noun("Legend");

            return n;
        }

        public Verb[] genVerbs()
        {
            Verb[] v = new Verb[300];

            // Original verbs (0–34)
            v[0] = new Verb("Boomed");
            v[1] = new Verb("Boom");
            v[2] = new Verb("Zoom");
            v[3] = new Verb("Didn't");
            v[4] = new Verb("Could");
            v[5] = new Verb("Should");
            v[6] = new Verb("Would");
            v[7] = new Verb("Booms");
            v[8] = new Verb("Bake");
            v[9] = new Verb("Sail");
            v[10] = new Verb("Rebel");
            v[11] = new Verb("Run");
            v[12] = new Verb("Befriend");
            v[13] = new Verb("Chat");
            v[14] = new Verb("Communicate");
            v[15] = new Verb("Meet");
            v[16] = new Verb("Divorce");
            v[17] = new Verb("Camp");
            v[18] = new Verb("Drive");
            v[19] = new Verb("Fly");
            v[20] = new Verb("Jump");
            v[21] = new Verb("Fall");
            v[22] = new Verb("Teleport");
            v[23] = new Verb("Go");
            v[24] = new Verb("Retreat");
            v[25] = new Verb("Think");
            v[26] = new Verb("Ponder");
            v[27] = new Verb("Meditate");
            v[28] = new Verb("Cry");
            v[29] = new Verb("Dance");
            v[30] = new Verb("Write");
            v[31] = new Verb("Read");
            v[32] = new Verb("Work");
            v[33] = new Verb("Love");
            v[34] = new Verb("Echo");

            // New verbs (35–99) — tone-matched
            v[35] = new Verb("Charge");
            v[36] = new Verb("Blast");
            v[37] = new Verb("Launch");
            v[38] = new Verb("Strike");
            v[39] = new Verb("Rise");

            v[40] = new Verb("Settle");
            v[41] = new Verb("Grow");
            v[42] = new Verb("Shrink");
            v[43] = new Verb("Vanish");
            v[44] = new Verb("Appear");

            v[45] = new Verb("Glide");
            v[46] = new Verb("Crawl");
            v[47] = new Verb("Sprint");
            v[48] = new Verb("Stumble");
            v[49] = new Verb("Climb");

            v[50] = new Verb("Whisper");
            v[51] = new Verb("Shout");
            v[52] = new Verb("Laugh");
            v[53] = new Verb("Scream");
            v[54] = new Verb("Sigh");

            v[55] = new Verb("Imagine");
            v[56] = new Verb("Realize");
            v[57] = new Verb("Forget");
            v[58] = new Verb("Remember");
            v[59] = new Verb("Wonder");

            v[60] = new Verb("Craft");
            v[61] = new Verb("Build");
            v[62] = new Verb("Destroy");
            v[63] = new Verb("Repair");
            v[64] = new Verb("Shape");

            v[65] = new Verb("Gather");
            v[66] = new Verb("Search");
            v[67] = new Verb("Discover");
            v[68] = new Verb("Explore");
            v[69] = new Verb("Travel");

            v[70] = new Verb("Transform");
            v[71] = new Verb("Empower");
            v[72] = new Verb("Weaken");
            v[73] = new Verb("Balance");
            v[74] = new Verb("Confuse");

            v[75] = new Verb("Cheer");
            v[76] = new Verb("Celebrate");
            v[77] = new Verb("Apologize");
            v[78] = new Verb("Forgive");
            v[79] = new Verb("Comfort");

            v[80] = new Verb("Guard");
            v[81] = new Verb("Protect");
            v[82] = new Verb("Chase");
            v[83] = new Verb("Hide");
            v[84] = new Verb("Sneak");

            v[85] = new Verb("Spin");
            v[86] = new Verb("Twist");
            v[87] = new Verb("Shake");
            v[88] = new Verb("Bounce");
            v[89] = new Verb("Roll");

            v[90] = new Verb("Swim");
            v[91] = new Verb("Slide");
            v[92] = new Verb("Dig");
            v[93] = new Verb("Lift");
            v[94] = new Verb("Push");

            v[95] = new Verb("Pull");
            v[96] = new Verb("Charge");
            v[97] = new Verb("Absorb");
            v[98] = new Verb("Radiate");
            v[99] = new Verb("Echoes");  // stylistic parallel to "Echo"

            v[100] = new Verb("Ascend");
            v[101] = new Verb("Ascended");
            v[102] = new Verb("Ascending");
            v[103] = new Verb("Descend");
            v[104] = new Verb("Descended");
            v[105] = new Verb("Descending");

            v[106] = new Verb("Charge");
            v[107] = new Verb("Charged");
            v[108] = new Verb("Charging");

            v[109] = new Verb("Collect");
            v[110] = new Verb("Collected");
            v[111] = new Verb("Collecting");

            v[112] = new Verb("Search");
            v[113] = new Verb("Searched");
            v[114] = new Verb("Searching");

            v[115] = new Verb("Leap");
            v[116] = new Verb("Leaped");
            v[117] = new Verb("Leaping");

            v[118] = new Verb("Clash");
            v[119] = new Verb("Clashed");
            v[120] = new Verb("Clashing");

            v[121] = new Verb("Roar");
            v[122] = new Verb("Roared");
            v[123] = new Verb("Roaring");

            v[124] = new Verb("Glitter");
            v[125] = new Verb("Glittered");
            v[126] = new Verb("Glittering");

            v[127] = new Verb("Shimmer");
            v[128] = new Verb("Shimmered");
            v[129] = new Verb("Shimmering");

            v[130] = new Verb("Charge");
            v[131] = new Verb("Rewind");
            v[132] = new Verb("Rewound");
            v[133] = new Verb("Rewinding");

            v[134] = new Verb("Freeze");
            v[135] = new Verb("Froze");
            v[136] = new Verb("Freezing");

            v[137] = new Verb("Melt");
            v[138] = new Verb("Melted");
            v[139] = new Verb("Melting");

            v[140] = new Verb("Spin");
            v[141] = new Verb("Spun");
            v[142] = new Verb("Spinning");

            v[143] = new Verb("Blow");
            v[144] = new Verb("Blew");
            v[145] = new Verb("Blowing");

            v[146] = new Verb("Unite");
            v[147] = new Verb("United");
            v[148] = new Verb("Uniting");

            v[149] = new Verb("Divide");
            v[150] = new Verb("Divided");
            v[151] = new Verb("Dividing");

            v[152] = new Verb("Rotate");
            v[153] = new Verb("Rotated");
            v[154] = new Verb("Rotating");

            v[155] = new Verb("Stare");
            v[156] = new Verb("Stared");
            v[157] = new Verb("Staring");

            v[158] = new Verb("Gaze");
            v[159] = new Verb("Gazed");
            v[160] = new Verb("Gazing");

            v[161] = new Verb("Shiver");
            v[162] = new Verb("Shivered");
            v[163] = new Verb("Shivering");

            v[164] = new Verb("Blink");
            v[165] = new Verb("Blinked");
            v[166] = new Verb("Blinking");

            v[167] = new Verb("Observe");
            v[168] = new Verb("Observed");
            v[169] = new Verb("Observing");

            v[170] = new Verb("Grab");
            v[171] = new Verb("Grabbed");
            v[172] = new Verb("Grabbing");

            v[173] = new Verb("Lifted");
            v[174] = new Verb("Lifting");
            v[175] = new Verb("Lift");

            v[176] = new Verb("Carry");
            v[177] = new Verb("Carried");
            v[178] = new Verb("Carrying");

            v[179] = new Verb("Guide");
            v[180] = new Verb("Guided");
            v[181] = new Verb("Guiding");

            v[182] = new Verb("Reveal");
            v[183] = new Verb("Revealed");
            v[184] = new Verb("Revealing");

            v[185] = new Verb("Hide");
            v[186] = new Verb("Hid");
            v[187] = new Verb("Hiding");

            v[188] = new Verb("Imagine");
            v[189] = new Verb("Imagined");
            v[190] = new Verb("Imagining");

            v[191] = new Verb("Transform");
            v[192] = new Verb("Transformed");
            v[193] = new Verb("Transforming");

            v[194] = new Verb("Shift");
            v[195] = new Verb("Shifted");
            v[196] = new Verb("Shifting");

            v[197] = new Verb("Vibrate");
            v[198] = new Verb("Vibrated");
            v[199] = new Verb("Vibrating");

            v[200] = new Verb("Amplify");
            v[201] = new Verb("Amplified");
            v[202] = new Verb("Amplifying");

            v[203] = new Verb("Radiate");
            v[204] = new Verb("Radiated");
            v[205] = new Verb("Radiating");

            v[206] = new Verb("Echo");
            v[207] = new Verb("Echoed");
            v[208] = new Verb("Echoing");

            v[209] = new Verb("Clatter");
            v[210] = new Verb("Clattered");
            v[211] = new Verb("Clattering");

            v[212] = new Verb("Collide");
            v[213] = new Verb("Collided");
            v[214] = new Verb("Colliding");

            v[215] = new Verb("Shake");
            v[216] = new Verb("Shaken");
            v[217] = new Verb("Shaking");

            v[218] = new Verb("Drift");
            v[219] = new Verb("Drifted");
            v[220] = new Verb("Drifting");

            v[221] = new Verb("Hover");
            v[222] = new Verb("Hovered");
            v[223] = new Verb("Hovering");

            v[224] = new Verb("Charge");
            v[225] = new Verb("Retreat");
            v[226] = new Verb("Retreated");
            v[227] = new Verb("Retreating");

            v[228] = new Verb("Advance");
            v[229] = new Verb("Advanced");
            v[230] = new Verb("Advancing");

            v[231] = new Verb("Cheer");
            v[232] = new Verb("Cheered");
            v[233] = new Verb("Cheering");

            v[234] = new Verb("Applaud");
            v[235] = new Verb("Applauded");
            v[236] = new Verb("Applauding");

            v[237] = new Verb("Encourage");
            v[238] = new Verb("Encouraged");
            v[239] = new Verb("Encouraging");

            v[240] = new Verb("Forgive");
            v[241] = new Verb("Forgave");
            v[242] = new Verb("Forgiving");

            v[243] = new Verb("Celebrate");
            v[244] = new Verb("Celebrated");
            v[245] = new Verb("Celebrating");

            v[246] = new Verb("Resist");
            v[247] = new Verb("Resisted");
            v[248] = new Verb("Resisting");

            v[249] = new Verb("Accept");
            v[250] = new Verb("Accepted");
            v[251] = new Verb("Accepting");

            v[252] = new Verb("Reject");
            v[253] = new Verb("Rejected");
            v[254] = new Verb("Rejecting");

            v[255] = new Verb("Conjure");
            v[256] = new Verb("Conjured");
            v[257] = new Verb("Conjuring");

            v[258] = new Verb("Summon");
            v[259] = new Verb("Summoned");
            v[260] = new Verb("Summoning");

            v[261] = new Verb("Unleash");
            v[262] = new Verb("Unleashed");
            v[263] = new Verb("Unleashing");

            v[264] = new Verb("Stabilize");
            v[265] = new Verb("Stabilized");
            v[266] = new Verb("Stabilizing");

            v[267] = new Verb("Wander");
            v[268] = new Verb("Wandered");
            v[269] = new Verb("Wandering");

            v[270] = new Verb("Journey");
            v[271] = new Verb("Journeyed");
            v[272] = new Verb("Journeying");

            v[273] = new Verb("Roam");
            v[274] = new Verb("Roamed");
            v[275] = new Verb("Roaming");

            v[276] = new Verb("Rally");
            v[277] = new Verb("Rallied");
            v[278] = new Verb("Rallying");

            v[279] = new Verb("Focus");
            v[280] = new Verb("Focused");
            v[281] = new Verb("Focusing");

            v[282] = new Verb("Calculate");
            v[283] = new Verb("Calculated");
            v[284] = new Verb("Calculating");

            v[285] = new Verb("Decode");
            v[286] = new Verb("Decoded");
            v[287] = new Verb("Decoding");

            v[288] = new Verb("Signal");
            v[289] = new Verb("Signaled");
            v[290] = new Verb("Signaling");

            v[291] = new Verb("Charge");
            v[292] = new Verb("Desire");
            v[293] = new Verb("Desired");
            v[294] = new Verb("Desiring");

            v[295] = new Verb("Assume");
            v[296] = new Verb("Assumed");
            v[297] = new Verb("Assuming");

            v[298] = new Verb("Generate");
            v[299] = new Verb("Generated");


            return v;
        }


        public Adverb[] genAdverbs()
        {
            Adverb[] a = new Adverb[34];

            a[0] = new Adverb("Not");
            a[1] = new Adverb("Always");
            a[2] = new Adverb("Bravely");
            a[3] = new Adverb("Carefully");
            a[4] = new Adverb("Never");
            a[5] = new Adverb("Often");
            a[6] = new Adverb("Eventually");
            a[7] = new Adverb("Daily");
            a[8] = new Adverb("Completely");
            a[9] = new Adverb("Sometimes");
            a[10] = new Adverb("Rarely");
            a[11] = new Adverb("Seldom");
            a[12] = new Adverb("Generally");
            a[13] = new Adverb("Normally");
            a[14] = new Adverb("Twice");
            a[15] = new Adverb("Tomorrow");
            a[16] = new Adverb("Previously");
            a[17] = new Adverb("Early");
            a[18] = new Adverb("Late");
            a[19] = new Adverb("Loudly");
            a[20] = new Adverb("Proudly");
            a[21] = new Adverb("Kindly");
            a[22] = new Adverb("Rudely");
            a[23] = new Adverb("Generously");
            a[24] = new Adverb("Eagerly");
            a[25] = new Adverb("Rapidly");
            a[26] = new Adverb("Foolishly");
            a[27] = new Adverb("Scarcely");
            a[28] = new Adverb("Slightly");
            a[29] = new Adverb("Extremely");
            a[30] = new Adverb("Somewhat");
            a[31] = new Adverb("Almost");
            a[32] = new Adverb("Nearly");
            a[33] = new Adverb("Overseas");



            return a;
        }

        public Conjunction[] genConjunctions()
        {
            Conjunction[] c = new Conjunction[34];

            c[0] = new Conjunction("And");
            c[1] = new Conjunction("But");
            c[2] = new Conjunction("However");
            c[3] = new Conjunction("For");
            c[4] = new Conjunction("Nor");
            c[5] = new Conjunction("Or");
            c[6] = new Conjunction("Yet");
            c[7] = new Conjunction("So");
            c[8] = new Conjunction("Now that");
            c[9] = new Conjunction("How");
            c[10] = new Conjunction("Though");
            c[11] = new Conjunction("Because");
            c[12] = new Conjunction("Before");
            c[13] = new Conjunction("Until");
            c[14] = new Conjunction("Unless");
            c[15] = new Conjunction("Since");
            c[16] = new Conjunction("So");        // appears twice in your list
            c[17] = new Conjunction("So that");
            c[18] = new Conjunction("Only If");
            c[19] = new Conjunction("Once");
            c[20] = new Conjunction("Although");
            c[21] = new Conjunction("After");
            c[22] = new Conjunction("As");
            c[23] = new Conjunction("While");
            c[24] = new Conjunction("When");
            c[25] = new Conjunction("Whereas");
            c[26] = new Conjunction("Whenever");
            c[27] = new Conjunction("Wherever");
            c[28] = new Conjunction("Whether");
            c[29] = new Conjunction("If");
            c[30] = new Conjunction("In case");
            c[31] = new Conjunction("In order that");
            c[32] = new Conjunction("Even though");
            c[33] = new Conjunction("Even if");


            return c;
        }

        public Preposition[] genPrepositions()
        {
            Preposition[] p = new Preposition[82];

            p[0] = new Preposition("Of");
            p[1] = new Preposition("Aboard");
            p[2] = new Preposition("About");
            p[3] = new Preposition("Above");
            p[4] = new Preposition("Absent");
            p[5] = new Preposition("Across");
            p[6] = new Preposition("After");
            p[7] = new Preposition("Against");
            p[8] = new Preposition("Along");
            p[9] = new Preposition("Alongside");
            p[10] = new Preposition("Amid");
            p[11] = new Preposition("Amidst");
            p[12] = new Preposition("Among");
            p[13] = new Preposition("Amongst");
            p[14] = new Preposition("Around");
            p[15] = new Preposition("As");
            p[16] = new Preposition("At");
            p[17] = new Preposition("Atop");
            p[18] = new Preposition("Barring");
            p[19] = new Preposition("Barring");       // duplicate from list
            p[20] = new Preposition("Before");
            p[21] = new Preposition("Behind");
            p[22] = new Preposition("Below");         // preserving your spelling
            p[23] = new Preposition("Beneath");
            p[24] = new Preposition("Beside");
            p[25] = new Preposition("Besides");
            p[26] = new Preposition("Between");
            p[27] = new Preposition("Beyond");
            p[28] = new Preposition("But");
            p[29] = new Preposition("By");
            p[30] = new Preposition("Circa");
            p[31] = new Preposition("Concerning");
            p[32] = new Preposition("Counting");
            p[33] = new Preposition("Despite");
            p[34] = new Preposition("Down");
            p[35] = new Preposition("During");
            p[36] = new Preposition("Effective");
            p[37] = new Preposition("Except");
            p[38] = new Preposition("Excepting");
            p[39] = new Preposition("Excluding");
            p[40] = new Preposition("Failing");
            p[41] = new Preposition("Following");
            p[42] = new Preposition("For");
            p[43] = new Preposition("From");
            p[44] = new Preposition("In");
            p[45] = new Preposition("Including");
            p[46] = new Preposition("Inside");
            p[47] = new Preposition("Into");
            p[48] = new Preposition("Less");
            p[49] = new Preposition("Like");
            p[50] = new Preposition("Minus");
            p[51] = new Preposition("Near");
            p[52] = new Preposition("Next");
            p[53] = new Preposition("Notwithstanding");
            p[54] = new Preposition("Off");
            p[55] = new Preposition("On");
            p[56] = new Preposition("Onto");
            p[57] = new Preposition("Opposite");
            p[58] = new Preposition("Out");
            p[59] = new Preposition("Outside");
            p[60] = new Preposition("Over");
            p[61] = new Preposition("Past");
            p[62] = new Preposition("Pending");
            p[63] = new Preposition("Per");
            p[64] = new Preposition("Plus");
            p[65] = new Preposition("Regarding");
            p[66] = new Preposition("Respecting");
            p[67] = new Preposition("Short");
            p[68] = new Preposition("Since");
            p[69] = new Preposition("Than");
            p[70] = new Preposition("Through");
            p[71] = new Preposition("Throughout");
            p[72] = new Preposition("To");
            p[73] = new Preposition("Toward");
            p[74] = new Preposition("Towards");
            p[75] = new Preposition("Versus");
            p[76] = new Preposition("Via");
            p[77] = new Preposition("Wanting");
            p[78] = new Preposition("With");
            p[79] = new Preposition("Within");
            p[80] = new Preposition("Without");
            p[81] = new Preposition("Worth");


            return p;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void displayPoem(Poem p)
        {
            poemListBox.Items.Clear();
            foreach (Line l in p.lines)
            {
                poemListBox.Items.Add(l.ToString());
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            switch (settingComboBox.Text)
            {
                case "True Random":
                    displayPoem(generateRandomPoem());
                    break;

                case "Random Algorithm":
                    displayPoem(generatePoem());
                    break;
            }


        }

        public Poem generatePoem()
        {
            Random random = new Random();
            return generatePoem(random.Next(1, maxLines));
        }

        public Poem generatePoem(int numOfLines)
        {
            Random random = new Random();
            Line[] lines = new Line[numOfLines];
            for (int i = 0; i < numOfLines; i++)
            {
                lines[i] = generateLine(random.Next(1, maxWords));
            }
            Line title = generateLine(random.Next(1, maxWords));
            Poem p = new Poem(title, lines);
            titlesListBox.Items.Add(p.title.ToString());
            poems.Add(p);
            return p;
        }

        public Line generateLine(int numOfWords)
        {
            Random random = new Random();
            Word[] words = new Word[numOfWords];
            words[0] = firstWord();
            for (int i = 1; i < numOfWords; i++)
            {
                words[i] = nextWord(words[i-1]);
            }
            Line l = new Line(words);

            return l;
        }
        public Word nextWord(Word previous)
        {
            Word w = new Word("");
            Random random = new Random();

            if (previous.GetType() == typeof(Noun))
            {
                switch (random.Next(5))
                {
                    default:
                        w = randomWord();
                        break;
                    case 0:
                        w = randomAdverb();
                        break;
                    case 1:
                        w = randomNoun();
                        break;
                    case 2:
                        w = randomConjunction();
                        break;
                    case 3:
                        w = randomPreposition();
                        break;
                    case 4:
                        w = randomVerb();
                        break;
                }
            }
            else if (previous.GetType() == typeof(Verb))
            {
                switch (random.Next(5))
                {
                    default:
                        w = randomWord();
                        break;
                    case 0:
                        w = randomAdverb();
                        break;
                    case 1: 
                        w = randomNoun();
                        break;
                    case 2:
                        w = randomConjunction();
                        break; 
                    case 3:
                        w = randomPreposition();
                        break;
                    case 4:
                        w = randomQuestionWord();
                        break;
                }
            }
            else if (previous.GetType() == typeof(Adjective))
            {
                switch (random.Next(3))
                {
                    default:
                        w = randomWord();
                        break;
                    case 0:
                        w = randomAdverb();
                        break;
                    case 1:
                        w = randomNoun();
                        break;
                    case 2:
                        w = randomConjunction();
                        break;
                    case 3:
                        w = randomPreposition();
                        break;
                }
            }
            else if (previous.GetType() == typeof(Adverb))
            {
                switch (random.Next(3))
                {
                    default:
                        w = randomWord();
                        break;
                    case 0:
                        w = randomAdverb();
                        break;
                    case 1:
                        w = randomNoun();
                        break;
                    case 2:
                        w = randomConjunction();
                        break;
                    case 3:
                        w = randomPreposition();
                        break;
                }
            }
            else if (previous.GetType() == typeof(Preposition))
            {
                switch (random.Next(3))
                {
                    default:
                        w = randomWord();
                        break;
                    case 0:
                        w = randomAdverb();
                        break;
                    case 1:
                        w = randomNoun();
                        break;
                    case 2:
                        w = randomConjunction();
                        break;
                    case 3:
                        w = randomPreposition();
                        break;
                }
            }
            else if (previous.GetType() == typeof(Conjunction))
            {
                switch (random.Next(3))
                {
                    default:
                        w = randomWord();
                        break;
                    case 0:
                        w = randomAdverb();
                        break;
                    case 1:
                        w = randomNoun();
                        break;
                    case 2:
                        w = randomConjunction();
                        break;
                    case 3:
                        w = randomPreposition();
                        break;
                }
            }
            else if (previous.GetType() == typeof(QuestionWord))
            {
                switch (random.Next(3))
                {
                    default:
                        w = randomWord();
                        break;
                    case 0:
                        w = randomAdverb();
                        break;
                    case 1:
                        w = randomNoun();
                        break;
                    case 2:
                        w = randomConjunction();
                        break;
                    case 3:
                        w = randomPreposition();
                        break;
                }
            }
            else if (previous.GetType() == typeof(Article))
            {
                switch (random.Next(3))
                {
                    default:
                        w = randomWord();
                        break;
                    case 0:
                        w = randomAdverb();
                        break;
                    case 1:
                        w = randomNoun();
                        break;
                    case 2:
                        w = randomConjunction();
                        break;
                    case 3:
                        w = randomPreposition();
                        break;
                }
            }
            else
            {
                // fallback: pick any word
                List<Word> words = genWords();
                w = words[random.Next(words.Count)];
            }

            return w;
        }
        public Word nextWordRepeatType(Word previous)
        {
            Word w = new Word("");
            Random random = new Random();

            if (previous.GetType() == typeof(Noun))
            {
                Noun[] nouns = genNouns();
                w = nouns[random.Next(nouns.Length)];
            }
            else if (previous.GetType() == typeof(Verb))
            {
                Verb[] verbs = genVerbs();
                w = verbs[random.Next(verbs.Length)];
            }
            else if (previous.GetType() == typeof(Adjective))
            {
                Adjective[] adjectives = genAdjectives();
                w = adjectives[random.Next(adjectives.Length)];
            }
            else if (previous.GetType() == typeof(Adverb))
            {
                Adverb[] adverbs = genAdverbs();
                w = adverbs[random.Next(adverbs.Length)];
            }
            else if (previous.GetType() == typeof(Preposition))
            {
                Preposition[] preps = genPrepositions();
                w = preps[random.Next(preps.Length)];
            }
            else if (previous.GetType() == typeof(Conjunction))
            {
                Conjunction[] cons = genConjunctions();
                w = cons[random.Next(cons.Length)];
            }
            else if (previous.GetType() == typeof(QuestionWord))
            {
                QuestionWord[] qwords = genQuestionWords();
                w = qwords[random.Next(qwords.Length)];
            } else if (previous.GetType() == typeof(Article))
            {
                Article[] articles = genArticles();
                w = articles[random.Next(articles.Length)];
            }
            else
            {
                // fallback: pick any word
                List<Word> words = genWords();
                w = words[random.Next(words.Count)];
            }

            return w;
        }


        public Word firstWord()
        {
            Word w = new Word("");
            Random random = new Random();
            List<Word> words = genWords();
            w = words[random.Next(words.Count)];
            return w;
        }

        public Poem generateRandomPoem()
        {
            Random random = new Random();
            return generateRandomPoem(random.Next(1, maxLines));
        }

        public Poem generateRandomPoem(int numOfLines)
        {
            Random random = new Random();
            Line[] lines = new Line[numOfLines];
            for (int i = 0; i < numOfLines; i++)
            {
                lines[i] = generateRandomLine(random.Next(1, maxWords));
            }
            Line title = generateRandomLine(random.Next(1, maxWords));
            Poem p = new Poem(title, lines);
            titlesListBox.Items.Add(p.title.ToString());
            poems.Add(p);
            return p;
        }

        public Line generateRandomLine(int numOfWords)
        {
            Random random = new Random();
            Word[] words = new Word[numOfWords];
            for (int i = 0; i < numOfWords; i++)
            {
                words[i] = randomWord();
            }
            Line l = new Line(words);

            return l;
        }

        public Word randomWord()
        {
            Word w = new Word("");
            Random random = new Random();
            List<Word> words = genWords();
            w = words[random.Next(words.Count)];
            return w;
        }

        public Word randomNoun()
        {
            Word w = new Word("");
            Random random = new Random();
            Noun[] nouns = genNouns();
            w = nouns[random.Next(nouns.Length)];
            return w;
        }

        public Word randomVerb()
        {
            Word w = new Word("");
            Random random = new Random();
            Verb[] verbs = genVerbs();
            w = verbs[random.Next(verbs.Length)];
            return w;
        }

        public Word randomAdjective()
        {
            Word w = new Word("");
            Random random = new Random();
            Adjective[] adjectives = genAdjectives();
            w = adjectives[random.Next(adjectives.Length)];
            return w;
        }

        public Word randomAdverb()
        {
            Word w = new Word("");
            Random random = new Random();
            Adverb[] adverbs = genAdverbs();
            w = adverbs[random.Next(adverbs.Length)];
            return w;
        }

        public Word randomPreposition()
        {
            Word w = new Word("");
            Random random = new Random();
            Preposition[] preps = genPrepositions();
            w = preps[random.Next(preps.Length)];
            return w;
        }

        public Word randomConjunction()
        {
            Word w = new Word("");
            Random random = new Random();
            Conjunction[] conjunctions = genConjunctions();
            w = conjunctions[random.Next(conjunctions.Length)];
            return w;
        }

        public Word randomQuestionWord()
        {
            Word w = new Word("");
            Random random = new Random();
            QuestionWord[] qwords = genQuestionWords();
            w = qwords[random.Next(qwords.Length)];
            return w;
        }

        public Word randomArticle()
        {
            Word w = new Word("");
            Random random = new Random();
            Article[] articles = genArticles();
            w = articles[random.Next(articles.Length)];
            return w;
        }





        private void titlesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int poemIndex = -1;
            string poemString = "";
            Poem selectedPoem = new Poem();

            try
            {
                poemString = ((string)titlesListBox.Items[titlesListBox.SelectedIndex]);
                poemIndex = findPoemByTitle(poemString);
                if (poemIndex != -1)
                {
                    selectedPoem = poems[poemIndex];
                }
                displayPoem(selectedPoem);
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"argument out of range. {ex.Message}");
                //selectedNameLabel.Text = "No Person Selected";
            }
        }

        public int findPoemByTitle(String title)
        {
            int result = -1;

            for (int i = 0; i < poems.Count; i++)
            {
                if (poems[i].title.ToString().Equals(title)) result = i;
            }

            return result;
        }
    }
}
