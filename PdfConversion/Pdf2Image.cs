// Decompiled with JetBrains decompiler
// Type: Cyotek.GhostScript.PdfConversion.Pdf2Image
// Assembly: Cyotek.GhostScript.PdfConversion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F846869A-603F-4B14-A759-B0D0C54D84D2
// Assembly location: D:\Proyectos\Matika\ModelosGX\MatikaErp_Up\CSharpModel\web\bin\Cyotek.GhostScript.PdfConversion.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

#nullable disable
namespace Cyotek.GhostScript.PdfConversion;

public class Pdf2Image
{
  private string _pdfFileName;
  private int _pdfPageCount;

  public Pdf2Image() => this.Settings = new Pdf2ImageSettings();

  public Pdf2Image(string pdfFileName)
    : this()
  {
    if (string.IsNullOrEmpty(pdfFileName))
      throw new ArgumentNullException(nameof (pdfFileName));
    this.PdfFileName = File.Exists(pdfFileName) ? pdfFileName : throw new FileNotFoundException();
  }

  public Pdf2Image(string pdfFileName, Pdf2ImageSettings settings)
    : this(pdfFileName)
  {
    this.Settings = settings != null ? settings : throw new ArgumentNullException("setting");
  }

  public void ConvertPdfPageToImage(string outputFileName, int pageNumber)
  {
    if (pageNumber < 1 || pageNumber > this.PageCount)
      throw new ArgumentException("Page number is out of bounds", nameof (pageNumber));
    using (GhostScriptAPI ghostScriptApi = new GhostScriptAPI())
      ghostScriptApi.Execute(this.GetConversionArguments(this._pdfFileName, outputFileName, pageNumber, this.PdfPassword, this.Settings));
  }

  public void GetImage(string outputFile, int pageNumber)
  {
    if (pageNumber < 1 || pageNumber > this.PageCount)
      throw new ArgumentException("Page number is out of bounds", nameof (pageNumber));
    string tempFileName = Path.GetTempFileName();
    try
    {
      this.ConvertPdfPageToImage(tempFileName, pageNumber);
      Bitmap bitmap;
      using (FileStream fileStream = new FileStream(tempFileName, FileMode.Open, FileAccess.Read))
        bitmap = new Bitmap((Stream) fileStream);
      bitmap.Save(outputFile);
    }
    finally
    {
      File.Delete(tempFileName);
    }
  }

  [DefaultValue(0)]
  public int PageCount
  {
    get
    {
      if (this._pdfPageCount == 0 && !string.IsNullOrEmpty(this._pdfFileName))
        this._pdfPageCount = this.GetPdfPageCount(this._pdfFileName);
      return this._pdfPageCount;
    }
  }

  [DefaultValue("")]
  public string PdfFileName
  {
    get => this._pdfFileName;
    set => this._pdfFileName = value;
  }

  [DefaultValue("")]
  public string PdfPassword { get; set; }

  public Pdf2ImageSettings Settings { get; set; }

  private int GetPdfPageCount(string fileName)
  {
    return Regex.Matches(File.ReadAllText(fileName), "/Type\\s*/Page[^s]").Count;
  }

  protected virtual IDictionary<GhostScriptCommand, object> GetConversionArguments(
    string pdfFileName,
    string outputImageFileName,
    int pageNumber,
    string password,
    Pdf2ImageSettings settings)
  {
    Dictionary<GhostScriptCommand, object> conversionArguments = new Dictionary<GhostScriptCommand, object>();
    conversionArguments.Add(GhostScriptCommand.Silent, (object) null);
    conversionArguments.Add(GhostScriptCommand.Safer, (object) null);
    conversionArguments.Add(GhostScriptCommand.Batch, (object) null);
    conversionArguments.Add(GhostScriptCommand.NoPause, (object) null);
    conversionArguments.Add(GhostScriptCommand.Device, (object) GhostScriptAPI.GetDeviceName(settings.ImageFormat));
    conversionArguments.Add(GhostScriptCommand.OutputFile, (object) outputImageFileName);
    conversionArguments.Add(GhostScriptCommand.FirstPage, (object) pageNumber);
    conversionArguments.Add(GhostScriptCommand.LastPage, (object) pageNumber);
    conversionArguments.Add(GhostScriptCommand.UseCIEColor, (object) null);
    if (settings.AntiAliasMode != AntiAliasMode.None)
    {
      conversionArguments.Add(GhostScriptCommand.TextAlphaBits, (object) settings.AntiAliasMode);
      conversionArguments.Add(GhostScriptCommand.GraphicsAlphaBits, (object) settings.AntiAliasMode);
    }
    conversionArguments.Add(GhostScriptCommand.GridToFitTT, (object) settings.GridFitMode);
    if (settings.TrimMode != PdfTrimMode.PaperSize)
      conversionArguments.Add(GhostScriptCommand.Resolution, (object) settings.Dpi.ToString());
    switch (settings.TrimMode)
    {
      case PdfTrimMode.PaperSize:
        if (settings.PaperSize != PaperSize.Default)
        {
          conversionArguments.Add(GhostScriptCommand.FixedMedia, (object) true);
          conversionArguments.Add(GhostScriptCommand.PaperSize, (object) settings.PaperSize);
          break;
        }
        break;
      case PdfTrimMode.TrimBox:
        conversionArguments.Add(GhostScriptCommand.UseTrimBox, (object) true);
        break;
      case PdfTrimMode.CropBox:
        conversionArguments.Add(GhostScriptCommand.UseCropBox, (object) true);
        break;
    }
    if (!string.IsNullOrEmpty(password))
      conversionArguments.Add(GhostScriptCommand.PDFPassword, (object) password);
    conversionArguments.Add(GhostScriptCommand.InputFile, (object) pdfFileName);
    return (IDictionary<GhostScriptCommand, object>) conversionArguments;
  }
}
