# SQL server进阶技能篇：SQL的存储过程与函数

[![HIT杂谈](https://picx.zhimg.com/v2-a71d558a4ba400c2a3c729c44fc96a1c_l.jpg?source=172ae18b)](https://www.zhihu.com/people/hitza-tan)

[HIT杂谈](https://www.zhihu.com/people/hitza-tan)

6 人赞同了该文章

前面的进阶篇讲到的跨库查询以及链接服务器相关知识，本篇着重介绍SQL中的存储过程与函数。为什么放在一起讲，一是因为单独讲存储过程或者函数，其实就那么多东西，再者是因为这两类对象有一定的相似性。废话不多说，我们进入主题。

一、SQL的存储过程：

存储过程其实就是一系列SQL语句的集合体，我们可以理解为一个封装单元，这个单元可以有出入参数，也可以没有。我们举几个简单的例子：

（1）无入参无出参的存储过程：

```sql
create proc  usp_test 
as 
update stu set  ssex='0' where  ssex=''
return 

exec  usp_test
```

注意：执行存储过程用：exec 存储过程名 参数1,参数2....结果如下：

![img](https://pic2.zhimg.com/80/v2-28007c080ddc35b622b50111ddc0a23d_720w.webp)

（2）无入参有出参的存储过程：

```sql
alter proc  usp_test 
as 
update stu set  ssex='0' where  ssex=''
select * from stu where  ssex='0' 
return 

exec  usp_test
```

注意：修改存储过程用alter，执行结果如下：

![img](https://pic4.zhimg.com/80/v2-f8533528efc112c3860a3f403038966b_720w.webp)

（3）有入参无出参的存储过程：

```sql
alter proc  usp_test 
@age  int 
as 
update stu set  ssex='1' where  sage>=@age 
return 

exec usp_test 20
```

注意：还记得变量的用法吗？这里就是将变量用到存储过程里了。

![img](https://pic3.zhimg.com/80/v2-99689ebb04356df4430c58b10a857a3e_720w.webp)

（4）有入参有出参的存储过程：

```sql
alter proc  usp_test 
@age  int 
as 
update stu set  ssex='1' where  sage>=@age
select * from stu where  ssex='1' 
return 

exec usp_test 20
```

注意： 这个存储过程就是两条sql语句的集合，执行结果如下：

![img](https://pic3.zhimg.com/80/v2-dd7ca85907ee771a82664b4da6fee816_720w.webp)

综合以上几个例子，我们能看到存储过程的创建、修改基本格式，当使用入参时怎么更新和返回数据等，其实再复杂的存储过程，都是由一条条简单的语句集合而成的。要理解存储过程，首先心理上不要有犯难和逃避，不能一看到代码多了就扭头不想理，正视它你才能搞定它。

接着说函数，开篇也说到，函数和存储过程有很大的相似性，也是一堆代码的集合，也有出入参。

比如下面的例子，我们做个算年龄的函数，有点难度，看仔细了：

```sql
 CREATE function age_cs 
 (@ksrq  date,
 @jsrq  date)
 returns VARCHAR (16) 
as
begin
declare @days int ,@year int,
        @day int,@age  VARCHAR (16) 
select @days=datediff(day,@ksrq,@jsrq)
select @year=@days/365
select @day=@days%365

select @age= convert(varchar(3),@year)+'岁'
             +convert(varchar(3),@day)+'天'
return(@age)
 end
```

我们先调用一下，看看结果，然后再解释代码的意思：

```sql
 select dbo.age_cs('1991-01-01','2021-01-26')
```

![img](https://pic4.zhimg.com/80/v2-b368cafa4608808be56907cb6d74977b_720w.webp)

解析：（1）函数的入参必须用括号包住，定义完入参以后紧接着就需要定义返回的参数类型，正文部分必须用begin...end包裹住；

（2）我们先定义了四个变量：@days总天数, @year年数,@day天数,@age输出的年龄。

先用datediff函数算出总天数，然后年数等于总天数除以365得到的整数，因为两个字段都是int型的，所以直接除下来不会有小数。

再用总天数%365得到余天数，注意%是取余的意思。

最后我们再把算出来的年龄，拼接起来赋值给@age。

（3）用return(@age) 输出结果。

这样，我们就得到了算年龄的函数，把它创建在数据库里，随时想用就随时调，不用再每次都去写一大段语句。

![img](https://pic1.zhimg.com/80/v2-fad00d9aa1dd71ac81ffe8613e9c2414_720w.webp)

那么综合上面讲到的存储过程和函数的使用，总结如下：

（1）存储过程和函数都可以将一段SQL语句进行封装，这样大大的方便了实际使用时候的调用步骤；

（2）存储过程里面可以嵌套存储过程，也经常会调用各种函数；

（3）函数里面可以调用其他函数，但是一般不嵌套存储过程；

（4）上面例子中的函数，也可以改写成存储过程，但是函数使用起来要方便的多，因为函数可以直接用select联用，但是存储过程只能用exec执行。