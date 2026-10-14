using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class FriendsService
    {
        private readonly FriendsRepository _repository;

        // اینجکت کردن Repository به سرویس با DI
        public FriendsService(FriendsRepository repository)
        {
            _repository = repository;
        }

        // خواندن لیست از ریپازیتوری
        public List<Friend> GetAll()
        {
            return _repository.GetAll();
        }

        // دریافت یک دوست با شماره
        public Friend? GetByNumber(int number)
        {
            return _repository.GetByNumber(number);
        }

        // ثبت دوست جدید در ریپازیتوری
        public void Add(Friend friend)
        {
            _repository.Add(friend);
        }

        // ویرایش دوست
        public void Update(Friend friend)
        {
            _repository.Update(friend);
        }

        // حذف دوست
        public void Delete(int number)
        {
            _repository.Delete(number);
        }
    }
}