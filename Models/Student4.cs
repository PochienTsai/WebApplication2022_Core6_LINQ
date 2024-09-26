namespace WebApplication2022_Core6_LINQ.Models
{
    /// <summary>
    ///  LINQ_04會用到這個小類別
    /// </summary>
    public class Student4
    {        
        public string First { get; set; }
        public string Last { get; set; }

        // 比起上一個 Student.cs 多了下面兩個屬性
        public int ID { get; set; }   
        public List<int> Scores;  // 改用 List<T>取代原本的陣列( int[] )。 List<T>好用又強！傳統陣列比不上！

        //// 範例
        // First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}

    }
}
