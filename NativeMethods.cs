// Decompiled with JetBrains decompiler
// Type: Cyotek.GhostScript.NativeMethods
// Assembly: Cyotek.GhostScript.PdfConversion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F846869A-603F-4B14-A759-B0D0C54D84D2
// Assembly location: D:\Proyectos\Matika\ModelosGX\MatikaErp_Up\CSharpModel\web\bin\Cyotek.GhostScript.PdfConversion.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Cyotek.GhostScript;

internal class NativeMethods
{
  [DllImport("gsdll64.dll")]
  public static extern void gsapi_delete_instance(IntPtr instance);

  [DllImport("gsdll64.dll")]
  public static extern int gsapi_exit(IntPtr instance);

  [DllImport("gsdll64.dll")]
  public static extern int gsapi_init_with_args(IntPtr instance, int argc, IntPtr argv);

  [DllImport("gsdll64.dll")]
  public static extern int gsapi_new_instance(out IntPtr pinstance, IntPtr caller_handle);

  [DllImport("gsdll64.dll")]
  public static extern int gsapi_revision(out NativeStructs.GS_Revision pr, int len);

  [DllImport("gsdll64.dll")]
  public static extern int gsapi_run_file(
    IntPtr instance,
    string file_name,
    int user_errors,
    int pexit_code);

  [DllImport("gsdll64.dll")]
  public static extern int gsapi_set_stdio(
    IntPtr instance,
    StdioCallBack stdin_fn,
    StdioCallBack stdout_fn,
    StdioCallBack stderr_fn);
}
