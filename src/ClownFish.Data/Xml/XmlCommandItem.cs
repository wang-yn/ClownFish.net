﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ClownFish.Base.Xml;

namespace ClownFish.Data.Xml
{
	/// <summary>
	/// 表示*.XmlCommand.config文件中的一个XmlCommand配置项。
	/// </summary>
	[XmlType("XmlCommand")]
	[Serializable]
	public sealed class XmlCommandItem
	{
		/// <summary>
		/// 命令的名字，这个名字将在XmlCommand.From时被使用。
		/// </summary>
		[XmlAttribute("Name")]
		public string CommandName { get; set; }

		/// <summary>
		/// 命令所引用的所有参数集合
		/// </summary>
		[XmlArrayItem("Parameter")]
		public List<XmlCmdParameter> Parameters = new List<XmlCmdParameter>();

		/// <summary>
		/// 命令的文本。是一段可运行的SQL脚本或存储过程名称。
		/// </summary>
		[XmlElement]
		public XmlCdata CommandText { get; set; }

		/// <summary>
		/// SQL命令类型
		/// </summary>
		[DefaultValue(CommandType.Text)]
		[XmlAttribute]
		public CommandType CommandType = CommandType.Text;

		/// <summary>
		/// 获取或设置在终止执行命令的尝试并生成错误之前的等待时间。 
		/// </summary>
		[DefaultValue(30)]
		[XmlAttribute]
		public int Timeout = 30;
	}

	
}
