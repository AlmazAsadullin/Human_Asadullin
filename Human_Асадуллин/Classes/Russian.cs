using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Human_Асадуллин.Classes
{
    public class Russian : Human
    {
        private List<Phrase> Phrases { get; set; }
        private int stepAudio;
        private int StepAudio
        {
            get
            {
                return StepAudio;
            }
            set
            {
                StepAudio = value;
                if (StepAudio > Phrases.Count - 1)
                    StepAudio = 0;
            }
        }
        public Russian(string Name, string Img) : base(Name, Img)
        {
            this.Phrases = AllPhrases();
        }
        public override void Speak(Label Phrase)
        {
            Phrase.Content = Phrases[StepAudio]._Phrase;
            MainWindow.MediaPlayer.Open(new Uri(Phrases[StepAudio].Src));
            MainWindow.MediaPlayer.Play();
            StepAudio++;
        }
        public static List<Phrase> AllPhrases()
        {
            List<Phrase> allPhrases = new List<Phrase>();
            allPhrases.Add(new Phrase("Привет", @"C:\Users\student-a502.PERMAVIAT\source\repos\AlmazAsadullin\Human_Asadullin\Human_Асадуллин\Voices\Voice1.mp3"));
            allPhrases.Add(new Phrase("Как дела?", @"C:\Users\student-a502.PERMAVIAT\source\repos\AlmazAsadullin\Human_Asadullin\Human_Асадуллин\Voices\voice2.mp3"));
            allPhrases.Add(new Phrase("Меня зовут Александр", @"C:\Users\student-a502.PERMAVIAT\source\repos\AlmazAsadullin\Human_Asadullin\Human_Асадуллин\Voices\Voice3.mp3"));
            return allPhrases;
        }
    }
}
