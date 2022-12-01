namespace Bank
{
    public class bank
    {
        public delegate void AccoutStateHandler(string message);
        public event AccoutStateHandler Bank;

        public void kasa()
        {
            Bank("Назва банку: Приватбанк");
            Bank("Адреси за якими знаходяться банкомати даного банку");
            Bank("Адреса: Вул. Волочаївська 15");
            Bank("Адреса: Вул. Житомирська 35");
            Bank("Адреса: Вул. Бердичівська 40");
            Bank("Адреса: Вул. Європейська 24");
            Bank("Адреса: Вул. Слов'янська 12");    
        }
    }
}