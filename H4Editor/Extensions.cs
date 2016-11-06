using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4Editor {

	public static class E {
		public static object[] ReadRow(this BinaryReader self) {
			var len = self.ReadInt16();
			var obj = new object[len];
			for (int i = 0; i < len; i++) {
				string v = ReadStr(self);
				int ivalue;
				if (int.TryParse(v, out ivalue))
					obj[i] = ivalue;
				else obj[i] = v;
			}
			return obj;
		}
		public static string ReadStr(this BinaryReader self) {
			int len = self.ReadInt16();
			if (len == 0) return "";
			return new string(self.ReadChars(len));
		}


		public static void WriteStr(this BinaryWriter self, string value) {
			WriteStr(self, value.ToCharArray());
		}
		public static void WriteStr(this BinaryWriter self, char[] value) {
			self.Write((short)value.Length);
			self.Write(value);
		}
	}
}
