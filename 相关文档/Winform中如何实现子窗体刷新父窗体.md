# Winform中如何实现子窗体刷新父窗体

**原理:**利用委托和事件,本文将以图文并茂的例子讲述,告诉我们So Easy

\------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

一.窗体展示

首先我们看到是一个父窗体,我们可以看到左边是一个[树控件],我们将点击[添加大类]和[添加字典]时调出子窗体

![img](https://images0.cnblogs.com/blog/33983/201311/20114450-e2cf9fc1546c40abafe0b04d167e3358.jpg)

 

接下来是子窗体展示,当我们点击取消或者关闭按钮时,我们需要看到我们添加或者修改的数据能展示出来,这就是我们要做的事

![img](https://images0.cnblogs.com/blog/33983/201311/20114508-2486c875c927415ba38a7c3e0a27e915.jpg).

 

二.代码展示

首先是子窗体中的代码,我们需要定义一个委托和事件

```
//定义委托``public` `delegate` `void` `Refresh();` `//定义事件``public` `event` `Refresh myRefresh;
```

　　其次是父窗体的代码,我们需要定义一个刷新的方法

```
/// <summary>``/// 刷新控件信息``/// </summary>``/// <author>PengZhen</author>``/// <time>2013-10-25 14:46:21</time>``private` `void` `RefreshControl()``{``  ``//绑定树信息``  ``BindTree();``}
```

　　

当上面两步完成之后,我们就要就行调用,进行刷新操作了

首先是父窗体中的代码,当我们点击[添加大类]或者[添加字典]时在相应的按钮事件中添加如下代码

```
//子窗体` `ChildForm objCF= ``new` `ChildForm();` `//定阅这个事件``objCF.myRefresh += ``new` `ChildForm.Refresh(RefreshControl);``//展示子窗体``objCF.ShowDialog();
```

　　

其次是子窗体的代码,当我们点击[取消]或者[关闭窗体]时在相应的按钮事件中添加如下代码

取消:

```
/// <summary>``/// 取消``/// </summary>``/// <author>PengZhen</author>``/// <time>2013-10-23 15:15:57</time>``/// <param name="sender"></param>``/// <param name="e"></param>``private` `void` `btCancel_Click(``object` `sender, EventArgs e)``{` `  ``this``.Close();` `  ``//关闭的时候执行事件``  ``myRefresh();``}
```

　　 关闭事件

```
/// <summary>``/// 用户点击关闭窗体后执行操作``/// </summary>``/// <author>PengZhen</author>``/// <time>2013-10-25 15:00:45</time>``/// <param name="sender"></param>``/// <param name="e"></param>``private` `void` `DataDictionaryInfoFrm_FormClosed(``object` `sender, FormClosedEventArgs e)``{``  ``//关闭的时候执行事件``  ``myRefresh();``}
```