using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Main.Views
{
    public static class MethodsTable
    {
        public static string getCellValueRowSelected(GridView grid, string column)
        {
            return grid.GetRowCellValue(grid.GetSelectedRows()[0], grid.Columns[column]).ToString();
        }

        public static int getCellValueRowSelectedInt(GridView grid, string column)
        {
            return Convert.ToInt16(grid.GetRowCellValue(grid.GetSelectedRows()[0], grid.Columns[column]).ToString());
        }

        public static int getCellValueRowSelectedIdInt(GridView grid)
        {
            if(grid.RowCount > 0)
                return Convert.ToInt16(grid.GetRowCellValue(grid.GetSelectedRows()[0], grid.Columns["Id"]).ToString());
            return 0;
        }

        public static string getCellValueRowSelectedId(GridView grid)
        {
            return grid.GetRowCellValue(grid.GetSelectedRows()[0], grid.Columns["Id"]).ToString();
        }

        public static string getFocusedCellValue(GridView grid, string item)
        {
            return grid.GetFocusedRowCellValue(item).ToString();
        }

        public static bool messageDelete()
        {
            return (MessageBox.Show("Deseja realmente apagar o item selecionado..?", "Apagar Item..!", MessageBoxButtons.YesNo) == DialogResult.Yes);
        }

        public static void messageIsUsage()
        {
            MessageBox.Show("Este item não pode ser apagado, porque está referênciado à outros itens..!", "Acesso Negado..!", MessageBoxButtons.OK);
        }
        public static void messageJaOperou()
        {
            MessageBox.Show("Esta entidade não pode ser apagada, porque está referênciado à outros documentos..!", "Acesso Negado..!", MessageBoxButtons.OK);
        }

        public static bool itensCombosMaiorZero(ComboBoxEdit cmb)
        {
            return cmb.Properties.Items.Count > 0;
        }

        public static void itensCombosMaiorZeroSelect(ComboBoxEdit cmb)
        {
            if (cmb.Properties.Items.Count > 0)
                cmb.SelectedIndex = 0;
        }

        public static void combosAdd(ComboBoxEdit cmb, string item)
        {
            cmb.Properties.Items.Add(item);
        }


    }
}
