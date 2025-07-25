// Decompiled with JetBrains decompiler
// Type: Cyotek.GhostScript.GhostScriptException
// Assembly: Cyotek.GhostScript.PdfConversion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F846869A-603F-4B14-A759-B0D0C54D84D2
// Assembly location: D:\Proyectos\Matika\ModelosGX\MatikaErp_Up\CSharpModel\web\bin\Cyotek.GhostScript.PdfConversion.dll

using System;

#nullable disable
namespace Cyotek.GhostScript;

public class GhostScriptException : Exception
{
  public GhostScriptException(int errorCode)
    : this(errorCode, new string[0])
  {
  }

  public GhostScriptException(int errorCode, string[] arguments)
    : this(errorCode, arguments, "Failed to process GhostScript command.")
  {
  }

  public GhostScriptException(int errorCode, string[] arguments, string message)
    : this(errorCode, arguments, message, (Exception) null)
  {
  }

  public GhostScriptException(
    int errorCode,
    string[] arguments,
    string message,
    Exception innerException)
    : base(message, innerException)
  {
    this.Arguments = arguments;
    this.ErrorCode = errorCode;
  }

  protected GhostScriptException()
  {
  }

  public string[] Arguments { get; protected set; }

  public int ErrorCode { get; protected set; }
}
