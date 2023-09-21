using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// adapter chuyển đổi từ adaptee sang target
    /// </summary>
    public class GroceryItemAdapter : IItem
    {
        private IGroceryItem _groceryItem;
        public GroceryItemAdapter(IGroceryItem groceryItem)
        {
            _groceryItem = groceryItem;
        }
        public string GetItemName()
        {
            return _groceryItem.GetName();
        }

        public string GetPrice()
        {
            return _groceryItem.GetPrice();
        }

        public string GetRestaurantName()
        {
            return _groceryItem.GetStoreName();
        }
    }
    /// <summary>
    /// client này đang sử dụng food item (target interface)
    /// </summary>
    public class SwiggyStore
    {
        public List<IItem> ListItems = new();
        public void AddItem(IItem item)
        {
            ListItems.Add(item);
        }
    }

    /// <summary>
    /// target interface
    /// </summary>
    public interface IItem
    {
        string GetItemName();
        string GetPrice();
        string GetRestaurantName();
    }

    /// <summary>
    /// implemention target
    /// </summary>
    public class FoodItem : IItem
    {
        public string GetItemName()
        {
            return "GetItemName";
        }

        public string GetPrice()
        {
            return "GetPrice";

        }

        public string GetRestaurantName()
        {
            return "GetRestaurantName";

        }
    }

    /// <summary>
    /// Adaptee không tương thích với client
    /// </summary>
    public interface IGroceryItem
    {
        string GetName();
        string GetPrice();
        string GetStoreName();
    }

    /// <summary>
    /// implemention adaptee
    /// </summary>
    public class GroceryItem: IGroceryItem
    {
        public string GetName()
        {
            return "GetName";
        }

        public string GetPrice()
        {
            return "GetPrice";
        }

        public string GetStoreName()
        {
            return "GetStoreName";
        }
    }
}
