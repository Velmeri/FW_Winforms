using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FW_Winforms
{
	public static class Global
	{
		static public Color erroeColor { get; set; }
		static public Color standartColor { get; set; }

		static Global()
		{
			erroeColor = Color.Red;
			standartColor = Color.Black;
		}
	}
}
