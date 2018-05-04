﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;


namespace Day08网络电视精灵
{
    /// <summary>
    /// TypeA类型节目单解析

    /// </summary>
    public class TypeAChannel : ChannelBase
    {
        public override void Fetch()
        {
            XmlDataDocument doc = new XmlDataDocument();
            doc.Load(Path);
            XmlNode root= doc.DocumentElement;
            foreach (XmlNode item in root.ChildNodes)
            {
                //一个item指的是
                if (item.Name=="tvProgramTable")
                {
                    foreach (XmlNode child in item.ChildNodes)
                    {
                         //一个child就是一个节目单
                        TvProgram tv = new TvProgram();
                        tv.FilePath = child["path"].InnerText;
                        tv.Median = child["meridien"].InnerText;
                        tv.PlayTime = Convert.ToDateTime(child["playTime"].InnerText);
                        tv.ProgramName = child["programName"].InnerText;
                        ProgramList.Add(tv);
                    }
                }
            }
        }
    }
}
