# SmobilerSamplesNetCore
> 从Smobiler5.0开始，Smobiler支持.Net Core 3.0，即可以在linux上愉快的运行Smobiler了，这里是一个示例项目，告诉你如何进行开发及部署


* SmobilerSamplesNetFramework
    * 由于VS2019目前还不支持在.Net Core下的设计器，所以这里设计器还是需要使用.Net Framework，在设计完成后，需要创建一个.Net Core 3.0的控制台应用程序并添加引用
* SmobilerSamplesNetCore
    * 在此项目中使用软连接的方式，将Smobiler的窗体文件引入，直接运行即可查看效果