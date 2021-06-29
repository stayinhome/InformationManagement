
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

        /// <summary>
        /// 主题
        /// </summary>
        public List<string> Subject = new List<string>();

        /// <summary>
        /// 上下文关键词
        /// </summary>
        public List<string> KeyWords = new List<string>();

    }

    public class SpeakResult
    {
        /// <summary>
        /// 目标对象
        /// </summary>
        public List<string> Target = new List<string>();

        /// <summary>
        /// 内容
        /// </summary>
        public List<string> Context = new List<string>();

    }



    public enum AtmosphereType
    {
        None = 0,
    }
}