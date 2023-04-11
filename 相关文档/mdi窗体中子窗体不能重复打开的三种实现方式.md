# C#编程学习19：mdi窗体中子窗体不能重复打开的三种实现方式

2022-12-29 87 吉林举报

**简介：** C#编程学习19：mdi窗体中子窗体不能重复打开的三种实现方式

需求描述：在MDI窗体中，子窗体只能被打开一次，如果已有窗体不会在重新创建窗体对象

# 1 窗体的创建

（1）创建mdi窗体：新建窗体将其名称更改为FormMain，属性IsMdiContainer设置为true



（2）创建子窗体1：新建窗体将其名称更改为childForm1



（3）创建子窗体1：新建窗体将其名称更改为childForm2



（4）增加菜单项tsmi_singleMode，其Text属性设置为单例模式子窗体



（5）增加菜单项tsmi_application，其Text属性设置为函数模式子窗体



（6）增加菜单项tsmi_foreach，其Text属性设置为函数模式子窗体



界面如下：

![20190526003336562.png](https://ucc.alicdn.com/pic/developer-ecology/prk5jtgggn43i_42785cab775e4bdf9354cb2dcc6ef58a.png)

# 2 单例模式的实现

（1）在子窗体1中将其构造函数改成private；添加静态成员和静态变量

```
//私有构造函数        
private childForm1()
        {
            InitializeComponent();
        }
//私有静态类类型的成员变量
        private static childForm1 inquire = null;
//公有静态类型成员函数
        public static childForm1 GetWindows()
        {
            if (inquire == null && inquire.IsDisposed)
            {
                inquire = new childForm1();
            }
            return inquire;            
        }
```

（2）父窗体MDI中的为tsmi_singleMode按钮添加Click事件：

```
        private void tsmi_singleMode_Click(object sender, EventArgs e)
        {
            childForm1 cf1 = childForm1.GetWindows();
            cf1.MdiParent = this;
            cf1.Show();
        }
```

# 3 函数模式之Application.OpenForms实现

使用Application.OpenForms来判断是否创建新的子窗体

```
//使用Application搜集已经打开的子窗体；若找不到就创建；找到则显示
          
private void tsmi_application_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)            
            {
                if (frm is ChildForm2)
                {
                    frm.Activate();
                    frm.WindowState = FormWindowState.Normal;
                    return;
                }
            }
            ChildForm2 youForm = new ChildForm2();
            youForm.MdiParent = this;
            youForm.Show();
        }
```

# 4 函数模式实现之遍历this.MdiChildren子窗体实现

定义判断函数

```
 private void OpenChildForm(Form formChild)//formChild只是是实例化的但既没有设置为父窗体的子窗体也没有显示
        {
            bool isOpened = false;
            foreach (Form form in this.MdiChildren)
            {
                //如果要显示的子窗体已经在父窗体的子窗体数组数组中，我们就把新建的多余的formChild销毁
 
                if (formChild.Name == form.Name)
                {
                    form.Activate();//既然我们想新建但已经有了，那就把之前存在的激活并调到最前边来
                    form.WindowState = FormWindowState.Normal;//窗口大小  为窗口模式
                    formChild.Dispose();
                    isOpened = true;//表示窗口已经打开
 
                    break;
                }
            }
 
            if (!isOpened)//如果没打开
            {
                formChild.MdiParent = this;//设置为子窗体
                formChild.Show();
 
            }
        }
```

添加点击事件

```
private void tmsi_foreach_Click(object sender, EventArgs e)
        {
            childForm3 cf3 = new childForm3();
            cf3.Name = "childForm3";
            OpenChildForm(cf3);
        }
```

# 5 总结

列举了三种实现方式，第一种将类定义为私有构造函数、私有静态成员和公有静态成员的单例模式来实现；方法二遍历Application.OpenForms判断子窗体是否打开；方法三，遍历this.MdiChildren判断子窗体是否存在