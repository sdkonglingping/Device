SQL Server 存储过程SQL语句的拼接

-小龙人

于 2020-12-26 17:11:27 发布

3729
 收藏 6
分类专栏： # SQL Server 文章标签： SQL Server SQL拼接
版权

SQL Server
专栏收录该内容
29 篇文章13 订阅
订阅专栏
场景
在存储过程中拼接SQL，有过经历的人都知道，字符拼接的单引号是多么的…本人觉得这玩意类似于正则了，就是不断尝试，碰巧又撞到了新的写法，拼接 in语句 ，这里就记录下…

直接上SQL


![image-20230411201821388](C:\Users\klp\AppData\Roaming\Typora\typora-user-images\image-20230411201821388.png)

这样拼出来的SQL是正确，可以执行的，结果如下：

![在这里插入图片描述](https://img-blog.csdnimg.cn/20201224212235900.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzM2MzMwMjI4,size_16,color_FFFFFF,t_70#pic_center)