namespace H4Editor {
	partial class FormTableEditor {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fromTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fromTSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toTSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
			this.menuStrip.Size = new System.Drawing.Size(1321, 40);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// importToolStripMenuItem
			// 
			this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromTXTToolStripMenuItem,
            this.fromTSVToolStripMenuItem});
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.Size = new System.Drawing.Size(87, 34);
			this.importToolStripMenuItem.Text = "Import";
			// 
			// fromTXTToolStripMenuItem
			// 
			this.fromTXTToolStripMenuItem.Name = "fromTXTToolStripMenuItem";
			this.fromTXTToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
			this.fromTXTToolStripMenuItem.Text = "from TXT";
			this.fromTXTToolStripMenuItem.Click += new System.EventHandler(this.fromTXTToolStripMenuItem_Click);
			// 
			// fromTSVToolStripMenuItem
			// 
			this.fromTSVToolStripMenuItem.Name = "fromTSVToolStripMenuItem";
			this.fromTSVToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
			this.fromTSVToolStripMenuItem.Text = "from TSV";
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toTXTToolStripMenuItem,
            this.toTSVToolStripMenuItem});
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(84, 34);
			this.exportToolStripMenuItem.Text = "Export";
			// 
			// toTXTToolStripMenuItem
			// 
			this.toTXTToolStripMenuItem.Name = "toTXTToolStripMenuItem";
			this.toTXTToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
			this.toTXTToolStripMenuItem.Text = "to TXT";
			this.toTXTToolStripMenuItem.Click += new System.EventHandler(this.toTXTToolStripMenuItem_Click);
			// 
			// toTSVToolStripMenuItem
			// 
			this.toTSVToolStripMenuItem.Name = "toTSVToolStripMenuItem";
			this.toTSVToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
			this.toTSVToolStripMenuItem.Text = "to TSV";
			this.toTSVToolStripMenuItem.Click += new System.EventHandler(this.toTSVToolStripMenuItem_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(0, 40);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowTemplate.Height = 31;
			this.dataGridView.Size = new System.Drawing.Size(1321, 581);
			this.dataGridView.TabIndex = 1;
			// 
			// openFileDialog
			// 
			this.openFileDialog.DefaultExt = "*.txt";
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.DefaultExt = "*.txt";
			// 
			// FormTableEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1321, 621);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.menuStrip);
			this.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormTableEditor";
			this.ShowIcon = false;
			this.Text = "Table Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCreaturesEditor_FormClosing);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toTSVToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fromTSVToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toTXTToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fromTXTToolStripMenuItem;
	}
}

