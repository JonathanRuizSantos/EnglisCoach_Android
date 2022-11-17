using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;                    //Clase que contiene el StreamReader para manipilar documentos txt

namespace EntrenadorIngles
{
    public partial class MainPage : CarouselPage
    {
        int numberone;
        int numbertwo;
        String r;
        String One;
        String Two;
        String Three;
        EnglisCoachClass ec;
        string wordShowOne;
        public MainPage()
        {
            InitializeComponent();
           ec = new EnglisCoachClass();
        }

        private void BtNextWord(object sender, EventArgs e)         // Button Next Page one
        {
            try {
                One = ec.wordsArraysOne();
                OutEnglishWord.Text = One;
                LabelAbout.Text = ec.lengArrayOneFuntion();

            }
            catch
            {
                LabelAbout.Text = "¡Error!   /_('_')_/   ಥ‿ಥ ";
            }
        }

        private void BtNextWordSpanish(object sender, EventArgs e)    // Button Next Page two
        {
            try
            {
                Two = ec.wordsArraysTwo();
                OutSpanishWord.Text = Two;
                LabelSpanishAbout.Text = ec.lengArrayTwoFuntion();
            }
            catch
            {
                LabelAbout.Text = "¡Error!   /_('_')_/   ಥ‿ಥ ";
            }
        }

        private void BtNextWordSpanishEnglish(object sender, EventArgs e)      //Button Next Page Three
        {
            try
            {
                Three = ec.wordsArraysThree();
                OutSpanishEnglishWords.Text = Three;
                LabelSpanishEnglishAbout.Text = ec.lengArrayThreeFuntion();
            }
            catch
            {
                LabelAbout.Text = "¡Error!   /_('_')_/   ಥ‿ಥ ";
            }
        }

        private void BtLimpiar(object sender, EventArgs e)           // Button Clear
        {
            OutEnglishWord.Text = "  ";
            OutSpanishWord.Text = "  ";
            OutSpanishEnglishWords.Text = "  ";
          
        }

        private void BtShow(object sender, EventArgs e)             // Button ShowOne
        {
            try
            {    
                wordShowOne = ec.dictionary_dic(One);
                LabelAbout.Text = wordShowOne;
            }
            catch
            {
                LabelAbout.Text = "¡Error!   /_('_')_/   ಥ‿ಥ ";
            }
        }

        

        private void BtShowTwo(object sender, EventArgs e)    // Button ShowTwo
        {
            try
            {
                LabelSpanishAbout.Text = ec.dictionary_dic(Two);
                
            }
            catch
            {
                LabelSpanishAbout.Text = "¡Error!   /_('_')_/   ಥ‿ಥ ";
            }
        }

        private void BtShowThree(object sender, EventArgs e)    // Button ShowThree
        {
            try
            {
                LabelSpanishEnglishAbout.Text = ec.dictionary_dic(Three);

            }
            catch
            {
                LabelSpanishEnglishAbout.Text = "¡Error!   /_('_')_/   ಥ‿ಥ ";
            }
        }

    }
}
