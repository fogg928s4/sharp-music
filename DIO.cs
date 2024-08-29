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
            // Declare the first few Notas of the song
            Nota[] MusicC =
            {
            //first
            new Nota(Tone.F5sharp, Duration.QUARTERP),
            new Nota(Tone.F5, Duration.THREEEIGHT),
            new Nota(Tone.REST, Duration.EIGHTH),
            new Nota(Tone.D5, Duration.SIXTEENTH),
            new Nota(Tone.E5, Duration.SIXTEENTH),
            //second
            new Nota(Tone.F5, Duration.EIGHTH),
            new Nota(Tone.E5, Duration.THREESIXTEENTH),
            new Nota(Tone.D5, Duration.EIGHTH),
            new Nota(Tone.C5sharp, Duration.EIGHTHP),
            new Nota(Tone.D5, Duration.THREESIXTEENTH),
            new Nota(Tone.E5, Duration.EIGHTH),
            //third
            new Nota(Tone.F5sharp, Duration.QUARTERP),
            new Nota(Tone.B5, Duration.THREEEIGHT),
            new Nota(Tone.B4, Duration.EIGHTH),
            new Nota(Tone.C5sharp, Duration.EIGHTH),
            //fourth
            new Nota(Tone.D5, Duration.EIGHTHP),
            new Nota(Tone.E5, Duration.THREESIXTEENTH),
            new Nota(Tone.D5, Duration.EIGHTH),
            new Nota(Tone.C5sharp, Duration.EIGHTHP),
            new Nota(Tone.A5, Duration.THREESIXTEENTH),
            new Nota(Tone.G5, Duration.EIGHTH),
            };
            JOJO();
            // Play the song
            Play(MusicC);
            Environment.Exit(0);
        }

        // Play the Notas in a song.
        static void JOJO()
        {
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⣀⡀⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⣴⣿⣿⠿⣫⣥⣄⠄⠄⠄⠄⠄⠄⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⠄⠄⢀⠄⠄⠄⠾⢿⢟⣵⣾⣿⡿⠃⠄⠄⠄⠄⠄⠄⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⠄⣰⡿⣀⣤⣴⣾⣿⡇⠙⠛⠁⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⣠⣾⣿⣿⣿⣿⣿⣿⣿⠁⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⠄⣴⣿⣿⠿⠛⠉⢩⣿⣿⡇⠄⠄⠄⠄⠄⠄⠄⠄⣀⣀⡀⠄⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⠈⠛⠉⠄⠄⠄⠄⢸⣿⣿⡇⠄⠄⠄⠄⠄⠄⢀⣼⡿⣫⣾⠆⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⢀⣶⣶⣶⣶⣶⣶⣿⣿⣿⠇⠄⠄⠄⣠⣎⣠⣴⣶⠎⠛⠁⠄⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⣾⣿⣿⣿⣿⠿⠿⠟⠛⠋⠄⠄⢀⣼⣿⠿⠛⣿⡟⠄⠄⠄⠄⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⠛⠉⠉⠄⠄⠄⠄⠄⠄⠄⠄⠄⠘⠉⠄⠄⢸⣿⡇⠄⠄⠄⠄⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⣼⣿⣿⣿⡿⠿⠃⠄⠄⠄⠄⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠋⠉⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄");
        }
        static void Play(Nota[] tune)
        {
            foreach (Nota n in tune)
            {
                if (n.NotaTone == Tone.REST)
                {
                    Thread.Sleep((int)n.NotaDuration);
                }
                else
                {
                    Console.Beep((int)n.NotaTone, (int)n.NotaDuration); //BEEp
                }                    
            }
        }
        // Define the frequencies of Notas in an octave, as well as silence (rest).
        protected enum Tone
        {
            REST = 0,
            C3 = 131,
            D3 =147,
            E3 = 165,
            F3 = 175,
            G3 = 196,
            A3 = 220,
            A3sharp = 233,
            B3 = 247,
            C4 = 262,
            C4sharp = 277,
            D4 = 293,
            D4sharp = 311,
            E4 = 330,
            F4 = 349,
            F4sharp = 370,
            G4 = 392,
            G4sharp = 415,
            A4 = 440,
            B4 = 494,
            C5 = 523,
            C5sharp = 554,
            D5 = 587,
            E5 = 659,
            F5 = 698,
            F5sharp = 740,
            G5 = 784,
            A5 = 880,
            B5 = 987,
            C6 = 1046,
        }
        // Define the duration of a Nota in units of milliseconds.
        protected enum Duration
        {
            WHOLE = 1800,//ms redonda
            WHOLEP=WHOLE + WHOLE/2,
            HALF = WHOLE / 2, //blanca
            HALFP = HALF + HALF/2,
            QUARTER = HALF / 2, //negra
            QUARTERP = QUARTER + QUARTER/2,
            EIGHTH = QUARTER / 2, //corcheta
            EIGHTHP = EIGHTH + EIGHTH/2,
            SIXTEENTH = EIGHTH / 2, //semicorcheta
            SIXTEENTHP= SIXTEENTH + SIXTEENTH/2,
            THIRTYTWO = SIXTEENTH / 2, //semisemicorcheta
            THIRTYTWOP = THIRTYTWO + THIRTYTWO/2,
            THREEEIGHT = (3*WHOLE)/8,
            THREESIXTEENTH = (3*WHOLE)/16,
        }

        // Define a Nota as a frequency (tone) and the amount of time (duration) the Nota plays.
        protected struct Nota
        {
            Tone toneVal;
            Duration durVal;

            // Define a constructor to create a specific Nota.
            public Nota(Tone frequency, Duration time)
            {
                toneVal = frequency;
                durVal = time;
            }

            // Define properties to return the Nota's tone and duration.
            public Tone NotaTone { get { return toneVal; } }
            public Duration NotaDuration { get { return durVal; } }
        }

    }
}