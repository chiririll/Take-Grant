using System;
using System.Drawing;
using System.Windows.Forms;
using TakeGrant.Model;

namespace TakeGrant.View
{
    public class AccessMatrixView
    {
        private readonly DataGridView grid;

        private AccessModel model;
        private bool ignoreEvent = false;

        public AccessMatrixView(DataGridView grid)
        {
            this.grid = grid;

            grid.CellEndEdit += UpdateItem;
        }

        ~AccessMatrixView()
        {
            grid.CellEndEdit -= UpdateItem;
        }

        public void Init(AccessModel model)
        {
            this.model = model;
            model.OnMatrixChanged += UpdateGrid;

            UpdateGrid();
        }

        public void UpdateGrid()
        {
            if (ignoreEvent) return;

            grid.Columns.Clear();
            grid.Rows.Clear();

            var i = 0;
            foreach (var item in model.Subjects)
            {
                grid.Columns.Add(item.ShortName, item.ShortName);
                grid.Rows.Add();
                
                grid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                grid.Rows[i].HeaderCell.Value = item.ShortName;

                grid.Rows[i].Cells[i].ReadOnly = true;
                grid.Rows[i].Cells[i].Style.BackColor = Color.LightGray;

                i++;
            }
            
            foreach (var item in model.Objects)
            {
                grid.Columns.Add(item.ShortName, item.ShortName);
                grid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            i = 0;
            foreach (var item in model.Items)
            {
                foreach (var right in item.AccessRights)
                {
                    grid.Rows[i].Cells[right.Key].Value = Rights.ToString(right.Value);
                }
                i++;
            }
        }

        private void UpdateItem(object sender, DataGridViewCellEventArgs e)
        {
            var cell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value == null)
                return;

            var rights = Rights.FromString(cell.Value.ToString(), e.ColumnIndex >= model.Subjects.Count);

            var srcItem = model.Items[e.RowIndex];
            var dstItem = model.Items[e.ColumnIndex];

            srcItem.EditRights(dstItem.id, rights);
            grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Rights.ToString(rights);

            ignoreEvent = true;
            model.Invalidate();
            ignoreEvent = false;
        }
    }
}
