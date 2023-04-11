# C#子窗体精确定位到父窗体的某个位…

发布于2018-08-03 12:30:41阅读 3860

 弹出的子窗体精确定位在父窗体的某个位置，需要有目标坐标（这里将子窗体的位置设置为父窗体中一个panel的位置，需要将panel的坐标转换成屏幕坐标）

lvlv_CauseForm cf = new lvlv_CauseForm();

cf.Left = this.PointToScreen(new Point(panel2.Left, panel2.Top)).X;（这里将panel的位置装换成相对于屏幕的坐标再赋给子窗体）

cf.Top = this.PointToScreen(new Point(panel2.Left, panel2.Top)).Y;

cf.ShowDialog();