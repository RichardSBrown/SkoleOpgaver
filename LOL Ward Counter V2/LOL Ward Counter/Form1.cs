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
        Double Top10Wards;
        Double TopTotalWards = 0;
        Double TopTotalPWards = 0;
        Double TopGreenTotalWards = 0;
        Double TopGnsTotalWards;
        Double TopGnsPWards;
        Double TopGnsWards;
        Double TopGns10Wards;
        Double TopGns135Wards;

        Double JungleTotalWards = 0;
        Double JungleTotalPWards = 0;
        Double JungleGreenTotalWards = 0;
        Double JungleGnsTotalWards;
        Double JungleGnsPWards;
        Double JungleGnsWards;
        Double JungleGns10Wards;
        Double JungleGns135Wards;

        Double MidTotalWards = 0;
        Double MidTotalPWards = 0;
        Double MidGreenTotalWards = 0;
        Double MidGnsTotalWards;
        Double MidGnsPWards;
        Double MidGnsWards;
        Double MidGns10Wards;
        Double MidGns135Wards;

        Double ADCTotalWards = 0;
        Double ADCTotalPWards = 0;
        Double ADCGreenTotalWards = 0;
        Double ADCGnsTotalWards;
        Double ADCGnsPWards;
        Double ADCGnsWards;
        Double ADCGns10Wards;
        Double ADCGns135Wards;

        Double SupportTotalWards = 0;
        Double SupportTotalPWards = 0;
        Double SupportGreenTotalWards = 0;
        Double SupportGnsTotalWards;
        Double SupportGnsPWards;
        Double SupportGnsWards;
        Double SupportGns10Wards;
        Double SupportGns35Wards;
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
            TopTotalWards = TotalWards(TopTotalWards, TopWards);

            TxtTopGnsTotalWards.Text = Convert.ToString(Total(TopTotalWards, GameCounter));  // Top Gns Total wards. VIRKER

            TxtTopGnsWards.Text = Convert.ToString(PrTenMin(TotalGameTime, TopTotalWards)); // Top Gns pr 10 min. VIRKER



            Top10Wards = WardRatio(GameTime, TopTotalWards); // Top gns pr 135 sec.



            TxtTopSec.Text = Convert.ToString(TopGns10Wards + Top10Wards);

            TxtTopGnsPWards.Text = Convert.ToString(TotalPWards(TopPWards, TopTotalPWards)); // Top Gns Pink Wards. VIRKER

            TxtTopWards.Text = "";
            TxtTopPWards.Text = "";

        }

        public void JungleData()
        {
            TxtJungleGnsTotalWards.Text = Convert.ToString(Total(JungleGnsTotalWards, GameCounter));  // Top Gns Total wards.
            TxtJungleGnsWards.Text = Convert.ToString(PrTenMin(TotalGameTime, JungleTotalWards)); // Top Gns pr 10 min.
            TxtJungleSec.Text = Convert.ToString(WardRatio(TotalGameTime, JungleWards)); // Top gns pr 135 sec.
            TxtJungleGnsPWards.Text = Convert.ToString(TotalPWards(JunglePWards, JungleTotalPWards)); // Top Gns Pink Wards.
            TxtJungleWards.Text = "";
            TxtJunglePWards.Text = "";
        }

        public void MidData()
        {
            TxtMidGnsTotalWards.Text = Convert.ToString(Total(MidGnsTotalWards, GameCounter));  // Top Gns Total wards.
            TxtMidGnsWards.Text = Convert.ToString(PrTenMin(TotalGameTime, MidTotalWards)); // Top Gns pr 10 min.
            TxtMidSec.Text = Convert.ToString(WardRatio(TotalGameTime, MidWards)); // Top gns pr 135 sec.
            TxtMidGnsPWards.Text = Convert.ToString(TotalPWards(MidPWards, MidTotalPWards)); // Top Gns Pink Wards.
            TxtMidWards.Text = "";
            TxtMidPWards.Text = "";
        }

        public void ADCData()
        {
            TxtADCGnsTotalWards.Text = Convert.ToString(Total(ADCGnsTotalWards, GameCounter));  // Top Gns Total wards.
            TxtADCGnsWards.Text = Convert.ToString(PrTenMin(TotalGameTime, ADCTotalWards)); // Top Gns pr 10 min.
            TxtADCSec.Text = Convert.ToString(WardRatio(TotalGameTime, ADCWards)); // Top gns pr 135 sec.
            TxtADCGnsPWards.Text = Convert.ToString(TotalPWards(ADCPWards, ADCTotalPWards)); // Top Gns Pink Wards.
            TxtADCWards.Text = "";
            TxtADCPWards.Text = "";
        }

        public void SupportData()
        {
            TxtSupportGnsTotalWards.Text = Convert.ToString(Total(SupportGnsTotalWards, GameCounter));  // Top Gns Total wards.
            TxtSupportGnsWards.Text = Convert.ToString(PrTenMin(TotalGameTime, SupportTotalWards)); // Top Gns pr 10 min.
            TxtSupportSec.Text = Convert.ToString(WardRatio(TotalGameTime, SupportWards)); // Top gns pr 135 sec.
            TxtSupportGnsPWards.Text = Convert.ToString(TotalPWards(SupportPWards, SupportTotalPWards)); // Top Gns Pink Wards.
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
