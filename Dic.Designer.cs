namespace Dic
{
    partial class Dic
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dic));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLoseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.DataGridView();
            this.txt = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(888, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpenToolStripMenuItem,
            this.cLoseToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.fileToolStripMenuItem.Text = "ファイル";
            // 
            // fileOpenToolStripMenuItem
            // 
            this.fileOpenToolStripMenuItem.Name = "fileOpenToolStripMenuItem";
            this.fileOpenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.fileOpenToolStripMenuItem.Text = "Tsvファイルを開く";
            this.fileOpenToolStripMenuItem.Click += new System.EventHandler(this.fileOpenToolStripMenuItem_Click);
            // 
            // cLoseToolStripMenuItem
            // 
            this.cLoseToolStripMenuItem.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cLoseToolStripMenuItem.Name = "cLoseToolStripMenuItem";
            this.cLoseToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cLoseToolStripMenuItem.Text = "閉じる";
            this.cLoseToolStripMenuItem.Click += new System.EventHandler(this.cLoseToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.helpToolStripMenuItem.Text = "ヘルプ";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versionToolStripMenuItem.Text = "バージョン情報";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(10, 31);
            this.lab.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(95, 17);
            this.lab.TabIndex = 1;
            this.lab.Text = "キー個数入力：";
            // 
            // value
            // 
            this.value.AllowUserToAddRows = false;
            this.value.AllowUserToDeleteRows = false;
            this.value.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.value.Location = new System.Drawing.Point(160, 53);
            this.value.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.value.Name = "value";
            this.value.ReadOnly = true;
            this.value.RowHeadersVisible = false;
            this.value.RowHeadersWidth = 82;
            this.value.RowTemplate.Height = 33;
            this.value.Size = new System.Drawing.Size(718, 642);
            this.value.TabIndex = 5;
            // 
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt.Enabled = false;
            this.txt.Location = new System.Drawing.Point(109, 28);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(48, 24);
            this.txt.TabIndex = 2;
            this.txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_PreviewKeyDown);
            // 
            // key
            // 
            this.key.AllowUserToAddRows = false;
            this.key.AllowUserToDeleteRows = false;
            this.key.AllowUserToOrderColumns = true;
            this.key.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.key.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.key.BackgroundColor = System.Drawing.Color.Wheat;
            this.key.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.key.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.key.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.key.Location = new System.Drawing.Point(12, 53);
            this.key.Name = "key";
            this.key.RowHeadersVisible = false;
            this.key.RowTemplate.Height = 21;
            this.key.Size = new System.Drawing.Size(144, 642);
            this.key.TabIndex = 3;
            this.key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_KeyDown);
            // 
            // search
            // 
            this.search.Enabled = false;
            this.search.Location = new System.Drawing.Point(163, 28);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(43, 23);
            this.search.TabIndex = 4;
            this.search.Text = "検索";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Dic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 707);
            this.Controls.Add(this.search);
            this.Controls.Add(this.key);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.value);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dic";
            this.Text = "辞書ツール";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLoseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.DataGridView value;
        private System.Windows.Forms.ToolStripMenuItem fileOpenToolStripMenuItem;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView key;
    }
}

