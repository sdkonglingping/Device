# c#分页工具类，完美实现List分页

2015-07-12 1480举报

**简介：** using System; using System.Collections.Generic; using System.Linq; using System.Web; namespace ProjectProgress.

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectProgress.BLL
{
    /// <summary>
    /// 分页工具类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PagingUtil<T> : List<T>
    {
        public int DataCount { get; set; } //总记录数
        public int PageCount { get; set; } //总页数
        public int PageNo { get; set; } //当前页码
        public int PageSize { get; set; } //每页显示记录数
        //是否有上一页
        public bool HasPreviousPage
        {
            get { return PageNo > 1; }
        }

        //是否有下一页
        public bool HasNextPage
        {
            get { return PageNo < this.PageCount; }
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="dataList"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNo"></param>
        public PagingUtil(List<T> dataList, int pageSize, int pageNo)
        {
            this.PageSize = pageSize;
            this.PageNo = pageNo;
            this.DataCount = dataList.Count;
            this.PageCount = (int) Math.Ceiling((decimal) this.DataCount/pageSize);
            this.AddRange(dataList.Skip((pageNo - 1)*pageSize).Take(pageSize));
        }
    }

}
```