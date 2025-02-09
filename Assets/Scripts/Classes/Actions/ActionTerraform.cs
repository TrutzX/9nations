using System.Collections.Generic;
using Buildings;
using Game;
using Libraries;
using Libraries.FActions;
using Libraries.FActions.General;
using Libraries.Terrains;
using MapElements;
using Players;
using Tools;
using UI;
using Units;
using UnityEngine;

namespace Classes.Actions
{
    public class ActionTerraform : BasePerformAction
    {
        public ActionTerraform() : base("terraform")
        {
        }

        protected override void Perform(ActionEvent evt, Player player, MapElementInfo info, NVector pos,
            ActionHolder holder)
        {
            DataTerrain terrain = GameMgmt.Get().newMap.Terrain(pos);

            //which is possible?
            List<(string key, string value)> opts = new List<(string key, string value)>();
            int i = 0;
            while (holder.data.ContainsKey(i.ToString()))
            {
                var d = SplitHelper.Split(holder.data[i.ToString()]);
                if (terrain.id == d.key)
                    opts.Add(d);
                i++;
            }

            //found it?
            if (opts.Count == 0)
            {
                OnMapUI.Get().unitUI.ShowPanelMessageError($"No terraform possible for {terrain.Name()}");
                return;
            }

            Vector3Int v3 = new Vector3Int(pos.x, pos.y, 1); //TODO find right pos
            if (opts.Count == 1)
            {
                GameMgmt.Get().newMap.levels[pos.level]
                    .SetTile(v3, opts[0].value == "remove" ? null : L.b.terrains[opts[0].value]);
                return;
            }

            //multiple?
            WindowPanelBuilder wpb = WindowPanelBuilder.Create($"Terraform {terrain.Name()}");
            foreach (var opt in opts)
            {
                wpb.panel.AddImageTextButton(CreateTitle(opt), terrain.Sprite(), () =>
                {
                    GameMgmt.Get().newMap.levels[pos.level]
                        .SetTile(v3, opt.value == "remove" ? null : L.b.terrains[opt.value]);
                    wpb.Close();
                });
            }

            wpb.AddClose();
            wpb.Finish();
        }

        protected override void Perform(ActionEvent evt, Player player, ActionHolder holder)
        {
            throw new System.NotImplementedException();
        }

        public override void BuildPanel(ActionDisplaySettings sett)
        {
            base.BuildPanel(sett);

            //list it
            int i = 0;
            while (sett.holder.data.ContainsKey(i.ToString()))
            {
                var d = SplitHelper.Split(sett.holder.data[i.ToString()]);
                DataTerrain terr = L.b.terrains[d.key];
                sett.panel.AddImageLabel(CreateTitle(d), terr.Icon);
                i++;
            }
        }

        private static string CreateTitle((string key, string value) d)
        {
            return d.value == "remove"
                ? $"Remove terrain {L.b.terrains[d.key].Name()}"
                : $"Convert {L.b.terrains[d.key].Name()} to {L.b.terrains[d.value].Name()}";
        }

        public override ActionHolder Create(string setting)
        {
            ActionHolder conf = base.Create(setting);
            conf.trigger = ActionEvent.Direct;

            string req = "";
            int i = 0;
            foreach (var e in SplitHelper.Separator(setting))
            {
                conf.data[(i++).ToString()] = e;
                req += req.Length > 0 ? ";" : "";
                req += SplitHelper.Split(e).key;
            }

            conf.req.Add("terrain", req);

            return conf;
        }
    }
}