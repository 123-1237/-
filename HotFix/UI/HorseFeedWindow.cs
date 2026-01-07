
using UnityEngine.UI;

namespace HotFix
{
    internal class HorseFeedWindow : Window
    {

        private Button Money;



        public override void Awake(object param1 = null, object param2 = null, object param3 = null)
        {
            GatAllComponent();
            AddAllBtnListener();
        }
        void AddAllBtnListener()
        {

            AddButtonClickListener(Money, ShowMoneyPanel);

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
        }


    }

}
