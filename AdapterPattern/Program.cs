using AdapterPattern;

// Giả sử store này đang bán các loại thực phẩm thì bỗng có lệnh cấm thực phẩm (FoodItem), họ liền chuyển
// sang giải pháp khác là bán đồ tạp hóa (GroceryItem) mà không muốn sửa code.
SwiggyStore swiggyStore = new();
swiggyStore.AddItem(new FoodItem());
swiggyStore.AddItem(new FoodItem());   
// Giải pháp là sử dụng Adapter pattern
swiggyStore.AddItem(new GroceryItemAdapter(new GroceryItem()));
