using InventorySystem.Models;
using InventorySystem.Services;

namespace InventorySystem.Forms.Staff
{
    public partial class StaffDashboardControl : UserControl {

        private readonly ProductService ProductService = new();
        private readonly StockService StockService = new();
        private readonly StockMovementService StockMovementService = new();
        private readonly CategoryService CategoryService = new();

        public StaffDashboardControl() {
            InitializeComponent();
        }

        private void LoadKpis() {
            // para sa total 
            int rowCount = ProductService.Count();
            lblTotalProducts.Text = rowCount.ToString();

            // para sa low stock
            lblLowStock.Text = StockService.CountLowStock().ToString();

            // para sa todays transaction
            lblTransactions.Text = StockMovementService.CountByCreatedAtRange(DateTime.Now, DateTime.Now.AddDays(1)).ToString();
        }

        private void LoadRecentTransactions() {
            List<StockMovement> movements = StockMovementService.All();

            movements.ForEach(movement => {
                dgvTransactions.Rows.Add(
                    movement.ProductId,
                    movement.MovementType.ToString(),
                    movement.Quantity,
                    movement.StorageLocation,
                    movement.ReferenceNo
                );
            });
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void DashboardControl_Load(object sender, EventArgs e) {
            LoadKpis();
            LoadRecentTransactions();

            List<Category> categories = CategoryService.All();
            categories.ForEach(category => {
                cmbProductCategory.Items.Add(category.CategoryName);
            }
            );
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            LoadRecentTransactions();
        }
        
        private void btnSearch_Click(object sender, EventArgs e) {
            string searchTerm = txtSearch.Text;
            string selectedCategory = cmbProductCategory.SelectedItem?.ToString() ?? string.Empty;
            
            List<StockMovement> movements;
            
            if (!string.IsNullOrEmpty(searchTerm) || !string.IsNullOrEmpty(selectedCategory)) {
                Category category = CategoryService.GetByName(selectedCategory);
                movements = StockMovementService.Find(searchTerm, category);
            } else {
                movements = StockMovementService.Find(searchTerm);
            }

            dgvTransactions.Rows.Clear();
            movements.ForEach(movement => {
                dgvTransactions.Rows.Add(
                    movement.ProductId,
                    movement.MovementType.ToString(),
                    movement.Quantity,
                    movement.StorageLocation,
                    movement.ReferenceNo
                );
            });
        }
    }
}
