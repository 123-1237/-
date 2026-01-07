using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace HotFix
{
    internal class HorseFeedWindow:Window
    {
        private Button Money;
        private Button Close;



        public override void Awake(object param1 = null, object param2 = null, object param3 = null)
        {
            GatAllComponent();
            AddAllBtnListener();
        }
        void AddAllBtnListener()
        {
          
            AddButtonClickListener(Money, ShowMoneyPanel);
           AddButtonClickListener(Close, Closepanel);

        }

        private void Closepanel()
        {
            UIManager.instance.CloseWnd(FilesName.HORSEFEEDPANEL);
        }

        private void ShowMoneyPanel()
        {
            UIManager.instance.PopUpWnd(FilesName.HORSEFEEDPANEL, true, false, Money.transform);
        }
        private void GatAllComponent()
        {
            Money = m_Transform.Find("Btns/Money").GetComponent<Button>();
           Close = m_Transform.Find("BackImg/Close").GetComponent<Button>();
        }
        
       
    }
}
