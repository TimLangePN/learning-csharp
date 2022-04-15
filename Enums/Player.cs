using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Player
    {
        public Weapons Weapon { get; set; }
    }

    public enum Weapons
    {
        Gun,
        Sniper,
        Bazooka
    }
}
