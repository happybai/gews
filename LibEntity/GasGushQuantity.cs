﻿// ******************************************************************
// 概  述：瓦斯涌出量实体
// 作  者：伍鑫
// 创建日期：2013/12/08
// 版本号：V1.0
// 版本信息：
// V1.0 新建
// ******************************************************************

namespace LibEntity
{
    public class GasGushQuantity
    {
        /** 编号 **/

        /// <summary>
        ///     编号
        /// </summary>
        public int PrimaryKey { get; set; }

        /** 坐标X **/

        /// <summary>
        ///     坐标X
        /// </summary>
        public double CoordinateX { get; set; }

        /** 坐标Y **/

        /// <summary>
        ///     坐标Y
        /// </summary>
        public double CoordinateY { get; set; }

        /** 坐标Z **/

        /// <summary>
        ///     坐标Z
        /// </summary>
        public double CoordinateZ { get; set; }

        /** 绝对瓦斯涌出量 **/

        /// <summary>
        ///     绝对瓦斯涌出量
        /// </summary>
        public double AbsoluteGasGushQuantity { get; set; }

        /** 相对瓦斯涌出量 **/

        /// <summary>
        ///     相对瓦斯涌出量
        /// </summary>
        public double RelativeGasGushQuantity { get; set; }

        /** 工作面日产量 **/

        /// <summary>
        ///     工作面日产量
        /// </summary>
        public double WorkingFaceDayOutput { get; set; }

        /** 回采年月 **/

        /// <summary>
        ///     回采年月
        /// </summary>
        public string StopeDate { get; set; }

        // 巷道编号

        /// <summary>
        ///     巷道编号
        /// </summary>
        public int TunnelID { get; set; }

        // 煤层编号

        /// <summary>
        ///     煤层编号
        /// </summary>
        public int CoalSeamsId { get; set; }

        /** BID **/

        /// <summary>
        ///     BID
        /// </summary>
        public string BindingId { get; set; }
    }
}