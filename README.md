GitDC是基于.Net Core 2.2的Git Server服务端程序。

底层框架：[DC.FrameWork](https://gitee.com/xingchensoft/DC.Framework/tree/develop)

感谢：
- [linezero/GitServer](https://github.com/linezero/GitServer)
- [Aimeast/GitCandy](https://github.com/Aimeast/GitCandy)

QQ群：774046050

下载之后运行dotnet watch run可直接本地运行。数据库为mysql

运行之后的演示地址：http://localhost:7070  账号：admin   密码： admin

实现功能：

1. 用户注册
2. 用户登录
3. 上传和拉取源码
4. 仓库项目资源列表展示
5. 腾讯开发者和禅道webHook转发（目前只实现了手动在数据库里配置）。

![注册](https://images.gitee.com/uploads/images/2019/0815/212129_dfe17ade_130171.png "5972F9CE-38AE-45f7-B84B-0F852FECCD61.png")
![登录](https://images.gitee.com/uploads/images/2019/0815/212158_13664b4e_130171.png "259BE4A4-4BB4-47ab-82E0-28675B4C3E30.png")
![仓库列表](https://images.gitee.com/uploads/images/2019/0817/235323_bb32fce7_130171.jpeg "360截图20190817235254075.jpg")