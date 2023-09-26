using ViennaNET.WebApi.Runners.BaseHttpSys;
using ViennaNET.WebApi.WindowsHosting;

BaseHttpSysRunner.Configure()
  .BuildWebHost(args)
  .RunAsWindowsService(args);
