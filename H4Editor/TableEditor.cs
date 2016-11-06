using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H4Editor {
	public partial class FormTableEditor:Form {
		public FormTableEditor() {
			InitializeComponent();
		}

		private void FormCreaturesEditor_FormClosing(object sender, FormClosingEventArgs e) {
			// TODO ask the user for save if something changed...
		}

		#region Utilities & Variables
		private object[][] loadFile(string fileName) {
			var b = File.ReadAllBytes(fileName);

			using (var ms = new MemoryStream(b))
			using (var r = new BinaryReader(ms)) {
				int length = r.ReadInt32();
				object[][] values = new object[length][];
				for (int i = 0; i < length; i++) {
					values[i] = r.ReadRow();
				}
				return values;
			}
		}
		#endregion

		private void fromTXTToolStripMenuItem_Click(object sender, EventArgs e) {
			if (openFileDialog.ShowDialog() != DialogResult.OK) return;

			try {
				var values = loadFile(openFileDialog.FileName);
				var dt = new DataTable();
				for (int i = 0; i < values[0].Length; i++) {
					if ((string)values[0][i] == "")
						dt.Columns.Add((string)values[1][i]);
					else dt.Columns.Add($"{values[0][i]};{values[1][i]}");
				}

				for (int i = 2; i < values.Length; i++) {
					dt.Rows.Add(values[i]);
				}

				dataGridView.DataSource = dt;

				dataGridView.AutoResizeColumns();
				dataGridView.AutoResizeRows();
			} catch (Exception ex) {
				MessageBox.Show(this, ex.Message, "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void toTXTToolStripMenuItem_Click(object sender, EventArgs e) {
			if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

			var dt = dataGridView.DataSource as DataTable;
			if (dt == null) return;

			using (var fs = File.OpenWrite(saveFileDialog.FileName))
			using (var w = new BinaryWriter(fs)) {
				int rowCount = dt.Rows.Count + 2;
				w.Write(rowCount);
				short colCount = (short)dt.Columns.Count;
				// Write headers
				w.Write(colCount);
				for (int i = 0; i < colCount; i++) {
					var index = dt.Columns[i].ColumnName.IndexOf(';');
					if (index > -1) {
						w.WriteStr(dt.Columns[i].ColumnName.Substring(0, index));
					} else w.WriteStr("");
				}
				w.Write(colCount);
				for (int i = 0; i < colCount; i++) {
					var colName = dt.Columns[i].ColumnName;
					var index = colName.IndexOf(';');
					if (index > -1) {
						w.WriteStr(colName.Substring(index + 1));
					} else w.WriteStr(colName);
				}
				// Write data
				for (int i = 0; i < rowCount - 2; i++) {
					w.Write(colCount);
					for (int j = 0; j < colCount; j++) {
						w.WriteStr(dt.Rows[i][j].ToString());
					}
				}
			}
		}

		private void toTSVToolStripMenuItem_Click(object sender, EventArgs e) {
			if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

			using (var fs = File.OpenWrite(saveFileDialog.FileName))
			using (var s = new StreamWriter(fs)) {
				// Export cells
				int length = dataGridView.Columns.Count - 1;
				for (int i = 0; i < length; i++)
					s.Write(dataGridView.Columns[i].HeaderText + "\t");
				s.WriteLine(dataGridView.Columns[length].HeaderText);

				// Export values
				foreach (DataGridViewRow row in dataGridView.Rows) {
					for (int i = 0; i < length; i++)
						s.Write(row.Cells[i].Value + "\t");
					s.WriteLine(row.Cells[length].Value);
				}
			}
		}
	}
}
