using EloBuddy.SDK.Menu.Values;
using ExorAIO.Utilities;
using LeagueSharp.SDK;

 namespace ExorAIO.Champions.Graves
{
    /// <summary>
    ///     The menu class.
    /// </summary>
    internal class Menus
    {
        /// <summary>
        ///     Sets the menu.
        /// </summary>
        public static void Initialize()
        {
            /// <summary>
            ///     Sets the menu for the Q.
            /// </summary>
            Vars.QMenu = Vars.Menu.AddSubMenu("Use Q to:");
            {
                Vars.QMenu.Add("combo", new CheckBox("Combo", true));
                Vars.QMenu.Add("killsteal", new CheckBox("KillSteal", true));
                Vars.QMenu.Add("logical", new CheckBox("Logical", true));
                Vars.QMenu.Add("clear", new Slider("Clear / if Mana >= x%", 50, 0, 101));
                Vars.QMenu.Add("harass", new Slider("Harass / if Mana >= x%", 50, 0, 101));
            }

            /// <summary>
            ///     Sets the menu for the W.
            /// </summary>
            Vars.WMenu = Vars.Menu.AddSubMenu("Use W to:");
            {
                Vars.WMenu.Add("combo", new CheckBox("Combo", true));
                Vars.WMenu.Add("killsteal", new CheckBox("KillSteal", true));
                Vars.WMenu.Add("logical", new CheckBox("Logical", true));
                Vars.WMenu.Add("gapcloser", new CheckBox("Anti-Gapcloser", true));
            }

            /// <summary>
            ///     Sets the menu for the E.
            /// </summary>
            Vars.EMenu = Vars.Menu.AddSubMenu("Use E to:");
            {
                Vars.EMenu.Add("combo", new CheckBox("Combo", true));
                Vars.EMenu.Add("engager", new CheckBox("Engager", true));
                Vars.EMenu.Add("buildings", new Slider("Buildings / if Mana >= x%", 50, 0, 101));
                Vars.EMenu.Add("jungleclear", new Slider("JungleClear / if Mana >= x%", 50, 0, 101));
            }

            /// <summary>
            ///     Sets the menu for the R.
            /// </summary>
            Vars.RMenu = Vars.Menu.AddSubMenu("Use R to:");
            {
                Vars.RMenu.Add("combo", new CheckBox("Combo", true));
                Vars.RMenu.Add("killsteal", new CheckBox("KillSteal", true));
                Vars.RMenu.AddLabel("The Semi-Automatic R will automatically ult the lowest on health non-invulnerable enemy in range.");
                Vars.RMenu.Add("bool", new CheckBox("Semi-Automatic R", true));
                Vars.RMenu.Add("key", new KeyBind("Key:", false, KeyBind.BindTypes.HoldActive, 'T'));
                {
                    /// <summary>
                    ///     Sets the menu for the R Whitelist.
                    /// </summary>
                    Vars.WhiteList2Menu = Vars.Menu.AddSubMenu("Ultimate: Whitelist Menu");
                    {
                        foreach (var target in GameObjects.EnemyHeroes)
                        {
                            Vars.WhiteList2Menu.Add(
                                    target.ChampionName.ToLower(),
                                    new CheckBox($"Use against: {target.ChampionName}",
                                    true));
                        }
                    }
                }
            }

            /// <summary>
            ///     Sets the drawings menu.
            /// </summary>
            Vars.DrawingsMenu = Vars.Menu.AddSubMenu("Drawings");
            {
                Vars.DrawingsMenu.Add("q", new CheckBox("Q Range"));
                Vars.DrawingsMenu.Add("w", new CheckBox("W Range"));
                Vars.DrawingsMenu.Add("r", new CheckBox("R Range"));
            }
        }
    }
}