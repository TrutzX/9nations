using Buildings;
using Game;
using Libraries.FActions;
using Libraries.FActions.General;
using MapElements;
using Players;
using Tools;
using Units;

namespace Classes.Actions
{
    public class ActionSleep : BasePerformAction
    {
        public ActionSleep() : base("sleep"){}

        protected override void Perform(ActionEvent evt, Player player, MapElementInfo info, NVector pos,
            ActionHolder holder)
        {
            //info.data.ap = 0;
            
            if (evt == ActionEvent.Direct)
            {
                info.SetRepeatAction(new ActionWaiting(holder, info.data.action, pos));
                OnMapUI.Get().UpdatePanel(info.Pos());
            }
        }

        protected override void Perform(ActionEvent evt, Player player, ActionHolder holder)
        {
            throw new System.NotImplementedException();
        }

        public override ActionHolder Create(string setting)
        {
            ActionHolder conf = base.Create(setting);
            conf.trigger = ActionEvent.Direct;
            return conf;
        }
    }
}