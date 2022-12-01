using System;
using System.Text.RegularExpressions;

namespace accounts
{
    public class Accounts
    {
        public delegate void AccoutStateHandler(string message);
        public event AccoutStateHandler Number;
        public event AccoutStateHandler Password;
        AccoutStateHandler _del;
        public void RegisterHandler(AccoutStateHandler del)
        {


            _del += del;
        }

        public void UnregisterHandler(AccoutStateHandler del)
        {


            _del -= del;
        }
        
        

        Int64 _number=1234567812345678;
        int _password = 1234;
        string name = "Dasha";
        string surname = "Gamarska";
        public Accounts(Int64 num, int password)
        {
            
            _number = num;
           
            _password = password;
        }
        public Int64 CurrentNum
        {
            get { return _number; 
                  return _password;
            }
        }

        public void Numbercard(Int64 num, int password)
        {
           if (_number == num && _password == password)
            { Number("Не правильно ведено карту або пін");
                 
            }
            else
            {   
                Number($"Ім'я {name}");
                Password($"Призвіще {surname}");
            }


           



        }




    }
}