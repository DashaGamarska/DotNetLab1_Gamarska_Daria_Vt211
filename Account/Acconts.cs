using automatedTellerMachine;

namespace Account
{ 
    public class Accout
    {  
        public delegate void AccoutStateHandler(string message);
        public event AccoutStateHandler Withdrawn;
        public event AccoutStateHandler Added;
      
        AccoutStateHandler _del;
        public void RegisterHandler(AccoutStateHandler del)
        {
            

            _del += del;
        }

        public void UnregisterHandler(AccoutStateHandler del)
        {
           

            _del -= del;
        }
        


        int _sum=150;
        public Accout(int sum)
        {
            _sum = sum;
        }
        public int CurrentSum
        {
            get { return _sum; }

        }
       

        public void Put(int sum)
        {
            Added($"На рахунку {_sum} ");
            _sum += sum;
            if (Added != null)
                Added($" На рахунок поступило {sum}");
            Added($"Залишок нарахунку {_sum} ");
        }

   
        public void Putcard(int sum)
        {
            
            
            _sum += sum;
            if (Added != null)
                Added($" На рахунок поступило {sum}");
            
        }
        public void countmoney()
        {
            if (Added != null)
                Added($" На рахунку {_sum}");
        }
      
        public void Withdraw(int sum)
        {
            
          
            Added($"На рахунку {_sum} ");
            if (_sum >= sum)
            {
                _sum -= sum;
                if (Withdrawn != null)
                    Withdrawn($"Суму {sum} знято з рахунку");
                Added($"Залишок на рахунку {_sum} ");

            }
            else
            {
                if (Withdrawn != null)
                    Withdrawn("Недостатньо коштів на рахунку");
            }


        }

        
    }
}