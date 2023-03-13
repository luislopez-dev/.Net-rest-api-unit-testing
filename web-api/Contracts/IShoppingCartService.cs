using web_api.Model;

namespace web_api.Contracts
{
	public interface IShoppingCartService
    {
        IEnumerable<ShoppingItem> GetAllItems();
        ShoppingItem Add(ShoppingItem newItem);
        ShoppingItem GetById(Guid id);
        ShoppingItem GetFirstItem();
        void Remove(Guid id);
    }
}
