using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace HotFix
{
    class AllHorseItem
    {
        private Transform m_transform;
        private HorseDetail m_Data;
        private Text m_Name;
        private Text m_Price;
        private Button m_DetileBtn;
        private Button m_LeaseBtn;

        public void init(GameObject item, HorseDetail data)
        {

            m_transform = item.GetComponent<Transform>();
            m_Data = data;
            m_Name = m_transform.Find("Title").GetComponent<Text>();
            m_Price = m_transform.Find("Des/DesNum").GetComponent<Text>();
            m_DetileBtn = m_transform.Find("Btn").GetComponent<Button>();
            m_LeaseBtn = m_transform.Find("RentOut").GetComponent<Button>();
            SetData(data);
        }
        public void SetData(HorseDetail data)
        {
            m_Data = data;
            m_Name.text = data.name;
            m_Price.text = data.price.ToString();
            m_DetileBtn.onClick.RemoveAllListeners();
            m_DetileBtn.onClick.AddListener(() => {
                UIManager.instance.PopUpWnd(FilesName.DETAILPANEL, true, false, m_Data);
            });

            m_LeaseBtn.onClick.RemoveAllListeners();
            m_LeaseBtn.onClick.AddListener(() => {
                RFrameWork.instance.OpenCommonConfirm("提示", "是否花费" + m_Data.price + "租赁" + m_Data.name, () =>
                {
                    if (UserInfoManager.foodNum - float.Parse(m_Data.price) <= 0)
                    {
                        RFrameWork.instance.OpenCommonConfirm("提示", "无法购买，金币不足", () => { }, null);
                    }
                    else
                    {
                        UserInfoManager.foodNum -= float.Parse(m_Data.price);
                        MessageCenter.instance.Dispatch(MessageCenterEventID.RefreshMoney);
                    }

                    //  MessageCenter.instance.Dispatch(MessageCenterEventID.RefrehMoney);
                }, () => { });
            });
            m_transform.gameObject.SetActive(true);
        }
    }

}