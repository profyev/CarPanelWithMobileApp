using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPanelWithMobileApp.Common
{
    public class CommonData
    {
        /// <summary>
        /// Текущая температура обдува
        /// </summary>
        public double CurrentTemperature { get;set; }

        /// <summary>
        /// Требуемая температура обдува
        /// </summary>
        public double NeedTemperature { get; set; }

        /// <summary>
        /// Состояние кондиционера
        /// </summary>
        public bool ConditionerState { get; set; }

        /// <summary>
        /// Текущая скорость вращения вентилятора обдума
        /// </summary>
        public int FanSpeed { get; set; }

        public delegate void FanSpeedChangedEventHandler(int newFanSpeed);

        public event FanSpeedChangedEventHandler FanSpeedChanged;
    }
}
