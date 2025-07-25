// Decompiled with JetBrains decompiler
// Type: Cyotek.GhostScript.NativeStructs
// Assembly: Cyotek.GhostScript.PdfConversion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F846869A-603F-4B14-A759-B0D0C54D84D2
// Assembly location: D:\Proyectos\Matika\ModelosGX\MatikaErp_Up\CSharpModel\web\bin\Cyotek.GhostScript.PdfConversion.dll

using System;

#nullable disable
namespace Cyotek.GhostScript;

internal class NativeStructs
{
  public struct GS_Revision
  {
    public int intRevision { get; set; }

    public int intRevisionDate { get; set; }

    public IntPtr strCopyright { get; set; }

    public IntPtr strProduct { get; set; }
  }
}
