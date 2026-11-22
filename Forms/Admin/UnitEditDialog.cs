#nullable disable

using InventorySystem.Models;
using InventorySystem.Services;
using System;
using System.Windows.Forms;

namespace InventorySystem.Forms.Admin
{
    public partial class UnitEditDialog : Form
    {
        private UnitsService unitsService = new UnitsService();
        private Units editingUnit = null;

        public UnitEditDialog()
        {
            InitializeComponent();
            Text = "Add Unit";
        }

        public UnitEditDialog(Units unit)
        {
            InitializeComponent();
            Text = "Edit Unit";

            editingUnit = unit;

            txtUnitName.Text = unit.UnitName;
            txtUnitSymbol.Text = unit.UnitSymbol;
            chkAllowsFraction.Checked = unit.AllowsFraction;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            string unitName = txtUnitName.Text.Trim();
            string unitSymbol = txtUnitSymbol.Text.Trim();

            short currentUnitId = 0;
            if (editingUnit != null)
            {
                currentUnitId = (short)editingUnit.UnitId;
            }

            if (unitName == "")
            {
                errorProvider.SetError(txtUnitName, "Unit name is required.");
                return;
            }

            if (unitsService.UnitNameExists(unitName, currentUnitId))
            {
                errorProvider.SetError(txtUnitName, "Unit name already exists.");
                return;
            }

            if (unitSymbol == "")
            {
                errorProvider.SetError(txtUnitSymbol, "Unit symbol is required.");
                return;
            }

            if (unitsService.UnitSymbolExists(unitSymbol, currentUnitId))
            {
                errorProvider.SetError(txtUnitSymbol, "Unit symbol already exists.");
                return;
            }

            try
            {
                if (editingUnit == null)
                {
                    Units newUnit = new Units();
                    newUnit.UnitName = unitName;
                    newUnit.UnitSymbol = unitSymbol;
                    newUnit.AllowsFraction = chkAllowsFraction.Checked;

                    unitsService.Save(newUnit);
                    MessageBox.Show(@"Unit created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    editingUnit.UnitName = unitName;
                    editingUnit.UnitSymbol = unitSymbol;
                    editingUnit.AllowsFraction = chkAllowsFraction.Checked;

                    unitsService.Update(editingUnit);
                    MessageBox.Show(@"Unit updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
