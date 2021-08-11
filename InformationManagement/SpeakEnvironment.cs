
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
        public List<SpeakContext> Context = new List<SpeakContext>();


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

    public class SpeakContext
    {
        /// <summary>
        /// 说话人ID
        /// </summary>
        public int SperkerID = 0;

        /// <summary>
        /// 主题左
        /// </summary>
        public List<string> SubjectListLeft = new List<string>();

        /// <summary>
        /// 主题右
        /// </summary>
        public string SubjectListRight = "";

        /// <summary>
        /// 主题逻辑
        /// </summary>
        public SubjectLogic logic = SubjectLogic.Equal;
    }

    public enum SubjectLogic
    {
        /// <summary>
        /// 相等
        /// </summary>
        Equal = 0,

        /// <summary>
        /// 包含
        /// </summary>
        Include = 1,

        /// <summary>
        /// 因果
        /// </summary>
        Cause = 2,
    }

    /// <summary>
    /// 目的
    /// </summary>
    public enum SpeakPurpose
    {



    }

    public enum AtmosphereType
    {
        None = 0,
    }
}