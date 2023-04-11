通用分页技术分析
需要返回不同的类型的数据--采用泛型实现该操作
需要提供不同的方法
1. 上一页
2. 上一页
3. 第一页
4. 最后一页
5. 跳转到指定页



Demo 代码



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAManagement
{
    /// <summary>
    /// 通过的分页类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Paging<T>
    {
        public List<T> DataSource = new List<T>();

        public int PageIndex { get; set; }
        public int AllPage { get; set; }
        public int EachCount { get; set; }


​        
        public Paging(List<T> dataSource, int eachCount)
        {
            this.DataSource = dataSource;
            this.AllPage = (int)Math.Ceiling((double)this.DataSource.Count / eachCount);
            this.EachCount = eachCount;
            this.PageIndex = 1;
        }
        //下一页
        public List<T> Next()
        {
            PageIndex++;
            if (this.PageIndex > AllPage)
                PageIndex--;
            return GetPage();
        }
        //上一页
        public List<T> Provious()
        {
            PageIndex--;
            if (this.PageIndex == 0)
                PageIndex++;
            return GetPage();
        }
        //第一页
        public List<T> Fist()
        {
            this.PageIndex = 1;
            return GetPage();
        }
        //最后一页
        public List<T> End()
        {
            this.PageIndex = this.AllPage;
            return GetPage();
        }
    
        /// <summary>
        /// 跳转到指定的页
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public List<T> GoTo(int index)
        {
            if (index <= 0)
                index = 1;
            if (index >= AllPage)
                index = AllPage;
            this.PageIndex = index;
            return GetPage();
        }
    
        /// <summary>
        /// 获得当前页
        /// </summary>
        /// <returns></returns>
        private List<T> GetPage()
        {
            return this.DataSource.Skip((PageIndex - 1) * EachCount).Take(EachCount).ToList();
        }
    }
    }

-----------------------------------
通过这样的一个类基本实现了大多数的情况下的分页操作(虽然可能性能不是很高),这里主要是运用了泛型的特性来帮助我们返回任意的对象集。只需要在UI中做一些简单的处理即可。
