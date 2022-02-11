using tonicAPI.Models.Repository;

namespace tonicAPI.Models.DataManager
{
    public class DataManager : DataRepository<ToDoItem>
    {

        protected ToDoDBContext _itemContext { get; set; }
        public DataManager(ToDoDBContext itemContext)
        {
            this._itemContext = itemContext;
        }

        public IEnumerable<ToDoItem> GetAll()
        {
            return _itemContext.ToDoItems.ToList();

        }

        public ToDoItem Get(long Id)
        {
            return _itemContext.ToDoItems.FirstOrDefault(x => x.Id == Id);
        }
        public void Add(ToDoItem entity)
        {
            _itemContext.ToDoItems.Add(entity);
            _itemContext.SaveChanges();
        }
        public void Update(long Id, ToDoItem item)
        {
            var oldItem = _itemContext.ToDoItems.FirstOrDefault(s => s.Id == Id);
            if (oldItem != null)
            {
                _itemContext.Entry<ToDoItem>(oldItem).CurrentValues.SetValues(item);
                _itemContext.SaveChanges();
            }
        }
        public void Delete(long Id)
        {
            var dItem = _itemContext.ToDoItems.FirstOrDefault(s => s.Id == Id);
            if (dItem != null)
            {
                _itemContext.ToDoItems.Remove(dItem);
                _itemContext.SaveChanges();
            }
        }
    }
}
