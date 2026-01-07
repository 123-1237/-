using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;

namespace HotFix
{

    class RentWindow:Window
    {
        private Button leaseBtn;
        private Button closeBtn;



        public override void Awake(object param1 = null, object param2 = null, object param3 = null)
        {
            GatAllComponent();
            AddAllBtnListener();
        }
        void AddAllBtnListener()
        {

            AddButtonClickListener(leaseBtn, LeaseHorsePanel);
            AddButtonClickListener(closeBtn, ClosePanel);
          //Console.WriteLine("2222222222");
          

        }

        private void ClosePanel()
        {
           // UIManager.instance.CloseWnd(FilesName.RENTPANEL);
        }

        private void LeaseHorsePanel()
        {
            UIManager.instance.PopUpWnd(FilesName.RENTPANEL, true, false, leaseBtn.transform);
           //onsole.WriteLine("租马");
       }
        private void GatAllComponent()
        {
            leaseBtn = m_Transform.Find("Btns/LeaseHorse").GetComponent<Button>();
            closeBtn = m_Transform.Find("BackImg/CloseBtn").GetComponent<Button>();
        }
    }
}
