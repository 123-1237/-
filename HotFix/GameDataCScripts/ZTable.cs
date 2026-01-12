using System.Collections;
using System.Collections.Generic;
using W.GameFrameWork.ExcelTool;
/*
* Author:W
* Excel表转换生成
* ZTable
*/
namespace HotFix
{
	[System.Serializable]
	public class ZTableParSer
	{
		public List<ZTable> data = new List<ZTable>();
		public List<ZTable> Data
		{
			get
			{
				return data;
			} 
		}	} 
	[System.Serializable]
	public class ZTable:ExcelItem
	{
	/// <summary>
	/// 编号
	/// <summary>
	public int ID;
	/// <summary>
	/// 名字
	/// <summary>
	public string Name;

	}
}