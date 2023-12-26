using Practice.DataBase.Entities;
using static Practice.DataBase.Functions;

namespace Practice.Forms.Manager;
public partial class Orders : Form
{
    public Orders()
    {
        InitializeComponent();
        InitMenu();
    }
    private void InitMenu()
    {
        StatusesList.Items.Clear();
        StatusesList.Items.AddRange(new string[]
        {
            "Отменен",
            "Принят",
            "В работе",
            "Выполнен"
        });

        OrdersList.Items.Clear();
        OrdersList.Items.AddRange(GetAllOrders());
    }
    private void OnCreateClick(object sender, EventArgs e)
    {
        var createdOrder = new Order()
        {
            ClientId = int.Parse(OrderClient.Text),
            Description = OrderDescription.Text,
            Status = "Принят"
        };

        AddOrder(createdOrder);
        InitMenu();
    }

    private void OnChangeClick(object sender, EventArgs e)
    {
        if (StatusesList.SelectedItem == null || OrdersList.SelectedItem == null)
            return;

        var status = StatusesList.SelectedItem.ToString();
        var order = (Order)OrdersList.SelectedItem;
        ChangeOrderStatus(order, status);
        InitMenu();
    }

    private void OnChangeItem(object sender, EventArgs e)
    {
        if (OrdersList.SelectedItem == null)
            return;

        var order = (Order)OrdersList.SelectedItem;
        OrderLabel.Text =
            $"ID Заказа - {order.OrderId}\n" +
            $"ID Клиента - {order.ClientId}\n" +
            $"Описание - {order.Description}\n" +
            $"Статус - {order.Status}";
    }
}
