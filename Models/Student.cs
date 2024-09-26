namespace WebApplication2022_Core6_LINQ.Models
{
    /// <summary>
    ///  LINQ_03會用到這個小類別
    /// </summary>
    public class Student
    {
        public string FirstName { get; set; }   // 名字
        public string LastName { get; set; }    // 姓氏
        public int[] Scores { get; set; }   // 每個學生都有 "好幾次" 考試的成績，所以用陣列（Array）
        //// 範例
        //        FirstName = "Svetlana（史文特拉娜）",
        //        LastName = "Omelchenko（第一位學生）",
        //        Scores = new int[] { 98, 92, 81, 60 }
    }

}
