using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2022_Core6_LINQ.Models;

namespace WebApplication2022_Core6_LINQ.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// *********************************************
        /// ***  以前微軟MSDN官方網站的範例，不確定現在改版後的 https://docs.microsoft.com/ 是否還有保留？？
        /// ***  http://msdn.microsoft.com/zh-tw/library/bb397933.aspx 
        /// *********************************************
        /// </summary>
        /// <returns></returns>


        public IActionResult LINQ_01()
        {
            return View();   // 新增檢視的時候，選擇「版面配置頁」
        }
        public IActionResult LINQ_02()
        {
            return View();   // 從現在起，新增檢視的時候，"沒有" 選擇「版面配置頁」
        }
        public IActionResult LINQ_03()
        {   // 請參閱 /Models目錄下的 Student.cs 
            return View();
        }

        //===== 基礎篇 ======================== (start)
        public IActionResult LINQ_04_select_alias()
        {   // 請參閱 /Models目錄下的 Student4.cs 
            return View();
        }
        public IActionResult LINQ_04_where()  
        {   // 請參閱 /Models目錄下的 Student4.cs 
            return View();
        }
        public IActionResult LINQ_04_where2()   // 搜尋關鍵字 - 明確搜尋某一個字，必須 100%正確才行（區分大小寫）
        {   // 請參閱 /Models目錄下的 Student4.cs 
            return View();
        }
        public IActionResult LINQ_04_where_contains()   // 模糊搜尋 關鍵字（請搭配 where）
        {   // 請參閱 /Models目錄下的 Student4.cs 
            return View();
        }
        public IActionResult LINQ_04_orderby()
        {   // 請參閱 /Models目錄下的 Student4.cs 
            return View();
        }        
        //===== 基礎篇 ======================== (end)


        public IActionResult LINQ_04from()     //*** 雙重 from 的查詢語法（類似 雙重迴圈） ***
        {   // 請參閱 /Models目錄下的 Student4.cs 
            return View();   
        }
        public IActionResult LINQ_04group()    // *** group by （分組）***
        {   // 請參閱 /Models目錄下的 Student4.cs 
            return View();
        }
        public IActionResult LINQ_04group_into_orderby()  // *** group into （分組、排序）orderby ***
        {   // 請參閱 /Models目錄下的 Student4.cs  
            return View();
        }

        public IActionResult LINQ_04let()  // *** let 關鍵字 ***
        {   // 請參閱 /Models目錄下的 Student4.cs  
            return View();
        }
        public IActionResult LINQ_04letgroup()  // *** let 關鍵字 ***
        {   // 請參閱 /Models目錄下的 Student4.cs  
            // 使用 let 當做方便儲存方法呼叫結果的位置，因此您不需要在 group 子句中呼叫方法兩次。
            // 另外，在 group 子句中，為了避免「除以零」的例外狀況，程式碼也會進行檢查，以確定學生的平均值不是零。
            return View();
        }


        //===== Join篇 ======================== (start)
        public IActionResult LINQ_05InnerJoin()    // *** Inner Join ***
        {   // 請參閱 /Models目錄下的 GProduct.cs與GCategory.cs
            // 如同資料庫的兩個"關連式資料表"將會 Join在一起
            return View();
        }

        public IActionResult LINQ_06GroupJoin()    // *** Group Join ***
                                                                             // 無法列出「商品種類」的名稱 Category.Name。下一個範例才能做到！ 
        {   // 請參閱 /Models目錄下的 GProduct.cs與GCategory.cs
            return View();
        }
        public IActionResult LINQ_06GroupJoin3()    // *** Group Join #3 ***
                                                   // 無法列出「商品種類」的名稱 Category.Name。下一個範例才能做到！ 
        {   // 請參閱 /Models目錄下的 GProduct.cs與GCategory.cs
            return View();
        }
        public IActionResult LINQ_07GroupInnerJoin()    // *** Group Inner Join ***
        {   // 請參閱 /Models目錄下的 GProduct.cs與GCategory.cs
            return View();
        }

        public IActionResult LINQ_08LeftOuterJoin()    // *** Left Outer Join ***
        {   // 請參閱 /Models目錄下的 GProduct.cs與GCategory.cs
            return View();
        }
        public IActionResult LINQ_08LeftOuterJoin2()    // *** Left Outer Join #2 ***
        {   // 請參閱 /Models目錄下的 GProduct.cs與GCategory.cs
            return View();
        }
        //===== Join篇 ======================== (end)



        //====== Home 控制器  預設的動作 ================
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}