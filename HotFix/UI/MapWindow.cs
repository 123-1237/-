using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace HotFix
{
    public class MapWindow : Window
    {
        private Button siYangChangBtn;
        private Button fanYuChangBtn;
        private Button saiMaChangBtn;
        private Button closeBtn;

        RawImage rapImage;

        Camera camera;

        public override void Awake(object param1 = null, object param2 = null, object param3 = null)
        {
            GatAllComponent();
            AddAllBtnListener();
        }

        void AddAllBtnListener()
        {
            AddButtonClickListener(closeBtn, CloseWndFunc);
            AddButtonClickListener(siYangChangBtn, GoToSiYangChang);
            AddButtonClickListener(fanYuChangBtn, GoToSaiYangChang);
            AddButtonClickListener(saiMaChangBtn, GoToFanYangChang);

        }

        private void GoToFanYangChang()
        {
            MessageCenter.instance.Dispatch(MessageCenterEventID.PlayerChangePosition, new Notification(3));
        }

        private void GoToSaiYangChang()
        {
            MessageCenter.instance.Dispatch(MessageCenterEventID.PlayerChangePosition, new Notification(2));
        }

        void GoToSiYangChang()
        {
            MessageCenter.instance.Dispatch(MessageCenterEventID.PlayerChangePosition, new Notification(1));
        }


        void CloseWndFunc()
        {
            UIManager.instance.CloseWnd(this);
        }

        private void GatAllComponent()
        {
            siYangChangBtn = m_Transform.Find("MapBack/siyangchang").GetComponent<Button>();
            fanYuChangBtn = m_Transform.Find("MapBack/fanzhichang").GetComponent<Button>();
            saiMaChangBtn = m_Transform.Find("MapBack/saimachang").GetComponent<Button>();
            closeBtn = m_Transform.Find("MapBack/Close").GetComponent<Button>();
            rapImage = m_Transform.Find("MapBack/RawImage").GetComponent<RawImage>();
            camera = m_Transform.Find("Camera").GetComponent<Camera>();
        }
    }
}
