using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class WindowTabBuilder : MonoBehaviour
    {
        /// <summary>
        /// Use the create method
        /// </summary>
        private WindowTabBuilder(){}
        public static WindowTabBuilder Create(string title)
        {
            GameObject act = Instantiate(UIElements.Get().tabWindow, GameObject.Find("WindowsMgmt").transform);
            act.name = title;
            act.GetComponent<WindowTabBuilder>().Init(title);
        
            return act.GetComponent<WindowTabBuilder>();
        }
        
        private List<Tab> _tabs;
        private string title;

        public Text header;
        public GameObject content;
        public GameObject tabList;
        
        public void Init(string title)
        {
            _tabs = new List<Tab>();
            this.title = title;
            header.text = title;
        }
        
        public void Add(Tab tab)
        {
            _tabs.Add(tab);
        }

        public void Finish()
        {
            //build tabs
            foreach (Tab t in _tabs)
            {
                UIElements.CreateImageButton(t.Icon(), tabList.transform, () => { ShowTab(t); });
            }

            //show first tab?
            if (_tabs.Count > 0)
            {
                ShowTab(_tabs[0]);
            }

            gameObject.SetActive(true);
        }

        private void ShowTab(Tab t)
        {
            header.text = $"{title} | {t.Name()}";
            UIHelper.ClearChild(content);
            t.Show(content.transform);
        }
    }
}