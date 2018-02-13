using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOL_Ward_Counter
{
    // Add a clear the boxes
    // Add a ward scorre

    public partial class Form1 : Form
    {
        Double GameCounter = 0;
        

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
        int GameTime;
        int TotalGameTime;
        
        //End of raw input

        //Calculated numbers
        Double TopTotalWards = 0;
        Double TopTotalPWards = 0;
        Double TopWardRatioGame;

        Double JungleTotalWards = 0;
        Double JungleTotalPWards = 0;
        Double JungleWardRatioGame;

        Double MidTotalWards = 0;
        Double MidTotalPWards = 0;
        Double MidWardRatioGame;

        Double ADCTotalWards = 0;
        Double ADCTotalPWards = 0;
        Double ADCWardRatioGame;

        Double SupportTotalWards = 0;
        Double SupportTotalPWards = 0;
        Double SupportWardRatioGame;


        //End of Calculated numbers

        public Form1()
        {
            InitializeComponent();
            LGamesCounter.Text = Convert.ToString(GameCounter);
        }


        public void butSubmit_Click(object sender, EventArgs e)
        {
            GameCounter++;
            LGamesCounter.Text = Convert.ToString(GameCounter);
            CheckBoxs();
            GameData();
            TopData();
            JungleData();
            MidData();
            ADCData();
            SupportData();

            //Add team Gns at some ponit
        }

        public void GameData()
        {
            GameTime = Convert.ToInt16(TxtGameTime.Text);
            TotalGameTime = TotalTime(GameTime, TotalGameTime);
        }

        public void TopData()
        {
            TopTotalWards = TotalWards(TopTotalWards, TopWards); // Top Total Ward.
            TxtTopGnsTotalWards.Text = Convert.ToString(Total(TopTotalWards, GameCounter));  // Top Gns Total wards. VIRKER
            TxtTopGnsWards.Text = Convert.ToString(PrTenMin(TotalGameTime, TopTotalWards)); // Top Gns pr 10 min. VIRKER
            TopWardRatioGame = WardRatio(GameTime, TopTotalWards); // Top gns pr 135 sec.
            TxtTopSec.Text = Convert.ToString(TopWardRatioGame) + TxtTopSec.Text; // Virker tror jeg :/
            TxtTopGnsPWards.Text = Convert.ToString(TotalPWards(TopPWards, TopTotalPWards)); // Top Gns Pink Wards. VIRKER
       
            TxtTopWards.Text = "";
            TxtTopPWards.Text = "";

        }

        public void JungleData()
        {
            JungleTotalWards = TotalWards(JungleTotalWards, JungleWards); // Top Total Ward.
            TxtJungleGnsTotalWards.Text = Convert.ToString(Total(JungleTotalWards, GameCounter));  // Top Gns Total wards. VIRKER
            TxtJungleGnsWards.Text = Convert.ToString(PrTenMin(TotalGameTime, JungleTotalWards)); // Top Gns pr 10 min. VIRKER
            JungleWardRatioGame = WardRatio(GameTime, JungleTotalWards); // Top gns pr 135 sec.
            TxtJungleSec.Text = Convert.ToString(JungleWardRatioGame) + TxtJungleSec.Text; // Virker tror jeg :/
            TxtJungleGnsPWards.Text = Convert.ToString(TotalPWards(JunglePWards, JungleTotalPWards)); // Top Gns Pink Wards. VIRKER
            TxtJungleWards.Text = "";
            TxtJunglePWards.Text = "";
        }

        public void MidData()
        {
            MidTotalWards = TotalWards(MidTotalWards, MidWards); // Top Total Ward.
            TxtMidGnsTotalWards.Text = Convert.ToString(Total(MidTotalWards, GameCounter));  // Top Gns Total wards. VIRKER
            TxtMidGnsWards.Text = Convert.ToString(PrTenMin(TotalGameTime, MidTotalWards)); // Top Gns pr 10 min. VIRKER
            MidWardRatioGame = WardRatio(GameTime, MidTotalWards); // Top gns pr 135 sec.
            TxtMidSec.Text = Convert.ToString(MidWardRatioGame) + TxtMidSec.Text; // Virker tror jeg :/
            TxtMidGnsPWards.Text = Convert.ToString(TotalPWards(MidPWards, MidTotalPWards)); // Top Gns Pink Wards. VIRKER
            TxtMidWards.Text = "";
            TxtMidPWards.Text = "";
        }

        public void ADCData()
        {
            ADCTotalWards = TotalWards(ADCTotalWards, ADCWards); // Top Total Ward.
            TxtADCGnsTotalWards.Text = Convert.ToString(Total(ADCTotalWards, GameCounter));  // Top Gns Total wards. VIRKER
            TxtADCGnsWards.Text = Convert.ToString(PrTenMin(TotalGameTime, ADCTotalWards)); // Top Gns pr 10 min. VIRKER
            ADCWardRatioGame = WardRatio(GameTime, ADCTotalWards); // Top gns pr 135 sec.
            TxtADCSec.Text = Convert.ToString(ADCWardRatioGame) + TxtADCSec.Text; // Virker tror jeg :/
            TxtADCGnsPWards.Text = Convert.ToString(TotalPWards(ADCPWards, ADCTotalPWards)); // Top Gns Pink Wards. VIRKER
            TxtADCWards.Text = "";
            TxtADCPWards.Text = "";
        }

        public void SupportData()
        {
            SupportTotalWards = TotalWards(TopTotalWards, TopWards); // Top Total Ward.
            TxtSupportGnsTotalWards.Text = Convert.ToString(Total(TopTotalWards, GameCounter));  // Top Gns Total wards. VIRKER
            TxtSupportGnsWards.Text = Convert.ToString(PrTenMin(TotalGameTime, TopTotalWards)); // Top Gns pr 10 min. VIRKER
            SupportWardRatioGame = WardRatio(GameTime, TopTotalWards); // Top gns pr 135 sec.
            TxtSupportSec.Text = Convert.ToString(SupportWardRatioGame) + TxtTopSec.Text; // Virker tror jeg :/
            TxtSupportGnsPWards.Text = Convert.ToString(TotalPWards(SupportPWards, SupportTotalPWards)); // Top Gns Pink Wards. VIRKER
            TxtSupportWards.Text = "";
            TxtSupportPWards.Text = "";
        }


        public void CheckBoxs()
        {
            

            //Normal WardCounter
            if (TxtTopWards.Text == "")
            {
                TopWards = 0;
            }
            else
            {
                TopWards = Convert.ToInt16(TxtTopWards.Text);
            }
            if (TxtJungleWards.Text == "")
            {
                JungleWards = 0;
            }
            else
            {
                JungleWards = Convert.ToInt16(TxtJungleWards.Text);
            }
            if (TxtMidWards.Text == "")
            {
                MidWards = 0;
            }
            else
            {
                MidWards = Convert.ToInt16(TxtMidWards.Text);
            }
            if (TxtADCWards.Text == "")
            {
                ADCWards = 0;
            }
            else
            {
                ADCWards = Convert.ToInt16(TxtADCWards.Text);
            }
            if (TxtSupportWards.Text == "") {
                SupportWards = 0;
            }
            else
            {
                SupportWards = Convert.ToInt16(TxtSupportWards.Text);
            }
            //End of Check for empty boxs 

            //Pink WardCounter
            if (TxtTopPWards.Text == "")
            {
                TopPWards = 0;
            }
            else
            {
                TopPWards = Convert.ToInt16(TxtTopPWards.Text);
            }
            if (TxtJunglePWards.Text == "")
            {
                JunglePWards = 0;
            }
            else
            {
                JunglePWards = Convert.ToInt16(TxtJunglePWards.Text);
            }
            if (TxtMidPWards.Text == "")
            {
                MidPWards = 0;
            }
            else
            {
                MidPWards = Convert.ToInt16(TxtMidPWards.Text);
            }
            if (TxtADCPWards.Text == "")
            {
                ADCPWards = 0;
            }
            else
            {
                ADCPWards = Convert.ToInt16(TxtADCPWards.Text);
            }
            if (TxtSupportPWards.Text == "")
            {
                SupportPWards = 0;
            }
            else
            {
                SupportPWards = Convert.ToInt16(TxtSupportPWards.Text);
            }
            //End of Check for empty boxs

        }

        public int TotalTime(int time, int totaltime)
        {
            int Data = time + totaltime;
            return Data;
        }

        public Double TotalWards (Double TotalWard, int ward)
        {
            Double Data = TotalWard + ward;
            return Data;
        }


        public Double PrTenMin(int time, Double ward)
        {
            Double Data = ward / time * 10;
            return Data;
        }

        public double WardRatio (int time, Double ward)
        {
            float tempData = (60 * time) / 135f;
            Console.WriteLine("temp " + tempData);
            double Data = ward - tempData;
            Console.WriteLine(Data);
            return Data;
        }

        public Double Total (Double ward, Double games)
        {
            Double Data = ward / games;
            return Data;
        }

        public Double TotalPWards (int Pink, Double TotalPink)
        {
            Double Data = Pink + TotalPink;
            return Data;
        }
    }
}
