﻿using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace Terraria.Plugins.Common {
  public class PlayerEventArgs: EventArgs {
    public Player TPlayer { get; private set; }


    public PlayerEventArgs(Player tPlayer) {
      //Contract.Requires<ArgumentNullException>(tPlayer != null);
            if (tPlayer == null) throw new ArgumentNullException();

            this.TPlayer = tPlayer;
    }
  }
}
