using System;
using System.Collections.Generic;
using System.Text;

namespace Module6
{
    enum CoffeMachinMaterial
    {
        Plastic, Wood, Glass
    }

    enum CoffeMachineColor
    {
        White, Black, Red
    }

    class CoffeMachine
    {
        public CoffeMachineColor Color { get; set; }
    }
}
