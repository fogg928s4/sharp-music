using System;
using System.Threading;

namespace awa
{
    class Sample
    {
        public static void Main()
        {
            Console.WindowWidth = 50;
            Console.WindowHeight = 32;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor= ConsoleColor.White;
            Console.Clear();
            // Declare the first few notes of the song
            Note[] /*Group*/MusicC =
            {
            new Note(Tone.D4, Duration.SIXTEENTH),
            new Note(Tone.D4, Duration.SIXTEENTH),
            new Note(Tone.D5, Duration.EIGHTH),
            new Note(Tone.A4, Duration.EIGHTH),
            new Note(Tone.REST, Duration.SIXTEENTH),
            new Note(Tone.G4sharp, Duration.SIXTEENTH),
            new Note(Tone.REST, Duration.SIXTEENTH),
            new Note(Tone.G4, Duration.SIXTEENTH),
            new Note(Tone.REST, Duration.SIXTEENTH),
            new Note(Tone.F4, Duration.EIGHTH),
            new Note(Tone.D4, Duration.SIXTEENTH),
            new Note(Tone.F4, Duration.SIXTEENTH),
            new Note(Tone.G4, Duration.SIXTEENTH),
            //Second compass
            new Note(Tone.C4, Duration.SIXTEENTH),
            new Note(Tone.C4, Duration.SIXTEENTH),
            new Note(Tone.D5, Duration.EIGHTH),
            new Note(Tone.A4, Duration.EIGHTH),
            new Note(Tone.REST, Duration.SIXTEENTH),
            new Note(Tone.G4sharp, Duration.SIXTEENTH),
            new Note(Tone.REST, Duration.SIXTEENTH),
            new Note(Tone.G4, Duration.SIXTEENTH),
            new Note(Tone.REST, Duration.SIXTEENTH),
            new Note(Tone.F4, Duration.EIGHTH),
            new Note(Tone.D4, Duration.SIXTEENTH),
            new Note(Tone.F4, Duration.SIXTEENTH),
            new Note(Tone.G4, Duration.SIXTEENTH),
            //Third and Fourth
            new Note(Tone.REST, Duration.EIGHTH),            
            //Fifth
            new Note(Tone.B3, Duration.SIXTEENTH),
            new Note(Tone.B3, Duration.SIXTEENTH),
            new Note(Tone.D5, Duration.EIGHTH),
            new Note(Tone.A4, Duration.EIGHTH),
            new Note(Tone.REST, Duration.SIXTEENTH),
            new Note(Tone.G4sharp, Duration.SIXTEENTH),
            new Note(Tone.REST, Duration.SIXTEENTH),
            new Note(Tone.G4, Duration.SIXTEENTH),
            new Note(Tone.REST, Duration.SIXTEENTH),
            new Note(Tone.F4, Duration.EIGHTH),
            new Note(Tone.D4, Duration.SIXTEENTH),
            new Note(Tone.F4, Duration.SIXTEENTH),
            new Note(Tone.G4, Duration.SIXTEENTH),
            //Sixth
            new Note(Tone.B3, Duration.SIXTEENTH),
            new Note(Tone.B3, Duration.SIXTEENTH),
            new Note(Tone.D5, Duration.EIGHTH),
            new Note(Tone.A4, Duration.EIGHTH),
            new Note(Tone.REST, Duration.SIXTEENTH),
            new Note(Tone.G4sharp, Duration.SIXTEENTH),
            new Note(Tone.REST, Duration.SIXTEENTH),
            new Note(Tone.G4, Duration.SIXTEENTH),
            new Note(Tone.REST, Duration.SIXTEENTH),
            new Note(Tone.F4, Duration.EIGHTH),
            new Note(Tone.D4, Duration.SIXTEENTH),
            new Note(Tone.F4, Duration.SIXTEENTH),
            new Note(Tone.G4, Duration.SIXTEENTH),
            new Note(Tone.A6, Duration.SIXTEENTH),
            new Note(Tone.E6, Duration.SIXTEENTH),
            new Note(Tone.A5, Duration.SIXTEENTH),
            new Note(Tone.B5, Duration.SIXTEENTH),
            new Note(Tone.C3, Duration.EIGHTH),
            };
            

            Sans();
            // Play the song
            Play(MusicC);
            Environment.Exit(0);
        }

        // Play the notes in a song.
        static void Sans()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                ██████████████████");
            Console.WriteLine("            ████                  ████");
            Console.WriteLine("          ██                          ██");
            Console.WriteLine("          ██                          ██");
            Console.WriteLine("        ██                              ██");
            Console.WriteLine("        ██                    ██████    ██");
            Console.WriteLine("        ██                    ██████    ██");
            Console.WriteLine("        ██    ██████    ██    ██████    ██");
            Console.WriteLine("          ██          ██████          ██");
            Console.WriteLine("        ████  ██                  ██  ████");
            Console.WriteLine("        ██    ██████████████████████    ██");
            Console.WriteLine("        ██      ██  ██  ██  ██  ██      ██");
            Console.WriteLine("          ████    ██████████████    ████");
            Console.WriteLine("        ██████████              ██████████");
            //jacket
            Console.Write("      ██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.Write("\n    ████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("████");
            Console.ForegroundColor= ConsoleColor.Black;
            Console.Write("██      ██      ██");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████");
            Console.Write("\n    ██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████  ██████");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.Write("\n  ██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████    ██    ██████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.Write("\n  ██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("████");
            Console.ForegroundColor= ConsoleColor.Black;
            Console.Write("██          ██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.Write("\n  ██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("██████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████      ████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("██████████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.Write("\n    ██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██          ██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("██████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\n      ████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("██");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\n        ██████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████████████");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("██████");
            //feet
            Console.WriteLine("        ██████████████████████████████████");
            Console.WriteLine("      ██████████████████████████████████████");
            Console.WriteLine("      ██████████████████  ██████████████████");            
            Console.WriteLine("        ██████████████      ████████████");
            Console.WriteLine("    ██████          ██      ██          ██████");
            Console.WriteLine("    ██            ████      ████              ██");
            Console.WriteLine("      ████████████              ██████████████");
        }
        static void Play(Note[] tune)
        {
            foreach (Note n in tune)
            {
                if (n.NoteTone == Tone.REST)//Thread.Sleep(6000);
                    Thread.Sleep((int)n.NoteDuration);
                else
                    Console.Beep((int)n.NoteTone, (int)n.NoteDuration);
            }
        }
        // Define the frequencies of notes in an octave, as well as silence (rest).
        protected enum Tone
        {
            REST = 0,
            GbelowC = 196,
            A3 = 220,
            A4 = 440,
            C3 = 131,
            E3 = 165,
            G3 = 196,
            G4 = 392,
            G4sharp = 415,
            B3 = 247,
            D4 = 293,
            D5 = 587,
            Asharp = 233,
            C4 = 262,
            Csharp = 277,
            D = 294,
            Dsharp = 311,
            E = 330,
            F4 = 349,
            Fsharp = 370,
            G = 392,
            Gsharp = 415,
            E5 = 659,
            A5 = 880,
            B5 = 987,
            C6 = 1046,
            D6 = 1173,
            E6=1318,
            A6 = 1760,
        }
        // Define the duration of a note in units of milliseconds.
        protected enum Duration
        {
            WHOLE = 3000,//ms redonda
            HALF = WHOLE / 2, //blanca
            QUARTER = HALF / 2, //negra
            EIGHTH = QUARTER / 2, //corcheta
            SIXTEENTH = EIGHTH / 2, //semicorcheta
            THIRTYTWO = SIXTEENTH /2 //semisemicorcheta
        }

        // Define a note as a frequency (tone) and the amount of time (duration) the note plays.
        protected struct Note
        {
            Tone toneVal;
            Duration durVal;

            // Define a constructor to create a specific note.
            public Note(Tone frequency, Duration time)
            {
                toneVal = frequency;
                durVal = time;
            }

            // Define properties to return the note's tone and duration.
            public Tone NoteTone { get { return toneVal; } }
            public Duration NoteDuration { get { return durVal; } }
        }
    }
}