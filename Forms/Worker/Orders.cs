using Practice.DataBase.Entities;
using static Practice.DataBase.Functions;

namespace Practice.Forms.Worker
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            InitMenu();
        }
        private void InitMenu()
        {
            OrdersList.Items.Clear();
            OrdersList.Items.AddRange(GetWorkingOrders());
        }
        private void OnChangeItem(object sender, EventArgs e)
        {
            if (OrdersList.SelectedItem == null)
                return;

            var order = (Order)OrdersList.SelectedItem;
            OrderInfo.Text =
                $"ID Заказа - {order.OrderId}\n" +
                $"Описание - {order.Description}\n" +
                $"Статус - {order.Status}";
        }
    }
}
