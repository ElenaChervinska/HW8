
//Порушен принцип єдиної відповідальності. Тому що, клас Order мав кілька відповідальності:
//робота із самим замовленням, візуалізація/відображення замовлення, робота з певною базою даних.
//Для вирішення цього завдання було прийнято поділити функціонал на три класи залежно від відповідальності

class Item
{
}

class OrderDB
{
    public void Load() {/*...*/}
    public void Save() {/*...*/}
    public void Update() {/*...*/}
    public void Delete() {/*...*/}
}

class OrderVisualizer
{
    public void PrintOrder() {/*...*/}
    public void ShowOrder() {/*...*/}
}
class Order
{
    private List<Item> itemList;
    internal List<Item> ItemList
    {
        get
        {
            return itemList;
        }
        set
        {
            itemList = value;
        }
    }

    public void CalculateTotalSum() {/*...*/}
    public void GetItems() {/*...*/}
    public void GetItemCount() {/*...*/}
    public void AddItem(Item item) {/*...*/}
    public void DeleteItem(Item item) {/*...*/}
}