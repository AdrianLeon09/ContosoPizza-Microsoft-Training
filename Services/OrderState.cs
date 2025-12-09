namespace BlazingPizza.Services
{
    public class OrderState
    {
        public bool ShowingConfiguredDialog { get; private set; }
        public Pizza ConfiguringPizza { get; private set; }
        public Order order { get; private set; } = new Order();

        public void ShowConfiguredDialog(PizzaSpecial special)
        {
            ConfiguringPizza = new Pizza
            {
                Special = special,
                SpecialId = special.Id,
                Size = Pizza.DefaultSize,
                Toppings = new List<PizzaTopping>()
            };
            ShowingConfiguredDialog = true;
        }
        public void CancelConfiguredPizzaDialog()
        {
            ConfiguringPizza = null;
            ShowingConfiguredDialog = false;
        }

        public void ConfirmConfigurePizzaDialog()
        {
            order.Pizzas.Add(ConfiguringPizza);
            ConfiguringPizza = null;
            ShowingConfiguredDialog = false;
        }

        public void RemoveConfiguredPizza(Pizza pizza)
        {
            order.Pizzas.Remove(pizza);
        }

    }
}
