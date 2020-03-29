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

namespace Dic
{
    public partial class Dic : Form
    {
        public Dic()
        {
            InitializeComponent();
        }

        private DataTable dt;

        private void cLoseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author:Shiming Xu\r\nDate:2020.3.28\r\nVersion:1.0", "バージョン情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fileOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.FileName = "dic.csv";
            ofd.InitialDirectory = @"E:\work";
            ofd.Filter = "Tsvファイル(*.tsv)|*.tsv|すべてのファイル(*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.Title = "開くファイルを選択してください";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dt = new DataTable("Dic");
                var stm = ofd.OpenFile();
                if (stm != null)
                {
                    using (var reader = new StreamReader(stm, Encoding.GetEncoding("shift_jis")))
                    {
                        var dicWords = reader.ReadToEnd().Replace("\r\n", "\n").Split(new[] { '\n' }).ToList();
                        if (dicWords.Count >= 2)
                        {
                            dt.Columns.Add("No.", Type.GetType("System.String"));
                            dicWords[0].Split(new[] { '\t' }).ToList().ForEach(x =>
                               {
                                   dt.Columns.Add(new DataColumn(x, Type.GetType("System.String")));
                               }
                            );
                            for (var idx = 1; idx < dicWords.Count; idx++)
                            {
                                var rows = dicWords[idx].Split(new[] { '\t' }).ToList();
                                rows.Insert(0, idx.ToString());
                                dt.Rows.Add(rows.ToArray());
                            }
                            this.txt.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Tsvファイルには辞書データがありません！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(this.txt.Text) && int.TryParse(this.txt.Text, out int num))
                {
                    var dt = new DataTable("Key");
                    dt.Columns.Add(new DataColumn("No.", Type.GetType("System.Int32")));
                    dt.Columns.Add(new DataColumn("キー", Type.GetType("System.String")));
                    for (var idx = 1; idx <= int.Parse(this.txt.Text); idx++)
                    {
                        dt.Rows.Add(idx, String.Empty);
                    }
                    this.key.DataSource = dt;
                    this.key.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    this.key.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    this.key.Columns[1].Width = 88;
                    foreach (DataGridViewColumn dgvc in key.Columns)
                    {
                        dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    this.key.Refresh();
                    this.search.Enabled = true;
                }
                else
                {
                    MessageBox.Show("キー個数を入力してください！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            var valueDt = dt.Clone();
            valueDt.Clear();
            var idx = 1;
            ((DataTable)this.key.DataSource).AsEnumerable().Select(x => x["キー"].ToString()).ToList().ForEach(x =>
                {
                    var drValues = dt.AsEnumerable().Where(y => y["キー"].ToString().Equals(x)).Select(y => y);
                    if (drValues != null && drValues.Count() > 0)
                    {
                        var dr = valueDt.NewRow();
                        dr.ItemArray = drValues.FirstOrDefault().ItemArray;
                        dr.ItemArray[0] = idx.ToString();

                        valueDt.Rows.Add(dr);
                    }
                    else
                    {
                        var nonLst = new List<String>();
                        for (var i = 0; i < dt.Columns.Count; i++)
                        {
                            nonLst.Add("辞書なし");
                        }
                        nonLst.Insert(0, x);
                        nonLst.Insert(0, idx.ToString());
                        var row = valueDt.NewRow();
                        row.ItemArray = nonLst.ToArray();
                        valueDt.Rows.Add(row);
                    }
                    idx++;
                }
            ); ;
            this.value.DataSource = valueDt;
        }

        private void key_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                var words = Clipboard.GetText().Replace("\r\n", "\n").Split(new[] { '\n' }).ToList();
                var idx = 0;
                foreach (DataGridViewCell dgvc in key.SelectedCells)
                {
                    int r = key.SelectedCells.Count - dgvc.RowIndex - 1;
                    int c = dgvc.ColumnIndex;
                    if (idx < words.Count)
                    {
                        this.key.Rows[r].Cells[c].Value = words[idx];
                    }
                    else
                    {
                        this.key.Rows[r].Cells[c].Value = string.Empty;
                    }
                    idx++;
                }
                this.key.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                this.key.Refresh();
            }
            if ( e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewCell dgvc in key.SelectedCells)
                {
                    int r = key.SelectedCells.Count - dgvc.RowIndex - 1;
                    int c = dgvc.ColumnIndex;
                    this.key.Rows[r].Cells[c].Value = string.Empty;
                }
                this.key.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                this.key.Refresh();
            }
        }
    }
}
