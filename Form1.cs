using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // DataSetはメモリ上で一時的にデータを保管する（電源を落としたら消える）
        private void AddButtonClicked(object sender, EventArgs e)
        {
            // DataTableにデータを追加
            bookDataSet.bookDataTable.AddbookDataTableRow(
                this.bookName.Text,
                this.author.Text,
                int.Parse(this.price.Text));  // Parse：stringからintに変換
        }

        private void RemoveButtonClicked(object sender, EventArgs e)
        {
            // 選択した行のデータを削除する
            int row = this.bookDataGrid.CurrentRow.Index;
            this.bookDataGrid.Rows.RemoveAt(row);
        }
    }
}
