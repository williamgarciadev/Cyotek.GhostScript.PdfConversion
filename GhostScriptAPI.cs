// Decompiled with JetBrains decompiler
// Type: Cyotek.GhostScript.GhostScriptAPI
// Assembly: Cyotek.GhostScript.PdfConversion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F846869A-603F-4B14-A759-B0D0C54D84D2
// Assembly location: D:\Proyectos\Matika\ModelosGX\MatikaErp_Up\CSharpModel\web\bin\Cyotek.GhostScript.PdfConversion.dll

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

#nullable disable
namespace Cyotek.GhostScript;

public class GhostScriptAPI : IDisposable
{
  private GCHandle[] _argumentHandles;
  private GCHandle _argumentPointersHandle;
  private IntPtr _ghostScriptInstance;

  public GhostScriptAPI()
  {
    NativeMethods.gsapi_new_instance(out this._ghostScriptInstance, IntPtr.Zero);
  }

  public static string GetCommandName(GhostScriptCommand command)
  {
    string commandName;
    switch (command)
    {
      case GhostScriptCommand.ColorScreen:
        commandName = "dCOLORSCREEN";
        break;
      case GhostScriptCommand.DitherPPI:
        commandName = "dDITHERPPI";
        break;
      case GhostScriptCommand.Interpolate:
        commandName = "dDOINTERPOLATE";
        break;
      case GhostScriptCommand.NoInterpolate:
        commandName = "dNOINTERPOLATE";
        break;
      case GhostScriptCommand.TextAlphaBits:
        commandName = "dTextAlphaBits";
        break;
      case GhostScriptCommand.GraphicsAlphaBits:
        commandName = "dGraphicsAlphaBits";
        break;
      case GhostScriptCommand.AlignToPixels:
        commandName = "dAlignToPixels";
        break;
      case GhostScriptCommand.GridToFitTT:
        commandName = "dGridFitTT";
        break;
      case GhostScriptCommand.UseCIEColor:
        commandName = "dUseCIEColor";
        break;
      case GhostScriptCommand.NoCIE:
        commandName = "dNOCIE";
        break;
      case GhostScriptCommand.NoSubstituteDeviceColors:
        commandName = "dNOSUBSTDEVICECOLORS";
        break;
      case GhostScriptCommand.NoPSICC:
        commandName = "dNOPSICC";
        break;
      case GhostScriptCommand.NoTransparency:
        commandName = "dNOTRANSPARENCY";
        break;
      case GhostScriptCommand.NoTN5044:
        commandName = "dNO_TN5044";
        break;
      case GhostScriptCommand.DoPS:
        commandName = "dDOPS";
        break;
      case GhostScriptCommand.FixedMedia:
        commandName = "dFIXEDMEDIA";
        break;
      case GhostScriptCommand.FixedResolution:
        commandName = "dFIXEDRESOLUTION";
        break;
      case GhostScriptCommand.Orient1:
        commandName = "dORIENT1";
        break;
      case GhostScriptCommand.DeviceWidthPoints:
        commandName = "dDEVICEWIDTHPOINTS";
        break;
      case GhostScriptCommand.DeviceHeightPoint:
        commandName = "dDEVICEHEIGHTPOINTS";
        break;
      case GhostScriptCommand.DefaultPaperSize:
        commandName = "sDEFAULTPAPERSIZE";
        break;
      case GhostScriptCommand.DiskFonts:
        commandName = "dDISKFONTS";
        break;
      case GhostScriptCommand.LocalFonts:
        commandName = "dLOCALFONTS";
        break;
      case GhostScriptCommand.NoCCFonts:
        commandName = "dNOCCFONTS";
        break;
      case GhostScriptCommand.NoFontMap:
        commandName = "dNOFONTMAP";
        break;
      case GhostScriptCommand.NoFontPath:
        commandName = "dNOFONTPATH";
        break;
      case GhostScriptCommand.NoPlatformFonts:
        commandName = "dNOPLATFONTS";
        break;
      case GhostScriptCommand.NoNativeFontMap:
        commandName = "dNONATIVEFONTMAP";
        break;
      case GhostScriptCommand.FontMap:
        commandName = "sFONTMAP";
        break;
      case GhostScriptCommand.FontPath:
        commandName = "sFONTPATH";
        break;
      case GhostScriptCommand.SubstituteFont:
        commandName = "sSUBSTFONT";
        break;
      case GhostScriptCommand.OldCFFParser:
        commandName = "dOLDCFF";
        break;
      case GhostScriptCommand.GenericResourceDirectory:
        commandName = "sGenericResourceDir";
        break;
      case GhostScriptCommand.FontResourceDirectory:
        commandName = "sFontResourceDir";
        break;
      case GhostScriptCommand.Batch:
        commandName = "dBATCH";
        break;
      case GhostScriptCommand.NoPagePrompt:
        commandName = "dNOPAGEPROMPT";
        break;
      case GhostScriptCommand.NoPause:
        commandName = "dNOPAUSE";
        break;
      case GhostScriptCommand.NoPrompt:
        commandName = "dNOPROMPT";
        break;
      case GhostScriptCommand.Quiet:
        commandName = "dQUIET";
        break;
      case GhostScriptCommand.ShortErrors:
        commandName = "dSHORTERRORS";
        break;
      case GhostScriptCommand.StandardOut:
        commandName = "sstdout";
        break;
      case GhostScriptCommand.TTYPause:
        commandName = "dTTYPAUSE";
        break;
      case GhostScriptCommand.NoDisplay:
        commandName = "dNODISPLAY";
        break;
      case GhostScriptCommand.Device:
        commandName = "sDEVICE";
        break;
      case GhostScriptCommand.OutputFile:
        commandName = "sOutputFile";
        break;
      case GhostScriptCommand.IgnoreMultipleCopies:
        commandName = "d.IgnoreNumCopies";
        break;
      case GhostScriptCommand.EPSCrop:
        commandName = "dEPSCrop";
        break;
      case GhostScriptCommand.EPPSFitPage:
        commandName = "dEPSFitPage";
        break;
      case GhostScriptCommand.NoEPS:
        commandName = "dNOEPS";
        break;
      case GhostScriptCommand.DefaultGrayProfile:
        commandName = "sDefaultGrayProfile";
        break;
      case GhostScriptCommand.DefaultRGBProfile:
        commandName = "sDefaultRGBProfile";
        break;
      case GhostScriptCommand.DefaultCMYKProfile:
        commandName = "sDefaultCMYKProfile";
        break;
      case GhostScriptCommand.DeviceNProfile:
        commandName = "sDeviceNProfile";
        break;
      case GhostScriptCommand.ProofProfile:
        commandName = "sProofProfile";
        break;
      case GhostScriptCommand.DeviceLinkProfile:
        commandName = "sDeviceLinkProfile";
        break;
      case GhostScriptCommand.NamedProfile:
        commandName = "sNamedProfile";
        break;
      case GhostScriptCommand.OutputICCProfile:
        commandName = "sOutputICCProfile";
        break;
      case GhostScriptCommand.RenderIntent:
        commandName = "sRenderIntent";
        break;
      case GhostScriptCommand.GraphicICCProfile:
        commandName = "sGraphicICCProfile";
        break;
      case GhostScriptCommand.GraphicIntent:
        commandName = "sGraphicIntent";
        break;
      case GhostScriptCommand.ImageICCProfile:
        commandName = "sImageICCProfile";
        break;
      case GhostScriptCommand.ImageIntent:
        commandName = "sImageIntent";
        break;
      case GhostScriptCommand.TextICCProfile:
        commandName = "sTextICCProfile";
        break;
      case GhostScriptCommand.TextIntent:
        commandName = "sTextIntent";
        break;
      case GhostScriptCommand.OverrideICC:
        commandName = "dOverrideICC";
        break;
      case GhostScriptCommand.OverrideRI:
        commandName = "dOverrideRI";
        break;
      case GhostScriptCommand.SourceObjectICC:
        commandName = "sSourceObjectICC";
        break;
      case GhostScriptCommand.DeviceGrayToK:
        commandName = "dDeviceGrayToK";
        break;
      case GhostScriptCommand.ICCProfilesDirectory:
        commandName = "sICCProfilesDir";
        break;
      case GhostScriptCommand.DelayBind:
        commandName = "dDELAYBIND";
        break;
      case GhostScriptCommand.PdfMarks:
        commandName = "dDOPDFMARKS";
        break;
      case GhostScriptCommand.JobServer:
        commandName = "dJOBSERVER";
        break;
      case GhostScriptCommand.NoBind:
        commandName = "dNOBIND";
        break;
      case GhostScriptCommand.NoCache:
        commandName = "dNOCACHE";
        break;
      case GhostScriptCommand.NoGC:
        commandName = "dNOGC";
        break;
      case GhostScriptCommand.NoOuterSave:
        commandName = "dNOOUTERSAVE";
        break;
      case GhostScriptCommand.NoSafer:
        commandName = "dNOSAFER";
        break;
      case GhostScriptCommand.Safer:
        commandName = "dSAFER";
        break;
      case GhostScriptCommand.Strict:
        commandName = "dSTRICT";
        break;
      case GhostScriptCommand.SystemDictionaryWritable:
        commandName = "dWRITESYSTEMDICT";
        break;
      case GhostScriptCommand.FirstPage:
        commandName = "dFirstPage";
        break;
      case GhostScriptCommand.LastPage:
        commandName = "dLastPage";
        break;
      case GhostScriptCommand.PDFFitPage:
        commandName = "dPDFFitPage";
        break;
      case GhostScriptCommand.Printed:
        commandName = "dPrinted";
        break;
      case GhostScriptCommand.UseCropBox:
        commandName = "dUseCropBox";
        break;
      case GhostScriptCommand.UseTrimBox:
        commandName = "dUseTrimBox";
        break;
      case GhostScriptCommand.PDFPassword:
        commandName = "sPDFPassword";
        break;
      case GhostScriptCommand.ShowAnnotations:
        commandName = "dShowAnnots";
        break;
      case GhostScriptCommand.ShowAcroForm:
        commandName = "dShowAcroForm";
        break;
      case GhostScriptCommand.NoUserInit:
        commandName = "dNoUserUnit";
        break;
      case GhostScriptCommand.RenderTTNotDef:
        commandName = "dRENDERTTNOTDEF";
        break;
      case GhostScriptCommand.Resolution:
        commandName = "r";
        break;
      case GhostScriptCommand.PaperSize:
        commandName = "sPAPERSIZE";
        break;
      case GhostScriptCommand.Silent:
        commandName = "q";
        break;
      case GhostScriptCommand.InputFile:
        commandName = string.Empty;
        break;
      default:
        throw new ArgumentException("Invalid command", nameof (command));
    }
    if (!string.IsNullOrEmpty(commandName))
      commandName = "-" + commandName;
    return commandName;
  }

  public static string GetDeviceName(ImageFormat format)
  {
    switch (format)
    {
      case ImageFormat.BitmapMono:
        return "bmpgray";
      case ImageFormat.Bitmap8:
        return "bmp256";
      case ImageFormat.Bitmap24:
        return "bmp16m";
      case ImageFormat.Jpeg:
        return "jpeg";
      case ImageFormat.PngMono:
        return "pnggray";
      case ImageFormat.Png8:
        return "png256";
      case ImageFormat.Png24:
        return "png16m";
      case ImageFormat.TiffMono:
        return "tiffgray";
      case ImageFormat.Tiff24:
        return "tiff24nc";
      default:
        throw new ArgumentException("Invalid format", nameof (format));
    }
  }

  public static string GetFormattedArgument(GhostScriptCommand command, object value)
  {
    switch (value)
    {
      case Enum _:
        value = (object) (int) value;
        break;
      case bool flag:
        value = flag ? (object) "true" : (object) "false";
        break;
    }
    string commandName = GhostScriptAPI.GetCommandName(command);
    string str1 = value == null || string.IsNullOrEmpty(commandName) || command == GhostScriptCommand.Resolution ? string.Empty : "=";
    string str2 = value == null ? string.Empty : value.ToString();
    return commandName + str1 + str2;
  }

  public static string[] GetFormattedArguments(IDictionary<GhostScriptCommand, object> args)
  {
    List<string> stringList = new List<string>();
    foreach (KeyValuePair<GhostScriptCommand, object> keyValuePair in (IEnumerable<KeyValuePair<GhostScriptCommand, object>>) args)
      stringList.Add(GhostScriptAPI.GetFormattedArgument(keyValuePair.Key, keyValuePair.Value));
    return stringList.ToArray();
  }

  public static string GetPaperSizeName(PaperSize paperSize)
  {
    switch (paperSize)
    {
      case PaperSize.LedgerPortrait:
        return "11x17";
      case PaperSize.Ledger:
        return "ledger";
      case PaperSize.Legal:
        return "legal";
      case PaperSize.Letter:
        return "letter";
      case PaperSize.LetterSmall:
        return "lettersmall";
      case PaperSize.ArchE:
        return "archE";
      case PaperSize.ArchD:
        return "archD";
      case PaperSize.ArchC:
        return "archC";
      case PaperSize.ArchB:
        return "archB";
      case PaperSize.ArchA:
        return "archA";
      case PaperSize.A0:
        return "a0";
      case PaperSize.A1:
        return "a1";
      case PaperSize.A2:
        return "a2";
      case PaperSize.A3:
        return "a3";
      case PaperSize.A4:
        return "a4";
      case PaperSize.A5:
        return "a5";
      case PaperSize.A6:
        return "a6";
      case PaperSize.A7:
        return "a7";
      case PaperSize.A8:
        return "a8";
      case PaperSize.A9:
        return "a9";
      case PaperSize.A10:
        return "a10";
      case PaperSize.B0:
        return "isob0";
      case PaperSize.B1:
        return "isob1";
      case PaperSize.B2:
        return "isob2";
      case PaperSize.B3:
        return "isob3";
      case PaperSize.B4:
        return "isob4";
      case PaperSize.B5:
        return "isob5";
      case PaperSize.B6:
        return "isob6";
      case PaperSize.C0:
        return "c0";
      case PaperSize.C1:
        return "c1";
      case PaperSize.C2:
        return "c2";
      case PaperSize.C3:
        return "c3";
      case PaperSize.C4:
        return "c4";
      case PaperSize.C5:
        return "c5";
      case PaperSize.C6:
        return "c6";
      case PaperSize.Foolscap:
        return "fse";
      case PaperSize.HalfLetter:
        return "halfletter";
      case PaperSize.Hagaki:
        return "hagaki";
      default:
        throw new ArgumentException("Invalid paper size", nameof (paperSize));
    }
  }

  public virtual void Dispose()
  {
    try
    {
      this.FreeHandles();
      NativeMethods.gsapi_exit(this._ghostScriptInstance);
      NativeMethods.gsapi_delete_instance(this._ghostScriptInstance);
    }
    catch
    {
    }
  }

  public int Execute(IDictionary<GhostScriptCommand, object> args)
  {
    return this.Execute(GhostScriptAPI.GetFormattedArguments(args));
  }

  public int Execute(string[] args)
  {
    if (!string.IsNullOrEmpty(args[0]))
    {
      string[] strArray = new string[args.Length + 1];
      args.CopyTo((Array) strArray, 1);
      strArray[0] = string.Empty;
      args = strArray;
    }
    this._argumentHandles = new GCHandle[args.Length];
    IntPtr[] numArray = new IntPtr[args.Length];
    for (int index = 0; index < args.Length; ++index)
    {
      this._argumentHandles[index] = GCHandle.Alloc((object) Encoding.ASCII.GetBytes(args[index]), GCHandleType.Pinned);
      numArray[index] = this._argumentHandles[index].AddrOfPinnedObject();
    }
    this._argumentPointersHandle = GCHandle.Alloc((object) numArray, GCHandleType.Pinned);
    int errorCode;
    try
    {
      errorCode = NativeMethods.gsapi_init_with_args(this._ghostScriptInstance, args.Length, this._argumentPointersHandle.AddrOfPinnedObject());
    }
    finally
    {
      this.FreeHandles();
    }
    return errorCode >= 0 ? errorCode : throw new GhostScriptException(errorCode, args);
  }

  protected virtual void FreeHandles()
  {
    if (this._argumentHandles != null && this._argumentHandles.Length != 0)
    {
      for (int index = 0; index < this._argumentHandles.Length; ++index)
        this._argumentHandles[index].Free();
    }
    this._argumentHandles = (GCHandle[]) null;
    if (!this._argumentPointersHandle.IsAllocated)
      return;
    this._argumentPointersHandle.Free();
  }
}
