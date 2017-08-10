using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Gma.System.MouseKeyHook;
using System.Timers;
using System.IO;

namespace xy
{
    public partial class Form_anzahl_mausklicks : Form
    {
        long tastatur = 0;
        int zeichenspeichercounter = 0;
        int zeichenspeichercounter_maus = 0;
        long maus = 0;
        string zeile, tastaturzeile, datezeile;
        private IKeyboardMouseEvents m_GlobalHook;
        

        public Form_anzahl_mausklicks()
        {
            InitializeComponent();
            m_GlobalHook = Hook.GlobalEvents();             //Statt Start-Button unten -> Um ihn zu löschen und überflüssig zu machen
            m_GlobalHook.MouseDownExt += GlobalHookMouseDownExt;
            m_GlobalHook.KeyPress += GlobalHookKeyPress;
            this.MaximizeBox = false;       //Verhindert Fullscreen und Mimimierung und zeigt Symbole nicht an
            this.MinimizeBox = false;
            


            try {
                StreamReader einlesen_maus = new StreamReader(@"speichere_wert_maus.txt");          //Liesst Anzahl Mausklicks aus File beim Start
                zeile = einlesen_maus.ReadLine();
                maus = long.Parse(zeile);
                einlesen_maus.Close();

                StreamReader einlesen_tastatur = new StreamReader(@"speichere_wert_tastatur.txt");          //Liesst Anzahl Tastatureingaben aus File beim Start
                tastaturzeile = einlesen_tastatur.ReadLine();
                tastatur = long.Parse(tastaturzeile);
                einlesen_tastatur.Close();

                StreamReader einlesen_date = new StreamReader(@"speichere_wert_date.txt");          //Liesst das Datum des letzten Resets aus
                datezeile = einlesen_date.ReadLine();
                tbDate.Visible = true;
                tbDate.Text = datezeile;
                einlesen_date.Close();


                tbAnzahlKeyboard.Text = tastatur.ToString();        //Damit zu Beginn Anzhal drinsteht (weil bis zum öffnen möglicherweise keine Tastatureingabe)
                tbAnzahlMouse.Text = maus.ToString();
            }
            catch (FileNotFoundException)
            {

            }
            


        }


        
        





    private void resetcounter(object sender, EventArgs e)     //Reset
        {
            // Unsubscribe();    //Falls ich wollte, dass bei Reset nicht sofort wieder angefangen wird - siehe Methode unten
            tbAnzahlKeyboard.Text = "Keine Eingabe";
            tbAnzahlMouse.Text = "Keine Eingabe";
            tastatur = 0;
            maus = 0;

            DateTime zeit = DateTime.Now;           //Gibt den letzten Resrt aus und macht Textbox sichtbar
            tbDate.Visible = true;
            tbDate.Text = "Letzter Reset: " + zeit.ToString();

            StreamWriter speichern_date = new StreamWriter(@"speichere_wert_date.txt");
            speichern_date.WriteLine(tbDate.Text);
            speichern_date.Close();
            

        }



        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)     //Immer wenn Keyboard geklickt
        {
            tastatur++;
            tbAnzahlKeyboard.Text = tastatur.ToString();
            zeichenspeichercounter++;

             if (zeichenspeichercounter == 5)               //Speichert bei jeder fünften Tastatureingabe
            {
                StreamWriter speichern = new StreamWriter(@"speichere_wert_tastatur.txt");
                speichern.WriteLine(tastatur.ToString());
                speichern.Close();
                zeichenspeichercounter = 0;
            }

        }



        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)     //Immer wenn Maus geklickt
        {
             maus++;
            tbAnzahlMouse.Text = maus.ToString();
            zeichenspeichercounter_maus++;

            if (zeichenspeichercounter_maus == 5)            //Speichert bei jeder fünften Mauseingabe
            {
                StreamWriter speichern_maus = new StreamWriter(@"speichere_wert_maus.txt");
                speichern_maus.WriteLine(maus.ToString());
                speichern_maus.Close();
                zeichenspeichercounter_maus = 0;
            }
        }

        // uncommenting the following line will suppress the middle mouse button click
        // if (e.Buttons == MouseButtons.Middle) { e.Handled = true; }






        protected override void OnFormClosing(FormClosingEventArgs e)           //Beim Schließen der Form
        {
            base.OnFormClosing(e);                      //Löst Event auf

            e.Cancel = true;                //Verhindert ein Dispose -> Important!!!!

            this.Hide();                //Versteckt die Form (läuft im Backhround weiter)

        }













        /* old stuff--------------------------------------------------*/


        /* private void button2_Click(object sender, EventArgs e)          //start
       {
           if (tastatur == 0 && maus == 0)
           {
               Subscribe();
           }
           else
           {
               DialogResult dialogResult = MessageBox.Show("Prozess bereits gestartet!", "", MessageBoxButtons.OKCancel);
           }
       }    */   //Falls ich wollte, dass bei Reset nicht sofort wieder angefangen wird - siehe Methode unten und STARTBUTTON brauche - will ich nicht!





        /*         public void Unsubscribe()           //ende zählen  edit: wtf kein plan 
                 {
                     try {
                        // m_GlobalHook.MouseDownExt -= GlobalHookMouseDownExt;
                        // m_GlobalHook.KeyPress -= GlobalHookKeyPress;
                        // m_GlobalHook.Dispose();     //Falls ich wollte, dass bei Reset nicht sofort wieder angefangen wir

            }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Prozess nicht gestartet");
                    }
                }                           */






        /* public void Subscribe()     //Start zählen
       {
        /*   // Note: for the application hook, use the Hook.AppEvents() instead
           m_GlobalHook = Hook.GlobalEvents();
           m_GlobalHook.MouseDownExt += GlobalHookMouseDownExt;
           m_GlobalHook.KeyPress += GlobalHookKeyPress;             //jetzt im Konstruktor -> macht Start-Button überflüssig

       } */

    }
}
