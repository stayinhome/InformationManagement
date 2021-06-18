
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace InformationManagement
{
    public class SpeakEnvironment
    {
        /// <summary>
        /// 士气值
        /// </summary>
        public int Morale = 0;

        /// <summary>
        /// 氛围
        /// </summary>
        public AtmosphereType AtmosphereType = AtmosphereType.None;

    }


    public enum AtmosphereType
    {
        None = 0,
    }
}