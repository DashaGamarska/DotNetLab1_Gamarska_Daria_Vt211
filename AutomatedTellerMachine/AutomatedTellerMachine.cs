namespace automatedTellerMachine
{
    public class AutomatedTellerMachine
    {


        public delegate void AccoutStateHandler(string message);
        public event AccoutStateHandler Bankomat;
       

        AccoutStateHandler _del;
        public void RegisterHandler(AccoutStateHandler del)
        {


            _del += del;
        }

        public void UnregisterHandler(AccoutStateHandler del)
        {


            _del -= del;
        }

        int _sum=5000;
        public AutomatedTellerMachine(int sum)
        {
            _sum = sum;
        }
        public int CurrentSum
        {
            get { return _sum; }

        }


        public void kasa(int sum)
        {
            Bankomat("Ідентифікатор банкомату: Приватбанк");
            Bankomat("Адреса: Вул. Чорноморська 30А");
            
            if (_sum >= sum)
            {
                _sum -= sum;
                if (Bankomat != null)
                    Bankomat($"Суму {sum} знято з рахунку");
                Bankomat($"Залишок в банку {_sum} ");

            }
            else
            {
                if (Bankomat != null)
                    Bankomat("Недостатньо коштів в банкоматі");
            }



        }


    }
}