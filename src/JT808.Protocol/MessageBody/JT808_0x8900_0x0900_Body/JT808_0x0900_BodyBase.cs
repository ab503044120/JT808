﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.MessageBody.JT808_0x8900_0x0900_Body
{
    /// <summary>
    /// 数据上行透传
    /// </summary>
    public abstract class JT808_0x0900_BodyBase
    {
        private const byte JT808_0x0900_0x83_Type = 0x83;

        public static IDictionary<byte, Type> JT808_0x0900Method { get; private set; }

        static JT808_0x0900_BodyBase()
        {
            JT808_0x0900Method = new Dictionary<byte, Type>
            {
                {JT808_0x0900_0x83_Type, typeof(JT808_0x0900_0x83)},
            };
        }

        internal static void AddJT808_0x0900Method<JT808_0x0900_Body>(byte passthroughType)
            where JT808_0x0900_Body : JT808_0x0900_BodyBase
        {
            JT808_0x0900Method.Add(passthroughType, typeof(JT808_0x0900_Body));
        }
    }
}
