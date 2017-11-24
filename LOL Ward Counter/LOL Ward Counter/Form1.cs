using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOL_Ward_Counter
{
    public partial class Form1 : Form
    {
        int GameCounter = 0;

        //The raw input
        int TopWards;
        int JungleWards;
        int MidWards;
        int ADCWards;
        int SupportWards;
        int TopPWards;
        int JunglePWards;
        int MidPWards;
        int ADCPWards;
        int SupportPWards;
        //End of raw input

        //Calculated numbers
        Double TopTotalWards = 0;
        Double TopTotalPWards = 0;
        Double TopGreenTotalWards = 0;
        Double TopGnsTotalWards;
        Double TopGnsPWards;
        Double TopGnsWards;
        Double JungleGnsTotalWards;
        Double JungleGnsPWards;
        Double JungleGnsWards;
        Double MidGnsTotalWards;
        Double MidGnsPWards;
        Double MidGnsWards;
        Double ADCGnsTotalWards;
        Double ADCGnsPWards;
        Double ADCGnsWards;
        Double SupportGnsTotalWards;
        Double SupportGnsPWards;
        Double SupportGnsWards;
        //End of Calculated numbers



        public Form1()
        {
            InitializeComponent();
            LGamesCounter.Text = Convert.ToString(GameCounter);
        }

        private void butSubmit_Click(object sender, EventArgs e)
        {
            GameCounter++;
            LGamesCounter.Text = Convert.ToString(GameCounter);
            CheckBoxs();
            Calculate();
            ConvertBackToString();
            //Add team Gns at some ponit
        }

        public void CheckBoxs()
        {
            

            //Normal WardCounter
            try
            {
                TopWards = Convert.ToInt16(TxtTopWards.Text);
                JungleWards = Convert.ToInt16(TxtJungleWards.Text);
                MidWards = Convert.ToInt16(TxtMidWards.Text);
                ADCWards = Convert.ToInt16(TxtADCWards.Text);
                SupportWards = Convert.ToInt16(TxtSupportWards.Text);
            }
            catch
            {
                TopWards = 0;
                JungleWards = 0;
                MidWards = 0;
                ADCWards = 0;
                SupportWards = 0;
            }
            //End of Check for empty boxs 

            //Pink WardCounter
            try
            {
                TopPWards = Convert.ToInt16(TxtTopPWards.Text);
                JunglePWards = Convert.ToInt16(TxtJunglePWards.Text);
                MidPWards = Convert.ToInt16(TxtMidPWards.Text);
                ADCPWards = Convert.ToInt16(TxtADCPWards.Text);
                SupportPWards = Convert.ToInt16(TxtSupportPWards.Text);
            }
            catch
            {
                TopPWards = 0;
                JunglePWards = 0;
                MidPWards = 0;
                ADCPWards = 0;
                SupportPWards = 0;
            }
            //End of Check for empty boxs

        }

        public void Calculate()
        {
            //Top

            TopTotalWards = TopTotalWards + TopWards + TopPWards;
            TopGnsTotalWards = TopTotalWards / GameCounter;
            TopTotalPWards = TopTotalPWards + TopPWards;
            TopGnsPWards = TopTotalPWards / GameCounter;
            TopGreenTotalWards = TopGreenTotalWards + TopWards;
            TopGnsWards = TopGnsWards / GameCounter;
            //End of Top

            /*//Jungle
            JungleGnsTotalWards = JungleWards + JunglePWards / GameCounter;
            JungleGnsPWards = JunglePWards / GameCounter;
            JungleGnsWards = JungleWards / GameCounter;
            //End of Jungle

            //Mid
            MidGnsTotalWards = MidWards + MidPWards / GameCounter;
            MidGnsPWards = MidPWards / GameCounter;
            MidGnsWards = MidWards / GameCounter;
            //End of Mid

            //ADC
            ADCGnsTotalWards = ADCWards + ADCPWards / GameCounter;
            ADCGnsPWards = ADCPWards / GameCounter;
            ADCGnsWards = ADCWards / GameCounter;
            //End of ADC

            //Support
            SupportGnsTotalWards = SupportWards + SupportPWards / GameCounter;
            SupportGnsPWards = SupportPWards / GameCounter;
            SupportGnsWards = SupportWards / GameCounter;
            //End of Support */
        }

        public void ConvertBackToString()
        {
            //Convert to String
            //top
            TxtTopGnsTotalWards.Text = Convert.ToString(TopGnsTotalWards);
            TxtTopGnsPWards.Text = Convert.ToString(TopGnsPWards);
            TxtTopGnsWards.Text = Convert.ToString(TopGnsWards);
            //End of Top
            /*//Jungle
            TxtJungleGnsTotalWards.Text = Convert.ToString(JungleGnsTotalWards);
            TxtJungleGnsPWards.Text = Convert.ToString(JungleGnsPWards);
            TxtJungleGnsWards.Text = Convert.ToString(JungleGnsWards);
            //End of Jungle
            //Mid
            TxtMidGnsTotalWards.Text = Convert.ToString(MidGnsTotalWards);
            TxtMidGnsPWards.Text = Convert.ToString(MidGnsPWards);
            TxtMidGnsWards.Text = Convert.ToString(MidGnsWards);
            //End of Mid
            //ADC
            TxtADCGnsTotalWards.Text = Convert.ToString(ADCGnsTotalWards);
            TxtADCGnsPWards.Text = Convert.ToString(ADCGnsPWards);
            TxtADCGnsWards.Text = Convert.ToString(ADCGnsWards);
            //End of ADC
            //Support
            TxtSupportGnsTotalWards.Text = Convert.ToString(SupportGnsTotalWards);
            TxtSupportGnsPWards.Text = Convert.ToString(SupportGnsPWards);
            TxtSupportGnsWards.Text = Convert.ToString(SupportGnsWards);
            //End of Support
            //End of Convert to string */
        }
    }
}
