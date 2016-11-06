using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H4Editor {
	static class Program {
		/// <summary> The main entry point for the application. </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormTableEditor());
			//using (var fs = File.OpenRead(@"C:\Users\Stamixan\Downloads\mh4.win32.006\table.creatures.txt"))
			//using (var r = new BinaryReader(fs)) {
			//	ReadBytes(r, @"Creatures.txt");
			//}
		}

		private static void ReadBytes(BinaryReader reader, string fileName) {
			using (var f = File.OpenWrite(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + fileName))
			using (var w = new StreamWriter(f)) {
				var fs = reader.BaseStream;
				int length = (int)fs.Length;
				for (int i = 0; i < length; i++) {
					var b = reader.ReadByte();
					switch (b) {
						case (byte)'\r': case (byte)'\n': w.Write("`n "); break;
						default:
							if (b >= 0x20 && b <= 'z')
								w.Write(" " + (char)b + " ");
							else w.Write($"{b:X2} ");
							break;
					}
					if (i % 32 == 31) w.WriteLine();
				}
			}
		}
	}
}
