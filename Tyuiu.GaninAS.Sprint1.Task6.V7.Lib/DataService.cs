using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GaninAS.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            string strText = "Хороший день";
            value = value.Replace("й", "");
            value = value.Replace("ь", "");
            return value;
          


        }
    }
}

    
    
        

        
    

    

















