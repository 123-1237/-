using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotFix
{
    class GetHorseDataClass
    {
            public int ID;
            public string Code;
            public string Name;
            public string Age;
            public string Endurance;
            public string StartSpeed;
            public string Speed;
            public string Wisdom;
            public string Fatigue;
            public string EnduranceMax;
            public string StartSpeedMax;
            public string SpeedMax;
            public string WisdomMax;
            public string FatigueMax;
            public string Status;
            public string Stage;
            public string IsRent;
            public string TotalFeedProgress;
            public string RemainFeedProgress;
            public string RemainFeedTime;
            public string TotalGrowUpProgress;
            public string AlreadyGrowUpProgress;
            public string RemainGrowUpNumber;
            public int RemainGrowUpTime;
            public int MatchNumebr;
            public string WinRate;
            public string Pic;
            public string Price;
            public string Time;

            public GetHorseDataClass(int id, string code, string name, string age, string endurance, string startSpeed, string speed, string wisdom, string fatigue, string enduranceMax, string startSpeedMax, string speedMax, string wisdomMax, string fatigueMax, string status, string stage, string isRent, string totalFeedProgress, string remainFeedProgress, string remainFeedTime, string totalGrowUpProgress, string alreadyGrowUpProgress, string remainGrowUpNumber, int remainGrowUpTime, int matchNumebr, string winRate, string pic, string price, string time)
            {
                ID = id;
                Code = code;
                Name = name;
                Age = age;
                Endurance = endurance;
                StartSpeed = startSpeed;
                Speed = speed;
                Wisdom = wisdom;
                Fatigue = fatigue;
                EnduranceMax = enduranceMax;
                StartSpeedMax = startSpeedMax;
                SpeedMax = speedMax;
                WisdomMax = wisdomMax;
                FatigueMax = fatigueMax;
                Status = status;
                Stage = stage;
                IsRent = isRent;
                TotalFeedProgress = totalFeedProgress;
                RemainFeedProgress = remainFeedProgress;
                RemainFeedTime = remainFeedTime;
                TotalGrowUpProgress = totalGrowUpProgress;
                AlreadyGrowUpProgress = alreadyGrowUpProgress;
                RemainGrowUpNumber = remainGrowUpNumber;
                RemainGrowUpTime = remainGrowUpTime;
                MatchNumebr = matchNumebr;
                WinRate = winRate;
                Pic = pic;
                Price = price;
                Time = time;
        }
    }
}
