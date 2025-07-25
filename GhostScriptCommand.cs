// Decompiled with JetBrains decompiler
// Type: Cyotek.GhostScript.GhostScriptCommand
// Assembly: Cyotek.GhostScript.PdfConversion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F846869A-603F-4B14-A759-B0D0C54D84D2
// Assembly location: D:\Proyectos\Matika\ModelosGX\MatikaErp_Up\CSharpModel\web\bin\Cyotek.GhostScript.PdfConversion.dll

#nullable disable
namespace Cyotek.GhostScript;

public enum GhostScriptCommand
{
  ColorScreen = 0,
  DitherPPI = 1,
  Interpolate = 2,
  NoInterpolate = 3,
  TextAlphaBits = 4,
  GraphicsAlphaBits = 5,
  AlignToPixels = 6,
  GridToFitTT = 7,
  UseCIEColor = 8,
  NoCIE = 9,
  NoSubstituteDeviceColors = 10, // 0x0000000A
  NoPSICC = 11, // 0x0000000B
  NoTransparency = 12, // 0x0000000C
  NoTN5044 = 13, // 0x0000000D
  DoPS = 14, // 0x0000000E
  FixedMedia = 15, // 0x0000000F
  FixedResolution = 16, // 0x00000010
  Orient1 = 17, // 0x00000011
  DeviceWidthPoints = 18, // 0x00000012
  DeviceHeightPoint = 19, // 0x00000013
  DefaultPaperSize = 20, // 0x00000014
  DiskFonts = 21, // 0x00000015
  LocalFonts = 22, // 0x00000016
  NoCCFonts = 23, // 0x00000017
  NoFontMap = 24, // 0x00000018
  NoFontPath = 25, // 0x00000019
  NoPlatformFonts = 26, // 0x0000001A
  NoNativeFontMap = 27, // 0x0000001B
  FontMap = 28, // 0x0000001C
  FontPath = 29, // 0x0000001D
  SubstituteFont = 30, // 0x0000001E
  OldCFFParser = 31, // 0x0000001F
  GenericResourceDirectory = 32, // 0x00000020
  FontResourceDirectory = 33, // 0x00000021
  Batch = 34, // 0x00000022
  NoPagePrompt = 35, // 0x00000023
  NoPause = 36, // 0x00000024
  NoPrompt = 37, // 0x00000025
  Quiet = 38, // 0x00000026
  ShortErrors = 39, // 0x00000027
  StandardOut = 40, // 0x00000028
  TTYPause = 41, // 0x00000029
  NoDisplay = 42, // 0x0000002A
  Device = 43, // 0x0000002B
  OutputFile = 44, // 0x0000002C
  IgnoreMultipleCopies = 45, // 0x0000002D
  EPSCrop = 46, // 0x0000002E
  EPPSFitPage = 47, // 0x0000002F
  NoEPS = 48, // 0x00000030
  DefaultGrayProfile = 49, // 0x00000031
  DefaultRGBProfile = 50, // 0x00000032
  DefaultCMYKProfile = 51, // 0x00000033
  DeviceNProfile = 52, // 0x00000034
  ProofProfile = 53, // 0x00000035
  DeviceLinkProfile = 54, // 0x00000036
  NamedProfile = 55, // 0x00000037
  OutputICCProfile = 56, // 0x00000038
  RenderIntent = 57, // 0x00000039
  GraphicICCProfile = 58, // 0x0000003A
  GraphicIntent = 59, // 0x0000003B
  ImageICCProfile = 60, // 0x0000003C
  ImageIntent = 61, // 0x0000003D
  TextICCProfile = 62, // 0x0000003E
  TextIntent = 63, // 0x0000003F
  OverrideICC = 64, // 0x00000040
  OverrideRI = 65, // 0x00000041
  SourceObjectICC = 66, // 0x00000042
  DeviceGrayToK = 67, // 0x00000043
  ICCProfilesDirectory = 68, // 0x00000044
  DelayBind = 69, // 0x00000045
  PdfMarks = 70, // 0x00000046
  JobServer = 71, // 0x00000047
  NoBind = 72, // 0x00000048
  NoCache = 73, // 0x00000049
  NoGC = 74, // 0x0000004A
  NoOuterSave = 75, // 0x0000004B
  DelayedSave = 76, // 0x0000004C
  NoSafer = 76, // 0x0000004C
  Safer = 77, // 0x0000004D
  Strict = 78, // 0x0000004E
  SystemDictionaryWritable = 79, // 0x0000004F
  FirstPage = 80, // 0x00000050
  LastPage = 81, // 0x00000051
  PDFFitPage = 82, // 0x00000052
  Printed = 83, // 0x00000053
  UseCropBox = 84, // 0x00000054
  UseTrimBox = 85, // 0x00000055
  PDFPassword = 86, // 0x00000056
  ShowAnnotations = 87, // 0x00000057
  ShowAcroForm = 88, // 0x00000058
  NoUserInit = 89, // 0x00000059
  RenderTTNotDef = 90, // 0x0000005A
  Resolution = 91, // 0x0000005B
  PaperSize = 92, // 0x0000005C
  Silent = 93, // 0x0000005D
  InputFile = 94, // 0x0000005E
}
