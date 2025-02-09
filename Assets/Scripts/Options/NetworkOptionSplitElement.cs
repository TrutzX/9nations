using Libraries;
using UI;
using UI.Show;
using UnityEngine;

namespace Options
{
    public class NetworkOptionSplitElement : BaseOptionSplitElement
    {
        public NetworkOptionSplitElement() : base("network","network", "internet")
        {
        }

        public override void ShowDetail(PanelBuilder panel)
        {
            panel.AddCheckbox(true, "Send errors automatically", s => { }).interactable = false;
            panel.AddCheckbox(true, "Send diagnostics", s => { }).interactable = false;
            panel.AddLabel(
                "If you do not want, to send the infos, please disable the network");
            panel.AddLabel(
                "or use a firewall. See also the privacy statement in the help menu");
            
            base.ShowDetail(panel);
        }

        public override void Perform()
        {
            Debug.LogWarning("Not implemented");
        }
    }
}